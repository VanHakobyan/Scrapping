using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Path = System.IO.Path;

namespace ParseLot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static FirefoxDriver driver = new FirefoxDriver();
        private static List<LotModel> models = new List<LotModel>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            driver.Navigate().GoToUrl(@"https://www.lot.com/pl/en/");
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                try
                {
                    await CreateModel();
                    
                    try
                    {
                        var findElementByClassName = driver.ExecuteScript("return document.getElementsByClassName('flight_pagination__item slick-slide slick-active')") as IEnumerable<IWebElement>;
                        findElementByClassName.ElementAt(4).Click();
                        await Task.Run(() => Thread.Sleep(11000));
                    }
                    catch (Exception)
                    {

                    }
                    try
                    {
                        var findElementByClassName1 = driver.ExecuteScript("return document.getElementsByClassName('flight_pagination__item slick-slide slick-active')") as IEnumerable<IWebElement>;
                        findElementByClassName1.ElementAt(11).Click();
                        await Task.Run(() => Thread.Sleep(10));
                    }
                    catch (Exception)
                    {

                    }
                }
                catch (Exception ex)
                {
                   
                }
            }

        }

        private static async Task CreateModel()
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(driver.PageSource);
            //var selectSingleNode = document.DocumentNode.SelectSingleNode("//li[@class='flight_pagination__item active slick-slide slick-active']");
            var dayTab = document.DocumentNode
                .SelectNodes("//li[@class='flight_pagination__item active slick-slide slick-active']").First();
            var dayOuterHtml = dayTab.SelectSingleNode("//a[starts-with(@aria-label,'Selected')]").OuterHtml;
            Regex r = new Regex("--date\">(.*?)</span>");
            var day = r.Match(dayOuterHtml).Groups[1].Value;

            var allTic = document.DocumentNode.SelectNodes("//div[@class='VAB__flight__content']").ToList();
            var starts = allTic[0]
                .SelectNodes(
                    "//p[@class='VAB__flight__info__direction__item VAB__flight__info__direction__item--departure']"); //.InnerText.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("Origin,", "").Replace("Destination,", "");
            var ends = allTic[0]
                .SelectNodes(
                    "//p[@class='VAB__flight__info__direction__item VAB__flight__info__direction__item--arrival']"); //.InnerText.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("Origin,", "").Replace("Destination,", "");

            for (int i = 0; i < allTic.Count; i++)
            {
                try
                {
                    var flight = "Departure";
                    HtmlDocument documentNest = new HtmlDocument();
                    documentNest.LoadHtml(allTic[i].InnerHtml);
                    var start = starts[i].InnerText.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("Origin,", "")
                        .Replace("Destination,", "").Trim();
                  
                    var end = ends[i].InnerText.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("Origin,", "")
                        .Replace("Destination,", "").Trim();

                    Regex reg = new Regex("price__amount\">(.*?)</span>");
                    var pricePEObj = documentNest.DocumentNode.SelectSingleNode("//a[@id='VAB__flight__rates__rate__header__content_-1-PREMIUM_ECONOMY']");
                    string pricePE = "";
                    string priceE = "";
                    string priceP="";
                    if (pricePEObj == null)
                    {
                        var allPr = documentNest.DocumentNode.SelectNodes("//a[starts-with(@id,'VAB__flight__rates__rate__header__content')]");
                        if(allPr.FirstOrDefault(x=>x.InnerHtml.Contains("Premium Economy"))!=null) pricePE = reg.Match(allPr.FirstOrDefault(x => x.InnerHtml.Contains("Premium Economy")).OuterHtml).Groups[1].Value;
                        if(allPr.FirstOrDefault(x => x.OuterHtml.Contains("Economy")) != null) priceE = reg.Match(allPr.FirstOrDefault(x => x.OuterHtml.Contains("Economy")).OuterHtml).Groups[1].Value;
                        if(allPr.FirstOrDefault(x => x.OuterHtml.Contains("Business")) != null) priceP = reg.Match(allPr.FirstOrDefault(x => x.OuterHtml.Contains("Business")).OuterHtml).Groups[1].Value;
                        //flight = "Return";
                    }
                    else
                    {
                        pricePE = reg.Match(pricePEObj.OuterHtml).Groups[1].Value;
                        // .SelectSingleNode("//span[@class='VAB__flight__rates__rate__price__amount']").InnerText;
                        var priceEObj = documentNest.DocumentNode.SelectSingleNode("//a[@id='VAB__flight__rates__rate__header__content_-1-ECONOMY']");

                        priceE = reg.Match(priceEObj.OuterHtml).Groups[1].Value;
                        // .SelectSingleNode("//span[@class='VAB__flight__rates__rate__price__amount']").InnerText; ;
                        var pricesPObj = documentNest.DocumentNode.SelectSingleNode("//a[@id='VAB__flight__rates__rate__header__content_-1-BUSINESS']");

                        priceP = reg.Match(pricesPObj.OuterHtml).Groups[1].Value;
                        //.SelectSingleNode("//span[@class='VAB__flight__rates__rate__price__amount']").InnerText; 
                    }

                    if (!start.Contains("WAW"))
                    {
                        flight = "Return";
                        var dayTabRet = document.DocumentNode
                            .SelectNodes("//a[starts-with(@aria-label,'Selected')]").Last();
                        Regex rRet = new Regex("--date\">(.*?)</span>");
                        day = rRet.Match(dayTabRet.InnerHtml).Groups[1].Value;
                    }
                    models.Add(new LotModel
                    {
                        Type = Type.Business,
                        Day = day,
                        Start = start,
                        End = end,
                        Price = priceP.Replace("&nbsp;",""),
                        Flight = flight
                    });
                    models.Add(new LotModel
                    {
                        Type = Type.PremiumEconomy,
                        Day = day,
                        Start = start,
                        End = end,
                        Price = pricePE.Replace("&nbsp;", ""),
                        Flight = flight
                    });
                    models.Add(new LotModel
                    {
                        Type = Type.Economy,
                        Day = day,
                        Start = start,
                        End = end,
                        Price = priceE.Replace("&nbsp;", ""),
                        Flight = flight
                    });
                }
                catch (Exception e)
                {

                }
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var path = TextBox.Text;
            try
            {
                File.WriteAllText($"{path}{Guid.NewGuid()}.json", JsonConvert.SerializeObject(models));
                MessageBox.Show("Succes");
            }
            catch (Exception ex)
            {
                
            }
            await Task.Run(() => Thread.Sleep(100));
        }
    }
}

