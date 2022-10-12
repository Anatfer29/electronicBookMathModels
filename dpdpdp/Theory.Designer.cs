namespace dpdpdp
{
    partial class Theory
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
            this.tcTheory = new MetroFramework.Controls.MetroTabControl();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditSpeecher = new System.Windows.Forms.Button();
            this.lblSpeech = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTheory
            // 
            this.tcTheory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTheory.Location = new System.Drawing.Point(0, 0);
            this.tcTheory.Margin = new System.Windows.Forms.Padding(5);
            this.tcTheory.Name = "tcTheory";
            this.tcTheory.Size = new System.Drawing.Size(899, 540);
            this.tcTheory.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcTheory.TabIndex = 0;
            this.tcTheory.SelectedIndexChanged += new System.EventHandler(this.tcTheory_SelectedIndexChanged);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeech.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeech.Location = new System.Drawing.Point(607, 5);
            this.btnSpeech.Margin = new System.Windows.Forms.Padding(5);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(287, 43);
            this.btnSpeech.TabIndex = 3;
            this.btnSpeech.Text = "Озвучить теорию";
            this.btnSpeech.UseVisualStyleBackColor = false;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnEditSpeecher, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSpeech, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSpeech, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 487);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 53);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnEditSpeecher
            // 
            this.btnEditSpeecher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSpeecher.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSpeecher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSpeecher.Location = new System.Drawing.Point(5, 5);
            this.btnEditSpeecher.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditSpeecher.Name = "btnEditSpeecher";
            this.btnEditSpeecher.Size = new System.Drawing.Size(287, 43);
            this.btnEditSpeecher.TabIndex = 5;
            this.btnEditSpeecher.Text = "Настроить диктора";
            this.btnEditSpeecher.UseVisualStyleBackColor = false;
            this.btnEditSpeecher.Click += new System.EventHandler(this.btnEditSpeecher_Click);
            // 
            // lblSpeech
            // 
            this.lblSpeech.AutoSize = true;
            this.lblSpeech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpeech.Location = new System.Drawing.Point(300, 0);
            this.lblSpeech.Name = "lblSpeech";
            this.lblSpeech.Size = new System.Drawing.Size(299, 53);
            this.lblSpeech.TabIndex = 6;
            this.lblSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tcTheory);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Theory";
            this.Text = "Теория";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Theory_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcTheory;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEditSpeecher;
        private System.Windows.Forms.Label lblSpeech;
    }
}