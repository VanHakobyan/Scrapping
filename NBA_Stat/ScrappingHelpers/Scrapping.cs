﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using ScrappingHelpers.Models;

namespace ScrappingHelpers
{
    public class Scrapping
    {
        private const string NbaUrl = "https://stats.nba.com/stats/leaguedashteamstats?Conference=&DateFrom=&DateTo=&Division=&GameScope=&GameSegment=&LastNGames=0&LeagueID=00&Location=&MeasureType=Advanced&Month=0&OpponentTeamID=0&Outcome=&PORound=0&PaceAdjust=N&PerMode=PerGame&Period=0&PlayerExperience=&PlayerPosition=&PlusMinus=N&Rank=N&Season=2017-18&SeasonSegment=&SeasonType=Regular+Season&ShotClockRange=&StarterBench=&TeamID=0&VsConference=&VsDivision=";
        private const string CleaningtheglassUrl = "https://www.cleaningtheglass.com/stats/league/fourfactors";
        private const string BasketballUrl = "https://www.basketball-reference.com/leagues/NBA_2018.html#misc_stats::none";

        public async Task<Resultset[]> GetNba()
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
            client.Headers.Add(HttpRequestHeader.Host, "stats.nba.com");
            client.Headers.Add(HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            client.Headers.Add(HttpRequestHeader.Cookie, "_ga=GA1.2.1855738158.1537100658; _gid=GA1.2.248724008.1537100658; ug=5b9e4b730bd1460a3f80c50015230761; ugs=1; check=true; s_cc=true; s_fid=4752F97492A5DF30-0E44F252D0FE76FD; s_sq=%5B%5BB%5D%5D; __gads=ID=251ef1f700689668:T=1537100661:S=ALNI_MYxIJY-B0G9Xm2lbqMAWUczGqVCyw; ak_bmsc=D992A79A1236A2C002530A8AEF4702CB0214846557690000764B9E5B68B81252~plux/4jmBFz/IezUWPaL4CAUerWwfzW266GjUO1dqKwEI2fXyGKiz+eXyRrUSkoCFQk1eHUNBvPyaxe+p7RC41H+J+ihLAYIIgBpixFplwMjpV2+rKSPgy3rg2PgX2Wlr5YdgBdzVc26720X/ijmOA9BuDS/g5Xyrj2fz+5VLBnlUYDfnZpFEAAE1gL0y2T5JP4I6xPuz0A5h5KBlAO5HzvKLUCl7ETbyETBo5iMpgELI=; s_vi=[CS]v1|2DCF25BB05031EBB-60001198C001333C[CE]; mbox=session#89613fc50ee6400cbdf16e3193331ada#1537102657|PC#89613fc50ee6400cbdf16e3193331ada.26_2#1600345461; bm_sv=C3220D3B876459291AA6DCCAC414413C~Tm4k8X9IefkaUzojmgOtXe/ZVmTN8022RNTGWpLojYviRGJRof1ruxxi421t9bSCKPIcTgZKNJva4GG6FuheASIqfqw9YUkFb8QAkMXmseF+qNEz/O8YHtxEBSl9Z5zMzokQiMXicm9+ogk3yqnMUQ==");
            //var jsonData = await client.DownloadStringTaskAsync(NbaUrl);
            var jsonData = await client.DownloadStringTaskAsync(NbaUrl);
            var nbaModel = JsonConvert.DeserializeObject<NbaModel>(jsonData);
            return nbaModel.resultSets;
        }

        public async Task<Resultset[]> GetCleaningtheglass()
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
            var htmlData = await client.DownloadStringTaskAsync(CleaningtheglassUrl);
            var document = new HtmlDocument();
            document.LoadHtml(htmlData);
            var tabele = document.DocumentNode.SelectSingleNode(".//div[@class='stat_table_container']");
            var rows = tabele.SelectSingleNode(".//tbody").SelectNodes(".//tr");
            var cleaningthegs=new List<Cleaningtheglass>();
            foreach (var row in rows)
            {
                var col = row.InnerText.Split(new []{"\n"," "},StringSplitOptions.RemoveEmptyEntries);
                var item =new Cleaningtheglass
                {
                   //todo:implemet items
                };
                cleaningthegs.Add(item);
            }

            return null;
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
