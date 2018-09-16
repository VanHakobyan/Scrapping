using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrappingHelpers.Models
{

    public class NbaModel
    {
        public string resource { get; set; }
        public Parameters parameters { get; set; }
        public Resultset[] resultSets { get; set; }
    }

    public class Parameters
    {
        public string MeasureType { get; set; }
        public string PerMode { get; set; }
        public string PlusMinus { get; set; }
        public string PaceAdjust { get; set; }
        public string Rank { get; set; }
        public string LeagueID { get; set; }
        public string Season { get; set; }
        public string SeasonType { get; set; }
        public int PORound { get; set; }
        public object Outcome { get; set; }
        public object Location { get; set; }
        public int Month { get; set; }
        public object SeasonSegment { get; set; }
        public object DateFrom { get; set; }
        public object DateTo { get; set; }
        public int OpponentTeamID { get; set; }
        public object VsConference { get; set; }
        public object VsDivision { get; set; }
        public int TeamID { get; set; }
        public object Conference { get; set; }
        public object Division { get; set; }
        public object GameSegment { get; set; }
        public int Period { get; set; }
        public object ShotClockRange { get; set; }
        public int LastNGames { get; set; }
        public object GameScope { get; set; }
        public object PlayerExperience { get; set; }
        public object PlayerPosition { get; set; }
        public object StarterBench { get; set; }
    }

    public class Resultset
    {
        public string name { get; set; }
        public string[] headers { get; set; }
        public object[][] rowSet { get; set; }
    }

}
