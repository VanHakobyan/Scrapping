using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Hellocoton
{
    class Program
    {
        private const string Link = "http://www.hellocoton.fr/annuaire";
        static void Main(string[] args)
        {
            var models=new  List<Categores>();
            var client=new WebClient();
            var downloadString = client.DownloadString(Link);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(downloadString);
            var userCategorys = htmlDoc.DocumentNode.SelectNodes(".//div[@class='user-cat']");
            foreach (var userCategory in userCategorys)
            {
                var categore= new Categores();
                var cat = userCategory.SelectSingleNode(".//div[@class='user-group-header']").SelectSingleNode(".//a").InnerText.Split('&').First().Trim();
                categore.CategoreName = cat;
                var userItems = userCategory.SelectNodes(".//div[@class='user-item']");
                if(userItems is null) continue;
                categore.Profiles=new List<Profile>();
                foreach (var userItem in userItems)
                {
                    var profile = new Profile();
                    var name = userItem.SelectSingleNode(".//h3").InnerText;
                    var folow = userItem.SelectNodes(".//p")[1].InnerText;
                    profile.Abonnés = folow;
                    var href = userItem.SelectSingleNode(".//a[@class='avatar']").GetAttributeValue("href","");
                    profile.ProfilePageUrl = href;
                    profile.Nickname = name;
                    var profileContent = client.DownloadString(href);
                    var doc=new HtmlDocument();
                    doc.LoadHtml(profileContent);
                    var websiteUrl = doc.DocumentNode.SelectSingleNode(".//div[@class='profile-wrap']").SelectSingleNode(".//p[@class='profile-blog']").SelectSingleNode(".//a").GetAttributeValue("href", "");
                    profile.WebsiteUrl = websiteUrl;
                    categore.Profiles.Add(profile);
                }
                models.Add(categore);
            }

            var json = JsonConvert.SerializeObject(models);
            File.WriteAllText(@"D:\hellocoton.json", json);
        }
    }
}
