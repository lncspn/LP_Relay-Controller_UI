namespace LP_RC_UI
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.txtTextToSpeak = new System.Windows.Forms.TextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.grpAdjustments = new System.Windows.Forms.GroupBox();
            this.ddlVoices = new System.Windows.Forms.ComboBox();
            this.lblInstalledVoices = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackBar_Rate = new System.Windows.Forms.TrackBar();
            this.lblRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAdjustments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTextToSpeak
            // 
            this.txtTextToSpeak.Location = new System.Drawing.Point(12, 12);
            this.txtTextToSpeak.Multiline = true;
            this.txtTextToSpeak.Name = "txtTextToSpeak";
            this.txtTextToSpeak.Size = new System.Drawing.Size(254, 76);
            this.txtTextToSpeak.TabIndex = 0;
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSpeak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpeak.Location = new System.Drawing.Point(97, 94);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(86, 32);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // grpAdjustments
            // 
            this.grpAdjustments.Controls.Add(this.ddlVoices);
            this.grpAdjustments.Controls.Add(this.lblInstalledVoices);
            this.grpAdjustments.Controls.Add(this.trackBar_Volume);
            this.grpAdjustments.Controls.Add(this.lblVolume);
            this.grpAdjustments.Controls.Add(this.trackBar_Rate);
            this.grpAdjustments.Controls.Add(this.lblRate);
            this.grpAdjustments.Location = new System.Drawing.Point(12, 175);
            this.grpAdjustments.Name = "grpAdjustments";
            this.grpAdjustments.Size = new System.Drawing.Size(254, 291);
            this.grpAdjustments.TabIndex = 2;
            this.grpAdjustments.TabStop = false;
            // 
            // ddlVoices
            // 
            this.ddlVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVoices.FormattingEnabled = true;
            this.ddlVoices.Location = new System.Drawing.Point(10, 225);
            this.ddlVoices.Name = "ddlVoices";
            this.ddlVoices.Size = new System.Drawing.Size(232, 28);
            this.ddlVoices.TabIndex = 5;
            this.ddlVoices.SelectedIndexChanged += new System.EventHandler(this.ddlVoices_SelectedIndexChanged);
            // 
            // lblInstalledVoices
            // 
            this.lblInstalledVoices.AutoSize = true;
            this.lblInstalledVoices.Location = new System.Drawing.Point(6, 202);
            this.lblInstalledVoices.Name = "lblInstalledVoices";
            this.lblInstalledVoices.Size = new System.Drawing.Size(121, 20);
            this.lblInstalledVoices.TabIndex = 4;
            this.lblInstalledVoices.Text = "Installed Voices";
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(10, 130);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(232, 69);
            this.trackBar_Volume.TabIndex = 3;
            this.trackBar_Volume.TabStop = false;
            this.trackBar_Volume.TickFrequency = 10;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(6, 107);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(63, 20);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "Volume";
            // 
            // trackBar_Rate
            // 
            this.trackBar_Rate.Location = new System.Drawing.Point(10, 45);
            this.trackBar_Rate.Name = "trackBar_Rate";
            this.trackBar_Rate.Size = new System.Drawing.Size(232, 69);
            this.trackBar_Rate.TabIndex = 1;
            this.trackBar_Rate.TabStop = false;
            this.trackBar_Rate.Scroll += new System.EventHandler(this.trackBar_Rate_Scroll);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(6, 22);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(44, 20);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adjustments";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(97, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAdjustments);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.txtTextToSpeak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Voice Setup";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.grpAdjustments.ResumeLayout(false);
            this.grpAdjustments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextToSpeak;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.GroupBox grpAdjustments;
        private System.Windows.Forms.ComboBox ddlVoices;
        private System.Windows.Forms.Label lblInstalledVoices;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trackBar_Rate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}