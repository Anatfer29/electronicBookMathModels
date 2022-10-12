namespace dpdpdp
{
    partial class EditSpeecher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSpeecher));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.nudVolume = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Голос: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Громкость голоса: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скорость голоса: ";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.White;
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(304, 46);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(222, 29);
            this.cbGender.TabIndex = 4;
            // 
            // nudRate
            // 
            this.nudRate.ForeColor = System.Drawing.Color.Black;
            this.nudRate.Location = new System.Drawing.Point(304, 144);
            this.nudRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(222, 29);
            this.nudRate.TabIndex = 7;
            this.nudRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSpeech
            // 
            this.btnSpeech.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeech.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeech.ForeColor = System.Drawing.Color.Black;
            this.btnSpeech.Location = new System.Drawing.Point(328, 201);
            this.btnSpeech.Margin = new System.Windows.Forms.Padding(5);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(198, 42);
            this.btnSpeech.TabIndex = 8;
            this.btnSpeech.Text = "Сохранить";
            this.btnSpeech.UseVisualStyleBackColor = false;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // nudVolume
            // 
            this.nudVolume.ForeColor = System.Drawing.Color.Black;
            this.nudVolume.Location = new System.Drawing.Point(304, 98);
            this.nudVolume.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudVolume.Name = "nudVolume";
            this.nudVolume.Size = new System.Drawing.Size(222, 29);
            this.nudVolume.TabIndex = 9;
            this.nudVolume.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInfo.Location = new System.Drawing.Point(27, 222);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 21);
            this.lblInfo.TabIndex = 11;
            // 
            // EditSpeecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 259);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.nudVolume);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditSpeecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка диктора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSpeecher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.NumericUpDown nudVolume;
        private System.Windows.Forms.Label lblInfo;
    }
}