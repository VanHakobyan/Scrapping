using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCharting
{
    [Table("PriceCharting")]
    public class PriceChartingModel
    {
        [Key, Column(Order = 0)]
        public string CategoryName { get; set; }
        [Key, Column(Order = 1)]
        public string Region { get; set; }
        public string URL { get; set; }
        public virtual List<Data> Data { get; set; }
    }
    [Table("PriceChartingData")]
    public class Data
    {
        [Key]
        public string IndexId { get; set; } //delete
        public string CategoryName { get; set; }
        public string Region { get; set; }
        public string Title { get; set; }
        public string LoosePrice { get; set; }
        public string CIBPrice { get; set; }
        public string NewPrice { get; set; }

    }
}
