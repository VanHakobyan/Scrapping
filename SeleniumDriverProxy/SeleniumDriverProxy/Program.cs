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
            option.AddArgument("no-sandbox");
            //option.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
            //option.AddUserProfilePreference("profile.default_content_setting_values.stylesheet", 2);
            option.AddArgument("--ignore-certificate-errors");
            option.AddArgument("--ignore-ssl-errors=yes");
            option.AddArgument("ssl-protocol=any");
            //option.AddArguments($"--proxy-server={ProxyIp}:{ProxyPort}");
            option.AddArgument("--disable-extensions");
            option.AddArgument("--disable-web-security");
            option.AddArgument("--whitelisted-ips");
            option.AddArguments("--allow-running-insecure-content");
            GetAndSetProxy(option);
        
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

            driver.Navigate().GoToUrl(@"https://stackoverflow.com/");
        }
    }
}
