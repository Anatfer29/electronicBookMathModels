namespace dpdpdp
{
    partial class EditTheory
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
            this.pnlChooseTheory = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTheory = new System.Windows.Forms.Button();
            this.btnDeleteTeory = new System.Windows.Forms.Button();
            this.btnEditTeory = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lbTheorys = new System.Windows.Forms.ListBox();
            this.pnlEditThory = new System.Windows.Forms.Panel();
            this.btnAddFromFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAlign = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFamily = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tbNameTheory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbTheory = new System.Windows.Forms.RichTextBox();
            this.pnlChooseTheory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlEditThory.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChooseTheory
            // 
            this.pnlChooseTheory.BackColor = System.Drawing.Color.Transparent;
            this.pnlChooseTheory.Controls.Add(this.tableLayoutPanel1);
            this.pnlChooseTheory.Controls.Add(this.lbTheorys);
            this.pnlChooseTheory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChooseTheory.Location = new System.Drawing.Point(0, 0);
            this.pnlChooseTheory.Margin = new System.Windows.Forms.Padding(5);
            this.pnlChooseTheory.Name = "pnlChooseTheory";
            this.pnlChooseTheory.Size = new System.Drawing.Size(1078, 655);
            this.pnlChooseTheory.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.40161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.59839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddTheory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTeory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditTeory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 597);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 58);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnAddTheory
            // 
            this.btnAddTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTheory.Location = new System.Drawing.Point(257, 5);
            this.btnAddTheory.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddTheory.Name = "btnAddTheory";
            this.btnAddTheory.Size = new System.Drawing.Size(237, 48);
            this.btnAddTheory.TabIndex = 10;
            this.btnAddTheory.Text = "Добавить теорию";
            this.btnAddTheory.UseVisualStyleBackColor = true;
            this.btnAddTheory.Click += new System.EventHandler(this.btnAddTheory_Click);
            // 
            // btnDeleteTeory
            // 
            this.btnDeleteTeory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTeory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeory.Location = new System.Drawing.Point(5, 5);
            this.btnDeleteTeory.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteTeory.Name = "btnDeleteTeory";
            this.btnDeleteTeory.Size = new System.Drawing.Size(242, 48);
            this.btnDeleteTeory.TabIndex = 7;
            this.btnDeleteTeory.Text = "Удалить теорию";
            this.btnDeleteTeory.UseVisualStyleBackColor = true;
            this.btnDeleteTeory.Click += new System.EventHandler(this.btnDeleteTeory_Click);
            // 
            // btnEditTeory
            // 
            this.btnEditTeory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditTeory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeory.Location = new System.Drawing.Point(825, 5);
            this.btnEditTeory.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditTeory.Name = "btnEditTeory";
            this.btnEditTeory.Size = new System.Drawing.Size(248, 48);
            this.btnEditTeory.TabIndex = 8;
            this.btnEditTeory.Text = "Редактировать теорию";
            this.btnEditTeory.UseVisualStyleBackColor = true;
            this.btnEditTeory.Click += new System.EventHandler(this.btnEditTeory_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(502, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(315, 58);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTheorys
            // 
            this.lbTheorys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTheorys.FormattingEnabled = true;
            this.lbTheorys.ItemHeight = 21;
            this.lbTheorys.Location = new System.Drawing.Point(0, 0);
            this.lbTheorys.Margin = new System.Windows.Forms.Padding(5);
            this.lbTheorys.Name = "lbTheorys";
            this.lbTheorys.Size = new System.Drawing.Size(1078, 655);
            this.lbTheorys.TabIndex = 0;
            // 
            // pnlEditThory
            // 
            this.pnlEditThory.Controls.Add(this.btnAddFromFile);
            this.pnlEditThory.Controls.Add(this.tableLayoutPanel2);
            this.pnlEditThory.Controls.Add(this.groupBox1);
            this.pnlEditThory.Controls.Add(this.btnAddImage);
            this.pnlEditThory.Controls.Add(this.lblError);
            this.pnlEditThory.Controls.Add(this.tbNameTheory);
            this.pnlEditThory.Controls.Add(this.label1);
            this.pnlEditThory.Controls.Add(this.rtbTheory);
            this.pnlEditThory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditThory.Location = new System.Drawing.Point(0, 0);
            this.pnlEditThory.Name = "pnlEditThory";
            this.pnlEditThory.Size = new System.Drawing.Size(1078, 655);
            this.pnlEditThory.TabIndex = 2;
            this.pnlEditThory.Visible = false;
            // 
            // btnAddFromFile
            // 
            this.btnAddFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFromFile.BackColor = System.Drawing.Color.White;
            this.btnAddFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFromFile.Location = new System.Drawing.Point(868, 43);
            this.btnAddFromFile.Name = "btnAddFromFile";
            this.btnAddFromFile.Size = new System.Drawing.Size(203, 29);
            this.btnAddFromFile.TabIndex = 24;
            this.btnAddFromFile.Text = "Импорт файла";
            this.btnAddFromFile.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 602);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1078, 53);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(207, 44);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(868, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 44);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbAlign);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbStyle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 111);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки текста";
            // 
            // cbAlign
            // 
            this.cbAlign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAlign.BackColor = System.Drawing.Color.White;
            this.cbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlign.FormattingEnabled = true;
            this.cbAlign.Items.AddRange(new object[] {
            "По левому краю",
            "По центру",
            "По правому краю"});
            this.cbAlign.Location = new System.Drawing.Point(439, 71);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(247, 29);
            this.cbAlign.TabIndex = 21;
            this.cbAlign.Click += new System.EventHandler(this.cbAlign_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выравнивание:";
            // 
            // cbStyle
            // 
            this.cbStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStyle.BackColor = System.Drawing.Color.White;
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Обычный",
            "Курсив",
            "Полужирный"});
            this.cbStyle.Location = new System.Drawing.Point(764, 28);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(260, 29);
            this.cbStyle.TabIndex = 19;
            this.cbStyle.Click += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Стиль текста: ";
            // 
            // nud
            // 
            this.nud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud.Location = new System.Drawing.Point(488, 29);
            this.nud.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(70, 29);
            this.nud.TabIndex = 17;
            this.nud.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Размер:";
            // 
            // cbFamily
            // 
            this.cbFamily.BackColor = System.Drawing.Color.White;
            this.cbFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamily.FormattingEnabled = true;
            this.cbFamily.Location = new System.Drawing.Point(101, 29);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(247, 29);
            this.cbFamily.TabIndex = 15;
            this.cbFamily.Click += new System.EventHandler(this.cbFamily_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Шрифт:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImage.BackColor = System.Drawing.Color.White;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Location = new System.Drawing.Point(659, 43);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(203, 29);
            this.btnAddImage.TabIndex = 20;
            this.btnAddImage.Text = "Вставить картинку";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(17, 573);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 19;
            // 
            // tbNameTheory
            // 
            this.tbNameTheory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameTheory.Location = new System.Drawing.Point(239, 43);
            this.tbNameTheory.Name = "tbNameTheory";
            this.tbNameTheory.Size = new System.Drawing.Size(402, 29);
            this.tbNameTheory.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Наименование теории:";
            // 
            // rtbTheory
            // 
            this.rtbTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTheory.BackColor = System.Drawing.Color.White;
            this.rtbTheory.Location = new System.Drawing.Point(21, 203);
            this.rtbTheory.Name = "rtbTheory";
            this.rtbTheory.Size = new System.Drawing.Size(1024, 364);
            this.rtbTheory.TabIndex = 14;
            this.rtbTheory.Text = "";
            // 
            // EditTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 655);
            this.Controls.Add(this.pnlEditThory);
            this.Controls.Add(this.pnlChooseTheory);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditTheory";
            this.Text = "Редактирование теории";
            this.pnlChooseTheory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlEditThory.ResumeLayout(false);
            this.pnlEditThory.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChooseTheory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditTeory;
        private System.Windows.Forms.Button btnDeleteTeory;
        private System.Windows.Forms.ListBox lbTheorys;
        private System.Windows.Forms.Panel pnlEditThory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAlign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNameTheory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbTheory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAddTheory;
        private System.Windows.Forms.Button btnAddFromFile;
    }
}