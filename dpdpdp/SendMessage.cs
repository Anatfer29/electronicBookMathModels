using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class SendMessage : Form
    {
        int id = 0;
        public SendMessage(int id)
        {
            InitializeComponent();
            usersTableAdapter1.Fill(usersDBDataSet1.users);
            this.id = id;
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (mail.NetConnection(lblInfo))
            {
                foreach (Control c in this.Controls)
                {
                    if (c is RadioButton)
                    {
                        if (((RadioButton)c).Checked)
                        {
                            switch (c.Text)
                            {
                                case "Курс пройден":
                                    msg = "Поздравляем! Вы успешно прошли курс по математическому моделированию процессов!";
                                    break;
                                case "Не набрал требуемый средний балл":
                                    msg = "К сожалению, Вы не смогли пройти курс по математическому моделированию, так как не набрали требуемый средний балл.";
                                    break;
                                case "Не пройдено всё тестирование":
                                    msg = "К сожалению, Вы не смогли пройти курс по математическому моделированию, так как не прошли всё тестирование.";
                                    break;
                            }
                            try
                            {
                                var prinyal = usersDBDataSet1.users.Where(item => item.idUser == id).First();


                                string subject = "Результат прохождения курса";

                                msg = "Здравствуйте, уважаемый(ая) " + prinyal.surname + " " + prinyal.name + " " + prinyal.middlename + "!\n" + msg;
                                if (mail.SendMessage(subject, msg, prinyal.email))
                                    lblInfo.Text = "Письмо успешно отправлено!";
                                else
                                    lblInfo.Text = "Не удалось отправить письмо.";
                            }
                            catch
                            {
                                //label1.Text = "Неккоректный адрес электронной почты";
                            }
                        }
                    }
                }
            }
        }
    }
}
