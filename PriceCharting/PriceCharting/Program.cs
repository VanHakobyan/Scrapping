using HtmlAgilityPack;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Enums;
using Scrapping.AllPossibilities.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using System.Threading;
using System.Net;

namespace PriceCharting
{
    public static class ExtensionMethods
    {
        public static string Replace(this string s, char[] separators, string newVal)
        {
            string[] temp;

            temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return String.Join(newVal, temp);
        }
    }
    class Program
    {
        private const string PageUrl = "http://www.pricecharting.com/";
        private const string PageUrlJson = "https://www.pricecharting.com/console/{category}?sort=&cursor={count}&format=json";
        private static readonly string FilePath = ConfigurationManager.AppSettings["Path"];
        private static readonly RequestHelper RequestHelper = new RequestHelper();
        private static readonly Dictionary<string, string> Headers = HeaderBuilder.BuildOwnHeaders(new HeaderModel
        {
            User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.113 Safari/537.36"
        });

        static async Task Main(string[] args)
        {
            try
            {
                await Parse();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private static async Task<string> GetData(string url)
        {
            var tryCount = 2;
            while (tryCount-- > 0)
            {
                try
                {
                    return await RequestHelper.SendRequestAsync(url, headers: Headers, useCookieContainer: true);
                }
                catch
                {
                    Thread.Sleep(100);
                    //ignore
                }
            }

            return null;
        }

        private static async Task Parse()
        {
            var html = await GetData(PageUrl);

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var result = new List<PriceChartingModel>();
            var brands = HtmlDocumentHelper.GetNodesByParams(doc.DocumentNode, HtmlTag.li, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "brand").Where(x => x.GetAttributeValue("id", null) != null && x.GetAttributeValue("id", null) != "tools");
            foreach (var brand in brands)
            {
                try
                {
                    var dropDownMenu = HtmlDocumentHelper.GetNodeByParamsUseXpathStartsWith(brand, HtmlTag.ul, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "menu-dropdown");
                    if (dropDownMenu != null)
                    {
                        var regions = HtmlDocumentHelper.GetNodesByParams(dropDownMenu, HtmlTag.ul, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "region");
                        if (regions != null)
                        {
                            foreach (var region in regions)
                            {
                                var regionName = HtmlDocumentHelper.GetNodeByParams(region, HtmlTag.li, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "title")?.InnerText;
                                var categories = region.SelectNodes(".//li").Where(x => x.InnerHtml != string.Empty);
                                foreach (var category in categories)
                                {
                                    if (category.ChildNodes[0] == null || category.ChildNodes[0].GetAttributeValue("href", null) == null)
                                        continue;
                                    var url = category.ChildNodes[0].GetAttributeValue("href", null);
                                    var name = category.ChildNodes[0].InnerText;
                                    result.Add(new PriceChartingModel
                                    {
                                        Region = regionName,
                                        CategoryName = name,
                                        URL = url
                                    });
                                }
                            }
                        }
                        else
                        {
                            var categories = brand.SelectNodes(".//li").Where(x => x.InnerHtml != string.Empty);
                            foreach (var category in categories)
                            {
                                if (category.ChildNodes[0]?.GetAttributeValue("href", null) == null) continue;
                                var url = category.ChildNodes[0].GetAttributeValue("href", null);
                                var name = category.ChildNodes[0].InnerText;
                                result.Add(new PriceChartingModel
                                {
                                    Region = "NTSC (USA)",
                                    CategoryName = name,
                                    URL = url
                                });
                            }
                        }
                    }
                }
                catch { }
            }
            foreach (var category in result)
            {
                try
                {
                    var categoryData = new List<Data>();
                    category.Data = new List<Data>();
                    var response = new List<Product>();
                    var pageCount = 0;


                    while (true)
                    {
                        try
                        {
                            var jUrl = PageUrlJson.Replace("{category}", category.URL.Split('/').Last()).Replace("{count}", pageCount.ToString());
                            var dataJson = await GetData(jUrl);
                            var jsonObj = JsonConvert.DeserializeObject<Response>(dataJson);
                            response.AddRange(jsonObj.products);
                            if (jsonObj.products.Length == 50)
                            {
                                pageCount += 50;
                                Thread.Sleep(100);
                                continue;
                            }
                            break;
                        }
                        catch
                        {

                        }
                    }

                    //var document = new HtmlDocument();
                    //var dataHtml = await requestHelper.SendRequestAsync(category.URL, headers: headers, useCookieContainer: true);
                    //document.LoadHtml(dataHtml);
                    //var table = HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, HtmlTag.table, Scrapping.AllPossibilities.Enums.HtmlAttribute.id, "games_table");
                    //var data = table?.SelectNodes(".//tbody//tr");
                    //if (data == null) continue;
                    //foreach (var product in data)
                    //{
                    //    var title = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "title")?.InnerText;
                    //    var loosePrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric used_price")?.InnerText;
                    //    var cIBPrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric cib_price")?.InnerText;
                    //    var newPrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric new_price")?.InnerText;
                    //    categoryData.Add(new Data
                    //    {
                    //        Title = title.Trim(' ', '\n'),
                    //        LoosePrice = loosePrice.Trim(' ', '\n'),
                    //        CIBPrice = cIBPrice.Trim(' ', '\n'),
                    //        NewPrice = newPrice.Trim(' ', '\n')
                    //    });
                    //}
                    foreach (var item in response)
                    {
                        categoryData.Add(new Data
                        {
                            Title = item.productName,
                            LoosePrice = item.price1,
                            CIBPrice = item.price3,
                            NewPrice = item.price2
                        });
                    }
                    category.Data = categoryData;
                }
                catch (Exception ex)
                {

                }
                // details
                foreach (var data in category.Data)
                {
                    try
                    {
                        var url = $"{category.URL.Replace("console", "game")}/{ExtensionMethods.Replace(data.Title, new char[] { '[', ']', '(', ')', '/', '\\', '.', ':'}, "").Replace(' ', '-')}";

                        Thread.Sleep(200);
                        html = await requestHelper.SendRequestAsync(url, headers: HeaderBuilder.GetDefaultHeaders(), useCookieContainer: true);

                        doc = new HtmlDocument();
                        doc.LoadHtml(html);
                        var attributeNode = HtmlDocumentHelper.GetNodeByParams(doc.DocumentNode, HtmlTag.table, Scrapping.AllPossibilities.Enums.HtmlAttribute.id, "attribute");
                        if (attributeNode != null)
                        {
                            var detailNodes = attributeNode.SelectNodes(".//tr");
                            var genre = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "Genre:");
                            var releaseDate = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "Release Date:");
                            var rating = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "ESRB Rating:");
                            var publisher = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "Publisher:");
                            var developer = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "Developer:");
                            var playerCount = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "Player Count:");
                            var upc = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "UPC:");
                            var asin = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "ASIN (Amazon):");
                            var epid = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "ePID (eBay):");
                            var priceChartingId = detailNodes.FirstOrDefault(x => x.SelectSingleNode(".//td").InnerText == "PriceCharting ID:");

                            if (genre != null)
                                data.Genre = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(genre, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (releaseDate != null)
                                data.ReleaseDate = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(releaseDate, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (rating != null)
                                data.Rating = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(rating, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (publisher != null)
                                data.Publisher = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(publisher, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (developer != null)
                                data.Developer = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(developer, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (playerCount != null)
                                data.PlayerCount = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(playerCount, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (upc != null)
                                data.UPC = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(upc, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (asin != null)
                                data.Amazon_ASIN = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(asin, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (epid != null)
                                data.Ebay_ePID = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(epid, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                            if (priceChartingId != null)
                                data.PriceChartingId = WebUtility.HtmlDecode(HtmlDocumentHelper.GetNodeByParams(priceChartingId, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "details")?.InnerText?.Trim(' ', '\n'));
                        }
                    }
                    catch
                    {

                    }
                }
                await Task.Delay(500);
            }
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            if (string.IsNullOrEmpty(FilePath))
            {
                Console.WriteLine("Wrong file name");
                return;
            }

            var fullPath = $"{FilePath}{DateTime.Now:yyyyMMdd_hhmmss}.json";
            try
            {
                using (var stream = new FileStream(fullPath, FileMode.OpenOrCreate))
                {
                    using (var writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        writer.Write(json);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        }
    }
