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
        [JsonProperty("current_bid_amount")]
        public decimal CurrentBidAmount { get; set; }
        [JsonProperty("id")]
        public string CurrentBid { get; set; }
        [JsonProperty("bidding_end_time")]
        public DateTime BiddingEndTime { get; set; }
        public string Url { get; set; }
    }
    public class JsonResult
    {
        [JsonProperty("lots")]
        public List<DataModel> Lots { get; set;  }
    }
}
