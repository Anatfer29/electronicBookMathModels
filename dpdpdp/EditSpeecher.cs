using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class EditSpeecher : Form
    {
        public SpeechSynthesizer spr = new SpeechSynthesizer();
        public EditSpeecher()
        {
            InitializeComponent();
            cbGender.BackColor = Color.Empty;
            nudVolume.BackColor = Color.Empty;
            nudRate.BackColor = Color.Empty;
            nudVolume.BackColor = Color.Empty;

            nudVolume.Value = speecher.talker.Volume;
            nudRate.Value = speecher.talker.Rate;
            foreach (var voice in spr.GetInstalledVoices())
            {
                if (voice.VoiceInfo.Culture.ToString().Contains("ru-RU"))
                    cbGender.Items.Add(voice.VoiceInfo.Name);
            }
            //cbGender.Items.Add("Мужской");
            //cbGender.Items.Add("Женский");
            //cbGender.Items.Add("Нейтральный");
            //cbGender.Items.Add("Нет спецификаций");
            cbGender.SelectedIndex = 0;

        }


        private void EditSpeecher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (cbGender.SelectedIndex != -1)
                {
                    //VoiceGender vg = new VoiceGender();
                    //switch(cbGender.SelectedIndex)
                    //{
                    //    case 0:
                    //        vg=VoiceGender.Male;
                    //        break;
                    //    case 1:
                    //        vg=VoiceGender.Female;
                    //        break;
                    //    case 2:
                    //        vg=VoiceGender.Neutral;
                    //        break;
                    //    case 3:
                    //        vg=VoiceGender.NotSet;
                    //        break;
                    //}

                    speecher.talker.SelectVoice(cbGender.SelectedItem.ToString());
                    speecher.talker.Rate = Convert.ToInt32(nudRate.Value);
                    speecher.talker.Volume = Convert.ToInt32(nudVolume.Value);
                    //speecher.SetSpeeching(vg, va);
                }
                else
                {
                    lblInfo.Text = "Выберите настройки для диктора";
                    e.Cancel = true;
                }
            }
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {

        }
    }
}
