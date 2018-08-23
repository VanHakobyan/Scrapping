using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Garymoe
{
    class Program
    {
        private static string link = @"http://www.garymoe.com/inventory.html?type=used&year=&make=&model=&trim=&offset={offset}";
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            var dataRoot = client.DownloadString(link.Replace("{offset}", ""));

            HtmlDocument documentRoot = new HtmlDocument();

            documentRoot.LoadHtml(dataRoot);
            int.TryParse(documentRoot.DocumentNode.SelectSingleNode(".//div[starts-with(@class,'page-div')]").FirstChild.InnerText.Split(' ')[3], out var count);
            var listUrls = new List<string>();
            for (int i = 0; i < count / 20 + 1; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        var carsRoot = documentRoot.DocumentNode.SelectNodes(".//div[@class='ibox']");
                        foreach (var car in carsRoot)
                        {
                            var url = car.SelectSingleNode(".//a[@class='ibox-aref']").GetAttributeValue("href", "");
                            listUrls.Add(url);
                        }
                        continue;
                    }
                    var data = client.DownloadString(link.Replace("{offset}",$"{i*20}"));
                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(data);
                    var cars = document.DocumentNode.SelectNodes(".//div[@class='ibox']");
                    foreach (var car in cars)
                    {
                        var url = car.SelectSingleNode(".//a[@class='ibox-aref']").GetAttributeValue("href", "");
                        listUrls.Add(url);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
