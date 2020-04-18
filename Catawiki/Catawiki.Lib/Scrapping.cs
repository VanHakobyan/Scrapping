using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Enums;
using Scrapping.AllPossibilities.Http;
using Scrapping.AllPossibilities.Selenium;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;

namespace Catawiki.Lib
{
    public class Scrapping
    {
        private const string Link = @"https://www.catawiki.com/c/365-computers-video-games";

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
            _driver.Navigate().GoToUrl(string.IsNullOrEmpty(link) ? Link : link);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(_driver.PageSource);

            var navNode = HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, "nav", "class", "be-pagination u-margin-t-large");
            navNode.GetAttributeValue("name", null);
            //logic
            return new List<DataModel>();
        }

        public async Task QuitSelenium()
        {
            _driver.Quit();
            await Task.Delay(5000);
        }
    }
}
