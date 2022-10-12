using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace dpdpdp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            try
            {
                usersTableAdapter1.Fill(this.usersDBDataSet1.users);
            }
            catch
            {
                MessageBox.Show("Данные не удалось загрузить","Ошибка загрузки данных");
            }
        }

        private void tbClear(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "tbMailAuth":
                    tbMailAuth.Clear();
                    break;
                case "tbPassAuth":
                    tbPassAuth.Clear();
                    tbPassAuth.PasswordChar = '*';
                    break;
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Enabled = false;
            reg.Enabled = false;
            reg.Show();
            this.Activate();
            reg.Opacity = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reg.Left += 10;
            if (reg.Left >= (classLeft.a + reg.Width))
            {
                reg.Activate();
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            reg.Left -= 10;
            if (reg.Left == classLeft.a)
            {
                timer2.Stop();
                reg.Enabled = true;
                this.Visible = false;
            }
        }
        Form reg;
        private void Auth_Load(object sender, EventArgs e)
        {
            reg = new Reg(this);
            classLeft.a = this.Left;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbMailAuth.Text.Trim() != "" && tbMailAuth.Text.Trim()!="Email") && (tbPassAuth.Text.Trim() != "" && tbPassAuth.Text.Trim() != "Пароль"))
                {
                    if (tbMailAuth.Text == Properties.Settings.Default.adminEmail && tbPassAuth.Text == Properties.Settings.Default.adminPassword)
                    {
                        currentUser.SetRole(0);
                    }
                    else
                    {
                        var users = usersDBDataSet1.users.Where(item => item.email == tbMailAuth.Text && item.password == tbPassAuth.Text).First();
                        currentUser.SetId(users.idUser);
                        currentUser.SetRole(users.idRole);
                    }
                    ClearFields();
                    this.Hide();
                    reg.Hide();
                    Form f = new MainForm(this);
                    f.Show();

                }
                else
                    lblError.Text = "Введите почту и пароль";
            }
            catch
            {
                lblError.Text = "Введённого пользователя не существует";
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            tbMailAuth.Text = "Email";
            tbPassAuth.PasswordChar = '\0';
            tbPassAuth.Text = "Пароль";
            lblError.Text = "";
        }

        private void tbLeave(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "tbMailAuth":
                    if (tbMailAuth.Text.Trim() == "")
                        tbMailAuth.Text = "Email";
                    break;
                case "tbPassAuth":
                    if (tbPassAuth.Text.Trim() == "")
                    {
                        tbPassAuth.Text = "Пароль";
                        tbPassAuth.PasswordChar = '\0';
                    }
                    break;
            }
            
        }

        private void btnEnterGuest_Click(object sender, EventArgs e)
        {
            currentUser.SetRole(3);
            ClearFields();
            this.Hide();
            reg.Hide();
            Form f = new MainForm(this);
            f.Show();
        }

        private void lblHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
