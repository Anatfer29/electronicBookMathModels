using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace dpdpdp
{
    public partial class MainForm : Form
    {
        private static Form activeForm;
        Auth auth;
        private Button currentButton;
        
        public MainForm(Auth f)
        {
            InitializeComponent();
            auth = f;
            System.Runtime.GCSettings.LargeObjectHeapCompactionMode = System.Runtime.GCLargeObjectHeapCompactionMode.CompactOnce;
            DisableButtons();
            activeForm = new Theory();
            currentButton = btnTheory;
            LoadChildForm();
            switch (currentUser.GetRole())
            {
                case 0:
                    btnCabinet.Visible = false;
                    btnTesting.Visible = false;
                    break;
                case 1:
                    btnAdmin.Visible = false;
                    break;
                case 2:
                    btnAdmin.Visible = false;
                    btnUsers.Visible = false;
                    break;
                case 3:
                    btnAdmin.Visible = false;
                    btnUsers.Visible = false;
                    btnCabinet.Visible = false;
                    break;
            }
            manager.pdisplay = pnlForm;
            manager.menu = pnlMenu;
            btnTheory.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\theory.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnTesting.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\testing.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnAdmin.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\admin.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnUsers.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\users.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnSpravka.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\spravka.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnInteractive.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\interactive.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnAbout.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\about.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnChangeUser.Image = Image.FromFile(Environment.CurrentDirectory + @"\source\exit.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
            btnGameLife.Image= Image.FromFile(Environment.CurrentDirectory + @"\source\game.png").GetThumbnailImage(40, 40, null, IntPtr.Zero);
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="childForm">Форма для загрузки</param>
        /// <param name="sender">Нажатая кнопка</param>
        public void LoadChildForm()
        {
            GC.Collect();
            GC.Collect();
            if (pnlSubMenu.Visible == true)
                pnlSubMenu.Visible = false;
            //Выставить все кнопки неактивными
            DisableButtons();
            //Сделать активной кнопку, которую нажал пользователь
            ActivateButton(currentButton);
            lblCurrent.Text =currentButton.Text;
            //Установка настроек для формы и загрузка в панель
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(activeForm);
            activeForm.BringToFront();
            //Показать форму
            activeForm.Show();
        }

        private void ShowOrHideSet(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = !pnlSubMenu.Visible;
        }

        private void ActivateButton(Button btn)
        {
            if (btn.Name == "btnEditTheory" || btn.Name == "btnEditAdmin" || btn.Name == "btnEditTest")
            {
                btn.Font = new Font(btn.Font.FontFamily, 12);
            }
            else
            {
                btn.Font = new Font(btn.Font.FontFamily, 14);
            }
            btn.BackColor = Color.FromArgb(143, 167, 213);
        }

        private void DisableButtons()
        {
            foreach (Control c in pnlSubMenu.Controls)
            {
                if (c is Button)
                {
                    c.Font = new Font(c.Font.FontFamily, 12);
                    c.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
            foreach (Control c in pnlMenu.Controls)
            {
                if (c is Button)
                {
                    c.Font = new Font(c.Font.FontFamily, 13);
                    c.BackColor = Color.FromArgb(51, 51, 76);

                }
            }
        }

        private void btnChangeUserClick(object sender, EventArgs e)
        {
            auth.Show();
            this.Hide();
        }

        private void Navigate(object sender, EventArgs e)
        {
            if (currentButton!=(Button)sender)
            {
                activeForm.Close();
                switch (((Button)sender).Name)
                {
                    case "btnTheory":
                        activeForm = new Theory();
                        break;
                    case "btnTesting":
                        activeForm = new Testing();
                        break;
                    case "btnInteractive":
                        activeForm = new Interactive();
                        break;
                    case "btnAddTest":
                        activeForm = new AddTest();
                        break;
                    case "btnEditAdmin":
                        activeForm = new EditAdmin();
                        break;
                    case "btnEditTheory":
                        activeForm = new EditTheory();
                        break;
                    case "btnEditTest":
                        activeForm = new EditTest();
                        break;
                    case "btnUsers":
                        if (currentUser.GetRole() == 0)
                        {
                            activeForm = new Users("admin");
                        }
                        else
                            activeForm = new Users("operator");
                        break;
                    case "btnAbout":
                        activeForm = new About();
                        break;
                    case "btnCabinet":
                        activeForm = new Users("cabinet");
                        break;
                    case "btnSpravka":
                        activeForm = new Reference();
                        break;
                }
                currentButton = (Button)sender;
                LoadChildForm();
            }
        }

        private void btnGameLife_Click(object sender, EventArgs e)
        {
            Form f = new GameLife();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            auth.Close();
        }
    }
}
