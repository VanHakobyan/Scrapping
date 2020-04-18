using System;
using System.Collections.Generic;
using System.Linq;
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
        private const string JsonURL = @"https://www.catawiki.com/buyer/api/v1/lots/live";

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
            await Task.Delay(0);
            _driver.Navigate().GoToUrl(Link);
            var doc = new HtmlDocument();
            doc.LoadHtml(_driver.PageSource);
            var nodes = doc.DocumentNode;
            var pageNumber = Convert.ToInt32(HtmlDocumentHelper.GetNodeByParams(nodes, "nav","class", "be-pagination u-margin-t-large").ChildNodes[4].InnerText);
            var result = new List<DataModel>();
            // iterate through every page
            for(int i=1; i<=pageNumber; i++)
            {
                string ids = "";
                List<DataModel> listPerPage = new List<DataModel>();
                _driver.Navigate().GoToUrl(Link + String.Format("?page={0}", i));
                doc.LoadHtml(_driver.PageSource);
                var lots = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, "div", "class", "be-lot-list gallery");
                foreach(var lot in lots.ChildNodes)
                {
                    var name = HtmlDocumentHelper.GetNodeByParams(lot, "h2", "class", "c-card__title be-lot__title").InnerText;
                    var url = HtmlDocumentHelper.GetNodeByParams(lot, "a", "class", "c-card").GetAttributeValue("href", null);
                    var id = new Uri(url).Segments[2].Split('-')[0];
                    listPerPage.Add(new DataModel { Name = name, Url = url, CurrentBid = id });
                    ids += String.Format(",{0}", id);
                }
                ids = ids.Substring(1, ids.Length - 1);
                RequestHelper helper = new RequestHelper();
                var response = await helper.SendRequestAsync(JsonURL + "?ids=" + ids, "POST");
                var list = JsonConvert.DeserializeObject<JsonResult>(response);
                foreach (var item in listPerPage)
                {
                    var correspondentItem = list.Lots.Where(x => x.CurrentBid == item.CurrentBid).SingleOrDefault();
                    item.BiddingEndTime = correspondentItem.BiddingEndTime;
                    item.CurrentBidAmount = correspondentItem.CurrentBidAmount;
                    result.Add(item);
                };
            }


            return new List<DataModel>();
        }

        public async Task QuitSelenium()
        {
            _driver.Quit();
            await Task.Delay(5000);
        }
    }
}
