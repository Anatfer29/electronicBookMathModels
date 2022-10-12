namespace dpdpdp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGameLife = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.btnEditTheory = new System.Windows.Forms.Button();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnInteractive = new System.Windows.Forms.Button();
            this.btnTesting = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCabinet = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnSpravka = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGameLife
            // 
            this.btnGameLife.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGameLife.FlatAppearance.BorderSize = 0;
            this.btnGameLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGameLife.ForeColor = System.Drawing.Color.White;
            this.btnGameLife.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameLife.Location = new System.Drawing.Point(0, 528);
            this.btnGameLife.Margin = new System.Windows.Forms.Padding(6);
            this.btnGameLife.Name = "btnGameLife";
            this.btnGameLife.Size = new System.Drawing.Size(286, 58);
            this.btnGameLife.TabIndex = 9;
            this.btnGameLife.Text = "Клеточный автомат";
            this.btnGameLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameLife.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGameLife.UseVisualStyleBackColor = true;
            this.btnGameLife.Click += new System.EventHandler(this.btnGameLife_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 470);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(286, 58);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = " Список пользователей";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.Navigate);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.btnEditTest);
            this.pnlSubMenu.Controls.Add(this.btnEditTheory);
            this.pnlSubMenu.Controls.Add(this.btnEditAdmin);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 321);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(286, 149);
            this.pnlSubMenu.TabIndex = 11;
            this.pnlSubMenu.Visible = false;
            // 
            // btnEditTest
            // 
            this.btnEditTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEditTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditTest.FlatAppearance.BorderSize = 0;
            this.btnEditTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditTest.ForeColor = System.Drawing.Color.White;
            this.btnEditTest.Location = new System.Drawing.Point(0, 100);
            this.btnEditTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditTest.Size = new System.Drawing.Size(286, 50);
            this.btnEditTest.TabIndex = 7;
            this.btnEditTest.Text = "Редактирование тестирования";
            this.btnEditTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTest.UseVisualStyleBackColor = false;
            this.btnEditTest.Click += new System.EventHandler(this.Navigate);
            // 
            // btnEditTheory
            // 
            this.btnEditTheory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEditTheory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditTheory.FlatAppearance.BorderSize = 0;
            this.btnEditTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditTheory.ForeColor = System.Drawing.Color.White;
            this.btnEditTheory.Location = new System.Drawing.Point(0, 50);
            this.btnEditTheory.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditTheory.Name = "btnEditTheory";
            this.btnEditTheory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditTheory.Size = new System.Drawing.Size(286, 50);
            this.btnEditTheory.TabIndex = 6;
            this.btnEditTheory.Text = "Редактирование теории";
            this.btnEditTheory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTheory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTheory.UseVisualStyleBackColor = false;
            this.btnEditTheory.Click += new System.EventHandler(this.Navigate);
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEditAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditAdmin.FlatAppearance.BorderSize = 0;
            this.btnEditAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditAdmin.ForeColor = System.Drawing.Color.White;
            this.btnEditAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnEditAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditAdmin.Size = new System.Drawing.Size(286, 50);
            this.btnEditAdmin.TabIndex = 5;
            this.btnEditAdmin.Text = "Редактирование профиля";
            this.btnEditAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAdmin.UseVisualStyleBackColor = false;
            this.btnEditAdmin.Click += new System.EventHandler(this.Navigate);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 263);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(286, 58);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = " Администрирование";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.ShowOrHideSet);
            // 
            // btnInteractive
            // 
            this.btnInteractive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInteractive.FlatAppearance.BorderSize = 0;
            this.btnInteractive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInteractive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInteractive.ForeColor = System.Drawing.Color.White;
            this.btnInteractive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteractive.Location = new System.Drawing.Point(0, 205);
            this.btnInteractive.Margin = new System.Windows.Forms.Padding(6);
            this.btnInteractive.Name = "btnInteractive";
            this.btnInteractive.Size = new System.Drawing.Size(286, 58);
            this.btnInteractive.TabIndex = 3;
            this.btnInteractive.Text = " Интерактив";
            this.btnInteractive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteractive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInteractive.UseVisualStyleBackColor = true;
            this.btnInteractive.Click += new System.EventHandler(this.Navigate);
            // 
            // btnTesting
            // 
            this.btnTesting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTesting.FlatAppearance.BorderSize = 0;
            this.btnTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTesting.ForeColor = System.Drawing.Color.White;
            this.btnTesting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesting.Location = new System.Drawing.Point(0, 147);
            this.btnTesting.Margin = new System.Windows.Forms.Padding(6);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(286, 58);
            this.btnTesting.TabIndex = 2;
            this.btnTesting.Text = " Тестирование";
            this.btnTesting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.Navigate);
            // 
            // btnTheory
            // 
            this.btnTheory.BackColor = System.Drawing.Color.Transparent;
            this.btnTheory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheory.FlatAppearance.BorderSize = 0;
            this.btnTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTheory.ForeColor = System.Drawing.Color.White;
            this.btnTheory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheory.Location = new System.Drawing.Point(0, 89);
            this.btnTheory.Margin = new System.Windows.Forms.Padding(6);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(286, 58);
            this.btnTheory.TabIndex = 1;
            this.btnTheory.Text = " Теория";
            this.btnTheory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheory.UseVisualStyleBackColor = false;
            this.btnTheory.Click += new System.EventHandler(this.Navigate);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCabinet);
            this.panel2.Controls.Add(this.lblCurrent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(305, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 90);
            this.panel2.TabIndex = 1;
            // 
            // btnCabinet
            // 
            this.btnCabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCabinet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(167)))), ((int)(((byte)(213)))));
            this.btnCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinet.ForeColor = System.Drawing.Color.White;
            this.btnCabinet.Location = new System.Drawing.Point(792, 28);
            this.btnCabinet.Name = "btnCabinet";
            this.btnCabinet.Size = new System.Drawing.Size(184, 33);
            this.btnCabinet.TabIndex = 13;
            this.btnCabinet.Text = "Личный кабинет";
            this.btnCabinet.UseVisualStyleBackColor = false;
            this.btnCabinet.Click += new System.EventHandler(this.Navigate);
            // 
            // lblCurrent
            // 
            this.lblCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(167)))), ((int)(((byte)(213)))));
            this.lblCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(0, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(987, 88);
            this.lblCurrent.TabIndex = 9;
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(305, 90);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(989, 623);
            this.pnlForm.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnChangeUser);
            this.pnlMenu.Controls.Add(this.btnSpravka);
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.btnGameLife);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Controls.Add(this.pnlSubMenu);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnInteractive);
            this.pnlMenu.Controls.Add(this.btnTesting);
            this.pnlMenu.Controls.Add(this.btnTheory);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(305, 713);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeUser.FlatAppearance.BorderSize = 0;
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeUser.ForeColor = System.Drawing.Color.White;
            this.btnChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUser.Location = new System.Drawing.Point(0, 702);
            this.btnChangeUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(286, 58);
            this.btnChangeUser.TabIndex = 12;
            this.btnChangeUser.Text = "Сменить пользователя";
            this.btnChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUserClick);
            // 
            // btnSpravka
            // 
            this.btnSpravka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpravka.FlatAppearance.BorderSize = 0;
            this.btnSpravka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpravka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpravka.ForeColor = System.Drawing.Color.White;
            this.btnSpravka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpravka.Location = new System.Drawing.Point(0, 644);
            this.btnSpravka.Margin = new System.Windows.Forms.Padding(6);
            this.btnSpravka.Name = "btnSpravka";
            this.btnSpravka.Size = new System.Drawing.Size(286, 58);
            this.btnSpravka.TabIndex = 11;
            this.btnSpravka.Text = "Справка";
            this.btnSpravka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpravka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpravka.UseVisualStyleBackColor = true;
            this.btnSpravka.Click += new System.EventHandler(this.Navigate);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 586);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(286, 58);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.Navigate);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 713);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1310, 752);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математическое моделирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pnlSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnInteractive;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Button btnGameLife;
        private System.Windows.Forms.Button btnCabinet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSpravka;
        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.Button btnEditTest;
        private System.Windows.Forms.Button btnEditTheory;
        private System.Windows.Forms.Button btnChangeUser;
    }
}

