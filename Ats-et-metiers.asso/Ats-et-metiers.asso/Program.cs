using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Ats_et_metiers.asso
{
    class Program
    {

        private static string pageUrl = @"https://www.arts-et-metiers.asso.fr/index.php/annuaire2/public";
        static void Main(string[] args)
        {
            List<PeopleModel> peoples = new List<PeopleModel>();
            //ChromeDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(pageUrl);
            
            //for (int i = 0; i < 1000; i++)
            //{
            //    driver.ExecuteScript($"scroll({i},{1000 * i})");
            //    Thread.Sleep(300);
            //}
            //var driverPageSource = driver.PageSource;
            var driverPageSource = File.ReadAllText(@"E:\as.txt");
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(driverPageSource);
            var profilesDiv = document.DocumentNode.SelectNodes(".//div[@class='mini_profil']");
            var profilesDivCustom = document.DocumentNode.SelectNodes(".//div[@class='vignette']");

            for (var i=0;i<profilesDiv.Count;i++)
            {
                var name = profilesDiv[i].SelectSingleNode(".//h3[@class='v_nom']")?.InnerText.Split(' ');
                var email = profilesDiv[i].SelectSingleNode(".//div[@class='vst st_mail']")?.InnerText?.Replace("\t","")?.Replace("\r","")?.Replace("\n","");
                var title = profilesDivCustom[i].SelectSingleNode(".//div[@class='v_fonction']")?.InnerText;
                var job = profilesDivCustom[i].SelectSingleNode(".//div[@class='v_entreprise']")?.InnerText;
                peoples.Add(new PeopleModel{LastName = name[0],SureName = name[1],Company = title,Email = email,Job = job});
            }

            var serializeObject = JsonConvert.SerializeObject(peoples);
        }
    }
}
