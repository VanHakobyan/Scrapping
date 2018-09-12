using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hellocoton
{
    class PostBody
    {
        public string order { get; set; }
        public string category { get; set; }
        public int page { get; set; }
    }
    class Program
    {
        private const string Link = "http://www.hellocoton.fr/annuaire";
        private static string DebutantesLink = "https://www.hellocoton.fr/annuaire/debutantes/{}";
        private static string GlobalLink = "https://www.hellocoton.fr/beaute";
        static void Main(string[] args)
        {
            var option = new ChromeOptions();
            option.AddArgument("no-sandbox");
            option.AddArgument("--start-maximized");
            option.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
            option.AddUserProfilePreference("profile.default_content_setting_values.stylesheet", 2);
            ChromeDriver driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl(GlobalLink);
            for (int i = 0; i < 150; i++)
            {
                driver.ExecuteScript("scroll(0, 125000);");
                var more = driver.FindElement(By.Id("pagination"));
                more.Click();
                Thread.Sleep(300);
            }

            var pageSource = driver.PageSource;
            var categore = new Categores();
           
           
           
           
            var docStars = new HtmlDocument();
            docStars.LoadHtml(pageSource);

            var userItems = docStars.DocumentNode.SelectNodes(".//div[@class='user-item']");
            categore.Profiles = new List<Profile>();
            foreach (var userItem in userItems)
            {
                try
                {
                    var client1 = new WebClient();
                    var profile = new Profile();
                    var name = userItem.SelectSingleNode(".//h3").InnerText;
                    var folow = userItem.SelectNodes(".//p")[1].InnerText;
                    profile.Abonnés = folow;
                    var href = userItem.SelectSingleNode(".//a[@class='avatar']").GetAttributeValue("href", "");
                    profile.ProfilePageUrl = href;
                    profile.Nickname = name;
                    var profileContent = client1.DownloadString(href);
                    var doc = new HtmlDocument();
                    doc.LoadHtml(profileContent);
                    var websiteUrl = doc.DocumentNode.SelectSingleNode(".//div[@class='profile-wrap']")
                        .SelectSingleNode(".//p[@class='profile-blog']").SelectSingleNode(".//a")
                        .GetAttributeValue("href", "");
                    profile.WebsiteUrl = websiteUrl;
                    GetSocial(websiteUrl, profile);
                    categore.Profiles.Add(profile);
                }
                catch (Exception)
                {
                }
            }

            categore.CategoreName = "beaute";
            var json = JsonConvert.SerializeObject(categore);
            File.WriteAllText(@"D:\beaute.json", json);
            //NewMethod();
        }

        private static void NewMethod()
        {
            var models = new List<Categores>();
            var client = new WebClient();
            var downloadString = client.DownloadString(Link);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(downloadString);
            var userCategorys = htmlDoc.DocumentNode.SelectNodes(".//div[@class='user-cat']");
            foreach (var userCategory in userCategorys)
            {
                try
                {
                    var categore = new Categores();
                    var cat = userCategory.SelectSingleNode(".//div[@class='user-group-header']").SelectSingleNode(".//a")
                        .InnerText.Split('&').First().Trim();
                    categore.CategoreName = cat;
                    var catLink = userCategory.SelectSingleNode(".//div[@class='user-group-header']").SelectSingleNode(".//a")
                        .GetAttributeValue("href", "");
                    var lesStars = client.DownloadString(catLink);
                    var docStars = new HtmlDocument();
                    docStars.LoadHtml(lesStars);

                    var userItems = docStars.DocumentNode.SelectNodes(".//div[@class='user-item']");
                    if (userItems is null) continue;
                    categore.Profiles = new List<Profile>();
                    foreach (var userItem in userItems)
                    {
                        try
                        {
                            var client1 = new WebClient();
                            var profile = new Profile();
                            var name = userItem.SelectSingleNode(".//h3").InnerText;
                            var folow = userItem.SelectNodes(".//p")[1].InnerText;
                            profile.Abonnés = folow;
                            var href = userItem.SelectSingleNode(".//a[@class='avatar']").GetAttributeValue("href", "");
                            profile.ProfilePageUrl = href;
                            profile.Nickname = name;
                            var profileContent = client1.DownloadString(href);
                            var doc = new HtmlDocument();
                            doc.LoadHtml(profileContent);
                            var websiteUrl = doc.DocumentNode.SelectSingleNode(".//div[@class='profile-wrap']")
                                .SelectSingleNode(".//p[@class='profile-blog']").SelectSingleNode(".//a")
                                .GetAttributeValue("href", "");
                            profile.WebsiteUrl = websiteUrl;
                            GetSocial(websiteUrl, profile);
                            categore.Profiles.Add(profile);
                        }
                        catch (Exception)
                        {
                        }
                    }

                    var client2 = new WebClient();
                    var linkDeb = docStars.DocumentNode.SelectSingleNode(".//ul[@class='user-group-switch group']")
                        .ChildNodes[3].ChildNodes[1].GetAttributeValue("href", "");
                    var lesDebutantes = client2.DownloadString(linkDeb);
                    var docDebutantes = new HtmlDocument();
                    docDebutantes.LoadHtml(lesDebutantes);

                    var userItemsDebutantes = docDebutantes.DocumentNode.SelectNodes(".//div[@class='user-item']");
                    if (userItemsDebutantes is null) continue;
                    foreach (var userItem in userItemsDebutantes)
                    {
                        try
                        {
                            var client1 = new WebClient();
                            var profile = new Profile();
                            var name = userItem.SelectSingleNode(".//h3").InnerText;
                            var folow = userItem.SelectNodes(".//p")[1].InnerText;
                            profile.Abonnés = folow;
                            var href = userItem.SelectSingleNode(".//a[@class='avatar']").GetAttributeValue("href", "");
                            profile.ProfilePageUrl = href;
                            profile.Nickname = name;
                            var profileContent = client1.DownloadString(href);
                            var doc = new HtmlDocument();
                            doc.LoadHtml(profileContent);
                            var websiteUrl = doc.DocumentNode.SelectSingleNode(".//div[@class='profile-wrap']")
                                .SelectSingleNode(".//p[@class='profile-blog']").SelectSingleNode(".//a")
                                .GetAttributeValue("href", "");
                            profile.WebsiteUrl = websiteUrl;
                            GetSocial(websiteUrl, profile);
                            categore.Profiles.Add(profile);
                        }
                        catch (Exception)
                        {
                        }
                    }


                    models.Add(categore);
                }
                catch (Exception)
                {
                }
            }

            var json = JsonConvert.SerializeObject(models);
            File.WriteAllText(@"D:\hellocoton.json", json);
        }

        public static void GetSocial(string url, Profile profile)
        {
            try
            {
                WebClient client = new WebClient();
                var downloadString = client.DownloadString(url);
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(downloadString);
                try
                {
                    var fbAttr = document.DocumentNode.SelectNodes(".//a").Where(x => x.OuterHtml.Contains("www.facebook") && !x.OuterHtml.Contains("share"));
                    var fb = fbAttr.FirstOrDefault()?.GetAttributeValue("href", "");
                    profile.FacebookURL = fb;
                }
                catch (Exception)
                {
                }
                try
                {
                    var insAttr = document.DocumentNode.SelectNodes(".//a").Where(x => x.OuterHtml.Contains("www.instagram") && !x.OuterHtml.Contains("share"));
                    var ins = insAttr.FirstOrDefault()?.GetAttributeValue("href", "");
                    profile.InstagramURL = ins;
                }
                catch (Exception)
                {
                }

                //var emailAttr = document.DocumentNode.SelectNodes(".//a").Where(x => x.OuterHtml.Contains("mail") && !x.OuterHtml.Contains("share"));
                //var email = emailAttr.FirstOrDefault()?.GetAttributeValue("href", "");
                profile.eMail = EmailRegex(downloadString);
            }
            catch (Exception e)
            {
            }
        }

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
    }
}
