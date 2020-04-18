using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Http;
using Scrapping.AllPossibilities.Selenium;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;

namespace Catawiki.Lib
{
    public class Scrapping
    {
        private const string Link = @"https://www.catawiki.com/c/365-computers-video-games";
        private const string JsonURL = @"http://www.catawiki.com/buyer/api/v1/lots/live";

        private readonly ChromeDriver _driver;

        public Scrapping()
        {
            _driver = ChromeDriverBuilder.CreateChromeDriver(new BuilderModel()
            {
                //IgnoreImage = true,
                //IgnoreStylesheet = true//TODO:uncomment before release 
            });
        }

        public async Task<List<DataModel>> Start(string link)
        {
            var result = new List<DataModel>();
            try
            {
                _driver.Navigate().GoToUrl(string.IsNullOrEmpty(link) ? Link : link);
                var doc = new HtmlDocument();
                doc.LoadHtml(_driver.PageSource);
                var nodes = doc.DocumentNode;
                var pageNumber = Convert.ToInt32(HtmlDocumentHelper.GetNodeByParams(nodes, "nav", "class", "be-pagination u-margin-t-large").ChildNodes[4].InnerText);
                // iterate through every page
                try
                {
                    for (int i = 1; i <= pageNumber; i++)
                    {
                        var ids = ""; // list of ids 
                        var listPerPage = new List<DataModel>(); // list of lots per page
                        _driver.Navigate().GoToUrl(Link + $"?page={i}");
                        doc.LoadHtml(_driver.PageSource);
                        var lots = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "be-lot-list gallery");
                        foreach (var lot in lots.ChildNodes)
                        {
                            var name = HtmlDocumentHelper.GetNodeByParams(lot, "h2", "class", "c-card__title be-lot__title").InnerText;
                            var url = HtmlDocumentHelper.GetNodeByParams(lot, "a", "class", "c-card").GetAttributeValue("href", null);
                            var id = new Uri(url).Segments[2].Split('-')[0];
                            listPerPage.Add(new DataModel { Name = name, Url = url, CurrentBid = id });
                            ids += $",{id}";
                        }
                        ids = ids.Substring(1, ids.Length - 1);
                        var helper = new RequestHelper();
                        var response = await helper.SendRequestAsync($"{JsonURL}?ids={ids}", automaticDecompression: true, headers: HeaderBuilder.GetDefaultHeaders());
                        var list = JsonConvert.DeserializeObject<JsonResult>(response);
                        try
                        {
                            foreach (var item in listPerPage)
                            {
                                var correspondentItem = list.Lots.FirstOrDefault(x => x.id == Convert.ToInt32(item.CurrentBid));
                                item.BiddingEndTime = correspondentItem.bidding_end_time;
                                var amount = correspondentItem.current_bid_amount;
                                item.CurrentBidAmount = amount.EUR;
                                result.Add(item);
                            };
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ex)
                {

                }
                
            }
            catch (Exception e)
            {
                //ignore
            }
            return result;
        }

        public async Task QuitSelenium()
        {
            _driver.Quit();
            await Task.Delay(5000);
        }
    }
}
