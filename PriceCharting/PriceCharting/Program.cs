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

namespace PriceCharting
{
    class Program
    {
        private const string PageUrl = "http://www.pricecharting.com/";
        private static readonly string FilePath = ConfigurationManager.AppSettings["Path"];
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
        private static async Task Parse()
        {
            var requestHelper = new RequestHelper();
            var headers = HeaderBuilder.BuildOwnHeaders(new HeaderModel
            {
                User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.113 Safari/537.36"
            });
            var html = await requestHelper.SendRequestAsync(PageUrl, headers: HeaderBuilder.GetDefaultHeaders(), useCookieContainer: true);

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
                    var document = new HtmlDocument();

                    var dataHtml = await requestHelper.SendRequestAsync(category.URL, headers: headers, useCookieContainer: true);
                    document.LoadHtml(dataHtml);
                    var table = HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, HtmlTag.table, Scrapping.AllPossibilities.Enums.HtmlAttribute.id, "games_table");
                    var data = table?.SelectNodes(".//tbody//tr");
                    if (data == null) continue;
                    foreach (var product in data)
                    {
                        var title = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "title")?.InnerText;
                        var loosePrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric used_price")?.InnerText;
                        var cIBPrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric cib_price")?.InnerText;
                        var newPrice = HtmlDocumentHelper.GetNodeByParams(product, HtmlTag.td, Scrapping.AllPossibilities.Enums.HtmlAttribute._class, "price numeric new_price")?.InnerText;
                        categoryData.Add(new Data
                        {
                            Title = title.Trim(' ', '\n'),
                            LoosePrice = loosePrice.Trim(' ', '\n'),
                            CIBPrice = cIBPrice.Trim(' ', '\n'),
                            NewPrice = newPrice.Trim(' ', '\n')
                        });
                    }
                    category.Data = categoryData;
                }
                catch (Exception ex)
                {

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
