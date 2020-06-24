using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumDriverProxy
{
    class Program
    {
        protected static ChromeDriver InitChromeDriver()
        {
            var option = new ChromeOptions();
            option.AddArgument("--start-maximized");
            option.AddArgument("--no-sandbox");
            //option.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
            //option.AddUserProfilePreference("profile.default_content_setting_values.stylesheet", 2);
            //option.AddArgument("--ignore-certificate-errors");
            //option.AddArgument("--ignore-ssl-errors=yes");
            //option.AddArguments($"--proxy-server={ProxyIp}:{ProxyPort}");
            option.AddArgument("--disable-extensions");
            option.AddArgument("--profile-directory=Default");
            option.AddArgument("--disable-infobars");
            option.AddArgument("--disable-plugins-discovery");
            //option.AddArgument("--disable-web-security");
            //option.AddArgument("--whitelisted-ips");
            //option.AddArguments("--allow-running-insecure-content");

            option.AddArgument("--user-agent= Mozilla/5.0 (Macintosh; Intel Mac OS X 10.14; rv:70.0) Gecko/20100101 Firefox/70.0");
            option.AddArgument("--Cookie= rmbs=3; aps03=cf=N&cg=1&cst=0&ct=158&hd=N&lng=1&oty=2&tzi=22; pstk=80D5708FF65B2F7F998F82FF1F49AC39000003");
            option.AddArgument("--Host= www.bet365.com");

            //GetAndSetProxy(option);
        
            // Set ACCEPT_SSL_CERTS  variable to true
            //option.AddAdditionalCapability(CapabilityType.AcceptInsecureCertificates, false);
            
            return new ChromeDriver(option);
        }


        //protected static void InitFirefoxDriver(ref FirefoxDriver driver)
        //{
        //    FirefoxOptions options = new FirefoxOptions();
        //    GetAndSetProxy(options);

        //    driver = new FirefoxDriver(options);


        //}
        protected static void GetAndSetProxy(ChromeOptions option)
        {
            
            var proxy = new Proxy
            {
                HttpProxy = "<<ip>>:<port>",
                Kind = ProxyKind.Manual,
                IsAutoDetect = false,
                SslProxy = "<<ip>>:<port>"
            };

            
            option.Proxy = proxy;
        }
        //protected static void GetAndSetProxy(FirefoxOptions options)
        //{
        //    var proxy = new Proxy
        //    {
        //        HttpProxy = $"{ProxyIp}:{ProxyPort}",
        //        Kind = ProxyKind.Manual,
        //        IsAutoDetect = false,
        //        SslProxy = $"{ProxyIp}:{ProxyPort}"
        //    };

        //    options.Proxy = proxy;
        //}

        static void Main(string[] args)
        {
            var driver = InitChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(@"https://stackoverflow.com/");
        }
    }
}
