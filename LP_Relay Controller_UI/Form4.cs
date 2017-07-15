using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LattePanda.Firmata;
using LP_RC_UI.Properties;
using System.Speech.Synthesis;
using System.Diagnostics;

/************************************************************
* Copyright(C)2017,LattePanda
* FileName: Form4.cs
* Author:   Luis Navarro
* Version:  V1.0
* Date:     2017.07
* Description: With this form you can control up to 4 relays.
*  
*************************************************************/
namespace LP_RC_UI
{

    public partial class Form4 : Form
    {
        Arduino arduino = new Arduino();

    public Form4()
    {
            InitializeComponent();

            if (Settings.Default.Relay1_IsOn == false)
            {
                btn_Power1.Image = Resources.btn_PowerOFF;
            }
            else
            {
                btn_Power1.Image = Resources.btn_PowerON;
            }

            if (Settings.Default.Relay2_IsOn == false)
            {
                btn_Power2.Image = Resources.btn_PowerOFF;
            }
            else
            {
                btn_Power2.Image = Resources.btn_PowerON;
            }

            if (Settings.Default.Relay3_IsOn == false)
            {
                btn_Power3.Image = Resources.btn_PowerOFF;
            }
            else
            {
                btn_Power3.Image = Resources.btn_PowerON;
            }

            if (Settings.Default.Relay4_IsOn == false)
            {
                btn_Power4.Image = Resources.btn_PowerOFF;
            }
            else
            {
                btn_Power4.Image = Resources.btn_PowerON;
            }

            if (Settings.Default.Relay1_Pin == 0)
            { comboBox1.SelectedItem = "Pin0"; }
            if (Settings.Default.Relay1_Pin == 1)
            { comboBox1.SelectedItem = "Pin1"; }
            if (Settings.Default.Relay1_Pin == 2)
            { comboBox1.SelectedItem = "Pin2"; }
            if (Settings.Default.Relay1_Pin == 3)
            { comboBox1.SelectedItem = "Pin3"; }
            if (Settings.Default.Relay1_Pin == 4)
            { comboBox1.SelectedItem = "Pin4"; }
            if (Settings.Default.Relay1_Pin == 5)
            { comboBox1.SelectedItem = "Pin5"; }
            if (Settings.Default.Relay1_Pin == 6)
            { comboBox1.SelectedItem = "Pin6"; }
            if (Settings.Default.Relay1_Pin == 7)
            { comboBox1.SelectedItem = "Pin7"; }
            if (Settings.Default.Relay1_Pin == 8)
            { comboBox1.SelectedItem = "Pin8"; }
            if (Settings.Default.Relay1_Pin == 9)
            { comboBox1.SelectedItem = "Pin9"; }
            if (Settings.Default.Relay1_Pin == 10)
            { comboBox1.SelectedItem = "Pin10"; }
            if (Settings.Default.Relay1_Pin == 11)
            { comboBox1.SelectedItem = "Pin11"; }
            if (Settings.Default.Relay1_Pin == 12)
            { comboBox1.SelectedItem = "Pin12"; }
            if (Settings.Default.Relay1_Pin == 13)
            { comboBox1.SelectedItem = "Pin13"; }

            if (Settings.Default.Relay2_Pin == 0)
            { comboBox2.SelectedItem = "Pin0"; }
            if (Settings.Default.Relay2_Pin == 1)
            { comboBox2.SelectedItem = "Pin1"; }
            if (Settings.Default.Relay2_Pin == 2)
            { comboBox2.SelectedItem = "Pin2"; }
            if (Settings.Default.Relay2_Pin == 3)
            { comboBox2.SelectedItem = "Pin3"; }
            if (Settings.Default.Relay2_Pin == 4)
            { comboBox2.SelectedItem = "Pin4"; }
            if (Settings.Default.Relay2_Pin == 5)
            { comboBox2.SelectedItem = "Pin5"; }
            if (Settings.Default.Relay2_Pin == 6)
            { comboBox2.SelectedItem = "Pin6"; }
            if (Settings.Default.Relay2_Pin == 7)
            { comboBox2.SelectedItem = "Pin7"; }
            if (Settings.Default.Relay2_Pin == 8)
            { comboBox2.SelectedItem = "Pin8"; }
            if (Settings.Default.Relay2_Pin == 9)
            { comboBox2.SelectedItem = "Pin9"; }
            if (Settings.Default.Relay2_Pin == 10)
            { comboBox2.SelectedItem = "Pin10"; }
            if (Settings.Default.Relay2_Pin == 11)
            { comboBox2.SelectedItem = "Pin11"; }
            if (Settings.Default.Relay2_Pin == 12)
            { comboBox2.SelectedItem = "Pin12"; }
            if (Settings.Default.Relay2_Pin == 13)
            { comboBox2.SelectedItem = "Pin13"; }

            if (Settings.Default.Relay3_Pin == 0)
            { comboBox3.SelectedItem = "Pin0"; }
            if (Settings.Default.Relay3_Pin == 1)
            { comboBox3.SelectedItem = "Pin1"; }
            if (Settings.Default.Relay3_Pin == 2)
            { comboBox3.SelectedItem = "Pin2"; }
            if (Settings.Default.Relay3_Pin == 3)
            { comboBox3.SelectedItem = "Pin3"; }
            if (Settings.Default.Relay3_Pin == 4)
            { comboBox3.SelectedItem = "Pin4"; }
            if (Settings.Default.Relay3_Pin == 5)
            { comboBox3.SelectedItem = "Pin5"; }
            if (Settings.Default.Relay3_Pin == 6)
            { comboBox3.SelectedItem = "Pin6"; }
            if (Settings.Default.Relay3_Pin == 7)
            { comboBox3.SelectedItem = "Pin7"; }
            if (Settings.Default.Relay3_Pin == 8)
            { comboBox3.SelectedItem = "Pin8"; }
            if (Settings.Default.Relay3_Pin == 9)
            { comboBox3.SelectedItem = "Pin9"; }
            if (Settings.Default.Relay3_Pin == 10)
            { comboBox3.SelectedItem = "Pin10"; }
            if (Settings.Default.Relay3_Pin == 11)
            { comboBox3.SelectedItem = "Pin11"; }
            if (Settings.Default.Relay3_Pin == 12)
            { comboBox3.SelectedItem = "Pin12"; }
            if (Settings.Default.Relay3_Pin == 13)
            { comboBox3.SelectedItem = "Pin13"; }

            if (Settings.Default.Relay4_Pin == 0)
            { comboBox4.SelectedItem = "Pin0"; }
            if (Settings.Default.Relay4_Pin == 1)
            { comboBox4.SelectedItem = "Pin1"; }
            if (Settings.Default.Relay4_Pin == 2)
            { comboBox4.SelectedItem = "Pin2"; }
            if (Settings.Default.Relay4_Pin == 3)
            { comboBox4.SelectedItem = "Pin3"; }
            if (Settings.Default.Relay4_Pin == 4)
            { comboBox4.SelectedItem = "Pin4"; }
            if (Settings.Default.Relay4_Pin == 5)
            { comboBox4.SelectedItem = "Pin5"; }
            if (Settings.Default.Relay4_Pin == 6)
            { comboBox4.SelectedItem = "Pin6"; }
            if (Settings.Default.Relay4_Pin == 7)
            { comboBox4.SelectedItem = "Pin7"; }
            if (Settings.Default.Relay4_Pin == 8)
            { comboBox4.SelectedItem = "Pin8"; }
            if (Settings.Default.Relay4_Pin == 9)
            { comboBox4.SelectedItem = "Pin9"; }
            if (Settings.Default.Relay4_Pin == 10)
            { comboBox4.SelectedItem = "Pin10"; }
            if (Settings.Default.Relay4_Pin == 11)
            { comboBox4.SelectedItem = "Pin11"; }
            if (Settings.Default.Relay4_Pin == 12)
            { comboBox4.SelectedItem = "Pin12"; }
            if (Settings.Default.Relay4_Pin == 13)
            { comboBox4.SelectedItem = "Pin13"; }

            if (Settings.Default.TTS_IsOn == false)
            { btn_Sound.Image = Resources.btn_SpeakerOFF; }
            if (Settings.Default.TTS_IsOn == true)
            { btn_Sound.Image = Resources.btn_SpeakerON; }

            Relay1_textBox.Text = Settings.Default.Relay1_Text;
            Relay2_textBox.Text = Settings.Default.Relay2_Text;
            Relay3_textBox.Text = Settings.Default.Relay3_Text;
            Relay4_textBox.Text = Settings.Default.Relay4_Text;

            Info_textBox.Text = "Started";
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form4_FormClosing;

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Relay1_Text = Relay1_textBox.Text;
            Settings.Default.Relay2_Text = Relay2_textBox.Text;
            Settings.Default.Relay3_Text = Relay3_textBox.Text;
            Settings.Default.Relay4_Text = Relay4_textBox.Text;
            Settings.Default.Save();
            arduino.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Settings.Default.Relay1_Pin = 0;          
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Settings.Default.Relay1_Pin = 1;               
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Settings.Default.Relay1_Pin = 2;               
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Settings.Default.Relay1_Pin = 3;                
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Settings.Default.Relay1_Pin = 4;                
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Settings.Default.Relay1_Pin = 5;                
            }
            if (comboBox1.SelectedIndex == 6)
            {
                Settings.Default.Relay1_Pin = 6;                
            }
            if (comboBox1.SelectedIndex == 7)
            {
                Settings.Default.Relay1_Pin = 7;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                Settings.Default.Relay1_Pin = 8;                
            }
            if (comboBox1.SelectedIndex == 9)
            {
                Settings.Default.Relay1_Pin = 9;                
            }
            if (comboBox1.SelectedIndex == 10)
            {
                Settings.Default.Relay1_Pin = 10;               
            }
            if (comboBox1.SelectedIndex == 11)
            {
                Settings.Default.Relay1_Pin = 11;
            }
            if (comboBox1.SelectedIndex == 12)
            {
                Settings.Default.Relay1_Pin = 12;               
            }
            if (comboBox1.SelectedIndex == 13)
            {
                Settings.Default.Relay1_Pin = 13;               
            }
        }   
          
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Settings.Default.Relay2_Pin = 0;               
            }
            if (comboBox2.SelectedIndex == 1)
            {
                Settings.Default.Relay2_Pin = 1;                
            }
            if (comboBox2.SelectedIndex == 2)
            {
                Settings.Default.Relay2_Pin = 2;               
            }
            if (comboBox2.SelectedIndex == 3)
            {
                Settings.Default.Relay2_Pin = 3;                
            }
            if (comboBox2.SelectedIndex == 4)
            {
                Settings.Default.Relay2_Pin = 4;               
            }
            if (comboBox2.SelectedIndex == 5)
            {
                Settings.Default.Relay2_Pin = 5;               
            }
            if (comboBox2.SelectedIndex == 6)
            {
                Settings.Default.Relay2_Pin = 6;               
            }
            if (comboBox2.SelectedIndex == 7)
            {
                Settings.Default.Relay2_Pin = 7;               
            }
            if (comboBox2.SelectedIndex == 8)
            {
                Settings.Default.Relay2_Pin = 8;            
            }
            if (comboBox2.SelectedIndex == 9)
            {
                Settings.Default.Relay2_Pin = 9;                
            }
            if (comboBox2.SelectedIndex == 10)
            {
                Settings.Default.Relay2_Pin = 10;                
            }
            if (comboBox2.SelectedIndex == 11)
            {
                Settings.Default.Relay2_Pin = 11;                
            }
            if (comboBox2.SelectedIndex == 12)
            {
                Settings.Default.Relay2_Pin = 12;               
            }
            if (comboBox2.SelectedIndex == 13)
            {
                Settings.Default.Relay2_Pin = 13;                
            }
        }   

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                Settings.Default.Relay3_Pin = 0;                
            }
            if (comboBox3.SelectedIndex == 1)
            {
                Settings.Default.Relay3_Pin = 1;                
            }
            if (comboBox3.SelectedIndex == 2)
            {
                Settings.Default.Relay3_Pin = 2;                
            }
            if (comboBox3.SelectedIndex == 3)
            {
                Settings.Default.Relay3_Pin = 3;                
            }
            if (comboBox3.SelectedIndex == 4)
            {
                Settings.Default.Relay3_Pin = 4;                
            }
            if (comboBox3.SelectedIndex == 5)
            {
                Settings.Default.Relay3_Pin = 5;               
            }
            if (comboBox3.SelectedIndex == 6)
            {
                Settings.Default.Relay3_Pin = 6;                
            }
            if (comboBox3.SelectedIndex == 7)
            {
                Settings.Default.Relay3_Pin = 7;                
            }
            if (comboBox3.SelectedIndex == 8)
            {
                Settings.Default.Relay3_Pin = 8;                
            }
            if (comboBox3.SelectedIndex == 9)
            {
                Settings.Default.Relay3_Pin = 9;                
            }
            if (comboBox3.SelectedIndex == 10)
            {
                Settings.Default.Relay3_Pin = 10;                
            }
            if (comboBox3.SelectedIndex == 11)
            {
                Settings.Default.Relay3_Pin = 11;                
            }
            if (comboBox3.SelectedIndex == 12)
            {
                Settings.Default.Relay3_Pin = 12;               
            }
            if (comboBox3.SelectedIndex == 13)
            {
                Settings.Default.Relay3_Pin = 13;               
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Settings.Default.Relay4_Pin = 0;               
            }
            if (comboBox4.SelectedIndex == 1)
            {
                Settings.Default.Relay4_Pin = 1;                
            }
            if (comboBox4.SelectedIndex == 2)
            {
                Settings.Default.Relay4_Pin = 2;
            }
            if (comboBox4.SelectedIndex == 3)
            {
                Settings.Default.Relay4_Pin = 3;               
            }
            if (comboBox4.SelectedIndex == 4)
            {
                Settings.Default.Relay4_Pin = 4;              
            }
            if (comboBox4.SelectedIndex == 5)
            {
                Settings.Default.Relay4_Pin = 5;               
            }
            if (comboBox4.SelectedIndex == 6)
            {
                Settings.Default.Relay4_Pin = 6;               
            }
            if (comboBox4.SelectedIndex == 7)
            {
                Settings.Default.Relay4_Pin = 7;                
            }
            if (comboBox4.SelectedIndex == 8)
            {
                Settings.Default.Relay4_Pin = 8;               
            }
            if (comboBox4.SelectedIndex == 9)
            {
                Settings.Default.Relay4_Pin = 9;                
            }
            if (comboBox4.SelectedIndex == 10)
            {
                Settings.Default.Relay4_Pin = 10;               
            }
            if (comboBox4.SelectedIndex == 11)
            {
                Settings.Default.Relay4_Pin = 11;                
            }
            if (comboBox4.SelectedIndex == 12)
            {
                Settings.Default.Relay4_Pin = 12;                
            }
            if (comboBox4.SelectedIndex == 13)
            {
                Settings.Default.Relay4_Pin = 13;               
            }
        }

        private String TTS_Text;

        private void PlayTTS()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer
            {
                Volume = Settings.Default.speechVolume,
                Rate = Settings.Default.speechRate
            })
            {
                synth.SelectVoice(Settings.Default.SelectedVoice);
                synth.Speak(TTS_Text);
            }
        }

        private void btn_Power1_Click(object sender, EventArgs e)
        {

            if (Settings.Default.Relay1_IsOn == false)
            {
                arduino.pinMode(Settings.Default.Relay1_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay1_Pin, Arduino.HIGH);
                Info_textBox.Text = Relay1_textBox.Text + " Is ON";
                TTS_Text = Info_textBox.Text;
                btn_Power1.Image = Resources.btn_PowerON;
                Settings.Default.Relay1_IsOn = true;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }

           else
            {
                arduino.pinMode(Settings.Default.Relay1_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay1_Pin, Arduino.LOW);
                Info_textBox.Text = Relay1_textBox.Text + " Is OFF";
                TTS_Text = Info_textBox.Text;
                btn_Power1.Image = Resources.btn_PowerOFF;
                Settings.Default.Relay1_IsOn = false;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
        }

        private void btn_Power2_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Relay2_IsOn == false)
            {
                arduino.pinMode(Settings.Default.Relay2_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay2_Pin, Arduino.HIGH);
                Info_textBox.Text = Relay2_textBox.Text + " Is ON";
                TTS_Text = Info_textBox.Text;
                btn_Power2.Image = Resources.btn_PowerON;
                Settings.Default.Relay2_IsOn = true;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
          else
            {
                arduino.pinMode(Settings.Default.Relay2_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay2_Pin, Arduino.LOW);
                Info_textBox.Text = Relay2_textBox.Text + " Is OFF";
                TTS_Text = Info_textBox.Text;
                btn_Power2.Image = Resources.btn_PowerOFF;
                Settings.Default.Relay2_IsOn = false;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
        }

        private void btn_Power3_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Relay3_IsOn == false)
            {
                arduino.pinMode(Settings.Default.Relay3_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay3_Pin, Arduino.HIGH);
                Info_textBox.Text = Relay3_textBox.Text + " Is ON";
                TTS_Text = Info_textBox.Text;
                btn_Power3.Image = Resources.btn_PowerON;
                Settings.Default.Relay3_IsOn = true;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
            else
            {
                arduino.pinMode(Settings.Default.Relay3_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay3_Pin, Arduino.LOW);
                Info_textBox.Text = Relay3_textBox.Text + " Is OFF";
                TTS_Text = Info_textBox.Text;
                btn_Power3.Image = Resources.btn_PowerOFF;
                Settings.Default.Relay3_IsOn = false;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
        }

        private void btn_Power4_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Relay4_IsOn == false)
            {
                arduino.pinMode(Settings.Default.Relay4_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay4_Pin, Arduino.HIGH);
                Info_textBox.Text = Relay4_textBox.Text + " Is ON";
                TTS_Text = Info_textBox.Text;
                btn_Power4.Image = Resources.btn_PowerON;
                Settings.Default.Relay4_IsOn = true;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
            else
            {
                arduino.pinMode(Settings.Default.Relay4_Pin, Arduino.OUTPUT);
                arduino.digitalWrite(Settings.Default.Relay4_Pin, Arduino.LOW);
                Info_textBox.Text = Relay4_textBox.Text + " Is OFF";
                TTS_Text = Info_textBox.Text;
                btn_Power4.Image = Resources.btn_PowerOFF;
                Settings.Default.Relay4_IsOn = false;

                if (Settings.Default.TTS_IsOn == true & Settings.Default.TTS_Setup == true)
                {
                    System.Threading.Thread TTS;
                    TTS = new System.Threading.Thread(PlayTTS);
                    TTS.Start();
                }
            }
        }

        private void btn_Sound_Click(object sender, EventArgs e)
        {
            if (Settings.Default.TTS_Setup == true)
            {
                if (Settings.Default.TTS_IsOn == false)
                {
                    btn_Sound.Image = Resources.btn_SpeakerON;
                    Settings.Default.TTS_IsOn = true;
                }
                else
                {
                    btn_Sound.Image = Resources.btn_SpeakerOFF;
                    Settings.Default.TTS_IsOn = false;
                }
            }
            else
            {
                Form6 frm6 = new Form6();
                frm6.ShowDialog();
            }
        }

        private void btn_VoiceSetup_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void btn_RelaySetup_Click(object sender, EventArgs e)
        {
            arduino.Close();
            this.FormClosing -= Form4_FormClosing;
            Settings.Default.Relay1_Text = Relay1_textBox.Text;
            Settings.Default.Relay2_Text = Relay2_textBox.Text;
            Settings.Default.Relay3_Text = Relay3_textBox.Text;
            Settings.Default.Relay4_Text = Relay4_textBox.Text;
            Settings.Default.Save();
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void pictureBoxLP_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.lattepanda.com");
        }

    }
}