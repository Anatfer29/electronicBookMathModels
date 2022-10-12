namespace dpdpdp
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.btnAuth = new System.Windows.Forms.Button();
            this.tbPassAuth = new System.Windows.Forms.TextBox();
            this.tbMailAuth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.usersDBDataSet1 = new dpdpdp.usersDBDataSet();
            this.usersTableAdapter1 = new dpdpdp.usersDBDataSetTableAdapters.usersTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnEnterGuest = new System.Windows.Forms.Button();
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAuth.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAuth.Location = new System.Drawing.Point(46, 475);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(6);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(275, 45);
            this.btnAuth.TabIndex = 3;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // tbPassAuth
            // 
            this.tbPassAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbPassAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassAuth.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassAuth.ForeColor = System.Drawing.Color.White;
            this.tbPassAuth.Location = new System.Drawing.Point(39, 364);
            this.tbPassAuth.Margin = new System.Windows.Forms.Padding(6);
            this.tbPassAuth.Name = "tbPassAuth";
            this.tbPassAuth.Size = new System.Drawing.Size(275, 25);
            this.tbPassAuth.TabIndex = 2;
            this.tbPassAuth.Text = "Пароль";
            this.tbPassAuth.Enter += new System.EventHandler(this.tbClear);
            this.tbPassAuth.Leave += new System.EventHandler(this.tbLeave);
            // 
            // tbMailAuth
            // 
            this.tbMailAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbMailAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMailAuth.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMailAuth.ForeColor = System.Drawing.Color.White;
            this.tbMailAuth.Location = new System.Drawing.Point(39, 269);
            this.tbMailAuth.Margin = new System.Windows.Forms.Padding(6);
            this.tbMailAuth.Name = "tbMailAuth";
            this.tbMailAuth.Size = new System.Drawing.Size(275, 25);
            this.tbMailAuth.TabIndex = 1;
            this.tbMailAuth.Text = "Email";
            this.tbMailAuth.Click += new System.EventHandler(this.tbClear);
            this.tbMailAuth.Leave += new System.EventHandler(this.tbLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(39, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 1);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(39, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 1);
            this.panel2.TabIndex = 27;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnReg.Location = new System.Drawing.Point(46, 609);
            this.btnReg.Margin = new System.Windows.Forms.Padding(6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(275, 45);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Зарегестрироваться";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
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
            // usersDBDataSet1
            // 
            this.usersDBDataSet1.DataSetName = "usersDBDataSet";
            this.usersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(27, 433);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 29;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(332, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 26);
            this.lblClose.TabIndex = 30;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnEnterGuest
            // 
            this.btnEnterGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEnterGuest.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnterGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterGuest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnEnterGuest.Location = new System.Drawing.Point(46, 542);
            this.btnEnterGuest.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnterGuest.Name = "btnEnterGuest";
            this.btnEnterGuest.Size = new System.Drawing.Size(275, 45);
            this.btnEnterGuest.TabIndex = 4;
            this.btnEnterGuest.Text = "Войти как гость";
            this.btnEnterGuest.UseVisualStyleBackColor = false;
            this.btnEnterGuest.Click += new System.EventHandler(this.btnEnterGuest_Click);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHide.ForeColor = System.Drawing.Color.White;
            this.lblHide.Location = new System.Drawing.Point(311, 0);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(22, 26);
            this.lblHide.TabIndex = 32;
            this.lblHide.Text = "_";
            this.lblHide.Click += new System.EventHandler(this.lblHide_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(358, 698);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.btnEnterGuest);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.tbPassAuth);
            this.Controls.Add(this.tbMailAuth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.TextBox tbPassAuth;
        private System.Windows.Forms.TextBox tbMailAuth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private usersDBDataSet usersDBDataSet1;
        private usersDBDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnEnterGuest;
        private System.Windows.Forms.Label lblHide;
    }
}