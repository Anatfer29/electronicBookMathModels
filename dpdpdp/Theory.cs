using System;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class Theory : Form
    {
        bool speacking=false;

        public Theory()
        {
            InitializeComponent();
            LoadTheory();
        }

        private void LoadTheory()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + @"\theory\");
            TabPage tp;
            RichTextBox rtb;
            foreach (var file in di.GetFiles())
            {
                tp = new TabPage(Path.GetFileNameWithoutExtension(file.Name));
                rtb = new RichTextBox();
                rtb.LoadFile(file.FullName);
                rtb.Dock = DockStyle.Fill;
                rtb.ReadOnly = true;
                rtb.BackColor = Color.Empty;
                
                tp.Controls.Add(rtb);
                tcTheory.TabPages.Add(tp);
                if (currentUser.GetRole() == 3)
                    break;
            }
            
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            if (speacking)
            {
                if (btnSpeech.Text == "Приостановить")
                {
                    btnSpeech.Text = "Продолжить";
                    speecher.talker.Pause();
                }
                else
                {
                    speecher.talker.Resume();
                    btnSpeech.Text = "Приостановить";
                }
            }
            else
            {
                btnSpeech.Text = "Приостановить";
                speacking = true;
                speecher.talker.SpeakAsync(((RichTextBox)tcTheory.SelectedTab.Controls[0]).Text);
                speecher.talker.Resume();
            }
        }

        private void tcTheory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSpeech.Text = "Озвучить теорию";
            speecher.talker.SpeakAsyncCancelAll();
            speacking = false;
        }

        private void btnEditSpeecher_Click(object sender, EventArgs e)
        {
            speacking = false;
            speecher.talker.SpeakAsyncCancelAll();
            EditSpeecher f = new EditSpeecher();
            if (f.ShowDialog() == DialogResult.OK)
                lblSpeech.Text = "Диктор настроен";
            else
                lblSpeech.Text = "Диктор настроен по умолчанию";
            btnSpeech.Text = "Озвучить теорию";
        }

        private void Theory_FormClosing(object sender, FormClosingEventArgs e)
        {
            speecher.talker.SpeakAsyncCancelAll();
        }
    }
}