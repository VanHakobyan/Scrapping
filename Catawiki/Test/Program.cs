using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Http;
using Scrapping.AllPossibilities.Selenium;

namespace Test
{
    class Program
    {
        private const string Link = @"https://www.catawiki.com/c/365-computers-video-games";
        private const string JsonUrl = @"http://www.catawiki.com/buyer/api/v1/lots/live";

        private static readonly ChromeDriver Driver = ChromeDriverBuilder.CreateChromeDriver(new BuilderModel
        {
            //IgnoreImage = true,
            //IgnoreStylesheet = true//TODO:uncomment before release 
        });

        static async Task Main()
        {
            try
            {
                var data = await Start(Link);
                WriteCollectionToCsvNew(data, @"D:\Export.csv");
                Console.WriteLine("For exit select any key!!!");
                Console.ReadKey();
            }
            finally
            {
                Driver.Quit();
                await Task.Delay(2000);
            }
        }
        public static async Task<List<DataModelBase>> Start(string link)
        {
            var result = new List<DataModelBase>();
            try
            {
                Driver.Navigate().GoToUrl(string.IsNullOrEmpty(link) ? Link : link);
                var doc = new HtmlDocument();
                doc.LoadHtml(Driver.PageSource);
                var nodes = doc.DocumentNode;
                var pageNumber = Convert.ToInt32(HtmlDocumentHelper.GetNodeByParams(nodes, "nav", "class", "be-pagination u-margin-t-large").ChildNodes[4].InnerText);
                // iterate through every page
                try
                {
                    for (var i = 1; i <= pageNumber; i++)
                    {
                        var sb = new StringBuilder(); // list of ids 
                        var listPerPage = new List<DataModel>(); // list of lots per page
                        Driver.Navigate().GoToUrl(Link + $"?page={i}");
                        doc.LoadHtml(Driver.PageSource);
                        var lots = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "be-lot-list gallery");
                        foreach (var lot in lots.ChildNodes)
                        {
                            try
                            {
                                var name = HtmlDocumentHelper.GetNodeByParams(lot, "h2", "class", "c-card__title be-lot__title").InnerText;
                                var url = HtmlDocumentHelper.GetNodeByParams(lot, "a", "class", "c-card").GetAttributeValue("href", null);
                                var id = new Uri(url).Segments[2].Split('-')[0];
                                listPerPage.Add(new DataModel { Name = name, Url = url, CurrentBid = int.Parse(id) });
                                sb.Append($",{id}");
                            }
                            catch
                            {
                                //ignore
                            }
                        }

                        var ids = sb.ToString().TrimStart(',');

                        var helper = new RequestHelper();
                        var response = await helper.SendRequestAsync($"{JsonUrl}?ids={ids}", automaticDecompression: true, headers: HeaderBuilder.GetDefaultHeaders());
                        var list = JsonConvert.DeserializeObject<JsonResult>(response);

                        foreach (var item in listPerPage)
                        {
                            try
                            {
                                var correspondentItem = list.Lots.FirstOrDefault(x => x.id == item.CurrentBid);
                                item.BiddingEndTime = correspondentItem.bidding_end_time;
                                var amount = correspondentItem.current_bid_amount;
                                item.CurrentBidAmount = amount.EUR;
                                item.ReservedPrice = correspondentItem.reserve_price_met.HasValue && correspondentItem.reserve_price_met.Value ? "Has reserve price" : "No reserve price";
                                result.Add(item);

                            }
                            catch
                            {
                                //ignore
                            }
                        };

                    }
                }
                catch
                {
                    //ignore
                }

            }
            catch (Exception e)
            {
                //ignore
            }
            return result;
        }
        public static bool WriteCollectionToCsvNew<T>(IEnumerable<T> items, string path)
        {
            try
            {
                var itemType = typeof(T);
                var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                    foreach (var item in items)
                    {
                        writer.WriteLine($"{string.Join(", ", props.Select(p => $"\"{p.GetValue(item, null)}\""))}");
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public class DataModelBase
    {
        public string Name { get; set; }
        public decimal CurrentBidAmount { get; set; }
        public DateTime BiddingEndTime { get; set; }
        public string Url { get; set; }
        public string ReservedPrice { get; set; }
    }
    public class DataModel : DataModelBase
    {
        public int CurrentBid { get; set; }

    }
    public class Currency
    {
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
        public decimal EUR { get; set; }
    }
    public class JsonResult
    {
        [JsonProperty("lots")]
        public List<DataModelJSON> Lots { get; set; }
    }
    public class DataModelJSON
    {
        public Currency current_bid_amount { get; set; }
        public int id { get; set; }
        public DateTime bidding_end_time { get; set; }
        public bool? reserve_price_met { get; set; }

    }
}
