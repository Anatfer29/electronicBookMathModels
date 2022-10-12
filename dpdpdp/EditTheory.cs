using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class EditTheory : Form
    {
        string thr;
        bool adding = false;
        public EditTheory()
        {
            InitializeComponent();
            var fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (var a in fonts.Families)
                cbFamily.Items.Add(a.Name);
            cbFamily.SelectedIndex = 0;
            cbStyle.SelectedIndex = 0;
            cbAlign.SelectedIndex = 0;
            LoadTheorys();
        }

        private void LoadTheorys()
        {
            lbTheorys.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"\theory");
            foreach (var file in dir.GetFiles())
            {
                lbTheorys.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        private void LoadTheory()
        {
            rtbTheory.LoadFile(Environment.CurrentDirectory + @"\theory\" + thr + ".rtf");
            tbNameTheory.Text = thr;
            cbAlign.SelectedIndex = 0;
            cbStyle.SelectedIndex = 0;
            cbFamily.SelectedItem = "Times New Roman";
            lblError.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rtbTheory.Text.Trim() != "" && tbNameTheory.Text.Trim() != "")
            {
                if (thr != "")
                {
                    File.Delete(Environment.CurrentDirectory + @"\theory\" + thr + ".rtf");
                }
                SaveThory();
                if (adding)
                {
                    lblError.Text = "Теория успешно сохранена";
                    adding = false;
                }
                else
                    lblError.Text = "Теория успешно изменена";
                thr = tbNameTheory.Text;
            }
            else
            {
                lblError.Text = "Заполните наименование теории и введите информацию.";
            }
        }

        private void SaveThory()
        {
            rtbTheory.SaveFile(Environment.CurrentDirectory + @"\theory\" + tbNameTheory.Text + ".rtf");
            lblError.Text = "Теория успешно загружена";
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakeText();
        }

        private void cbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakeText();
        }

        private FontStyle TextStyle()
        {
            FontStyle style;
            switch (cbStyle.SelectedIndex)
            {
                case 0:
                    style = FontStyle.Regular;
                    break;
                case 1:
                    style = FontStyle.Italic;
                    break;
                default:
                    style = FontStyle.Bold;
                    break;
            }
            return style;
        }

        private void TakeText()
        {
            rtbTheory.SelectionFont = new Font(cbFamily.SelectedItem.ToString(), (float)nud.Value, TextStyle());
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            TakeText();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg | png|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(ofd.FileName);
                Clipboard.SetDataObject(bitmap);
                DataFormats.Format format = DataFormats.GetFormat(DataFormats.Bitmap);
                rtbTheory.Paste();
            }
            else
                lblError.Text = "Вы не выбрали изображение для загрузки";
        }

        private void cbAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAlign.SelectedIndex)
            {
                case 0:
                    rtbTheory.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case 1:
                    rtbTheory.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                default:
                    rtbTheory.SelectionAlignment = HorizontalAlignment.Right;
                    break;
            }
        }

        private void btnEditTeory_Click(object sender, EventArgs e)
        {
            if (lbTheorys.SelectedIndex != -1)
            {
                thr = lbTheorys.SelectedItem.ToString();
                pnlChooseTheory.Visible = false;
                pnlEditThory.Visible = true;
                LoadTheory();
            }
            else
                lblInfo.Text = "Выберите теорию для изменения";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            thr = "";
            pnlChooseTheory.Visible = true;
            pnlEditThory.Visible = false;
            adding = false;
            LoadTheorys();
        }

        private void btnDeleteTeory_Click(object sender, EventArgs e)
        {
            if (lbTheorys.SelectedIndex != -1)
            {
                if (lbTheorys.Items.Count >= 1)
                {
                    File.Delete(Environment.CurrentDirectory + @"\theory\" + lbTheorys.SelectedItem.ToString() + ".rtf");
                    lblInfo.Text = "Теория успешно удалена";
                    LoadTheorys();
                }
                else
                {
                    lblInfo.Text = "Минимальное количество теорий - 1";
                }
                
            }
            else
                lblInfo.Text = "Выберите теорию для удаления";
        }

        private void btnAddTheory_Click(object sender, EventArgs e)
        {
            pnlEditThory.Dock = DockStyle.Fill;
            pnlChooseTheory.Visible = false;
            pnlEditThory.Visible = true;
            adding = true;
        }
    }
}
