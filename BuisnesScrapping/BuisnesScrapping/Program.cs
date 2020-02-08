using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using BuisnesScrapping;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BusinessScrapping
{
    class Program
    {
        public static void WriteCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);


            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
        private const string CarD =
            @"https://www.google.com/search?rlz=1C1GCEU_enAM821AM821&tbm=lcl&sxsrf=ACYBGNTcw-J0y2f3RYNyrOKdF7Q4i7srIA%3A1581154062144&ei=Dn8-XpnFCK6mmwW3m5xo&q=Car+Dealer+63385&oq=Car+Dealer+63385&gs_l=psy-ab.12..0i7i30k1l2j0i30k1j0i7i5i30k1l4.20675.20675.0.22338.1.1.0.0.0.0.151.151.0j1.1.0....0...1c.1.64.psy-ab..0.1.150....0.Tn6Hp1CDfO4#rlfi=hd:;si:;mv:[[38.8179424,-90.7856395],[38.7940532,-90.8889121]]";
        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(CarD);
            Thread.Sleep(2000);
            List<BModel> bModels=new List<BModel>();

            do
            {
                var fullList = chromeDriver.FindElementsByXPath(".//div[@jsname='GZq3Ke']");
                foreach (var item in fullList)
                {
                    item.Click();
                    Thread.Sleep(500);

                    var document = new HtmlDocument();
                    document.LoadHtml(chromeDriver.PageSource);
                    var info = document.DocumentNode.SelectSingleNode(".//div[@class='immersive-container']");
                    var name = info.SelectSingleNode(".//div[@data-attrid='title']")?.InnerText;
                    var address = info.SelectSingleNode(".//span[@class='LrzXr']")?.InnerText;
                    var phone = info.SelectSingleNode(".//span[@data-local-attribute='d3ph']")?.InnerText;
                    var web = info.SelectSingleNode(".//div[@class='QqG1Sd']")?.SelectSingleNode(".//a")?.GetAttributeValue("href", "no value");
                    bModels.Add( new BModel
                    {
                        Address = address?.Replace(",","."),
                        Name = name?.Replace(",", "."),
                        Phone = phone?.Replace(",", "."),
                        Web = web?.Replace(",", ".")
                    });
                }

                IWebElement findElementByXPath;
                try
                {
                    findElementByXPath = chromeDriver.FindElementByXPath(".//a[@id='pnnext']");
                }
                catch
                {
                    findElementByXPath = null;
                }
                if (findElementByXPath == null) break;
                findElementByXPath.Click();
                Thread.Sleep(2000);
            } while (true);
            WriteCSV(bModels,@"D:\car.csv");
        }
    }
}
