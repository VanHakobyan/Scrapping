using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Enums;
using Scrapping.AllPossibilities.Http;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;
using System.Data.Entity;

namespace GameValueNow
{
    class Program
    {
        private const string PageUrl = "http://gamevaluenow.com";
        static async Task Main()
        {
            try
            {
                await Parse();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private static async Task Parse()
        {
            var requestHelper = new RequestHelper();
            var hader = HeaderBuilder.BuildOwnHeaders(new HeaderModel()
            {
                Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9",
                Host = "gamevaluenow.com",
                Referer = "https://gamevaluenow.com/",
                User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36"
            });
            var html = await requestHelper.SendRequestAsync(PageUrl, headers: HeaderBuilder.GetDefaultHeaders());

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var result = new List<GameValueNowModel>();
            var nodes = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(doc.DocumentNode, HtmlTag.a, HtmlAttribute._class, "brand-");

            foreach (var node in nodes)
            {
                try
                {
                    var href = node.GetAttributeValue("href", null);
                    if (href is null || href == "#") continue;
                    var model = new GameValueNowModel();
                    var url = $"{PageUrl}{href}";
                    var name = node.InnerText;
                    model.URL = url;
                    model.PlatformName = WebUtility.HtmlDecode(name);
                    if (result.Select(x => x.PlatformName).Contains(model.PlatformName)) continue;
                    result.Add(model);
                }
                catch
                {
                    //ignore;
                }
            }


            foreach (var item in result)
            {
                try
                {
                    item.Data = new List<Data>();
                    var document = new HtmlDocument();

                    var dataHtml = await requestHelper.SendRequestAsync(item.URL, headers: hader);
                    document.LoadHtml(dataHtml);

                    // stats
                    var statsNode = HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, HtmlTag.div, HtmlAttribute.id, "stats");
                    var statListNode = HtmlDocumentHelper.GetNodesByParams(statsNode, HtmlTag.div, HtmlAttribute._class, "col-100 stat");

                    var avgLoosePrice = statListNode.FirstOrDefault(x => x.InnerText.Contains("Avg Loose"));
                    var avgCompletePrice = statListNode.FirstOrDefault(x => x.InnerText.Contains("Avg Complete"));
                    var looseSetValue = statListNode.FirstOrDefault(x => x.InnerText.Contains("Loose Set"));
                    var completeSetValue = statListNode.FirstOrDefault(x => x.InnerText.Contains("Complete Set"));
                    var sharpOfGames = statListNode.FirstOrDefault(x => x.InnerText.Contains("#"));

                    if (avgLoosePrice != null) item.AvgLoosePrice = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(avgLoosePrice, HtmlTag.div, HtmlAttribute._class, "stat-value")?.InnerText?.Trim();
                    if (avgCompletePrice != null) item.AvgCompletePrice = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(avgCompletePrice, HtmlTag.div, HtmlAttribute._class, "stat-value")?.InnerText?.Trim();
                    if (looseSetValue != null) item.LooseSetValue = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(looseSetValue, HtmlTag.div, HtmlAttribute._class, "stat-value")?.InnerText?.Trim();
                    if (completeSetValue != null) item.CompleteSetValue = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(completeSetValue, HtmlTag.div, HtmlAttribute._class, "stat-value")?.InnerText?.Trim();
                    if (sharpOfGames != null) item.SharpOfGames = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(sharpOfGames, HtmlTag.div, HtmlAttribute._class, "stat-value")?.InnerText?.Trim();

                    // items
                    var listNode =
                        HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, HtmlTag.div, HtmlAttribute.id, "item-list");
                    var collectionItemNodes = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(listNode, HtmlTag.div,
                        HtmlAttribute._class, "item-row desktop all");
                    foreach (var collectionItemNode in collectionItemNodes)
                    {
                        try
                        {
                            var data = new Data();
                            var name = HtmlDocumentHelper
                                .GetNodeByParams(collectionItemNode, HtmlTag.a, HtmlAttribute._class, "game-link").InnerText;
                            var id = HtmlDocumentHelper
                                .GetNodeByParams(collectionItemNode, HtmlTag.div, HtmlAttribute._class, "item-number").InnerText
                                .Replace("\n", "").Replace(" ", "");
                            data.Title = name;
                            data.Id = id;
                            var priceContainer = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(collectionItemNode, HtmlTag.div, HtmlAttribute._class, "price-col-container");
                            if (priceContainer is null) continue;
                            var prices = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(priceContainer, HtmlTag.a, HtmlAttribute._class, "game-link");
                            if (prices is null) continue;
                            var priceCount = prices.Count;
                            if (priceCount > 0) data.Loose = prices[0].InnerText;
                            if (priceCount > 1) data.Complete = prices[1].InnerText;
                            if (priceCount > 2) data.New = prices[2].InnerText;
                            if (priceCount > 3) data.Graded = prices[3].InnerText;
                            data.PlatformName = item.PlatformName;
                            item.Data.Add(data);
                        }
                        catch
                        {
                            //ignore
                        }
                    }
                }
                catch (Exception e)
                {
                    //ignore
                }
                await Task.Delay(500);
            }

            using (var gameContext = new GameContext())
            {
                try
                {
                    var categories = result.Where(x => x.Data != null);
                    foreach (var item in categories)
                    {
                        try
                        {
                            var platform = gameContext.GameValueNow.Include(g => g.Data).FirstOrDefault(x => x.PlatformName == item.PlatformName);
                            if (platform == null)
                            {
                                gameContext.GameValueNow.Add(item);
                            }
                            else
                            {
                                gameContext.Entry(platform).CurrentValues.SetValues(item);
                                if (item.Data is null || item.Data.Count == 0) continue;
                                foreach (var data in item.Data)
                                {
                                    try
                                    {
                                        var gameData = gameContext.GameData.FirstOrDefault(g => g.Id == data.Id && g.PlatformName == item.PlatformName);
                                        if (gameData == null)
                                        {
                                            gameContext.GameData.Add(data);
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        //ignore
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            //ignore
                        }
                    }

                    await gameContext.SaveChangesAsync();
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
