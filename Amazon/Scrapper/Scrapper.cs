using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using HtmlAgilityPack;
using Scrapping.AllPossibilities;
using Scrapping.AllPossibilities.Enums;
using Scrapping.AllPossibilities.Http;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;

namespace Scrapper
{
    public class Scrapper
    {
        private const string LinkAmazon = "https://www.amazon.com/dp/B08FC5L3RG/?coliid=IMO2X4ZPUWGCZ&colid=3AR9V4F4V52IQ&psc=0&ref_=lv_ov_lig_dp_it";
        //private const string Link = "https://www.amazon.com/DualSense-Wireless-Controller-PlayStation-5/dp/B08FC6C75Y/ref=pd_sbs_63_1/137-9654958-0379925?_encoding=UTF8&pd_rd_i=B08FC6C75Y&pd_rd_r=395463fa-9d1d-4628-ad0f-e521e80aed2e&pd_rd_w=QlyDq&pd_rd_wg=ewofj&pf_rd_p=965b754e-4670-4322-863d-d4929773ec49&pf_rd_r=79ZMM22B2Q7CFZGEQ6HW&psc=1&refRID=79ZMM22B2Q7CFZGEQ6HW";
        private readonly Timer _timer = new Timer(TimeSpan.FromMinutes(10).TotalMilliseconds);
        private readonly EmailHelper _emailHelper = new EmailHelper();
        public Scrapper()
        {
            _timer.Elapsed += async (sender, args) => { await ParseAmazon(); };
            _timer.Start();
            ParseAmazon().GetAwaiter().GetResult();
        }

       
        public async Task ParseAmazon()
        {
            try
            {
                var helper = new RequestHelper();
                var data = await helper.SendRequestAsync(LinkAmazon, headers: HeaderBuilder.GetDefaultHeaders(), automaticDecompression: true);

                if (!data.Contains("Currently unavailable"))
                {
                    var document = new HtmlDocument();
                    document.LoadHtml(data);
                    var text = HtmlDocumentHelper.GetNodeByParams(document.DocumentNode, HtmlTag.div, HtmlAttribute.id, "centerCol").InnerText.Replace("\n", " ");
                    _emailHelper.SendEmail(text);
                }
                else
                {
                    File.AppendAllText(@"D:\playstationLog.log", $"{DateTime.Now}: Not available in Amazon{Environment.NewLine}");
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(@"D:\playstationLog.log", $"{DateTime.Now}: {e}{Environment.NewLine}");
            }
        }
    }
}
