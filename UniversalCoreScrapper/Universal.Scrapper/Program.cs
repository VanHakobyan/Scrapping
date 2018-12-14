using System;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Configuration;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace Universal.Scrapper
{

    class Program
    {

        public static void Login(IConfigurationRoot builder, RemoteWebDriver driver)
        {
            var credential = builder.GetSection("Credentials").GetChildren().Select(x => x.Value).ToList();
            var _email = credential[0];
            var _password = credential[1];
            var url = builder.GetValue<string>("SiteToLogin");
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(builder.GetValue<int>("Sleep"));
            var email = driver.FindElementByXPath(".//input[@id='ius-userid']");
            var password = driver.FindElementByXPath(".//input[@id='ius-password']");
            email?.SendKeys(_email);
            password?.SendKeys(_password);
            var signin = driver.FindElementByXPath(".//button[@id='ius-sign-in-submit-btn']");
            signin?.Click();
        }

        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            var directoryInfo = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;
            var builder = new ConfigurationBuilder()
                .SetBasePath(directoryInfo)
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var urls = builder.GetSection("Urls").GetChildren().Select(x => x.Value).ToList();
            var option = new ChromeOptions();
            option.AddArgument("--start-maximized");
            option.AddArguments("--headless");
            option.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
            option.AddUserProfilePreference("profile.default_content_setting_values.stylesheet", 2);
            var proxy = new Proxy { HttpProxy = builder.GetValue<string>("Proxy") };
            option.Proxy = proxy;
            var driver = new ChromeDriver(Directory.GetCurrentDirectory(), option);
            if(builder.GetValue<bool>("IsLogin")) Login(builder,driver);

            foreach (var url in urls)
            {
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(builder.GetValue<int>("Sleep"));
                logger.Info(driver.PageSource);
            }
        }
    }
}
