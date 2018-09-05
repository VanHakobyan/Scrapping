using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace SecondKeys1
{
    class Program
    {
        private const string tvUrl = @"http://vesta.am/tv";
        private const string dishwasherUrl = @"http://vesta.am/dishwasher/dishwashers";
        private const string stoveUrl = @"https://vega.am/hy/oven#";
        private const string refUrl = @"https://vega.am/hy/krupnaja-bytovaja-texnika/ref";

        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            HtmlDocument documentTv = new HtmlDocument();
            var stringTv = client.DownloadString(tvUrl);
            documentTv.LoadHtml(stringTv);
            var allContent = documentTv.DocumentNode.SelectNodes(".//div[@class='product-layout product-grid col-lg-4 col-md-4 col-sm-6 col-xs-12']").Select(x => x.SelectSingleNode(".//div[@class='image']/a/@href"));
            var listOfTvLinks = new List<string>();
            Regex regexTv = new Regex("<a href=\"(.*?)\"");
            foreach (var tv in allContent)
            {
                listOfTvLinks.Add(regexTv.Match(tv.OuterHtml).Groups[1].Value);
            }
            List<DescModel> descModels = new List<DescModel>();
            Model1 model1 = new Model1();
            model1.Desc.AddRange(descModels);
            foreach (var ofTvLink in listOfTvLinks)
            {
                try
                {
                    HtmlDocument document = new HtmlDocument();
                    using (WebClient client1=new WebClient())
                    {
                        client1.Headers.Add(HttpRequestHeader.Cookie, "PHPSESSID=7f6fc6bc63d50c92c8f93e6860d2cf02; currency=AMD; _ga=GA1.2.1278618675.1536123905; _gid=GA1.2.542430229.1536123905; _a_d3t6sf=duYQ4AIPd9esVXtsghCLtcJy; language=am; _gat=1");
                        document.LoadHtml(client1.DownloadString(ofTvLink)); 
                    }
                    var prodName = document.DocumentNode.SelectSingleNode(".//h1[@class='prodTitle']").InnerText;
                    var prodDescript = document.DocumentNode.SelectSingleNode(".//div[@id='tab-description']").FirstChild.SelectNodes(".//tr");
                    var descModel = new DescModel { Model = prodName };
                    foreach (var desc in prodDescript)
                    {
                        try
                        {
                            var key = desc.SelectNodes(".//td")[0].InnerText;
                            var value = desc.SelectNodes(".//td")[1].InnerText;
                            descModel.KeyValueDesc.Add(new KeyValueDesc {Key = key,Value = value});
                        }
                        catch { }
                    }
                    descModels.Add(descModel);
                    Thread.Sleep(1500);
                }
                catch
                {
                    Thread.Sleep(5000);
                }
            }
            
            model1.Desc.AddRange(descModels);
            model1.SaveChanges();
            Console.WriteLine();

        }
    }
}
