using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catawiki.Lib
{
    public class DataModel
    {
        public string Name { get; set; }
        public decimal CurrentBidAmount { get; set; }
        public string CurrentBid { get; set; }
        public DateTime BiddingEndTime { get; set; }
        public string Url { get; set; }
    }
    public class Currency
    {
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
        public decimal EUR { get; set; }
    }
    public class JsonResult
    {
        [JsonProperty("lots")]
        public List<DataModelJSON> Lots { get; set;  }
    }
    public class DataModelJSON
    {
        public Currency current_bid_amount { get; set; }
        public int id { get; set; }
        public DateTime bidding_end_time { get; set; }
    }
}
