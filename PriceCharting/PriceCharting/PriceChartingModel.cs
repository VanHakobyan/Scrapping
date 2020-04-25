using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCharting
{
    [Table("PriceCharting")]
    public class PriceChartingModel
    {
        public string CategoryName { get; set; }
        public string Region { get; set; }
        public string URL { get; set; }
        public virtual List<Data> Data { get; set; }
    }
    [Table("PriceChartingData")]
    public class Data
    {
        public string CategoryName { get; set; }
        public string Region { get; set; }
        public string Title { get; set; }
        public string LoosePrice { get; set; }
        public string CIBPrice { get; set; }
        public string NewPrice { get; set; }

    }
}
