using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace TraiteursCamille
{
    class Program
    {
        public static async Task<string> SendGetRequest(string url, string ipAddress, string port)
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
                //var builder = new UriBuilder(ipAddress)
                //{
                //    Port = int.Parse(port)
                //};
                //IWebProxy proxy = new WebProxy(builder.Uri);
                //request.Proxy = proxy;
                //request.Timeout = 30000;
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
        private const string RootLink = @"https://www.traiteurs-de-france.com/le-reseau";
        static void Main(string[] args)
        {
            var content = SendGetRequest(RootLink, null, null).Result;
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(content);
            var links = document.DocumentNode.SelectNodes(".//a[@target='_self']").Select(x => x.GetAttributeValue("href", "")).Where(x => x.Contains("LesTraiteurs")).ToList();
            List<Model> list=new List<Model>();
            foreach (var link in links)
            {
                HtmlAgilityPack.HtmlDocument d = new HtmlAgilityPack.HtmlDocument();
                var c = SendGetRequest(link, null, null).Result;
                d.LoadHtml(c);
                var innerScript = d.DocumentNode.SelectNodes(".//script[@type='text/javascript']").FirstOrDefault(x => x.InnerHtml.Contains("Contact commercial"))?.InnerText.Replace("var warmupData = ", "").TrimStart('\n').Replace("\"tpaWidgeNativeAspectWarmupData\":{}};", "\"tpaWidgeNativeAspectWarmupData\":{}}").Trim();
                var deserializeObject = JsonConvert.DeserializeObject<Rootobject>(innerScript);
                var adresse = deserializeObject.dynamicPages.data.ai3xt.routerData.items.FirstOrDefault()?.adresse;
                var other = deserializeObject.dynamicPages.data.ai3xt.routerData.items.FirstOrDefault()?.contactCommercial;
                var dirigeant = deserializeObject.dynamicPages.data.ai3xt.routerData.items.FirstOrDefault()?.dirigeant;
                Regex regex = new Regex("style=\"text-align:center\">(.*?)<\\/p>");
                var address = string.Join(" ", regex.Matches(adresse).Cast<Match>().Select(x => x.Groups[1].Value).Take(2));
                Regex regexTel = new Regex("style=\"text-align:center\">TEL : (.*?)<\\/p>");
                var tel = regexTel.Match(adresse).Groups[1].Value;
                Regex regexFax = new Regex("style=\"text-align:center\">FAX : (.*?)<\\/p>");
                var fax = regexFax.Match(adresse).Groups[1].Value;
                Regex regexEmail = new Regex("style=\"text-align:center\">Email : (.*?)<\\/p>");
                var email = string.Join(" ", regexEmail.Matches(adresse).Cast<Match>().Select(x => x.Groups[1].Value).Take(2));
                var model = new Model
                {
                    Adress = HttpUtility.HtmlDecode(address),
                    ContactCommercial = HttpUtility.HtmlDecode(other),
                    Dirigeant = HttpUtility.HtmlDecode(dirigeant),
                    EmailAddress = HttpUtility.HtmlDecode(email?.Replace("<a href=\"", " ").Replace("\">","")),
                    NameOfTheTraiteur = HttpUtility.HtmlDecode(link.Split(new[] {"LesTraiteurs/"}, StringSplitOptions.RemoveEmptyEntries)
                        .LastOrDefault()?.Replace("-", " ")),
                    TelephoneNumber = HttpUtility.HtmlDecode(tel),
                    Fax = HttpUtility.HtmlDecode(fax)
                };
                list.Add(model);
                Thread.Sleep(1500);
            }

            foreach (var item in list)
            {
                item.Adress = item.Adress?.Replace(",", " ");
                item.ContactCommercial = item.ContactCommercial?.Replace(",", " ");
                item.Dirigeant = item.Dirigeant?.Replace(",", " ");
                item.EmailAddress = item.EmailAddress?.Replace(",", " ");
                item.NameOfTheTraiteur = item.NameOfTheTraiteur?.Replace(",", " ");
                item.TelephoneNumber = item.TelephoneNumber?.Replace(",", " ");
                item.Fax = item.Fax?.Replace(",", " ");
            }
            WriteCSV(list,@"E:\\data.csv");
        }
    }
}
