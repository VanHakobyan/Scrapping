using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Dribbble.Lib
{
    public class Scrapper
    {
        private string AllProfileUrl = @"https://dribbble.com/designers?page={id}&per_page=6";


        public async Task<List<string>> GetProfileContent()
        {
            var listOfContacts=new List<string>();
            for (var i = 1 ;i < 9; i++)
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

    }
}
