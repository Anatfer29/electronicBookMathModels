using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class Users : Form
    {
        TabPage tp1;
        TabPage tp2;
        int idUser = 0;
        string surname;
        string name;
        string midName;
        string phone;
        string email;
        string password;
        bool oper;
        int code;
        Random rnd = new Random();

        public Users()
        {
            InitializeComponent();
            usersTableAdapter1.Fill(usersDBDataSet1.users);
            testingTableAdapter1.Fill(usersDBDataSet1.testing);
            dtpEnd.MaxDate = DateTime.Now;
            TakeDates();
            dgvUsers.Font = new Font(this.Font.FontFamily, 12);
            label10.Visible = false;
            tbCode.Visible = false;
            DirectoryInfo df = new DirectoryInfo(Environment.CurrentDirectory + @"\tests\");
            foreach (var file in df.GetFiles())
            {
                cbTests.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        public Users(string type) : this()
        {
            switch (type)
            {
                case "cabinet":
                    tc.TabPages.RemoveAt(0);
                    FillUser(currentUser.GetId());
                    FillTesting(currentUser.GetId());
                    tc.SelectedTab = tc.TabPages[0];
                    btnSendMessage.Visible = false;
                    idUser = currentUser.GetId();
                    cbOpearator.Enabled = false;

                    break;
                case "operator":
                    tp1 = tc.TabPages[1];
                    tp2 = tc.TabPages[2];
                    FillUsers();
                    tableLayoutPanel1.Enabled = false;
                    cbOpearator.Enabled = false;
                    label6.Visible = false;
                    tbPassword.Visible = false;
                    label6.Enabled = false;
                    btnResend.Visible = false;
                    tc.TabPages.RemoveAt(1);
                    tc.TabPages.RemoveAt(1);
                    break;
                case "admin":
                    tp1 = tc.TabPages[1];
                    tp2 = tc.TabPages[2];
                    FillUsers();
                    btnResend.Visible = false;
                    tc.TabPages.RemoveAt(1);
                    tc.TabPages.RemoveAt(1);
                    break;
            }
        }

        private void FillUsers()
        {
            var a = usersDBDataSet1.users.Where(item => item.idUser != currentUser.GetId()).Select(item => new { id = item.idUser, ФИО = item.surname + " " + item.name + " " + (item["middlename"] == DBNull.Value ? "" : item.middlename), Почта = item.email, Телефон = (item["phone"] == DBNull.Value ? "" : item.phone) }).Where(item => item.ФИО.Contains(tbFind.Text));
            dgvUsers.DataSource = a.ToList();
            dgvUsers.Columns[0].Visible = false;
        }

        private void FillUser(int id)
        {
            var user = usersDBDataSet1.users.Where(item => item.idUser == id).First();
            surname = tbSurname.Text = user.surname;
            name = tbName.Text = user.name;
            midName = tbMiddleName.Text = user.middlename;
            phone = mtbPhone.Text = user.phone;
            email = tbEmail.Text = user.email;
            password = tbPassword.Text = user.password;
            oper = cbOpearator.Checked = user.idRole == 1;
        }

        private void FillTesting(int id)
        {
            var tests = usersDBDataSet1.testing.Select(item => new { id = item.idUser, Тест = item.nameOfTest, Оценка = item.scoreOfTest, Пройден = item.dateOfTest }).Where(item => item.Тест.ToLower().Contains(cbTests.Text.ToLower()) && item.Пройден >= dtpStart.Value.AddDays(-1) && item.Пройден <= dtpEnd.Value && item.id == id);

            dgvTesters.DataSource = tests.ToList();
            dgvTesters.Columns[0].Visible = false;
        }

        private void TakeDates()
        {
            FillTesting(idUser);
            dtpStart.MaxDate = dtpEnd.Value.AddDays(-1);
            dtpEnd.MinDate = dtpStart.Value.AddDays(1);
        }

        private void dtpValueChanged(object sender, EventArgs e)
        {
            TakeDates();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 0)
            {
                if (idUser == 0)
                {
                    tc.TabPages.Add(tp1);
                    tc.TabPages.Add(tp2);
                }
                if (idUser != Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value))
                {
                    idUser = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                    tc.SelectedTab = tc.TabPages[1];
                    FillUser(idUser);
                    FillTesting(idUser);
                    lblSave.Text = "";
                }
            }
        }

        private bool CheckChanges()
        {
            if (tbSurname.Text == surname && tbName.Text == name && tbMiddleName.Text == midName && mtbPhone.Text == phone && tbEmail.Text == email && tbPassword.Text == password && cbOpearator.Checked == oper)
            {
                return false;
            }
            return true;
        }

        private bool Validatinger()
        {
            if (!regExpr.ValidationSurname(tbSurname.Text))
            {
                lblSave.Text = "Неккоректный формат фамилии";
                return false;
            }
            else if (!regExpr.ValidNameAndMidName(tbName.Text))
            {
                lblSave.Text = "Неккоректный формат имени";
                return false;
            }
            else if (!regExpr.ValidNameAndMidName(tbMiddleName.Text) && tbMiddleName.Text != "")
            {
                lblSave.Text = "Неккоректный формат отчества";
                return false;
            }
            else if (!regExpr.ValidationPassword(tbPassword.Text))
            {
                lblSave.Text = "Неккоректный формат пароля: длина пароля от 6 до 12 символов, 1 строчная и 1 заглавная буква, цифра и спец-символ.";
                return false;
            }
            else if ((!mtbPhone.MaskFull && mtbPhone.Text != phone) || !(mtbPhone.Text == "+7 (   )    -"))
            {
                lblSave.Text = "Неккоретный номер телефона";
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                if (Validatinger())
                {
                    if (currentUser.GetRole() == 0)
                    {
                        
                        EditUser();
                        FillUsers();
                    }
                    else
                    {
                        if (btnSave.Text == "Подтвердить")
                        {
                            if (code.ToString() == tbCode.Text)
                            {
                                EditUser();
                                FillUsers();
                            }
                            else
                                lblSave.Text = "Неккоректный код подтверждения";
                        }
                        else if (AcceptChanges())
                        {
                            lblSave.Text = "Код для подтверждения отправлен Вам на почту";
                            label10.Visible = true;
                            tbCode.Visible = true;
                            btnResend.Visible = true;
                            btnSave.Text = "Подтвердить";
                        }
                    }
                }
            }
            else
            {
                lblSave.Text = "Нет информации для изменения.";
            }
        }

        private void EditUser()
        {
            usersDBDataSet.usersRow usersRow = usersDBDataSet1.users.FindByidUser(idUser);
            surname = usersRow.surname = tbSurname.Text;
            name = usersRow.name = tbName.Text;
            midName = usersRow.middlename = tbMiddleName.Text;
            email = usersRow.email = tbEmail.Text;
            phone = usersRow.phone = mtbPhone.Text;
            password = usersRow.password = tbPassword.Text;
            usersRow.idRole = cbOpearator.Checked ? 1 : 2;
            oper = cbOpearator.Checked;
            usersTableAdapter1.Update(usersRow);
            lblSave.Text = "Изменения успешно применены.";
            btnSave.Text = "Сохранить изменения";
            label10.Visible = false;
            tbCode.Visible = false;
        }

        private void tc_TabIndexChanged(object sender, EventArgs e)
        {
            if (btnResend.Visible)
            {
                btnSave.Text = "Сохранить изменения";
                label10.Visible = false;
                FillUser(idUser);
                btnResend.Visible = false;
                tbCode.Visible = false;
            }
            lblSave.Text = "";
        }

        private void cbTests_TextChanged(object sender, EventArgs e)
        {
            FillTesting(idUser);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Form f = new SendMessage(idUser);
            f.Show();
        }

        private bool AcceptChanges()
        {
            if (mail.NetConnection(lblSave))
            {

                string subject = "Редактирование информации";
                code = rnd.Next(1000, 9999);

                string msg = "Здравствуйте, уважаемый(ая) " + tbSurname.Text + " " + tbName.Text + " " + tbMiddleName.Text + ", Ваш код для подтверждения в измнений в приложении \"Математическое моделирование процессов\": " + code.ToString() + "!";

                if (mail.SendMessage(subject, msg, tbEmail.Text))
                {
                    return true;
                }
                else
                {
                    lblSave.Text = "Не удалось отправить код подтверждения";
                }
            }
            return false;
        }

        private void btnReSend_Click(object sender, EventArgs e)
        {
            if (AcceptChanges())
            {
                lblSave.Text = "Код подтверждения отправлен повторно";
            }
        }
    }
}
