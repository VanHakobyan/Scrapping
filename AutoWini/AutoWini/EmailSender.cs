using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AutoWini
{
    public class EmailSender
    {

        public void SendEmail(CarModel car)
        {

            using (var msg = new MailMessage())
            {

                msg.To.Add("vanhakobyan1996@gmail.com");
                msg.From = new MailAddress("ISTCCsharp@gmail.com");

                msg.Subject = "Autowini have New Kia K5";
                msg.IsBodyHtml = false;
                msg.Body = JsonConvert.SerializeObject(car);

                var client = new SmtpClient
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                };

                try
                {
                    client.Send(msg);
                }
                catch (Exception ex)
                {
                   
                }

            }

        }
    }
}
