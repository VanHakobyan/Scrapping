using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameValueNow
{
    public class GameValueNowModel
    {
        public string PlatformName { get; set; }
        public string AvgLoosePrice { get; set; }
        public string AvgCompletePrice { get; set; }
        public string LooseSetValue { get; set; }
        public string CompleteSetValue { get; set; }
        public string SharpOfGames { get; set; }
        public string URL { get; set; }
        public List<Data> Data { get; set; }
    }
    public class Data
    {
        public string Id { get; set; }
        public string PlatformName { get; set; }
        public string Title { get; set; }
        public string Loose { get; set; }
        public string Complete { get; set; }
        public string New { get; set; }
        public string Graded { get; set; }
    }
}
