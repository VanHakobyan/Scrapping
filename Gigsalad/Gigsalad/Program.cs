using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;

namespace Gigsalad
{
    class Program
    {
        public static string EmailRegex(string text)
        {
            try
            {
                const string MatchEmailPattern =
                    @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
                Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                // Find matches.
                MatchCollection matches = rx.Matches(text);
                // Report the number of matches found.

                // Report on each match.
                foreach (Match match in matches)
                {
                    return match.Value;
                }
            }
            catch (Exception e)
            {
            }

            return "";
        }
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
        private const string link = "https://www.gigsalad.com/Disc-Jockeys-DJs/Club-DJ/CA/Los+Angeles";
        static void Main(string[] args)
        {

            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(link);
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    try
                    {

                        chromeDriver.ExecuteScript("scroll(0, 125000);");
                        var more = chromeDriver.FindElementById("show_more_results");
                        more.Click();
                        Thread.Sleep(300);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {
            }
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(chromeDriver.PageSource);
            var linksNode = document.DocumentNode.SelectNodes(".//a[@class='vendor-card__image js-vendor-card__image']");
            var links = linksNode.Select(x => x.GetAttributeValue("href", ""));
            var listModel = new List<Model>();
            foreach (var linkItem in links)
            {
                chromeDriver.Navigate().GoToUrl($"https://www.gigsalad.com/{linkItem}");
                HtmlDocument documentItem = new HtmlDocument();
                documentItem.LoadHtml(chromeDriver.PageSource);
                var model = new Model();
                var userName = documentItem.DocumentNode.SelectSingleNode(".//h1[@class='profile-vendor-card__act-name']").InnerText;
                var category = documentItem.DocumentNode.SelectSingleNode(".//a[@class='link--secondary-color']").InnerText;
                var informationDivs = documentItem.DocumentNode.SelectSingleNode(".//div[@class='row small-up-1 medium-up-2']");
                if (informationDivs != null)
                {
                    var number = informationDivs.ChildNodes.FirstOrDefault(x => x.InnerText.Contains("Call"));
                    var phoneNumber = number?.SelectSingleNode(".//a[@data-drop-type='profileShowPhone']").GetAttributeValue("data-promokit-phone", "");
                    if (!string.IsNullOrEmpty(phoneNumber)) model.Phone = phoneNumber;
                    var website = informationDivs?.ChildNodes?.FirstOrDefault(x => x.InnerText.Contains("Website"))?.SelectSingleNode(".//a")?.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(website)) model.WebSite = website;
                }

                var socialDiv = documentItem.DocumentNode.SelectSingleNode(".//div[@id='social']");

                if (socialDiv != null)
                {
                    var linksSoc = socialDiv.SelectNodes(".//a").Select(x => x.GetAttributeValue("href", ""));
                    if (linksSoc != null && linksSoc.Count() != 0) model.SocialLink = string.Join(" , ", linksSoc);
                }

                model.Email = EmailRegex(chromeDriver.PageSource);
                model.UserName = userName;
                model.Category = category;
                listModel.Add(model);
            }

            WriteCSV(listModel, "E:\\Djs.csv");

        }
    }
}
