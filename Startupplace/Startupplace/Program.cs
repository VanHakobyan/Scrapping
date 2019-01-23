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
        public List<string> Members { get; set; }
    }
    class Model1
    {
        public string Company { get; set; }
        public string City { get; set; }
        public string Capital { get; set; }
        public string CreationDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Link { get; set; }
        public string Members { get; set; }
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
            try
            {

                driver.ExecuteScript("scroll(0, 200000);");
                Thread.Sleep(250);

            }
            catch (Exception ե)
            {

            }
        }
        static void Main(string[] args)
        {
            var readAllText = File.ReadAllText("E:\\jsonStat.txt");
            var deserializeObject = JsonConvert.DeserializeObject<List<Model>>(readAllText);
            var m = new List<Model1>();
            foreach (var model in deserializeObject)
            {
                m.Add(new Model1
                {
                    Members = string.Join("|||", model.Members).Replace(",", "."),
                    Capital = model.Capital,
                    City = model.City,
                    Company = model.Company,
                    CreationDate = model.CreationDate,
                    EmailAddress = model.EmailAddress,
                    PhoneNumber = model.PhoneNumber,
                    Link = model.Link
                });
            }
            WriteCSV(m, "E:\\csv.csv");
            var links = File.ReadAllLines("E:\\instr.txt");

            ChromeOptions co = new ChromeOptions();
            co.AddArgument("--disable-images");
            ChromeDriver chromeDriver = new ChromeDriver(co);
            List<Model> models = new List<Model>();
            HtmlDocument document = new HtmlDocument();
            //var links = File.ReadAllLines(@"D:\\StatLink.txt");
            foreach (var link in links)
            {
                chromeDriver.Navigate().GoToUrl(link);
                Thread.Sleep(3200);
                document.LoadHtml(chromeDriver.PageSource);
                var content = document.DocumentNode.SelectSingleNode(".//div[@class='col-content']");
                var company = content.SelectSingleNode(".//h1[@class='startup-name']")?.InnerText?.ToUpper()?.Trim();
                var infos = content.SelectSingleNode(".//div[@class='infos']");
                var infoCollection = infos.SelectNodes(".//p[@class='txt-gris']");
                var CreationDate = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-info"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var Capital = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-dollar"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Replace("€", "Euro")?.Trim();
                var City = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("map-marker"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var Phone = infoCollection.FirstOrDefault(x => x.OuterHtml.Contains("fa-phone"))?.InnerText?.Replace("\t", "")?.Replace("\r", "")?.Replace("\n", "")?.Trim();
                var email = infos.SelectSingleNode(".//p[@class='mail-link']")?.SelectSingleNode(".//a")?.GetAttributeValue("href", "")?.Replace("mailto:", "");
                var teamList = document.DocumentNode.SelectSingleNode(".//div[@class='team-list']")?.SelectNodes(".//span[@class='tool']")?.Select(x => x.InnerText?.Replace("&amp;", "&")?.Replace("\r\n", " ")?.Trim());


                var model = new Model
                {
                    Capital = Capital?.Replace(",", "."),
                    City = City,
                    Company = company,
                    CreationDate = CreationDate,
                    EmailAddress = email,
                    Link = link,
                    PhoneNumber = Phone,
                    Members = teamList.ToList()
                };
                models.Add(model);
            }

            //models.Select(x=>x.)
            WriteCSV(models, "E:\\csv.csv");

            var serializeObject = JsonConvert.SerializeObject(models);
            File.AppendAllText("E:\\jsonStat.txt", serializeObject);

            var htmlNodeCollection = document.DocumentNode.SelectNodes(".//div[@class='item-startup']").Select(x => x.SelectSingleNode(".//a").GetAttributeValue("href", "")).ToList();
            File.AppendAllLines(@"E:\\StatLink.txt", htmlNodeCollection);
            chromeDriver.Navigate().GoToUrl(@"https://www.startupplace.io/search-startup/");
            while (true)
            {
                try
                {
                    //File.AppendAllText(@"E:\\start.html", chromeDriver.PageSource);
                    Scroll(chromeDriver);
                    var findElementById = chromeDriver.FindElementById("load-more-items");
                    findElementById.Click();

                    Thread.Sleep(5000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
