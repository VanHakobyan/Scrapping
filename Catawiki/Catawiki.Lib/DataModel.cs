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
}
