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
            foreach (var node in nodes)
            {
                var model = new GameValueNowModel();
                var url = $"{pageURL}{node}";
                model.URL = url;
                //var name = node.ChildNodes[1].ChildNodes[3].InnerText;
                //model.PlatformName = name;
                result.Add(model);
            }
            foreach (var item in result)
            {
                html = await requestHelper.SendRequestAsync(item.URL);
                doc.LoadHtml(html);
                //var node = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "col-100 stat");
                //var l = node.ChildNodes[3].InnerText;
                var listNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.div, HtmlAttribute.id, "item-list");
                var collectionItemNodes = HtmlDocumentHelper.GetNodesByParams(listNode, HtmlTag.div, HtmlAttribute._class, "item-row desktop all licensed");
                foreach (var collectionItemNode in collectionItemNodes)
                {
                    var name = HtmlDocumentHelper.GetNodeByParams(collectionItemNode, HtmlTag.a, HtmlAttribute._class, "game-link").InnerText;
                    var priceContainer = HtmlDocumentHelper.GetNodeByParamsUseXpathContains(collectionItemNode, HtmlTag.div, HtmlAttribute._class, "price-col-container");
                    //more logic
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
