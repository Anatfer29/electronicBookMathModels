namespace dpdpdp
{
    partial class Interactive
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
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.pbMulti = new System.Windows.Forms.PictureBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.btnMultiMatrix = new System.Windows.Forms.Button();
            this.btnMatrixB = new System.Windows.Forms.Button();
            this.btnMatrixA = new System.Windows.Forms.Button();
            this.lblMulti = new System.Windows.Forms.Label();
            this.gbAdaptive = new System.Windows.Forms.GroupBox();
            this.pbInverse = new System.Windows.Forms.PictureBox();
            this.lblAdaptive = new System.Windows.Forms.Label();
            this.btnAdaptiveMatrix = new System.Windows.Forms.Button();
            this.btnReadAdaptive = new System.Windows.Forms.Button();
            this.lblSaveAdapt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbOnNum = new System.Windows.Forms.PictureBox();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnMatrixOnNum = new System.Windows.Forms.Button();
            this.btnMatrixANum = new System.Windows.Forms.Button();
            this.lblNumRez = new System.Windows.Forms.Label();
            this.cbParallel = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbDeter = new System.Windows.Forms.PictureBox();
            this.lblROpred = new System.Windows.Forms.Label();
            this.btnSaveOpred = new System.Windows.Forms.Button();
            this.btnOpred = new System.Windows.Forms.Button();
            this.lblOpred = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbTrans = new System.Windows.Forms.PictureBox();
            this.lblReadTrans = new System.Windows.Forms.Label();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnTransMatrix = new System.Windows.Forms.Button();
            this.lblSaveTrans = new System.Windows.Forms.Label();
            this.tpMultiply = new MetroFramework.Components.MetroToolTip();
            this.tpInverse = new MetroFramework.Components.MetroToolTip();
            this.tpNum = new MetroFramework.Components.MetroToolTip();
            this.tpDeter = new MetroFramework.Components.MetroToolTip();
            this.tpTrans = new MetroFramework.Components.MetroToolTip();
            this.gbMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMulti)).BeginInit();
            this.gbAdaptive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInverse)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeter)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMail
            // 
            this.gbMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbMail.BackColor = System.Drawing.Color.Transparent;
            this.gbMail.Controls.Add(this.pbMulti);
            this.gbMail.Controls.Add(this.lblB);
            this.gbMail.Controls.Add(this.lblA);
            this.gbMail.Controls.Add(this.btnMultiMatrix);
            this.gbMail.Controls.Add(this.btnMatrixB);
            this.gbMail.Controls.Add(this.btnMatrixA);
            this.gbMail.ForeColor = System.Drawing.Color.Black;
            this.gbMail.Location = new System.Drawing.Point(128, 62);
            this.gbMail.Name = "gbMail";
            this.gbMail.Size = new System.Drawing.Size(594, 114);
            this.gbMail.TabIndex = 1;
            this.gbMail.TabStop = false;
            this.gbMail.Text = "Перемножение матриц";
            // 
            // pbMulti
            // 
            this.pbMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMulti.Image = global::dpdpdp.Properties.Resources.about;
            this.pbMulti.Location = new System.Drawing.Point(565, 12);
            this.pbMulti.Name = "pbMulti";
            this.pbMulti.Size = new System.Drawing.Size(29, 23);
            this.pbMulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMulti.TabIndex = 10;
            this.pbMulti.TabStop = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.Location = new System.Drawing.Point(214, 80);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 15);
            this.lblB.TabIndex = 4;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.Location = new System.Drawing.Point(25, 80);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 15);
            this.lblA.TabIndex = 3;
            // 
            // btnMultiMatrix
            // 
            this.btnMultiMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiMatrix.Location = new System.Drawing.Point(421, 38);
            this.btnMultiMatrix.Name = "btnMultiMatrix";
            this.btnMultiMatrix.Size = new System.Drawing.Size(115, 35);
            this.btnMultiMatrix.TabIndex = 2;
            this.btnMultiMatrix.Text = "Сохранить";
            this.btnMultiMatrix.UseVisualStyleBackColor = true;
            this.btnMultiMatrix.Click += new System.EventHandler(this.btnMultiMatrix_Click);
            // 
            // btnMatrixB
            // 
            this.btnMatrixB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixB.Location = new System.Drawing.Point(217, 38);
            this.btnMatrixB.Name = "btnMatrixB";
            this.btnMatrixB.Size = new System.Drawing.Size(115, 35);
            this.btnMatrixB.TabIndex = 1;
            this.btnMatrixB.Text = "Матрица B";
            this.btnMatrixB.UseVisualStyleBackColor = true;
            this.btnMatrixB.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // btnMatrixA
            // 
            this.btnMatrixA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixA.Location = new System.Drawing.Point(28, 38);
            this.btnMatrixA.Name = "btnMatrixA";
            this.btnMatrixA.Size = new System.Drawing.Size(115, 35);
            this.btnMatrixA.TabIndex = 0;
            this.btnMatrixA.Text = "Матрица А";
            this.btnMatrixA.UseVisualStyleBackColor = true;
            this.btnMatrixA.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // lblMulti
            // 
            this.lblMulti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMulti.AutoSize = true;
            this.lblMulti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMulti.Location = new System.Drawing.Point(407, 183);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(0, 19);
            this.lblMulti.TabIndex = 5;
            // 
            // gbAdaptive
            // 
            this.gbAdaptive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdaptive.BackColor = System.Drawing.Color.Transparent;
            this.gbAdaptive.Controls.Add(this.pbInverse);
            this.gbAdaptive.Controls.Add(this.lblAdaptive);
            this.gbAdaptive.Controls.Add(this.btnAdaptiveMatrix);
            this.gbAdaptive.Controls.Add(this.btnReadAdaptive);
            this.gbAdaptive.ForeColor = System.Drawing.Color.Black;
            this.gbAdaptive.Location = new System.Drawing.Point(128, 251);
            this.gbAdaptive.Name = "gbAdaptive";
            this.gbAdaptive.Size = new System.Drawing.Size(594, 114);
            this.gbAdaptive.TabIndex = 6;
            this.gbAdaptive.TabStop = false;
            this.gbAdaptive.Text = "Поиск обратной матрицы";
            // 
            // pbInverse
            // 
            this.pbInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInverse.Image = global::dpdpdp.Properties.Resources.about;
            this.pbInverse.Location = new System.Drawing.Point(565, 12);
            this.pbInverse.Name = "pbInverse";
            this.pbInverse.Size = new System.Drawing.Size(29, 23);
            this.pbInverse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInverse.TabIndex = 11;
            this.pbInverse.TabStop = false;
            // 
            // lblAdaptive
            // 
            this.lblAdaptive.AutoSize = true;
            this.lblAdaptive.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdaptive.Location = new System.Drawing.Point(25, 80);
            this.lblAdaptive.Name = "lblAdaptive";
            this.lblAdaptive.Size = new System.Drawing.Size(0, 15);
            this.lblAdaptive.TabIndex = 3;
            // 
            // btnAdaptiveMatrix
            // 
            this.btnAdaptiveMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaptiveMatrix.Location = new System.Drawing.Point(421, 38);
            this.btnAdaptiveMatrix.Name = "btnAdaptiveMatrix";
            this.btnAdaptiveMatrix.Size = new System.Drawing.Size(115, 35);
            this.btnAdaptiveMatrix.TabIndex = 2;
            this.btnAdaptiveMatrix.Text = "Сохранить";
            this.btnAdaptiveMatrix.UseVisualStyleBackColor = true;
            this.btnAdaptiveMatrix.Click += new System.EventHandler(this.btnAdaptiveMatrix_Click);
            // 
            // btnReadAdaptive
            // 
            this.btnReadAdaptive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadAdaptive.Location = new System.Drawing.Point(28, 38);
            this.btnReadAdaptive.Name = "btnReadAdaptive";
            this.btnReadAdaptive.Size = new System.Drawing.Size(115, 35);
            this.btnReadAdaptive.TabIndex = 0;
            this.btnReadAdaptive.Text = "Матрица А";
            this.btnReadAdaptive.UseVisualStyleBackColor = true;
            this.btnReadAdaptive.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // lblSaveAdapt
            // 
            this.lblSaveAdapt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaveAdapt.AutoSize = true;
            this.lblSaveAdapt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaveAdapt.Location = new System.Drawing.Point(125, 368);
            this.lblSaveAdapt.Name = "lblSaveAdapt";
            this.lblSaveAdapt.Size = new System.Drawing.Size(0, 19);
            this.lblSaveAdapt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbOnNum);
            this.groupBox1.Controls.Add(this.nudNum);
            this.groupBox1.Controls.Add(this.lblNum);
            this.groupBox1.Controls.Add(this.btnMatrixOnNum);
            this.groupBox1.Controls.Add(this.btnMatrixANum);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(128, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Умножение матрицы на число";
            // 
            // pbOnNum
            // 
            this.pbOnNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOnNum.Image = global::dpdpdp.Properties.Resources.about;
            this.pbOnNum.Location = new System.Drawing.Point(565, 12);
            this.pbOnNum.Name = "pbOnNum";
            this.pbOnNum.Size = new System.Drawing.Size(29, 23);
            this.pbOnNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOnNum.TabIndex = 11;
            this.pbOnNum.TabStop = false;
            // 
            // nudNum
            // 
            this.nudNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNum.Location = new System.Drawing.Point(217, 43);
            this.nudNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(115, 29);
            this.nudNum.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(25, 80);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 15);
            this.lblNum.TabIndex = 3;
            // 
            // btnMatrixOnNum
            // 
            this.btnMatrixOnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixOnNum.Location = new System.Drawing.Point(421, 37);
            this.btnMatrixOnNum.Name = "btnMatrixOnNum";
            this.btnMatrixOnNum.Size = new System.Drawing.Size(115, 35);
            this.btnMatrixOnNum.TabIndex = 2;
            this.btnMatrixOnNum.Text = "Сохранить";
            this.btnMatrixOnNum.UseVisualStyleBackColor = true;
            this.btnMatrixOnNum.Click += new System.EventHandler(this.btnMatrixOnNum_Click);
            // 
            // btnMatrixANum
            // 
            this.btnMatrixANum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixANum.Location = new System.Drawing.Point(28, 37);
            this.btnMatrixANum.Name = "btnMatrixANum";
            this.btnMatrixANum.Size = new System.Drawing.Size(115, 35);
            this.btnMatrixANum.TabIndex = 0;
            this.btnMatrixANum.Text = "Матрица А";
            this.btnMatrixANum.UseVisualStyleBackColor = true;
            this.btnMatrixANum.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // lblNumRez
            // 
            this.lblNumRez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumRez.AutoSize = true;
            this.lblNumRez.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumRez.Location = new System.Drawing.Point(125, 550);
            this.lblNumRez.Name = "lblNumRez";
            this.lblNumRez.Size = new System.Drawing.Size(0, 19);
            this.lblNumRez.TabIndex = 5;
            // 
            // cbParallel
            // 
            this.cbParallel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbParallel.AutoSize = true;
            this.cbParallel.BackColor = System.Drawing.Color.Transparent;
            this.cbParallel.Location = new System.Drawing.Point(128, 182);
            this.cbParallel.Name = "cbParallel";
            this.cbParallel.Size = new System.Drawing.Size(262, 25);
            this.cbParallel.TabIndex = 8;
            this.cbParallel.Text = "Параллельное перемножение";
            this.cbParallel.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pbDeter);
            this.groupBox2.Controls.Add(this.lblROpred);
            this.groupBox2.Controls.Add(this.btnSaveOpred);
            this.groupBox2.Controls.Add(this.btnOpred);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(128, 628);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск определителя матрицы";
            // 
            // pbDeter
            // 
            this.pbDeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeter.Image = global::dpdpdp.Properties.Resources.about;
            this.pbDeter.Location = new System.Drawing.Point(565, 12);
            this.pbDeter.Name = "pbDeter";
            this.pbDeter.Size = new System.Drawing.Size(29, 23);
            this.pbDeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeter.TabIndex = 12;
            this.pbDeter.TabStop = false;
            // 
            // lblROpred
            // 
            this.lblROpred.AutoSize = true;
            this.lblROpred.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblROpred.Location = new System.Drawing.Point(25, 80);
            this.lblROpred.Name = "lblROpred";
            this.lblROpred.Size = new System.Drawing.Size(0, 15);
            this.lblROpred.TabIndex = 3;
            // 
            // btnSaveOpred
            // 
            this.btnSaveOpred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOpred.Location = new System.Drawing.Point(421, 37);
            this.btnSaveOpred.Name = "btnSaveOpred";
            this.btnSaveOpred.Size = new System.Drawing.Size(115, 35);
            this.btnSaveOpred.TabIndex = 2;
            this.btnSaveOpred.Text = "Найти";
            this.btnSaveOpred.UseVisualStyleBackColor = true;
            this.btnSaveOpred.Click += new System.EventHandler(this.btnSaveDeterminator_Click);
            // 
            // btnOpred
            // 
            this.btnOpred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpred.Location = new System.Drawing.Point(28, 37);
            this.btnOpred.Name = "btnOpred";
            this.btnOpred.Size = new System.Drawing.Size(115, 35);
            this.btnOpred.TabIndex = 0;
            this.btnOpred.Text = "Матрица А";
            this.btnOpred.UseVisualStyleBackColor = true;
            this.btnOpred.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // lblOpred
            // 
            this.lblOpred.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOpred.AutoSize = true;
            this.lblOpred.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpred.Location = new System.Drawing.Point(125, 747);
            this.lblOpred.Name = "lblOpred";
            this.lblOpred.Size = new System.Drawing.Size(0, 19);
            this.lblOpred.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.pbTrans);
            this.groupBox3.Controls.Add(this.lblReadTrans);
            this.groupBox3.Controls.Add(this.btnTrans);
            this.groupBox3.Controls.Add(this.btnTransMatrix);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(128, 830);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 114);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск траспонированной матрицы";
            // 
            // pbTrans
            // 
            this.pbTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrans.Image = global::dpdpdp.Properties.Resources.about;
            this.pbTrans.Location = new System.Drawing.Point(565, 12);
            this.pbTrans.Name = "pbTrans";
            this.pbTrans.Size = new System.Drawing.Size(29, 23);
            this.pbTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrans.TabIndex = 13;
            this.pbTrans.TabStop = false;
            // 
            // lblReadTrans
            // 
            this.lblReadTrans.AutoSize = true;
            this.lblReadTrans.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReadTrans.Location = new System.Drawing.Point(25, 80);
            this.lblReadTrans.Name = "lblReadTrans";
            this.lblReadTrans.Size = new System.Drawing.Size(0, 15);
            this.lblReadTrans.TabIndex = 3;
            // 
            // btnTrans
            // 
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Location = new System.Drawing.Point(421, 28);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(115, 35);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "Сохранить";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnTransMatrix
            // 
            this.btnTransMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransMatrix.Location = new System.Drawing.Point(28, 28);
            this.btnTransMatrix.Name = "btnTransMatrix";
            this.btnTransMatrix.Size = new System.Drawing.Size(115, 35);
            this.btnTransMatrix.TabIndex = 0;
            this.btnTransMatrix.Text = "Матрица А";
            this.btnTransMatrix.UseVisualStyleBackColor = true;
            this.btnTransMatrix.Click += new System.EventHandler(this.btnReadMatrix);
            // 
            // lblSaveTrans
            // 
            this.lblSaveTrans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaveTrans.AutoSize = true;
            this.lblSaveTrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaveTrans.Location = new System.Drawing.Point(125, 947);
            this.lblSaveTrans.Name = "lblSaveTrans";
            this.lblSaveTrans.Size = new System.Drawing.Size(0, 19);
            this.lblSaveTrans.TabIndex = 5;
            // 
            // tpMultiply
            // 
            this.tpMultiply.AutomaticDelay = 100;
            this.tpMultiply.AutoPopDelay = 5000;
            this.tpMultiply.InitialDelay = 100;
            this.tpMultiply.ReshowDelay = 20;
            this.tpMultiply.Style = MetroFramework.MetroColorStyle.White;
            this.tpMultiply.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tpInverse
            // 
            this.tpInverse.AutomaticDelay = 100;
            this.tpInverse.AutoPopDelay = 5000;
            this.tpInverse.InitialDelay = 100;
            this.tpInverse.ReshowDelay = 20;
            this.tpInverse.Style = MetroFramework.MetroColorStyle.White;
            this.tpInverse.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tpNum
            // 
            this.tpNum.AutomaticDelay = 100;
            this.tpNum.AutoPopDelay = 5000;
            this.tpNum.InitialDelay = 100;
            this.tpNum.ReshowDelay = 20;
            this.tpNum.Style = MetroFramework.MetroColorStyle.White;
            this.tpNum.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tpDeter
            // 
            this.tpDeter.AutomaticDelay = 100;
            this.tpDeter.AutoPopDelay = 5000;
            this.tpDeter.InitialDelay = 100;
            this.tpDeter.ReshowDelay = 20;
            this.tpDeter.Style = MetroFramework.MetroColorStyle.White;
            this.tpDeter.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tpTrans
            // 
            this.tpTrans.AutomaticDelay = 100;
            this.tpTrans.AutoPopDelay = 5000;
            this.tpTrans.InitialDelay = 100;
            this.tpTrans.ReshowDelay = 20;
            this.tpTrans.Style = MetroFramework.MetroColorStyle.White;
            this.tpTrans.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Interactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 1060);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblSaveTrans);
            this.Controls.Add(this.lblOpred);
            this.Controls.Add(this.lblSaveAdapt);
            this.Controls.Add(this.lblNumRez);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbParallel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAdaptive);
            this.Controls.Add(this.gbMail);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Interactive";
            this.Text = "Интерактив";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.interactive_FormClosing);
            this.gbMail.ResumeLayout(false);
            this.gbMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMulti)).EndInit();
            this.gbAdaptive.ResumeLayout(false);
            this.gbAdaptive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInverse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnMultiMatrix;
        private System.Windows.Forms.Button btnMatrixB;
        private System.Windows.Forms.Button btnMatrixA;
        private System.Windows.Forms.GroupBox gbAdaptive;
        private System.Windows.Forms.Label lblSaveAdapt;
        private System.Windows.Forms.Label lblAdaptive;
        private System.Windows.Forms.Button btnAdaptiveMatrix;
        private System.Windows.Forms.Button btnReadAdaptive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumRez;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnMatrixOnNum;
        private System.Windows.Forms.Button btnMatrixANum;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.CheckBox cbParallel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpred;
        private System.Windows.Forms.Label lblROpred;
        private System.Windows.Forms.Button btnSaveOpred;
        private System.Windows.Forms.Button btnOpred;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSaveTrans;
        private System.Windows.Forms.Label lblReadTrans;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnTransMatrix;
        private System.Windows.Forms.PictureBox pbMulti;
        private System.Windows.Forms.PictureBox pbInverse;
        private System.Windows.Forms.PictureBox pbOnNum;
        private System.Windows.Forms.PictureBox pbDeter;
        private System.Windows.Forms.PictureBox pbTrans;
        private MetroFramework.Components.MetroToolTip tpMultiply;
        private MetroFramework.Components.MetroToolTip tpInverse;
        private MetroFramework.Components.MetroToolTip tpNum;
        private MetroFramework.Components.MetroToolTip tpDeter;
        private MetroFramework.Components.MetroToolTip tpTrans;
    }
}