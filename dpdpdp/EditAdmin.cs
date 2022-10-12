using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Linq;

namespace dpdpdp
{
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
            tbEmail.Text = Properties.Settings.Default.adminEmail;
            tbEmailPassword.Text = Properties.Settings.Default.adminPasswordEmail;
            tbPassword.Text = Properties.Settings.Default.adminPassword;
            usersTableAdapter1.Fill(usersDBDataSet1.users);
        }

        private void btnSendMessage_Click(object sender, System.EventArgs e)
        {
            if (CheckChanges())
            {
                if (regExpr.ValidationPassword(tbPassword.Text))
                {
                    if (CorrectEmail())
                    {
                        Properties.Settings.Default.adminEmail = tbEmail.Text;
                        Properties.Settings.Default.adminPassword = tbPassword.Text;
                        Properties.Settings.Default.adminPasswordEmail = tbEmailPassword.Text;
                        dpdpdp.Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    lblInfo.Text = "Пароль от 6 до 12 символов. Содержит строчную и заглавную букву, спец символ и цифру";
                }
            }
        }

        private bool CorrectEmail()
        {
            if (mail.NetConnection(lblInfo))
            {
                try
                {
                    var usemail = usersDBDataSet1.users.Where(item => item.email == tbEmail.Text).Select(item => item.email);
                    if (usemail.Count() == 0)
                    {
                        MailAddress from = new MailAddress(tbEmail.Text.Trim());
                        MailAddress to1 = new MailAddress(tbEmail.Text.Trim());

                        MailMessage mailMessage = new MailMessage(from, to1);

                        mailMessage.Subject = "Изменение информации администратора";

                        mailMessage.Body = "Информация администратора успешно изменена";

                        string s = tbEmail.Text.Trim().Split('@')[1];

                        SmtpClient smtp = new SmtpClient(string.Format("smtp.{0}", s), s == "yandex" ? 25 : s == "mail" ? 2525 : s == "icloud" ? 993 : 587);

                        smtp.Credentials = new NetworkCredential(tbEmail.Text.Trim(), tbEmailPassword.Text.Trim());
                        smtp.EnableSsl = true;
                        smtp.Send(mailMessage);
                        lblInfo.Text = "Информация успешно изменена";
                        return true;
                    }
                    else
                    {
                        lblInfo.Text = "Данный email занят пользователем";
                        return false;
                    }
                }
                catch
                {
                    lblInfo.Text = "Проверьте правильность введённых данных";
                    return false;
                }
            }
            return false;
        }
        private bool CheckChanges()
        {
            if (tbEmail.Text==Properties.Settings.Default.adminEmail && tbEmailPassword.Text == Properties.Settings.Default.adminPasswordEmail && tbPassword.Text == Properties.Settings.Default.adminPassword)
            {
                lblInfo.Text = "Изменения не были внесены";
                return false;
            }
            return true;
        }
    }
}
