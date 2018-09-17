using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium.PhantomJS;
using ScrappingHelpers.Models;

namespace ScrappingHelpers
{
    public class Scrapping
    {
        private const string NbaUrl = "https://stats.nba.com/stats/leaguedashteamstats?Conference=&DateFrom=&DateTo=&Division=&GameScope=&GameSegment=&LastNGames=0&LeagueID=00&Location=&MeasureType=Advanced&Month=0&OpponentTeamID=0&Outcome=&PORound=0&PaceAdjust=N&PerMode=PerGame&Period=0&PlayerExperience=&PlayerPosition=&PlusMinus=N&Rank=N&Season=2017-18&SeasonSegment=&SeasonType=Regular+Season&ShotClockRange=&StarterBench=&TeamID=0&VsConference=&VsDivision=";
        private const string CleaningtheglassUrl = "https://www.cleaningtheglass.com/stats/league/fourfactors";
        private const string BasketballUrl = "https://www.basketball-reference.com/leagues/NBA_2018.html#misc_stats::none";
        private PhantomJSDriver _driver;

        public Resultset[] GetNba()
        {
            try
            {
                //ChromeOptions options = new ChromeOptions();
                //options.AddArguments("no-sandbox");
                //var phantomJsOptions = new PhantomJSOptions();
                _driver = new PhantomJSDriver();

                _driver.Navigate().GoToUrl(@"https://stats.nba.com/");
                var cookieJar = _driver.Manage().Cookies;
                WebClient client = new WebClient();
                client.Headers.Add(HttpRequestHeader.UserAgent,
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
                client.Headers.Add(HttpRequestHeader.Host, "stats.nba.com");
                client.Headers.Add(HttpRequestHeader.Accept,
                    "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                client.Headers.Add(HttpRequestHeader.Cookie,
                    $"_ga=GA1.2.1855738158.1537100658; ug=5b9e4b730bd1460a3f80c50015230761; check=true; s_cc=true; s_fid=4752F97492A5DF30-0E44F252D0FE76FD; s_sq=%5B%5BB%5D%5D; __gads=ID=251ef1f700689668:T=1537100661:S=ALNI_MYxIJY-B0G9Xm2lbqMAWUczGqVCyw; s_vi=[CS]v1|2DCF25BB05031EBB-60001198C001333C[CE]; _gid=GA1.2.2014030341.1537215695; ugs=1; ak_bmsc=75561C64DE8794A73A9348785F53F9EB0214846557690000D40CA05B3F216365~plY8nzTM5OusXgMfVU1kHZpM3EST1C/E0o74yCdwSULkDXMD/I31FIwAq6bmgCH5rWWrwXzqms6jw2irrNCe+bJdyDOdv0+wZuLa3vfMsz1lauBt73IfDM3911Ljvs9BYNyDBmJaZZPA336BBmQbwblZgL8dqxS+HfYxIpfYMZtj3QUbf+//ej7ygYydXsHMYwIPhHpqEZJfl+WcTFpvd8L+48ddYVOId3eeRHm0WTaSc=; bm_sv=7A4DFBD7B1B77AA2608375F7F0D9EDA4~Tm4k8X9IefkaUzojmgOtXUXszEDq+nwHMZnTbwckANlLE0sEq1OBCLNaEsRlT7IG7vN/GZXrhToR9Dh79oP9ixdkDnXzfHUlgcBsRk7mUIrUA9oI0Cqmwjitu6UOzUbjsPAQJRbZHmGNxNuaJG1nxw==; _gat=1; {cookieJar.GetCookieNamed("mbox")}");
                var jsonData = client.DownloadString(NbaUrl);

                //_driver.Navigate().GoToUrl(NbaUrl);
                //var jsonData = _driver.PageSource;
                var nbaModel = JsonConvert.DeserializeObject<NbaModel>(jsonData
                    .Replace(
                        "<html xmlns=\"http://www.w3.org/1999/xhtml\"><head></head><body><pre style=\"word-wrap: break-word; white-space: pre-wrap;\">",
                        "").Replace("</pre></body></html>", ""));
                return nbaModel.resultSets;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
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
