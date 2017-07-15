using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using LP_RC_UI.Properties;

namespace LP_RC_UI
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            trackBar_Rate.Value = Settings.Default.speechRate;
            trackBar_Volume.Value = Settings.Default.speechVolume;
            AddInstalledVoicesToList();
        }

        private void AddInstalledVoicesToList()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    ddlVoices.Items.Add(voice.VoiceInfo.Name);
                }
                if (string.IsNullOrEmpty(Settings.Default.SelectedVoice))
                { ddlVoices.SelectedIndex = 0; }
                else
                {
                    ddlVoices.Text = Settings.Default.SelectedVoice;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTextToSpeak.Text))
            {
                MessageBox.Show("Please enter some text in the text box before trying to speak");
               return;
            }

            using (SpeechSynthesizer synth = new SpeechSynthesizer
            {
                Volume = Settings.Default.speechVolume,
                Rate = Settings.Default.speechRate
        })
            {
                synth.SelectVoice(Settings.Default.SelectedVoice);
                grpAdjustments.Enabled = false;
                synth.Speak(txtTextToSpeak.Text);
                grpAdjustments.Enabled = true;
            }
    }

        private void trackBar_Rate_Scroll(object sender, EventArgs e)
        {
            Settings.Default.speechRate = trackBar_Rate.Value;
        }

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            Settings.Default.speechVolume = trackBar_Volume.Value;
        }

        private void ddlVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.SelectedVoice = ddlVoices.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.TTS_Setup = true;
            Settings.Default.Save(); 
            this.Close();
        }
    }
}