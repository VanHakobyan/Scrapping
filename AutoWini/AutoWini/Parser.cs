using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace AutoWini
{
    public class Parser
    {
        private const string KiaK5Url = @"http://www.autowini.com/Cars/Kia-K5/car-search.do?i_sIndexVal=bq&i_sSearchType=quick&startYear=2010&endYear=2015&sPriceFrom=2500&sPriceTo=4200";
        private const string KiaK5PostData = @"i_sSoldType=N&i_sSort=recentdate&i_iPageSize=40&i_iNowPageNo=1&V_PAGEACTION=SELECT&i_sType_q=&i_sMakeCd_q=C0810&i_sModelCd_q=&i_sSteeringCd_q=&i_sTransmissionCd_q=&i_sDriveTypeCd_q=&i_sFuelTypeCd_q=&i_sLocationCd_q=&i_sStartYear_q=2009&i_sEndYear_q=2015&i_sPriceFrom_q=2500&i_sPriceTo_q=3500&i_sKeyWord_q=&i_sYouTubeIdYn_q=&i_sEscrowYn_q=&i_sCheckReportYn_q=&i_sFlagPhotographed_q=&i_sFlagPrime=&i_sPassenger=";
        private static readonly List<CarModel> CarModels = new List<CarModel>();
        private static readonly EmailSender EmailSender=new EmailSender();

        public void GetAndAnalyzeData()
        {
            EmailSender.SendEmail(new CarModel(){Name = "Test",Price = 0});
            while (true)
            {
                HttpClient client = new HttpClient();
                var content = client.PostAsync(KiaK5Url, new StringContent(KiaK5PostData)).Result;
                var source = content.Content.ReadAsStringAsync().Result.ToString();
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(source);
                var allAutoUl = document.DocumentNode.SelectSingleNode(".//ul[@class='searchResultList']");
                var autoCollection = allAutoUl.SelectNodes(".//li[@class='original ']");
                foreach (var auto in autoCollection)
                {
                    var autoInfo = auto.SelectSingleNode(".//div[@class='stockInfo']");
                    if (autoInfo != null && !autoInfo.InnerText.ToLower().Contains("taxi") && auto.InnerHtml.Contains("image.autowini.com/resources/IMG/renew/common/icon/icon_new.png"))
                    {
                        var autoPrice = auto.SelectSingleNode(".//div[@class='stockPrice']").InnerText.ToLower().Replace("usd", "").Replace(",", "").Trim();
                        var price = int.Parse(autoPrice);
                        if (price > 2500 && price <= 3500)
                        {
                            var autoName = autoInfo.SelectSingleNode(".//span").InnerText;
                            var dd = autoInfo.SelectSingleNode(".//dd").InnerText.Replace("\r\n","");
                            Alert(autoName+" " + dd, price);
                        }
                    }
                }

                Thread.Sleep(TimeSpan.FromMinutes(10));
            }
        }

        private void Alert(string name, int price)
        {
            var carModel = new CarModel {Name = name, Price = price};
            if (!CarModels.Select(x => x.Name.ToLower()).Contains(name.ToLower()))
            {
                EmailSender.SendEmail(carModel);
                CarModels.Add(carModel);
            }
            
        }
    }
}
