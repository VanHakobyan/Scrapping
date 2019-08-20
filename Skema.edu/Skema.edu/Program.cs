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

namespace Skema.edu
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetLink();
            GetProfile();
        }

        private static void GetProfile()
        {
            List<Model> models=new List<Model>();
            var text = File.ReadAllText((@"E:\kamil.json"));
            var links = JsonConvert.DeserializeObject<List<string>>(text);
            links = links.Select(x => x.Insert(0, "https://alumni.skema.edu/fr")).ToList();
            ChromeDriver chromeDriver = new ChromeDriver();
            foreach (var link in links)
            {
                chromeDriver.Navigate().GoToUrl(link);
                Thread.Sleep(2500);

                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(chromeDriver.PageSource);
                var fn = document.DocumentNode.SelectSingleNode(".//div[@class='ep-infos-txt']").InnerText.Split(new []{"\r\n" },StringSplitOptions.RemoveEmptyEntries).Where(x=>!string.IsNullOrWhiteSpace(x)).ToList();
                var email = document.DocumentNode.SelectSingleNode(".//div[@id='adresse_perso_mail_tooltip']")?.SelectSingleNode(".//a")?.GetAttributeValue("href", "")?.Replace("Mailto:", "");
                var phone = document.DocumentNode.SelectSingleNode(".//div[@id='adresse_perso_phone_tooltip']")?.InnerText?.Trim();

                var name = fn[0].Trim().Split(' ')[0];
                var name2 = fn[0].Trim().Split(' ')[1];
                var name3 = fn[1].Trim().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)[0];
                var name4 = fn[1].Trim().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)[1];
                models.Add(new Model
                {
                    Email = email,
                    FirstName = name,
                    FamilyName = name2,
                    JobTitle = name4,
                    Company = name3,
                    Telephone = phone
                });
            }

            var serializeObject = JsonConvert.SerializeObject(models);
        }

        private static void GetLink()
        {
            var allLinks = new List<string>();
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(@"https://alumni.skema.edu/fr/annuaire-657");
            Thread.Sleep(4000);
            for (int i = 1; i <= 245; i++)

            {
                try
                {
                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(chromeDriver.PageSource);
                    var links = document.DocumentNode.SelectNodes(".//div[@class='ppl']")
                        .Select(x => x.SelectSingleNode(".//a").GetAttributeValue("href", ""));
                    allLinks.AddRange(links);
                    chromeDriver.FindElementByClassName("next").Click();
                    Thread.Sleep(8000);
                }
                catch (Exception e)
                {
                }
            }

            var text = JsonConvert.SerializeObject(allLinks);
            File.WriteAllText(@"E:\kamil.json", text);
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
    }
}
