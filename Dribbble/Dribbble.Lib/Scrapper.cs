using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dribbble.Lib
{
    public class Scrapper
    {
        private string RootUrl = @"https://dribbble.com";
        private string AllProfileUrl = @"https://dribbble.com/designers?page={id}&per_page=6";


        public async Task<List<string>> GetProfileLinks()
        {
            var listOfContacts = new List<string>();
            for (var i = 1; i < 9; i++)
            {
                try
                {
                    var content = await SendGetRequest(AllProfileUrl.Replace("{id}", i.ToString()));
                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(content);
                    var contacts = document.DocumentNode.SelectNodes(".//a[@class='jobs-mark']").Select(x => x.GetAttributeValue("href", ""));
                    listOfContacts.AddRange(contacts.Select(x => x.Replace("/jobs", "")));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return listOfContacts;
        }

        public static async Task<string> SendGetRequest(string url)
        {
            var response = string.Empty;

            try
            {

                ServicePointManager.DefaultConnectionLimit = 10;
                ServicePointManager.Expect100Continue = false;
                ServicePointManager.DnsRefreshTimeout = 1000;
                ServicePointManager.UseNagleAlgorithm = false;

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";

                request.Timeout = 30000;
                using (var stream = (await request.GetResponseAsync()).GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var streamReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                        {
                            response = await streamReader.ReadToEndAsync();
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public async Task<List<ProfileModel>> GetProfiles()
        {
            var profileUrls = await GetProfileLinks();
            var profiles = new List<ProfileModel>();
            foreach (var url in profileUrls)
            {
                try
                {
                    var profile = new ProfileModel();
                    profiles.Add(profile);

                    var content = await SendGetRequest($"{RootUrl}{url}");
                    var document = new HtmlDocument();
                    document.LoadHtml(content);
                    var profileLeftNode = document.DocumentNode.SelectSingleNode(".//div[@class='floating-sidebar profile-info ']");
                    var essentials = profileLeftNode.SelectSingleNode(".//div[@class='profile-info-mod profile-essentials']");
                    var sidebarFloat = profileLeftNode.SelectSingleNode(".//div[@class='floating-sidebar-float']");
                    var sidebarExtras = profileLeftNode.SelectNodes(".//div[@class='floating-sidebar-extra']//div[@class='profile-info-mod']");

                    var nameAndImageNode = essentials.SelectSingleNode(".//a[@class='url']");
                    var name = nameAndImageNode.InnerText.Trim();
                    var imageUrl = nameAndImageNode.SelectSingleNode(".//picture//img").GetAttributeValue("src", "");
                    var biography = essentials.SelectSingleNode(".//div[@class='bio']")?.InnerText?.Trim();
                    var bioAndEmail = biography?.Split('\n');
                    var skills = sidebarFloat.SelectNodes(".//ul[@class='skills-list']//li")?.Select(x => x.InnerText?.Trim());
                    var location = essentials?.SelectSingleNode(".//span[@class='locality']")?.InnerText?.Trim();


                    profile.Name = name;
                    profile.ImageUrl = imageUrl;
                    profile.Location = location;
                    if (skills != null) profile.Skills.AddRange(skills);
                    if (bioAndEmail != null && bioAndEmail.Length > 1) profile.Bio = bioAndEmail[0];
                    if (bioAndEmail != null && bioAndEmail.Length > 1) profile.Email = bioAndEmail[1];

                    var onTeams = sidebarExtras?.FirstOrDefault(x => x.InnerText.Contains("On Teams"));
                    var elsewhere = sidebarExtras?.FirstOrDefault(x => x.InnerText.Contains("Elsewhere"));
                    var projects = sidebarExtras?.FirstOrDefault(x => x.InnerText.Contains("Projects"));
                    var featured = sidebarExtras?.FirstOrDefault(x => x.InnerText.Contains("Featured"));

                    if (onTeams != null)
                    {
                        var lis = onTeams.SelectNodes(".//ul[@class='profile-details on-teams']//li").Select(x => x.InnerText.Trim());
                        profile.OnTeams.AddRange(lis);
                    }
                    if (elsewhere != null)
                    {
                        var lis = elsewhere.SelectNodes(".//ul[@class='profile-details']//li//a")?.Select(x => x.GetAttributeValue("href", "")?.Trim()).Select(x => x?.Insert(0, RootUrl));
                        profile.Elsewhere.AddRange(lis);
                    }
                    if (projects != null)
                    {
                        var projectList = new List<Project>();
                        var lis = projects.SelectNodes(".//ul[@class='profile-projects']//li//a");
                        foreach (var li in lis.Reverse().Skip(1))
                        {
                            var project = new Project
                            {
                                ImageUrl = li.SelectSingleNode(".//img").GetAttributeValue("src", ""),
                                Name = li.SelectSingleNode(".//h4")?.InnerText?.Trim(),
                                Shots = li.SelectSingleNode(".//span")?.InnerText?.Trim()
                            };
                            projectList.Add(project);
                        }
                        profile.Projects.AddRange(projectList);
                    }
                    if (featured != null)
                    {
                        var lis = featured.SelectNodes(".//ul[@class='profile-details profile-featured']//li")?.Select(x => x.InnerText.Trim());
                        profile.Featured.AddRange(lis);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            return profiles;
        }
    }
}
