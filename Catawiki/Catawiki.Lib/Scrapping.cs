using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Scrapping.AllPossibilities.Selenium;

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

        public async Task<List<DataModel>> Start()
        {
            await Task.Delay(0);
            _driver.Navigate().GoToUrl(Link);
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
