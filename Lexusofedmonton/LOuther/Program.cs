using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace LOuther
{
    class Program
    {
        private static string link =
            @"https://www.lexusofedmonton.ca/used-vehicles/#action=im_ajax_call&perform=get_results&type%5B%5D=Used&type%5B%5D=Certified+Used";
        static void Main(string[] args)
        {
            var urls = new List<string>();
            for (int i = 1; i < 9; i++)
            {
                string index = i.ToString();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(link);
                webreq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64;x64; rv: 58.0) Gecko / 20100101 Firefox / 58.0";
                webreq.ContentType = "application/x-www-form-urlencoded;charset = UTF - 8";
                //webreq.MediaType = "application/json";
                webreq.Accept = "application/json, text/javascript, /; q=0.01";

                webreq.Method = "POST";

                CookieContainer container = new CookieContainer();
                Cookie ck = new Cookie();
                webreq.Headers.Add("Cookie",
                @"forty_n_user=AdtdiU80-T3GEVr4aAuQAA~~;forty_n_t=1.cf026a.1534782833.1.4.1534782833.1534782948.4.0;di_roxanne[visit_id]=453190142; di_roxannevisitor_id]=714806210;diGeolocationIgnoreData={""currentRequestCount"":2,""createdAt"":1534782850335};tp_referral=1541655;di_referral=%7B%22ppc_terms%22%3Anull%2C%22url%22%3A%22NA%22%2C%22type%22%3A%22Direct%22%2C%22createdAt%22%3A%222018-08-20T16%3A33%3A55%2B0000%22%7D;di_page_history=a%3A2%3A%7Bi%3A0%3Bs%3A13%3A%22used-vehicles%22%3Bi%3A1%3Bs%3A28%3A%22welcome-to-lexus-of-edmonton%22%3B%7D;di_visited=3; m_sidebar_user_settings_used=type;gwcc=%7B%22expires%22%3A86400%2C%22backoff_expires%22%3A1534869246%7D;im-visitor-ip=23.17.106.204");
                string postData = string.Format(@"action=im_ajax_call&perform=get_results&order=t3j5n5&orderby=distance&page={0}&_nonce=fb607d6b7586e676a3010da691f417b7&_post_id={1}&_referer=/used-vehicles/", index, "5");



                webreq.ContentLength = postData.Length;
                using (Stream writeStream = webreq.GetRequestStream())
                {
                    UTF8Encoding encoding = new UTF8Encoding();
                    byte[] bytes = encoding.GetBytes(postData);
                    writeStream.Write(bytes, 0, bytes.Length);
                }

                string outputstring = string.Empty;
                using (HttpWebResponse response = (HttpWebResponse)webreq.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader readStream = new
                        StreamReader(responseStream, Encoding.UTF8))
                        {
                            outputstring = readStream.ReadToEnd();
                        }
                    }

                }
                HtmlDocument document = new HtmlDocument();

                document.LoadHtml(outputstring);
                var cars = document.DocumentNode.SelectNodes(".//div[contains(@class,'vehicle-title')]");
                foreach (var car in cars)
                {
                    var carDetail = car.SelectSingleNode(".//a");
                    var url = carDetail.GetAttributeValue("href", "").Replace("\\\"","").Replace("/","");
                    if (!urls.Contains(url)) urls.Add(url);
                }

            }

            Console.ReadKey();
        }
    }
}
