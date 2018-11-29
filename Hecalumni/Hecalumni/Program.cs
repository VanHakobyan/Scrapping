using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;

namespace Hecalumni
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
        const string Url = @"https://www.hecalumni.fr/addressbook/fullsearch/index?q=*&facets%5Bcountry_facet%5D%5B%5D=france&facets%5Bcountry_facet%5D%5B%5D=suisse&facets%5Bcountry_facet%5D%5B%5D=belgique&facets%5Bgroups_facet%5D%5B%5D=angels";

        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(Url);
            Thread.Sleep(5000);
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    chromeDriver.ExecuteScript($"window.scrollBy(0,1750);");
                }
                catch(Exception e)
                {

                }
                Thread.Sleep(1000);
            }
            var models = new List<Model>();
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(chromeDriver.PageSource);
            var listOfLink = document.DocumentNode.SelectNodes(".//a[starts-with(@id,'addressbook-details')]")?.Select(x => x.GetAttributeValue("href", ""))?.Distinct().ToList();
            foreach (var link in listOfLink)
            {
                try
                {
                    chromeDriver.Navigate().GoToUrl($"https://www.hecalumni.fr{link}");
                    Thread.Sleep(2000);
                    var doc = new HtmlDocument();
                    doc.LoadHtml(chromeDriver.PageSource);
                    var model = new Model();
                    model.FirstName = link.Split('/')[2].Split('-')?.First();
                    model.LastName = link.Split('/')[2].Split('-')?.Last();
                    chromeDriver.FindElementByXPath(".//a[@id='link-addresses']")?.Click();
                    var profileDiv = doc.DocumentNode.SelectSingleNode(".//div[@class='row-fluid profile-user-job']");
                    var job = profileDiv.SelectSingleNode(".//div[@class='span12 bigger']")?.InnerText?.Trim().Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    var city = profileDiv.SelectNodes(".//div[@class='row-fluid no-min-height pull-up-mini']").First()?.SelectSingleNode(".//a")?.InnerText?.Split(',')?.First().Trim().Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    var mail = profileDiv.SelectNodes(".//div[@class='row-fluid no-min-height pull-up-mini']")?.Last()?.InnerText?.Trim()?.Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    model.City = city;
                    model.Email = mail;
                    model.Job = job;
                    models.Add(model);
                }
                catch (Exception e)
                {

                }
            }

            WriteCSV(models,"D:\\HEC.csv");
            WriteCSV(listOfLink,"D:\\HECLink.csv");

        }
    }
}
