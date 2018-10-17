using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using ScrappingHelpers.Models;

namespace ScrappingHelpers
{
    public class Scrapping
    {
        private const string NbaUrl = "https://stats.nba.com/stats/leaguedashteamstats?Conference=&DateFrom=&DateTo=&Division=&GameScope=&GameSegment=&LastNGames=0&LeagueID=00&Location=&MeasureType=Advanced&Month=0&OpponentTeamID=0&Outcome=&PORound=0&PaceAdjust=N&PerMode=PerGame&Period=0&PlayerExperience=&PlayerPosition=&PlusMinus=N&Rank=N&Season=2018-19&SeasonSegment=&SeasonType=Regular+Season&ShotClockRange=&StarterBench=&TeamID=0&VsConference=&VsDivision=";
        private const string CleaningtheglassUrl = "https://www.cleaningtheglass.com/stats/league/fourfactors";
        private const string BasketballUrl = "https://www.basketball-reference.com/leagues/NBA_2019.html#misc_stats::none";
        private PhantomJSDriver _driver;
        private ChromeDriver _chromeDriver;

        public List<NBAFactory> GetNba()
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                //options.AddArguments("no-sandbox");
                //options.AddArguments("--headless");
                _chromeDriver = new ChromeDriver(options);
                _chromeDriver.Navigate().GoToUrl(NbaUrl);


                //WebClient client = new WebClient();
                //client.Headers.Add(HttpRequestHeader.UserAgent,
                //    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
                //client.Headers.Add(HttpRequestHeader.Host, "stats.nba.com");
                //client.Headers.Add(HttpRequestHeader.Accept,
                //    "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                //client.Headers.Add(HttpRequestHeader.Cookie,
                //$"{cookieJar.GetCookieNamed("_ga")}; {cookieJar.GetCookieNamed("ug")} ;check=true; s_cc=true; s_fid=4752F97492A5DF30-0E44F252D0FE76FD;{cookieJar.GetCookieNamed("s_sq")}__gads=ID=251ef1f700689668:T=1537100661:S=ALNI_MYxIJY-B0G9Xm2lbqMAWUczGqVCyw; s_vi=[CS]v1|2DCF25BB05031EBB-60001198C001333C[CE]; {cookieJar.GetCookieNamed("_gid")}; ugs=1; ads=ID=4fd23ebe8f320268:T=1537189166:S=ALNI_MY53ngmtln7hli682R46WOv-irTrQ; s_vi=[CS]v1|2DCFD29785030596-40001198C0001155[CE]; _gat=1; _gat=1; {cookieJar.GetCookieNamed("mbox")}");
                //client.Headers.Add(HttpRequestHeader.Cookie, $"_ga=GA1.2.1476500595.1537189165; _gid=GA1.2.7857329hnfhfg21.1537189165; ug=5b9fa52d059ee60a3f984b00125c21f1; ugs=1; check=true; s_cc=true; s_fid=24650818396EAA92-09886E3EE71714BE; s_sq=%5B%5BB%5D%5D; __gads=ID=4fd23ebe8f320268:T=1537189166:S=ALNI_MY53ngmtln7hli682R46WOv-irTrQ; s_vi=[CS]v1|2DCFD29785030596-40001198C0001155[CE];ak_bmsc=ED989E0150A303EA8EB5D6B8E21451BD173ADF4C8B6F00003FC2A05B6AB3DE25~plbjQbnWsmd3Sk14Xx9ctymCQi7I3qIzf4uM+7/pJtm4nw6Ozgzfgz1pkwnfnnEtfq67amcZsVIp68UaGBZr9eSkRaIspocIQhskXhIGHrPdOnc7KMSvrMik6gBWQRBYBFoiy7sj9TU4CZZ0OnGJu9zpRLSHJd2Oc207ze0pRCLz+udjLGED7lUKZualn9l5copOsG/nCUFYOpAQFPH8Mm7OtZXWSxu69cdeb3AYfJLaI=; _gat=1;mbox=PC#9dfe128d64994a678f941302f459d68e.26_2#1600499329|session#b2743753531642b286afad0bb5ca2742#1537256389");
                //client.Headers.Add(HttpRequestHeader.Cookie,$"_ga=GA1.2.1476500595.1537189165; _gid=GA1.2.785732921.1537189165; ug=5b9fa52d059ee60a3f984b00125c21f1; ugs=1; check=true; s_cc=true; s_fid=24650818396EAA92-09886E3EE71714BE; s_sq=%5B%5BB%5D%5D; __gads=ID=4fd23ebe8f320268:T=1537189166:S=ALNI_MY53ngmtln7hli682R46WOv-irTrQ; s_vi=[CS]v1|2DCFD29785030596-40001198C0001155[CE]; mbox=PC#9dfe128d64994a678f941302f459d68e.26_2#1600499329|session#b2743753531642b286afad0bb5ca2742#1537256389; ak_bmsc=ED989E0150A303EA8EB5D6B8E21451BD173ADF4C8B6F00003FC2A05B6AB3DE25~plbjQbnWsmd3Sk14Xx9ctymCQi7I3qIzf4uM+7/pJtm4nw6Ozgzfgz1pkwnfnnEtfq67amcZsVIp68UaGBZr9eSkRaIspocIQhskXhIGHrPdOnc7KMSvrMik6gBWQRBYBFoiy7sj9TU4CZZ0OnGJu9zpRLSHJd2Oc207ze0pRCLz+udjLGED7lUKZualn9l5copOsG/nCUFYOpAQFPH8Mm7OtZXWSxu69cdeb3AYfJLaI=; bm_sv=69B3D72A775B96BE61BFC7ACB02344A1~v/KZyNn0RCydppnc7RhtV1p0+YG8jHyCBxF3pWqJSIQXGoQ3p5JT7mcoqQsviJ2rrTAS3wvEr4XRbw7d+uPBF7Iy3ckIKPSXhBkF8j1QZ5ZWziGhTUns8N/mI45/5GCfggLN2DvKtbGhKRKQGj5i4g==");
                //var jsonData = client.DownloadString("https://stats.nba.com/teams/advanced/?sort=W&dir=-1");

                var jsonData = _chromeDriver.PageSource;
                var nbaModel = JsonConvert.DeserializeObject<NbaModel>(jsonData
                    .Replace(
                        "<html xmlns=\"http://www.w3.org/1999/xhtml\"><head></head><body><pre style=\"word-wrap: break-word; white-space: pre-wrap;\">",
                        "").Replace("</pre></body></html>", ""));
                var nbas=new List<NBAFactory>();
                for (int i = 0; i < nbaModel.resultSets[0].rowSet.Length; i++)
                {
                    var k = 0;
                    var nba=new NBAFactory
                    {
                        TEAM_ID = nbaModel.resultSets[0].rowSet[i][k++],
                        TEAM_NAME      =nbaModel.resultSets[0].rowSet[i][k++],
                        GP             =nbaModel.resultSets[0].rowSet[i][k++],
                        W              =nbaModel.resultSets[0].rowSet[i][k++],
                        L              =nbaModel.resultSets[0].rowSet[i][k++],
                        W_PCT          =nbaModel.resultSets[0].rowSet[i][k++],
                        MIN            =nbaModel.resultSets[0].rowSet[i][k++],
                        OFF_RATING     =nbaModel.resultSets[0].rowSet[i][k++],
                        DEF_RATING     =nbaModel.resultSets[0].rowSet[i][k++],
                        NET_RATING     =nbaModel.resultSets[0].rowSet[i][k++],
                        AST_PCT        =nbaModel.resultSets[0].rowSet[i][k++],
                        AST_TO         =nbaModel.resultSets[0].rowSet[i][k++],
                        AST_RATIO      =nbaModel.resultSets[0].rowSet[i][k++],
                        OREB_PCT       =nbaModel.resultSets[0].rowSet[i][k++],
                        DREB_PCT       =nbaModel.resultSets[0].rowSet[i][k++],
                        REB_PCT        =nbaModel.resultSets[0].rowSet[i][k++],
                        TM_TOV_PCT     =nbaModel.resultSets[0].rowSet[i][k++],
                        EFG_PCT        =nbaModel.resultSets[0].rowSet[i][k++],
                        TS_PCT         =nbaModel.resultSets[0].rowSet[i][k++],
                        PACE           =nbaModel.resultSets[0].rowSet[i][k++],
                        PIE            =nbaModel.resultSets[0].rowSet[i][k++],
                        GP_RANK        =nbaModel.resultSets[0].rowSet[i][k++],
                        W_RANK         =nbaModel.resultSets[0].rowSet[i][k++],
                        L_RANK         =nbaModel.resultSets[0].rowSet[i][k++],
                        W_PCT_RANK     =nbaModel.resultSets[0].rowSet[i][k++],
                        MIN_RANK       =nbaModel.resultSets[0].rowSet[i][k++],
                        OFF_RATING_RANK=nbaModel.resultSets[0].rowSet[i][k++],
                        DEF_RATING_RANK=nbaModel.resultSets[0].rowSet[i][k++],
                        NET_RATING_RANK=nbaModel.resultSets[0].rowSet[i][k++],
                        AST_PCT_RANK   =nbaModel.resultSets[0].rowSet[i][k++],
                        AST_TO_RANK    =nbaModel.resultSets[0].rowSet[i][k++],
                        AST_RATIO_RANK =nbaModel.resultSets[0].rowSet[i][k++],
                        OREB_PCT_RANK  =nbaModel.resultSets[0].rowSet[i][k++],
                        DREB_PCT_RANK  =nbaModel.resultSets[0].rowSet[i][k++],
                        REB_PCT_RANK   =nbaModel.resultSets[0].rowSet[i][k++],
                        TM_TOV_PCT_RANK=nbaModel.resultSets[0].rowSet[i][k++],
                        EFG_PCT_RANK   =nbaModel.resultSets[0].rowSet[i][k++],
                        TS_PCT_RANK    =nbaModel.resultSets[0].rowSet[i][k++],
                        PACE_RANK      =nbaModel.resultSets[0].rowSet[i][k++],
                        PIE_RANK       =nbaModel.resultSets[0].rowSet[i][k++],
                        CFID           =nbaModel.resultSets[0].rowSet[i][k++],
                        CFPARAMS       =nbaModel.resultSets[0].rowSet[i][k]
                    };
                   nbas.Add(nba);
                }
                return nbas;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                _chromeDriver?.Close();
                _chromeDriver?.Quit();
                _driver?.Quit();
            }
        }

        public async Task<List<Cleaningtheglass>> GetCleaningtheglass()
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
            var htmlData = await client.DownloadStringTaskAsync(CleaningtheglassUrl);
            var document = new HtmlDocument();
            document.LoadHtml(htmlData);
            var tabele = document.DocumentNode.SelectSingleNode(".//div[@class='stat_table_container']");
            var rows = tabele.SelectSingleNode(".//tbody").SelectNodes(".//tr");
            var cleaningthegs = new List<Cleaningtheglass>();
            foreach (var row in rows)
            {
                var col = row.InnerText.Split(new[] { "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
                var item = new Cleaningtheglass
                {
                    Team = col[0],
                    Diff_rank = col[1],
                    Diff_value = col[2],
                    ExpW82 = col[3],
                    ExpW = col[4],
                    Win = col[5],
                    WinDiff = col[6],
                    W = col[7],
                    L = col[8],
                    Offense_Pts_Poss_rank = col[9],
                    Offense_Pts_Poss_value = col[10],
                    Offense_eFGProcent_rank = col[11],
                    Offense_eFGProcent_value = col[12],
                    Offense_TovProcent_rank = col[13],
                    Offense_TovProcent_value = col[14],
                    Offense_ORBProcent_rank = col[15],
                    Offense_ORBProcent_value = col[16],
                    Offense_FTRate_rank = col[17],
                    Offense_FTRate_value = col[18],
                    Defense_Pts_Poss_rank = col[19],
                    Defense_Pts_Poss_value = col[20],
                    Defense_eFGProcent_rank = col[21],
                    Defense_eFGProcent_value = col[22],
                    Defense_TovProcent_rank = col[23],
                    Defense_TovProcent_value = col[24],
                    Defense_ORBProcent_rank = col[25],
                    Defense_ORBProcent_value = col[26],
                    Defense_FTRate_rank = col[27],
                    Defense_FTRate_value = col[28]
                };
                cleaningthegs.Add(item);
            }

            return cleaningthegs;
        }



        public async Task<List<Basketball>> GetBasketball()
        {
            var document = new HtmlDocument();
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
            var htmlData = await client.DownloadStringTaskAsync(BasketballUrl);
            document.LoadHtml(htmlData);
            var table = document.DocumentNode.SelectSingleNode(".//div[@id='all_misc_stats']");
            var tableWithComments = table.OuterHtml;
            var tableUncommented = tableWithComments.Replace("<!--", "").Replace("-->", "");
            var document1 = new HtmlDocument();
            document1.LoadHtml(tableUncommented);

            var rows = document1.DocumentNode.SelectSingleNode(".//tbody").SelectNodes(".//tr");
            var basketballs = new List<Basketball>();
            foreach (var row in rows)
            {
                var items = row.ChildNodes;
                var bass = new Basketball
                {
                    Rk = items[0].InnerText,
                    Team = items[1].InnerText,
                    Age = items[2].InnerText,
                    Wins = items[3].InnerText,
                    Losses = items[4].InnerText,
                    WinsPyth = items[5].InnerText,
                    LossesPyth = items[6].InnerText,
                    MOV = items[7].InnerText,
                    SOS = items[8].InnerText,
                    SRS = items[9].InnerText,
                    OffRtg = items[10].InnerText,
                    DefRtg = items[11].InnerText,
                    Pace = items[12].InnerText,
                    Fta_per_fga_pct = items[13].InnerText,
                    Fg3a_per_fga_pct = items[14].InnerText,
                    TSProcent = items[15].InnerText,
                    EfgPrc = items[16].InnerText,
                    TOVProcent = items[17].InnerText,
                    ORBProcent = items[18].InnerText,
                    FTRate = items[19].InnerText,
                    Opp_efg_pct = items[20].InnerText,
                    Opp_tov_pct = items[21].InnerText,
                    DRBProcent = items[22].InnerText,
                    Opp_ft_rate = items[23].InnerText,
                    Arena = items[24].InnerText,
                    Attend = items[25].InnerText,
                    Attendance_Per = items[26].InnerText,
                };
                basketballs.Add(bass);
            }
            return basketballs;
        }
    }
}
