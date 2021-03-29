using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace EasyNote.Utilities
{
    public static class EmailUtility
    {
        public static async Task SendEmailAsync( string to , string subject, string body)
        {
            using (var smtp = new SmtpClient("bircanatas.com"))
            {
                smtp.Credentials = new NetworkCredential("easynote@bircanatas.com", "*******");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                MailMessage message = new MailMessage("easynote@bircanatas.com",to, subject, body);
                message.IsBodyHtml= true;
                await smtp.SendMailAsync(message);
            }
        }
    }
}