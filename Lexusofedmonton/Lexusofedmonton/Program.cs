using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Lexusofedmonton
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var urls = new List<string>();

            for (int i = 1; i < 9; i++)
            {
                string link =$@"https://www.lexusofedmonton.ca/used-vehicles/#action=im_ajax_call&perform=get_results&page=5&type%5B%5D=Used&type%5B%5D=Certified+Used";
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://example.com/");
                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.TryAddWithoutValidation("Cookie", "_ga=GA1.2.1177969263.1534788610; _gid=GA1.2.2007031624.1534788610; im_sidebar_user_settings_used=type; im-visitor-ip=82.199.221.176; gwcc=%7B%22fallback%22%3A%227804668300%22%2C%22clabel%22%3A%22t-CLCLL36XkQsfLaigM%22%2C%22backoff%22%3A86400%2C%22backoff_expires%22%3A1534875012%7D; _referrer_og=https%3A%2F%2Fwww.upwork.com%2Fleaving%3Fref%3Dhttps%253A%252F%252Fwww.lexusofedmonton.ca%252Fused-vehicles%252F%2523action%253Dim_ajax_call%2526perform%253Dget_results%2526page%253D1%2526type%25255B%25255D%253DUsed%2526type%25255B%25255D%253DCertified%252BUsed; _jsuid=1719558711; di_roxanne[visit_id]=453379279; di_roxanne[visitor_id]=718765392; forty_n_user=AdtdiU80-T1XZuTZv8vvGQ~~; tp_referral=1541838; di_referral=%7B%22ppc_terms%22%3Anull%2C%22url%22%3A%22https%3A%5C%2F%5C%2Fwww.upwork.com%5C%2Fleaving%3Fref%3Dhttps%253A%252F%252Fwww.lexusofedmonton.ca%252Fused-vehicles%252F%2523action%253Dim_ajax_call%2526perform%253Dget_results%2526page%253D1%2526type%25255B%25255D%253DUsed%2526type%25255B%25255D%253DCertified%252BUsed%22%2C%22type%22%3A%22Referral%22%2C%22createdAt%22%3A%222018-08-20T18%3A10%3A20%2B0000%22%7D; di_page_history=a%3A1%3A%7Bi%3A0%3Bs%3A13%3A%22used-vehicles%22%3B%7D; diGeolocationIgnoreData={\"currentRequestCount\":2,\"createdAt\":1534788626820}; _hjIncludedInSample=1; di_inv_bc_www.lexusofedmonton.ca=/used-vehicles/%23action%3Dim_ajax_call%26perform%3Dget_results%26page%3D7%26type%255B%255D%3DUsed%26type%255B%255D%3DCertified+Used; di_vehicle_history=a%3A3%3A%7Bs%3A5%3A%22makes%22%3Ba%3A1%3A%7Bi%3A0%3Bs%3A5%3A%22Lexus%22%3B%7Ds%3A6%3A%22models%22%3Ba%3A3%3A%7Bi%3A0%3Bs%3A6%3A%22GX+460%22%3Bi%3A1%3Bs%3A6%3A%22RX+350%22%3Bi%3A2%3Bs%3A6%3A%22ES+350%22%3B%7Ds%3A4%3A%22vins%22%3Ba%3A3%3A%7Bi%3A0%3Bs%3A17%3A%22JTJJM7FX9J5188010%22%3Bi%3A1%3Bs%3A17%3A%22JTJHK31U492055761%22%3Bi%3A2%3Bs%3A17%3A%2258ABK1GG5HU054043%22%3B%7D%7D; forty_n_t=1.423e97.1534788615.4.1.1534797789.1534797789.4.0; di_visited=16; _eventqueue=%7B%22heatmap%22%3A%5B%7B%22type%22%3A%22heatmap%22%2C%22href%22%3A%22%2Fused-vehicles%2F%22%2C%22x%22%3A330%2C%22y%22%3A417%2C%22w%22%3A779%7D%5D%2C%22events%22%3A%5B%7B%22type%22%3A%22click%22%2C%22href%22%3A%22%2F%3F%23action%3Dim_ajax_call%26perform%3Dget_results%26page%3D5%26type%255B%255D%3DUsed%26type%255B%255D%3DCertified%2BUsed%22%2C%22title%22%3A%22%22%7D%5D%7D");
                //link=link.Replace("{page}", i.ToString());
                var json = "{\"action\":\"im_ajax_call\",\"perform\":\"get_results\",\"page\":5,\"type\":[\"Used\",\"Certified Used\"],\"_nonce\":\"cff7592a44937c676fb5540b544b3456\",\"_referer\":\"/used-vehicles/\",\"_post_id\":5,}";
                var jsonC = json.Replace("{page}", i.ToString());
                var Content = new StringContent(jsonC, Encoding.UTF8, "application/json");
                var postAsync = client.PostAsync(link, Content).Result;

                var result = postAsync.Content.ReadAsStringAsync().Result;
                //client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");


                //client.Headers.Add(HttpRequestHeader.Cookie, s1);
                //client.Headers.Add(HttpRequestHeader.Cookie, s2);
                HtmlDocument document = new HtmlDocument();

                document.LoadHtml(result);
                var cars = document.DocumentNode.SelectNodes(".//div[@class='vehicle-title clearfix']");
                foreach (var car in cars)
                {
                    var carDetail = car.SelectSingleNode(".//a");
                    var url = carDetail.GetAttributeValue("href", "");
                    if (!urls.Contains(url)) urls.Add(url);
                }
            }

            //File.WriteAllLines(@"E:\urls.txt",urls);
        }
    }
}
