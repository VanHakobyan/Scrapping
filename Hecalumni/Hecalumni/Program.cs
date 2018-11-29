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
            for (int i = 0; i < 80; i++)
            {
                try
                {
                    chromeDriver.ExecuteScript($"window.scrollBy(0,1750);");
                }
                catch (Exception e)
                {

                }
                Thread.Sleep(2000);
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
                    Thread.Sleep(1300);
                    var doc = new HtmlDocument();
                    doc.LoadHtml(chromeDriver.PageSource);
                    var model = new Model();
                    var s = link.Split('/')[2];
                    var arr = s.Split('-');
                    var fn = string.Empty;
                    var ln = string.Empty;
                    fn = arr[0];
                    if (arr.Length == 2)
                    {
                        ln = arr[1];
                    }
                    else
                    {
                        ln = string.Join(" ", arr.Skip(1));
                    }

                    model.FirstName = fn;
                    model.LastName = ln;
                    //try
                    //{
                    //    chromeDriver.FindElementByXPath(".//a[@id='link-addresses']")?.Click();
                    //    Thread.Sleep(1000);
                    //}
                    //catch (Exception e)
                    //{

                    //}
                    var profileDiv = doc.DocumentNode.SelectSingleNode(".//div[@class='row-fluid profile-user-job']");
                    var mail = doc.DocumentNode.SelectSingleNode(".//div[@class='row-fluid no-min-height user-profil-email-1']")?.SelectSingleNode(".//a")?.InnerText?.Trim()?.Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    var job = profileDiv.SelectSingleNode(".//div[@class='row-fluid']")?.InnerText?.Trim().Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    var city = profileDiv.SelectNodes(".//div[@class='row-fluid no-min-height pull-up-mini']").FirstOrDefault(x => x.OuterHtml.Contains("Masquer les coordonnées"))?.SelectSingleNode(".//div[@class='span12']").ChildNodes.Where(x => x.Name == "#text").ElementAt(1).InnerText?.Trim().Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    //var mail = profileDiv.SelectNodes(".//div[@class='row-fluid no-min-height pull-up-mini']")?.Last()?.InnerText?.Trim()?.Replace("\r", "")?.Replace("\t", "")?.Replace("\n", "");
                    model.City = city;
                    model.Email = mail;
                    model.Job = job;
                    models.Add(model);
                }
                catch (Exception e)
                {

                }
            }

            foreach (var model in models)
            {
                model.FirstName = model.FirstName?.Replace(",", ".");
                model.LastName = model.LastName?.Replace(",", ".");
                model.Job = model.Job?.Replace(",", ".");
                model.City = model.City?.Replace(",", ".");
                model.Email = model.Email?.Replace(",", ".");
            }
            WriteCSV(models, "E:\\HEC1.csv");
            //File.WriteAllLines("E:\\HECLink.txt", listOfLink);

        }
    }
}
