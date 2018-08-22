using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Rivercityhyundai
{
    class Program
    {
        private static string link =
            @"https://www.rivercityhyundai.com/used-vehicles/#action=im_ajax_call&perform=get_results";
        static void Main(string[] args)
        {
            var urls = new List<string>();
            for (int i = 1; i < 7; i++)
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
                @"_ga=GA1.2.2006639997.1534915595; _gid=GA1.2.429939189.1534915595; _referrer_og=https%3A%2F%2Fwww.upwork.com%2Fleaving%3Fref%3Dhttps%253A%252F%252Fwww.rivercityhyundai.com%252Fused-vehicles%252F%2523action%253Dim_ajax_call%2526perform%253Dget_results%2526page%253D5; _jsuid=2152719567; no_trackyy_100920250=1; im_sidebar_user_settings_used=type; gwcc=%7B%22fallback%22%3A%228779169589%22%2C%22clabel%22%3A%22bC6uCK_O8GIQ8ePKvQM%22%2C%22backoff%22%3A86400%2C%22backoff_expires%22%3A1535001996%7D; im-visitor-ip=91.103.58.109; _hjIncludedInSample=1; di_roxanne[visit_id]=456367341; di_roxanne[visitor_id]=720992422; diGeolocationIgnoreData={""currentRequestCount"":2,""createdAt"":1534915601244}; di_page_history=a%3A1%3A%7Bi%3A0%3Bs%3A13%3A%22used-vehicles%22%3B%7D; tp_referral=518947; di_referral=%7B%22ppc_terms%22%3Anull%2C%22url%22%3A%22https%3A%5C%2F%5C%2Fwww.upwork.com%5C%2Fleaving%3Fref%3Dhttps%253A%252F%252Fwww.rivercityhyundai.com%252Fused-vehicles%252F%2523action%253Dim_ajax_call%2526perform%253Dget_results%2526page%253D5%22%2C%22type%22%3A%22Referral%22%2C%22createdAt%22%3A%222018-08-22T05%3A26%3A42%2B0000%22%7D; di_visited=2; _gat_UA-61919916-1=1; _eventqueue=%7B%22heatmap%22%3A%5B%7B%22type%22%3A%22heatmap%22%2C%22href%22%3A%22%2Fused-vehicles%2F%22%2C%22x%22%3A65%2C%22y%22%3A415%2C%22w%22%3A150%7D%5D%2C%22events%22%3A%5B%7B%22type%22%3A%22click%22%2C%22href%22%3A%22%2F%3F%23action%3Dim_ajax_call%26perform%3Dget_results%26page%3D2%22%2C%22title%22%3A%22%22%7D%5D%7D");
                string postData = string.Format(@"action=im_ajax_call&perform=get_results&order=t3j5n5&orderby=distance&page={0}&_nonce=dca35247fd7cdf6fe33fd201f6e23d3c&_post_id={1}&_referer=/used-vehicles/", index, "5");
                string postDataFirst = string.Format(@"action=im_ajax_call&perform=get_results&order=t3j5n5&orderby=distance&_nonce=dca35247fd7cdf6fe33fd201f6e23d3c&_post_id={0}&_referer=/used-vehicles/","5");

             


                if(i==1) webreq.ContentLength = postDataFirst.Length; 
                else webreq.ContentLength = postData.Length;
                using (Stream writeStream = webreq.GetRequestStream())
                {
                    UTF8Encoding encoding = new UTF8Encoding();
                    if (i==1)
                    {
                        byte[] bytes = encoding.GetBytes(postDataFirst);
                        writeStream.Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        byte[] bytes = encoding.GetBytes(postData);
                        writeStream.Write(bytes, 0, bytes.Length); 
                    }
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
                    var url = carDetail.GetAttributeValue("href", "").Replace("\\\"", "").Replace("/", "");
                    if (!urls.Contains(url)) urls.Add(url);
                }

            }

            Console.ReadKey();
        }
    }
}
