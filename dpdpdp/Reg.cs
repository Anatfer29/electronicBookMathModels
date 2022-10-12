using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dpdpdp
{

    public partial class Reg : Form
    {
        Random rnd = new Random();
        StringBuilder code = new StringBuilder();
        Auth f1;
        public Reg()
        {
            InitializeComponent();
            
        }

        public Reg(Auth f) : this()
        {
            f1 = f;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (mail.NetConnection(label1))
            {
                if (CheckMail())
                {
                    code.Clear();

                    for (int i = 0; i < 6; i++)
                        code.Append(rnd.Next(0, 10));

                    string msg = "Здравствуйте, уважаемый(ая) " + tbSur.Text + ", Ваш код для регистрации в приложении: " + code.ToString() + "!";
                    string subject = "Код регистрации в приложении \"Математическое моделирование процессов\"";
                    if (mail.SendMessage(subject, msg, tbEmail.Text))
                    {
                        MessageBox.Show(code.ToString());
                        label1.Text = "Код подтверждения отправлен Вам на почту";
                    }
                    else
                    {
                        label1.Text = "Не удалось отправить код подтверждения";
                    }  
                }
            }
        }

        /// <summary>
        /// Метод для проверки электронной почты
        /// </summary>
        /// <returns></returns>
        private bool CheckMail()
        {
            //Выборка из БД на совпадения электронной почты
            var usemail= usersDBDataSet1.users.Where(item => item.email == tbEmail.Text).Select(item=>item.email);
            //Проверка на то, что введённой почты нет в БД и она не является почтой администратора
            if (usemail.Count() == 0 && tbEmail.Text!=Properties.Settings.Default.adminEmail)
            {
                //Выход из метода
                return true;
            }
            //Вывод сообщения и выход из метода
            label1.Text = "Данный email занят";
            return false;
        }

        private void btnAcceptCode_Click(object sender, EventArgs e)
        {
            CheckCode();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbSur.Text != "Фамилия*" && tbName.Text != "Имя*" && tbEmail.Text != "Email*" && tbPassword.Text != "Пароль*" && tbRePass.Text != "Подтверждение пароля*")
            {

                if (CheckCode())
                {

                    if (Validatinger())
                    {
                        if (tbPassword.Text == tbRePass.Text)
                        {
                            usersDBDataSet.usersRow usersRow = usersDBDataSet1.users.NewusersRow();
                            usersRow["surname"] = tbSur.Text;
                            usersRow["name"] = tbName.Text;
                            usersRow["middlename"] = tbMid.Text == "Отчество" ? "" : tbMid.Text;
                            usersRow["email"] = tbEmail.Text;
                            usersRow["password"] = tbPassword.Text;
                            usersRow["idRole"] = 2;
                            usersRow["phone"] = mtbPhone.Text;
                            usersDBDataSet1.users.AddusersRow(usersRow);
                            usersTableAdapter1.Update(usersRow);
                            ClearFields();
                            MessageBox.Show("Успешная регистрация", "Пользователь успешно зарегестрирован");
                        }
                        else
                            lblError.Text = "Пароли не совпадают";
                    }
                }
                else
                    lblError.Text = "Введите код подтверждения";
            }
            else
                lblError.Text = "Заполните все обязательные поля";
        }

        private bool CheckCode()
        {
            if (tbCode.Text == code.ToString())
            {
                tbEmail.Enabled = false;
                tbCode.Enabled = false;
                label1.Text = "Почта успешно подтверждена";
                return true;
            }
            lblError.Text = "Неверный код подтверждения почты.";
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f1.Left += 10;
            if (f1.Left >= (classLeft.a + f1.Width))
            {
                f1.Activate();
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            f1.Left -= 10;
            this.Opacity -= 0.01;
            if (f1.Left == classLeft.a)
            {
                timer2.Stop();
                f1.Enabled = true;
                this.Hide();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ClearFields();
            timer1.Start();
            this.Enabled = false;
            f1.Visible = true;
            f1.Opacity = 1;
            this.Activate();
        }

        private void tbCLick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "tbSur":
                    tbSur.Text = "";
                    break;
                case "tbName":
                    tbName.Text = "";
                    break;
                case "tbMid":
                    tbMid.Text = "";
                    break;
                case "tbEmail":
                    tbEmail.Text = "";
                    break;
                case "tbCode":
                    tbCode.Text = "";
                    break;
                case "tbPassword":
                    tbPassword.Text = "";
                    tbPassword.PasswordChar = '*';
                    break;
                case "tbRePass":
                    tbRePass.Text = "";
                    tbRePass.PasswordChar = '*';
                    break;
            }
        }

        private void tbLeave(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "tbSur":
                    if (tbSur.Text.Trim() == "")
                        tbSur.Text = "Фамилия*";
                    break;
                case "tbName":
                    if (tbName.Text.Trim() == "")
                        tbName.Text = "Имя*";
                    break;
                case "tbMid":
                    if (tbMid.Text.Trim() == "")
                        tbMid.Text = "Отчество";
                    break;
                case "tbEmail":
                    if (tbEmail.Text.Trim() == "")
                        tbEmail.Text = "Email*";
                    break;
                case "tbCode":
                    if (tbCode.Text.Trim() == "")
                        tbCode.Text = "Код*";
                    break;
                case "tbPassword":
                    if (tbPassword.Text.Trim() == "")
                    {
                        tbPassword.Text = "Пароль*";
                        tbPassword.PasswordChar = '\0';
                    }
                    break;
                case "tbRePass":
                    if (tbRePass.Text.Trim() == "")
                    {
                        tbRePass.Text = "Подтверждение пароля*";
                        tbRePass.PasswordChar = '\0';
                    }
                    break;
            }
        }
        
        private bool Validatinger()
        {
            if (!regExpr.ValidationSurname(tbSur.Text))
            {
                lblError.Text = "Неккоректный формат фамилии";
                return false;
            }
            else if (!regExpr.ValidNameAndMidName(tbName.Text))
            {
                lblError.Text = "Неккоректный формат имени";
                return false;
            }
            else if (!regExpr.ValidNameAndMidName(tbMid.Text))
            {
                lblError.Text = "Неккоректный формат отчества";
                return false;
            }
            else if (!regExpr.ValidationPassword(tbPassword.Text))
            {
                lblError.Text = "Неккоректный формат пароля: длина пароля\nот 6 до 12 символов, 1 строчная и\n1 заглавная буква, цифра и спец-символ.";
                return false;
            }
            else if (!mtbPhone.MaskFull && mtbPhone.Text.Trim() != "+7 (   )    -")
            {
                lblError.Text = "Неккоректный формат телефона";
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            lblError.Text = "";
            label1.Text = "";
            tbSur.Text = "Фамилия*";
            tbName.Text = "Имя*";
            tbMid.Text = "Отчество";
            tbEmail.Text = "Email*";
            tbCode.Text = "Код*";
            tbPassword.Text = "Пароль*";
            tbRePass.Text = "Подтверждение пароля*";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Close();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            try
            {
                usersTableAdapter1.Fill(usersDBDataSet1.users);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить данные", "Не удалось загрузить данные");
            }
        }
    }
}
