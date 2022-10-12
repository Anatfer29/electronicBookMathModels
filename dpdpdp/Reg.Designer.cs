namespace dpdpdp
{
    partial class Reg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.usersDBDataSet1 = new dpdpdp.usersDBDataSet();
            this.usersTableAdapter1 = new dpdpdp.usersDBDataSetTableAdapters.usersTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbMid = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnAcceptCode = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbRePass = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSur = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDBDataSet1
            // 
            this.usersDBDataSet1.DataSetName = "usersDBDataSet";
            this.usersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(43, 225);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 1);
            this.panel8.TabIndex = 53;
            // 
            // mtbPhone
            // 
            this.mtbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPhone.ForeColor = System.Drawing.Color.White;
            this.mtbPhone.Location = new System.Drawing.Point(39, 206);
            this.mtbPhone.Mask = "+7 (999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(262, 28);
            this.mtbPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "Телефон:";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnEnter.Location = new System.Drawing.Point(39, 610);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(275, 45);
            this.btnEnter.TabIndex = 54;
            this.btnEnter.Text = "Авторизоваться";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(39, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 1);
            this.panel7.TabIndex = 51;
            // 
            // tbMid
            // 
            this.tbMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbMid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMid.ForeColor = System.Drawing.Color.White;
            this.tbMid.Location = new System.Drawing.Point(39, 134);
            this.tbMid.Name = "tbMid";
            this.tbMid.Size = new System.Drawing.Size(275, 28);
            this.tbMid.TabIndex = 3;
            this.tbMid.Text = "Отчество";
            this.tbMid.Enter += new System.EventHandler(this.tbCLick);
            this.tbMid.Leave += new System.EventHandler(this.tbLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(39, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 1);
            this.panel6.TabIndex = 47;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(39, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 28);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Имя*";
            this.tbName.Enter += new System.EventHandler(this.tbCLick);
            this.tbName.Leave += new System.EventHandler(this.tbLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 52;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblError.Location = new System.Drawing.Point(25, 485);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 22);
            this.lblError.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(39, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 1);
            this.panel5.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(39, 420);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(39, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(39, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 1);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(39, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1);
            this.panel1.TabIndex = 42;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(39, 284);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(275, 32);
            this.btnSendCode.TabIndex = 6;
            this.btnSendCode.Text = "Отправить код";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.ForeColor = System.Drawing.Color.White;
            this.tbCode.Location = new System.Drawing.Point(39, 336);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(145, 28);
            this.tbCode.TabIndex = 7;
            this.tbCode.Text = "Код*";
            this.tbCode.Enter += new System.EventHandler(this.tbCLick);
            this.tbCode.Leave += new System.EventHandler(this.tbLeave);
            // 
            // btnAcceptCode
            // 
            this.btnAcceptCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAcceptCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptCode.ForeColor = System.Drawing.Color.White;
            this.btnAcceptCode.Location = new System.Drawing.Point(190, 336);
            this.btnAcceptCode.Name = "btnAcceptCode";
            this.btnAcceptCode.Size = new System.Drawing.Size(124, 29);
            this.btnAcceptCode.TabIndex = 8;
            this.btnAcceptCode.Text = "Подтвердить";
            this.btnAcceptCode.UseVisualStyleBackColor = false;
            this.btnAcceptCode.Click += new System.EventHandler(this.btnAcceptCode_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnReg.Location = new System.Drawing.Point(39, 550);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(275, 45);
            this.btnReg.TabIndex = 38;
            this.btnReg.Text = "Зарегестрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbRePass
            // 
            this.tbRePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbRePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRePass.ForeColor = System.Drawing.Color.White;
            this.tbRePass.Location = new System.Drawing.Point(39, 451);
            this.tbRePass.Name = "tbRePass";
            this.tbRePass.Size = new System.Drawing.Size(246, 28);
            this.tbRePass.TabIndex = 10;
            this.tbRePass.Text = "Подтверждение пароля*";
            this.tbRePass.Click += new System.EventHandler(this.tbCLick);
            this.tbRePass.Enter += new System.EventHandler(this.tbCLick);
            this.tbRePass.Leave += new System.EventHandler(this.tbLeave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(39, 396);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(246, 28);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "Пароль*";
            this.tbPassword.Click += new System.EventHandler(this.tbCLick);
            this.tbPassword.Enter += new System.EventHandler(this.tbCLick);
            this.tbPassword.Leave += new System.EventHandler(this.tbLeave);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(39, 245);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(275, 28);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "Email*";
            this.tbEmail.Enter += new System.EventHandler(this.tbCLick);
            this.tbEmail.Leave += new System.EventHandler(this.tbLeave);
            // 
            // tbSur
            // 
            this.tbSur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbSur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSur.ForeColor = System.Drawing.Color.White;
            this.tbSur.Location = new System.Drawing.Point(39, 43);
            this.tbSur.Name = "tbSur";
            this.tbSur.Size = new System.Drawing.Size(275, 28);
            this.tbSur.TabIndex = 1;
            this.tbSur.Text = "Фамилия*";
            this.tbSur.Click += new System.EventHandler(this.tbCLick);
            this.tbSur.Leave += new System.EventHandler(this.tbLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(333, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 29);
            this.lblClose.TabIndex = 57;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHide.ForeColor = System.Drawing.Color.White;
            this.lblHide.Location = new System.Drawing.Point(312, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(26, 29);
            this.lblHide.TabIndex = 58;
            this.lblHide.Text = "_";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(358, 698);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tbMid);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnAcceptCode);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbRePass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSur);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reg_FormClosing);
            this.Load += new System.EventHandler(this.Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private usersDBDataSet usersDBDataSet1;
        private usersDBDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbMid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnAcceptCode;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbRePass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblHide;
    }
}