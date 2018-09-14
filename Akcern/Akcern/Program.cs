using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Akcern
{
    class Program
    {
        static string urlBase = @"https://akcern.am/en/realty/search-{id}.html?type=sale&street=&from_floor=&to_floor=&from_price=&to_price=&rate=USD&from_area=&to_area=&code=&vidocode=";
        static void Main(string[] args)
        {
            var allHomes=new List<HtmlNodeCollection>();
            for (var i = 1; i < 10; i++)
            {
                WebClient client = new WebClient();
                HtmlDocument document=new HtmlDocument();
                var str = client.DownloadString(urlBase.Replace("{id}", i.ToString()));
                document.LoadHtml(str);
                var homes = document.DocumentNode.SelectNodes(".//div[@class='item_desc_bl row']");
                allHomes.Add(homes);
            }
        }
    }
}
