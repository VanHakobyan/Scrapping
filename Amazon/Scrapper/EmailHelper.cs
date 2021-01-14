using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Scrapper
{
    public class EmailHelper
    {
        public void SendEmail(string textMessage)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = true,
                EnableSsl = true
            };
            var from = new MailAddress("newsvh2018@gmail.com", "VH news");
            var to = new MailAddress("vanhakobyan1996@gmail.com", "Van");
            using (var message = new MailMessage(@from, to))
            {
                message.Body = textMessage;
                message.Subject = "Playstation is available on amazon";
                var myCredentials = new NetworkCredential("newsvh2018@gmail.com", "******", "");
                client.Credentials = myCredentials;
                client.EnableSsl = true;
                try
                {
                    client.Send(message);
                }
                catch (Exception e)
                {
                    File.AppendAllText(@"D:\playstationLog.log",$"{DateTime.Now}: {e}");
                }
            }
        }
    }
}
