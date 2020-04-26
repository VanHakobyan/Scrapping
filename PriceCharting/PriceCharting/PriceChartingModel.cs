using System;
using System.Collections.Generic;


namespace PriceCharting
{
    public class PriceChartingModel
    {
        public string SourceCode { get; set; } = "PriceCharting";
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

    public class Response
    {
        public string cursor { get; set; }
        public Product[] products { get; set; }
    }

    public class Product
    {
        public string consoleUri { get; set; }
        public bool hasProduct { get; set; }
        public string id { get; set; }
        public bool isGameCategory { get; set; }
        public string price1 { get; set; }
        public string price2 { get; set; }
        public string price3 { get; set; }
        public string productName { get; set; }
        public string productUri { get; set; }
        public bool wishlistHasProduct { get; set; }
    }

}
