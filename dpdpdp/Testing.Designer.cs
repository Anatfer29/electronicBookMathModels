namespace dpdpdp
{
    partial class Testing
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTesting = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnNextQue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlChooseTest = new System.Windows.Forms.Panel();
            this.lbTests = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.usersDBDataSet1 = new dpdpdp.usersDBDataSet();
            this.testingTableAdapter1 = new dpdpdp.usersDBDataSetTableAdapters.testingTableAdapter();
            this.pnlTesting.SuspendLayout();
            this.pnlChooseTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlTesting
            // 
            this.pnlTesting.BackColor = System.Drawing.Color.White;
            this.pnlTesting.Controls.Add(this.lblScore);
            this.pnlTesting.Controls.Add(this.btnBack);
            this.pnlTesting.Controls.Add(this.lblQuestions);
            this.pnlTesting.Controls.Add(this.btnNextQue);
            this.pnlTesting.Controls.Add(this.label1);
            this.pnlTesting.Controls.Add(this.time);
            this.pnlTesting.Controls.Add(this.statusStrip1);
            this.pnlTesting.Controls.Add(this.gbAnswers);
            this.pnlTesting.Controls.Add(this.lblQuestion);
            this.pnlTesting.Location = new System.Drawing.Point(894, 552);
            this.pnlTesting.Name = "pnlTesting";
            this.pnlTesting.Size = new System.Drawing.Size(10, 10);
            this.pnlTesting.TabIndex = 1;
            this.pnlTesting.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(3, 424);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 21);
            this.lblScore.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(7, -91);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(236, 39);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Вернуться к выбору теста";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuestions
            // 
            this.lblQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(3, -17);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(53, 21);
            this.lblQuestions.TabIndex = 27;
            this.lblQuestions.Text = "label2";
            // 
            // btnNextQue
            // 
            this.btnNextQue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQue.Location = new System.Drawing.Point(-223, -91);
            this.btnNextQue.Name = "btnNextQue";
            this.btnNextQue.Size = new System.Drawing.Size(206, 39);
            this.btnNextQue.TabIndex = 26;
            this.btnNextQue.Text = "Следующий вопрос";
            this.btnNextQue.UseVisualStyleBackColor = true;
            this.btnNextQue.Click += new System.EventHandler(this.btnNextQue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-476, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Осталось";
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.time.Location = new System.Drawing.Point(-248, -22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(245, 26);
            this.time.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Location = new System.Drawing.Point(0, -30);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(10, 40);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnswers.Location = new System.Drawing.Point(7, 224);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(0, 186);
            this.gbAnswers.TabIndex = 22;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Ответы";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(10, 168);
            this.lblQuestion.TabIndex = 21;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChooseTest
            // 
            this.pnlChooseTest.BackColor = System.Drawing.Color.White;
            this.pnlChooseTest.Controls.Add(this.lbTests);
            this.pnlChooseTest.Controls.Add(this.label3);
            this.pnlChooseTest.Controls.Add(this.label2);
            this.pnlChooseTest.Controls.Add(this.btnStart);
            this.pnlChooseTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChooseTest.Location = new System.Drawing.Point(0, 0);
            this.pnlChooseTest.Name = "pnlChooseTest";
            this.pnlChooseTest.Size = new System.Drawing.Size(896, 562);
            this.pnlChooseTest.TabIndex = 2;
            // 
            // lbTests
            // 
            this.lbTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTests.FormattingEnabled = true;
            this.lbTests.ItemHeight = 21;
            this.lbTests.Location = new System.Drawing.Point(0, 62);
            this.lbTests.Margin = new System.Windows.Forms.Padding(0);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(669, 454);
            this.lbTests.TabIndex = 11;
            this.lbTests.SelectedIndexChanged += new System.EventHandler(this.lbTests_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(669, 62);
            this.label3.TabIndex = 10;
            this.label3.Text = "Для начала тестирования выберите тест из предложенного списка и нажмите на кнопку" +
    " \"Начать тестирование\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(669, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 516);
            this.label2.TabIndex = 9;
            this.label2.Text = "Критерии оценки:\r\n5-90% правильных ответов\r\n4-75% правильных ответов\r\n3-60% прави" +
    "льных ответов\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(0, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(896, 46);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Начать тестирование";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // usersDBDataSet1
            // 
            this.usersDBDataSet1.DataSetName = "usersDBDataSet";
            this.usersDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingTableAdapter1
            // 
            this.testingTableAdapter1.ClearBeforeFill = true;
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 562);
            this.Controls.Add(this.pnlChooseTest);
            this.Controls.Add(this.pnlTesting);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Testing";
            this.Text = "Тестирование";
            this.SizeChanged += new System.EventHandler(this.Testing_SizeChanged);
            this.pnlTesting.ResumeLayout(false);
            this.pnlTesting.PerformLayout();
            this.pnlChooseTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTesting;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnNextQue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar time;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlChooseTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTests;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblScore;
        private usersDBDataSet usersDBDataSet1;
        private usersDBDataSetTableAdapters.testingTableAdapter testingTableAdapter1;
    }
}