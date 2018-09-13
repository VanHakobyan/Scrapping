using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Heepsy
{
    class Program
    {
        static void Main(string[] args)
        {
          WebClient  client=new WebClient();
            client.Headers.Add(HttpRequestHeader.Cookie, "_ga=GA1.2.7113657.1536858097; _gid=GA1.2.1774507454.1536858097; fs_intercom=5730871106600960:5629499534213120; intercom-id-t9epzkvq=24d4881d-e4bf-4d5a-a4d8-39fef7d456a4; grsf.cid=vz6syr; grsf.ccid=aeobcm; grsf.cccid=aeobcmvz6syr; fs_uid=fullstory.com`84XC9`5730871106600960:5629499534213120`23351`; intercom-lou-t9epzkvq=1; session_cookie=0f2990ff24b74ca94bd00bf827415829; intercom-session-t9epzkvq=UlNjVmVtVGttVDFSSFo2eTRyRkJwekJkNnlELzVPdlIxYjhRdWlPNmppUGlzUFd3d3RDMlphR3IybVVjRHF3aC0talVGcHAzUk1JLzVLbSs1bDlzQWNtUT09--0df03f5c358c835b217aca7f302c35116a1b561a");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
            client.Headers.Add(HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            client.Headers.Add(HttpRequestHeader.Referer, "https://www.heepsy.com/login");
            client.Headers.Add("Upgrade-Insecure-Requests", "1");
            //client.Headers.Add(HttpRequestHeader.Connection, "keep-alive");
            var downloadString = client.DownloadString("https://www.heepsy.com/influencers");
        }
    }
}
