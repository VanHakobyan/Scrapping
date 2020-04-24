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
                    var statsValues = HtmlDocumentHelper.GetNodesByParamsUseXpathContains(statsNode, HtmlTag.div, HtmlAttribute._class, "col-30 col-30-md stat-value");
                    item.AvgLoosePrice = statsValues[0].InnerText.Replace("\n", "").Replace(" ", "");
                    item.AvgCompletePrice = statsValues[1].InnerText.Replace("\n", "").Replace(" ", "");
                    item.LooseSetValue = statsValues[2].InnerText.Replace("\n", "").Replace(" ", "");
                    item.CompleteSetValue = statsValues[3].InnerText.Replace("\n", "").Replace(" ", "");
                    item.SharpOfGames = statsValues[4].InnerText.Replace("\n", "").Replace(" ", "");

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
                            var priceContainer = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(collectionItemNode,
                                HtmlTag.div, HtmlAttribute._class, "price-col-container");

                            var prices = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(priceContainer, HtmlTag.div,
                                HtmlAttribute._class, "col-25 col-sm-25 price-col left");
                            data.Loose = prices[0].InnerText.Replace("\n", "").Replace(" ", "");
                            data.Complete = prices[1].InnerText.Replace("\n", "").Replace(" ", "");
                            data.New = prices[2].InnerText.Replace("\n", "").Replace(" ", "");
                            data.Graded = prices[3].InnerText.Replace("\n", "").Replace(" ", "");
                            data.PlatformName = item.PlatformName;
                            item.Data.Add(data);
                        }
                        catch
                        {
                            //ignore
                        }
                    }
                }
                catch 
                {
                    //ignore
                }
                await Task.Delay(500);
            }

            using (var gameContext = new GameContext())
            {
                foreach (var item in result)
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
                                catch
                                {
                                    //ignore
                                }
                            }
                        }
                    }
                    catch
                    {
                        //ignore
                    }
                }

                await gameContext.SaveChangesAsync();
            }
        }
    }
}
