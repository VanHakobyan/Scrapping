using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameValueNow
{
  //  [Table("GameValueNow")]
    public class GameValueNowModel
    {
        //  [Key]
        public string SourceCode { get; set; } = "GameValueNow";
        public string PlatformName { get; set; }
        public string AvgLoosePrice { get; set; }
        public string AvgCompletePrice { get; set; }
        public string LooseSetValue { get; set; }
        public string CompleteSetValue { get; set; }
        public string SharpOfGames { get; set; }
        public string URL { get; set; }
        public virtual List<Data> Data { get; set; }
    }
   // [Table("GameData")]
    public class Data
    {
        public string Id { get; set; }
        public string PlatformName { get; set; }
        public string Title { get; set; }
        public string Loose { get; set; }
        public string Complete { get; set; }
        public string New { get; set; }
        public string Graded { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public string Rating { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public string PlayerCount { get; set; }
        public string UPC { get; set; }
        public string Amazon_ASIN { get; set; }
        public string Ebay_ePID { get; set; }
        public string PriceChartingId { get; set; }
    }
}
