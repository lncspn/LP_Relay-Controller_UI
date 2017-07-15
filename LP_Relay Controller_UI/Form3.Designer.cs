namespace LP_RC_UI
{
    partial class Form3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Info_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBoxLP = new System.Windows.Forms.PictureBox();
            this.btn_Power2 = new System.Windows.Forms.PictureBox();
            this.btn_Power1 = new System.Windows.Forms.PictureBox();
            this.Relay1_textBox = new System.Windows.Forms.TextBox();
            this.Relay2_textBox = new System.Windows.Forms.TextBox();
            this.btn_VoiceSetup = new System.Windows.Forms.Button();
            this.btn_RelaySetup = new System.Windows.Forms.Button();
            this.btn_Sound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Power2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Power1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // Info_textBox
            // 
            this.Info_textBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.Info_textBox.CausesValidation = false;
            this.Info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_textBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Info_textBox.Location = new System.Drawing.Point(29, 5);
            this.Info_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Info_textBox.Name = "Info_textBox";
            this.Info_textBox.ReadOnly = true;
            this.Info_textBox.Size = new System.Drawing.Size(262, 26);
            this.Info_textBox.TabIndex = 20;
            this.Info_textBox.TabStop = false;
            this.Info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pin0",
            "Pin1",
            "Pin2",
            "Pin3",
            "Pin4",
            "Pin5",
            "Pin6",
            "Pin7",
            "Pin8",
            "Pin9",
            "Pin10",
            "Pin11",
            "Pin12",
            "Pin13"});
            this.comboBox1.Location = new System.Drawing.Point(90, 176);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 23);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.TabStop = false;
            this.comboBox1.Tag = "Pin";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pin0",
            "Pin1",
            "Pin2",
            "Pin3",
            "Pin4",
            "Pin5",
            "Pin6",
            "Pin7",
            "Pin8",
            "Pin9",
            "Pin10",
            "Pin11",
            "Pin12",
            "Pin13"});
            this.comboBox2.Location = new System.Drawing.Point(170, 176);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 23);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.TabStop = false;
            this.comboBox2.Tag = "Pin";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBoxLP
            // 
            this.pictureBoxLP.Image = global::LP_RC_UI.Properties.Resources.Lattepanda_Banner_Logo;
            this.pictureBoxLP.Location = new System.Drawing.Point(4, 288);
            this.pictureBoxLP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLP.Name = "pictureBoxLP";
            this.pictureBoxLP.Size = new System.Drawing.Size(315, 46);
            this.pictureBoxLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLP.TabIndex = 29;
            this.pictureBoxLP.TabStop = false;
            this.pictureBoxLP.Click += new System.EventHandler(this.pictureBoxLP_Click);
            // 
            // btn_Power2
            // 
            this.btn_Power2.Image = ((System.Drawing.Image)(resources.GetObject("btn_Power2.Image")));
            this.btn_Power2.Location = new System.Drawing.Point(162, 52);
            this.btn_Power2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Power2.Name = "btn_Power2";
            this.btn_Power2.Size = new System.Drawing.Size(78, 84);
            this.btn_Power2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Power2.TabIndex = 9;
            this.btn_Power2.TabStop = false;
            this.btn_Power2.Click += new System.EventHandler(this.btn_Power2_Click);
            // 
            // btn_Power1
            // 
            this.btn_Power1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Power1.Image")));
            this.btn_Power1.Location = new System.Drawing.Point(83, 52);
            this.btn_Power1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Power1.Name = "btn_Power1";
            this.btn_Power1.Size = new System.Drawing.Size(78, 84);
            this.btn_Power1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Power1.TabIndex = 4;
            this.btn_Power1.TabStop = false;
            this.btn_Power1.Click += new System.EventHandler(this.btn_Power1_Click);
            // 
            // Relay1_textBox
            // 
            this.Relay1_textBox.Location = new System.Drawing.Point(83, 144);
            this.Relay1_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Relay1_textBox.Name = "Relay1_textBox";
            this.Relay1_textBox.Size = new System.Drawing.Size(78, 26);
            this.Relay1_textBox.TabIndex = 31;
            this.Relay1_textBox.TabStop = false;
            this.Relay1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Relay2_textBox
            // 
            this.Relay2_textBox.Location = new System.Drawing.Point(162, 144);
            this.Relay2_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Relay2_textBox.Name = "Relay2_textBox";
            this.Relay2_textBox.Size = new System.Drawing.Size(78, 26);
            this.Relay2_textBox.TabIndex = 32;
            this.Relay2_textBox.TabStop = false;
            this.Relay2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_VoiceSetup
            // 
            this.btn_VoiceSetup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_VoiceSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_VoiceSetup.Location = new System.Drawing.Point(4, 248);
            this.btn_VoiceSetup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VoiceSetup.Name = "btn_VoiceSetup";
            this.btn_VoiceSetup.Size = new System.Drawing.Size(115, 32);
            this.btn_VoiceSetup.TabIndex = 35;
            this.btn_VoiceSetup.TabStop = false;
            this.btn_VoiceSetup.Text = "Voice Setup";
            this.btn_VoiceSetup.UseVisualStyleBackColor = false;
            this.btn_VoiceSetup.Click += new System.EventHandler(this.btn_VoiceSetup_Click);
            // 
            // btn_RelaySetup
            // 
            this.btn_RelaySetup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_RelaySetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_RelaySetup.Location = new System.Drawing.Point(198, 248);
            this.btn_RelaySetup.Name = "btn_RelaySetup";
            this.btn_RelaySetup.Size = new System.Drawing.Size(115, 32);
            this.btn_RelaySetup.TabIndex = 36;
            this.btn_RelaySetup.TabStop = false;
            this.btn_RelaySetup.Text = "Relay Setup";
            this.btn_RelaySetup.UseVisualStyleBackColor = false;
            this.btn_RelaySetup.Click += new System.EventHandler(this.btn_RelaySetup_Click);
            // 
            // btn_Sound
            // 
            this.btn_Sound.Image = global::LP_RC_UI.Properties.Resources.btn_SpeakerOFF;
            this.btn_Sound.Location = new System.Drawing.Point(147, 250);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(30, 30);
            this.btn_Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Sound.TabIndex = 37;
            this.btn_Sound.TabStop = false;
            this.btn_Sound.Click += new System.EventHandler(this.btn_Sound_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 335);
            this.Controls.Add(this.btn_Sound);
            this.Controls.Add(this.btn_RelaySetup);
            this.Controls.Add(this.btn_VoiceSetup);
            this.Controls.Add(this.Relay2_textBox);
            this.Controls.Add(this.Relay1_textBox);
            this.Controls.Add(this.pictureBoxLP);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Info_textBox);
            this.Controls.Add(this.btn_Power2);
            this.Controls.Add(this.btn_Power1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "LP Relay Controller (2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Power2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Power1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Sound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Power1;
        private System.Windows.Forms.PictureBox btn_Power2;
        private System.Windows.Forms.TextBox Info_textBox;
        private System.Windows.Forms.PictureBox pictureBoxLP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox Relay1_textBox;
        private System.Windows.Forms.TextBox Relay2_textBox;
        private System.Windows.Forms.Button btn_VoiceSetup;
        private System.Windows.Forms.Button btn_RelaySetup;
        private System.Windows.Forms.PictureBox btn_Sound;
    }
}

