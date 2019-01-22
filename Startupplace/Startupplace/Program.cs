using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;

namespace Startupplace
{
    class Model
    {
        public string Company { get; set; }
        public string City { get; set; }
        public string Capital { get; set; }
        public string CreationDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Link { get; set; }
    }
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
        private static void Scroll(ChromeDriver driver)
        {
            driver.ExecuteScript("scroll(0, 200000);");
            Thread.Sleep(250);
        }
        static void Main(string[] args)
        {
            var deserializeObject = JsonConvert.DeserializeObject<List<Model>>(File.ReadAllText("D:\\jsonStat.txt"));
            foreach (var model in deserializeObject)
            {
                model.Capital=model.Capital?.Replace(",", ".");
            }
            WriteCSV(deserializeObject,"D:\\csv.csv");

            ChromeDriver chromeDriver = new ChromeDriver();
            List<Model> models = new List<Model>();
            HtmlDocument document = new HtmlDocument();
            var links = File.ReadAllLines(@"D:\\StatLink.txt");
            foreach (var link in links)
            {
                chromeDriver.Navigate().GoToUrl(link);
                Thread.Sleep(4200);
                document.LoadHtml(chromeDriver.PageSource);
                var content = document.DocumentNode.SelectSingleNode(".//div[@class='col-content']");
                var company = content.SelectSingleNode(".//h1[@class='startup-name']")?.InnerText?.ToUpper()?.Trim();
                var infos = content.SelectSingleNode(".//div[@class='infos']");
                var infoCollection = infos.SelectNodes(".//p[@class='txt-gris']");
                var CreationDate = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-info"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var Capital = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-dollar"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var City = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("map-marker"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var Phone = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-phone"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var email = infos.SelectSingleNode(".//p[@class='mail-link']")?.SelectSingleNode(".//a")?.GetAttributeValue("href", "")?.Replace("mailto:", "");

                var model = new Model
                {
                    Capital = Capital,
                    City = City,
                    Company = company,
                    CreationDate = CreationDate,
                    EmailAddress = email,
                    Link = link,
                    PhoneNumber = Phone
                };
                models.Add(model);
            }

            var serializeObject = JsonConvert.SerializeObject(models);
            File.WriteAllText(serializeObject, "D:\\jsonStat.txt");

            //var htmlNodeCollection = document.DocumentNode.SelectNodes(".//div[@class='item-startup']").Select(x=>x.SelectSingleNode(".//a").GetAttributeValue("href", "")).ToList();
            //File.AppendAllLines(@"D:\\StatLink.txt",htmlNodeCollection);
            //chromeDriver.Navigate().GoToUrl(@"https://www.startupplace.io/search-startup/");
            //while (true)
            //{
            //    try
            //    {
            //        File.AppendAllText(@"D:\\start.html", chromeDriver.PageSource);
            //        Scroll(chromeDriver);
            //        var findElementById = chromeDriver.FindElementById("load-more-items");
            //        findElementById.Click();

            //        Thread.Sleep(5000);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

        }
    }
}
