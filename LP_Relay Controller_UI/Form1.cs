using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LP_RC_UI.Properties;

namespace LP_RC_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Info_textBox.Text = "Select the number of relays";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectedForm = "Form2";
            Settings.Default.Save();
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectedForm = "Form3";
            Settings.Default.Save();
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectedForm = "Form4";
            Settings.Default.Save();
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectedForm = "Form5";
            Settings.Default.Save();
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.lattepanda.com");
        }
    }
}
