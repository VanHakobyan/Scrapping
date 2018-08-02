using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace BookLot
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client=new WebClient();
            var downloadString =  client.DownloadStringTaskAsync(@"https://book.lot.com/web/lot-airways/flights?id=e0e04b672f304457a30a258420906691").Result;
            HtmlDocument document=new HtmlDocument();
            document.LoadHtml(downloadString);
            var htmlNodeCollection = document.DocumentNode.SelectNodes(".//span[@class='nr-flight_pagination--date']");
            var contains = downloadString.Contains("Wroclaw (WRO)");
        }
    }
}
