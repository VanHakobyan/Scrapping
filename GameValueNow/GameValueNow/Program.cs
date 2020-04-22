using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Enums;
using Scrapping.AllPossibilities.Http;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;

namespace GameValueNow
{
    class Program
    {
        private const string pageURL = "https://gamevaluenow.com";
        static async Task Main(string[] args)
        {
            var requestHelper = new RequestHelper();
            var html = await requestHelper.SendRequestAsync(pageURL);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var result = new List<GameValueNowModel>();
            var containerNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.div, HtmlAttribute._class, "platforms-container");
            var nodes = containerNode.SelectNodes(".//a").Select(x => x.GetAttributeValue("href", null)).Where(x => x != null);
            var id = 0;
            foreach (var node in nodes)
            {
                var model = new GameValueNowModel() { Id = ++id };
                var url = $"{pageURL}{node}";
                model.URL = url;
                result.Add(model);
            }

            //var gameContext = new GameContext();
            //gameContext.GameValueNow.AddRange(result);
            //await gameContext.SaveChangesAsync();
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
                    item.Data.Add(data);                             
                }
            }

        }

        //public static string HttpCall(string pageUrl)
        //{
        //    var client = new HttpClient();
        //    using (HttpResponseMessage response = client.GetAsync(pageUrl).Result)
        //    {
        //        using (HttpContent content = response.Content)
        //        {
        //            return content.ReadAsStringAsync().Result;
        //        }
        //    }
        //}
    }
}
