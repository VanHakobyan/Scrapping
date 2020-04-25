using System;
using System.Collections.Generic;


namespace PriceCharting
{
    public class PriceChartingModel
    {
        public string CategoryName { get; set; }
        public string Region { get; set; }
        public string URL { get; set; }
        public virtual List<Data> Data { get; set; }
    }
    public class Data
    {
        public string Title { get; set; }
        public string LoosePrice { get; set; }
        public string CIBPrice { get; set; }
        public string NewPrice { get; set; }

    }
}
