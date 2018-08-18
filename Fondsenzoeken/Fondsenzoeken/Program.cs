using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenQA.Selenium.Firefox;

namespace Fondsenzoeken
{
    class Program
    {
        static void Main(string[] args)
        {
            var linl = "https://www.fondsenzoeken.nl/public/profielen/{id}";
            var readAllText = File.ReadAllText(@"E:\jk.json");
            var deserializeObject = JsonConvert.DeserializeObject<List<Class1>>(readAllText);
            FirefoxProfile firefoxOption = new FirefoxProfile();
            firefoxOption.SetPreference("permissions.default.stylesheet", 2);
            firefoxOption.SetPreference("permissions.default.image", 2);
            firefoxOption.SetPreference("dom.ipc.plugins.enabled.libflashplayer.so", false);
            FirefoxOptions fire = new FirefoxOptions();
            fire.Profile = firefoxOption;
            FirefoxDriver client = new FirefoxDriver(fire);
            List<Model> list = new List<Model>();
            var temp = "";
            foreach (var class1 in deserializeObject)
            {
                client.Navigate().GoToUrl(linl.Replace("{id}", class1.id.ToString()));
                HtmlAgilityPack.HtmlDocument document = new HtmlDocument();
                L: Thread.Sleep(700);
                if (temp != client.PageSource) document.LoadHtml(client.PageSource);
                else goto L;
                try
                {
                    temp = client.PageSource;
                    var innerHtml = document.DocumentNode.SelectSingleNode(".//div[@class='blok clearfix']");
                    var email = innerHtml.SelectSingleNode(".//a[@href='mailto:']").InnerText;
                    var org = innerHtml.SelectSingleNode(".//dd[@class='ng-binding']").InnerText;
                    var web = innerHtml.SelectSingleNode(".//a[@class='new ng-binding']").InnerText;
                    list.Add(new Model { email = email, name = org, web = web });
                }
                catch (Exception e)
                {
                    goto L;
                }

            }

            var serializeObject = JsonConvert.SerializeObject(list);
            File.WriteAllText("E:\\col.json", serializeObject);
            Console.WriteLine("complete");
        }
    }
}

public class Rootobject
{
    public Class1[] Property1 { get; set; }
}

public class Class1
{
    public int id { get; set; }
    public string naam { get; set; }
    public string organisatie { get; set; }
    public int Q06 { get; set; }
}

public class Model
{
    public string name { get; set; }
    public string email { get; set; }
    public string web { get; set; }
}

