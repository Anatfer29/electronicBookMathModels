namespace dpdpdp
{
    partial class SendMessage
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rbAvg = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.usersDBDataSet1 = new dpdpdp.usersDBDataSet();
            this.usersTableAdapter1 = new dpdpdp.usersDBDataSetTableAdapters.usersTableAdapter();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Location = new System.Drawing.Point(369, 107);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(168, 35);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Отправить письмо";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // rbAvg
            // 
            this.rbAvg.AutoSize = true;
            this.rbAvg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAvg.Location = new System.Drawing.Point(223, 27);
            this.rbAvg.Name = "rbAvg";
            this.rbAvg.Size = new System.Drawing.Size(314, 25);
            this.rbAvg.TabIndex = 0;
            this.rbAvg.TabStop = true;
            this.rbAvg.Text = "Не набрал требуемый средний балл";
            this.rbAvg.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNo.Location = new System.Drawing.Point(223, 58);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(276, 25);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Не пройдено всё тестирование";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbYes.Location = new System.Drawing.Point(12, 27);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(141, 25);
            this.rbYes.TabIndex = 6;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Курс пройден";
            this.rbYes.UseVisualStyleBackColor = true;
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 128);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 19);
            this.lblInfo.TabIndex = 7;
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 155);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbAvg);
            this.Controls.Add(this.btnSendMessage);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SendMessage";
            this.Text = "Результат прохождения курса";
            ((System.ComponentModel.ISupportInitialize)(this.usersDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbAvg;
        private System.Windows.Forms.RadioButton rbYes;
        private usersDBDataSet usersDBDataSet1;
        private usersDBDataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label lblInfo;
    }
}