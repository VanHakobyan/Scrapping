using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Http;

namespace GameValueNow
{
    class Program
    {
        private const string pageURL = "https://gamevaluenow.com";
        static void Main(string[] args)
        {
            var html = HttpCall(pageURL);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var result = new List<GameValueNowModel>();
            ///html[1]/body[1]/div[2]/div[1]/section[3]/div[4]
            var containerNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "platforms-container");
            var nodes = HtmlDocumentHelper.GetNodesByParams(containerNode, "div", "class", "platform");
            foreach (var node in nodes)
            {
                var model = new GameValueNowModel();
                var url = pageURL + node.ChildNodes[1].GetAttributeValue("href", null);
                var name = node.ChildNodes[1].ChildNodes[3].InnerText;
                model.URL = url; model.PlatformName = name;
                result.Add(model);
            }
            foreach(var item in result)
            {
                html = HttpCall(item.URL);
                doc.LoadHtml(html);
                var node = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "col-100 stat");
                var l = node.ChildNodes[3].InnerText;

            }
            
        }
        public static string HttpCall(string pageUrl)
        {
            HttpClient client = new HttpClient();
            using (HttpResponseMessage response = client.GetAsync(pageUrl).Result)
            {
                using (HttpContent content = response.Content)
                {
                    return content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
