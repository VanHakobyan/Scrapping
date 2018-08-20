using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Lexusofedmonton
{
    class Program
    {
        private static string link =
            @"https://www.lexusofedmonton.ca/used-vehicles/#action=im_ajax_call&perform=get_results&page={page}&type%5B%5D=Used&type%5B%5D=Certified+Used";
        static void Main(string[] args)
        {
            var urls=new List<string>();
            
            for (int i = 1; i < 9; i++)
            {
                HttpClient client = new HttpClient();
                //client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
                HtmlDocument document = new HtmlDocument();
                var globalUrl = link.Replace("{page}", i.ToString());
                var data = client.GetStringAsync(globalUrl).Result;
                document.LoadHtml(data);
                var cars = document.DocumentNode.SelectNodes(".//div[@class='vehicle-title clearfix']");
                foreach (var car in cars)
                {
                    var carDetail = car.SelectSingleNode(".//a");
                    var url = carDetail.GetAttributeValue("href", "");
                    urls.Add(url);
                }
            }

            //File.WriteAllLines(@"E:\urls.txt",urls);
        }
    }
}
