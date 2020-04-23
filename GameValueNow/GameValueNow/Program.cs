using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        private const string PageUrl = "https://gamevaluenow.com";
        static async Task Main(string[] args)
        {
            var requestHelper = new RequestHelper();
            var html = await requestHelper.SendRequestAsync(PageUrl);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var result = new List<GameValueNowModel>();
            var containerNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.div, HtmlAttribute._class, "platforms-container");
            var nodes = containerNode.SelectNodes(".//a").Where(x => x != null);

            foreach (var node in nodes)
            {
                var model = new GameValueNowModel();
                var url = $"{PageUrl}{node.GetAttributeValue("href", null)}";
                var name = node.SelectNodes(".//p").Select(x => x.InnerText).FirstOrDefault(x => x != null);
                model.URL = url;
                model.PlatformName = WebUtility.HtmlDecode(name);
                result.Add(model);
            }


            foreach (var item in result)
            {
                item.Data = new List<Data>();
                html = await requestHelper.SendRequestAsync(item.URL);
                doc.LoadHtml(html);

                // stats
                var statsNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.div, HtmlAttribute.id, "stats");
                var statsContainer = HtmlDocumentHelper.GetNodesByParamsUseXpathContains(statsNode, HtmlTag.div, HtmlAttribute._class, "col-100 stat");
                var statsValues = HtmlDocumentHelper.GetNodesByParamsUseXpathContains(statsNode, HtmlTag.div, HtmlAttribute._class, "col-30 col-30-md stat-value");
                item.AvgLoosePrice = statsValues[0].InnerText.Replace("\n", "").Replace(" ", "");
                item.AvgCompletePrice = statsValues[1].InnerText.Replace("\n", "").Replace(" ", "");
                item.LooseSetValue = statsValues[2].InnerText.Replace("\n", "").Replace(" ", "");
                item.CompleteSetValue = statsValues[3].InnerText.Replace("\n", "").Replace(" ", "");
                item.SharpOfGames = statsValues[4].InnerText.Replace("\n", "").Replace(" ", "");

                // items
                var listNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.div, HtmlAttribute.id, "item-list");
                var collectionItemNodes = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(listNode, HtmlTag.div, HtmlAttribute._class, "item-row desktop all");
                foreach (var collectionItemNode in collectionItemNodes)
                {
                    var data = new Data();
                    var name = HtmlDocumentHelper.GetNodeByParams(collectionItemNode, HtmlTag.a, HtmlAttribute._class, "game-link").InnerText;
                    var id = HtmlDocumentHelper.GetNodeByParams(collectionItemNode, HtmlTag.div, HtmlAttribute._class, "item-number").InnerText.Replace("\n", "").Replace(" ", "");
                    data.Title = name;
                    data.Id = id;
                    var priceContainer = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(collectionItemNode, HtmlTag.div, HtmlAttribute._class, "price-col-container");
                    //more logic for prices
                    var prices = HtmlDocumentHelper.GetNodesByParamsUseXpathStartsWith(priceContainer, HtmlTag.div, HtmlAttribute._class, "col-25 col-sm-25 price-col left");
                    data.Loose = prices[0].InnerText.Replace("\n", "").Replace(" ", "");
                    data.Complete = prices[1].InnerText.Replace("\n", "").Replace(" ", "");
                    data.New = prices[2].InnerText.Replace("\n", "").Replace(" ", "");
                    data.Graded = prices[3].InnerText.Replace("\n", "").Replace(" ", "");
                    data.PlatformName = item.PlatformName;
                    item.Data.Add(data);
                }
            }
            using (var gameContext = new GameContext())
            {
                foreach(var item in result)
                {
                    var platform = gameContext.GameValueNow.Include(g => g.Data).Where(x => x.PlatformName == item.PlatformName).FirstOrDefault();
                    if (platform == null)
                    {
                        gameContext.GameValueNow.Add(item);
                    }
                    else
                    {
                        gameContext.Entry(platform).CurrentValues.SetValues(item);
                        foreach (var data in item.Data)
                        {
                            // stupid way, but didn't have time to find something better
                            var gameData = gameContext.GameData.Where(g => g.Id == data.Id && g.PlatformName == item.PlatformName).FirstOrDefault();
                            if (gameData == null)
                            {
                                gameContext.GameData.Add(data);
                            }
                        }
                    }
                }
                await gameContext.SaveChangesAsync();
            }
      
        }
    }
}
