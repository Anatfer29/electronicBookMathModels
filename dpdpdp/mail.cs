using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;

namespace dpdpdp
{
    static class mail
    {
        public static bool NetConnection(System.Windows.Forms.Label lbl)
        {
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com");
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    rspFP.Close();
                    return true;
                }
                else
                {
                    rspFP.Close();
                    lbl.Text = "Отсутсвует подключение к интернету";
                    return false;
                }
            }
            catch (WebException)
            {
                lbl.Text = "Отсутсвует подключение к интернету";
                return false;
            }
        }

        public static bool SendMessage(string subject, string message, string toSender)
        {
            try
            {
                MailAddress from = new MailAddress(Properties.Settings.Default.adminEmail);

                MailAddress to = new MailAddress(toSender);

                MailMessage m = new MailMessage(from, to);

                m.Subject = subject;

                m.Body = message;

                m.IsBodyHtml = true;

                string s = from.Address.Split('@')[1];

                SmtpClient smtp = new SmtpClient(string.Format("smtp.{0}", s), s == "yandex" ? 25 : s == "mail" ? 2525 : s == "icloud" ? 993 : 587);

                smtp.Credentials = new NetworkCredential(from.Address, Properties.Settings.Default.adminPasswordEmail);
                smtp.EnableSsl = true;

                smtp.Send(m);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
