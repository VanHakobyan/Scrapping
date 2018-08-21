using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace LSelenium
{
    class Program
    {
         private static string link =
            @"https://www.lexusofedmonton.ca/used-vehicles/#action=im_ajax_call&perform=get_results&page=1&type%5B%5D=Used&type%5B%5D=Certified+Used";
        static void Main(string[] args)
        {
            var urls = new List<string>();
            PhantomJSDriver driver=new PhantomJSDriver();
            driver.Navigate().GoToUrl(link);
            for (int i = 1; i < 9; i++)
            {
                var pages = driver.FindElements(By.ClassName("pages"));
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(driver.PageSource);
                var cars = document.DocumentNode.SelectNodes(".//div[@class='vehicle-title clearfix']");
                foreach (var car in cars)
                {
                    var carDetail = car.SelectSingleNode(".//a");
                    var url = carDetail.GetAttributeValue("href", "");
                    if (!urls.Contains(url)) urls.Add(url);
                }
                if (i == 8) break;
                pages.ElementAt(i).Click();
                Thread.Sleep(1000);
            }

            Console.ReadKey();

        }
    }
}
