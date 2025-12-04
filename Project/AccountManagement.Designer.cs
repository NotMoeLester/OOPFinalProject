namespace Project
{
    partial class AccountManagement
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
            dataGridViewFinancialReport = new DataGridView();
            label1 = new Label();
            LabelName = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxFullyPaid = new CheckBox();
            label4 = new Label();
            checkBoxEnrolled = new CheckBox();
            checkBoxNotEnrolled = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ButtonViewRecords = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialReport).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFinancialReport
            // 
            dataGridViewFinancialReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinancialReport.Location = new Point(60, 131);
            dataGridViewFinancialReport.Name = "dataGridViewFinancialReport";
            dataGridViewFinancialReport.RowHeadersWidth = 51;
            dataGridViewFinancialReport.Size = new Size(457, 295);
            dataGridViewFinancialReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 57);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 6;
            label1.Text = "Name of User";
            label1.Click += label1_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(535, 131);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(45, 15);
            LabelName.TabIndex = 7;
            LabelName.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 104);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 10;
            label2.Text = "Financial Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 209);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 11;
            label3.Text = "Financial Report :";
            // 
            // checkBoxFullyPaid
            // 
            checkBoxFullyPaid.AutoSize = true;
            checkBoxFullyPaid.Location = new Point(645, 209);
            checkBoxFullyPaid.Name = "checkBoxFullyPaid";
            checkBoxFullyPaid.Size = new Size(77, 19);
            checkBoxFullyPaid.TabIndex = 12;
            checkBoxFullyPaid.Text = "Fully Paid";
            checkBoxFullyPaid.UseVisualStyleBackColor = true;
            checkBoxFullyPaid.CheckedChanged += checkBoxFullyPaid_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 159);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 13;
            label4.Text = "Course :";
            // 
            // checkBoxEnrolled
            // 
            checkBoxEnrolled.AutoSize = true;
            checkBoxEnrolled.Location = new Point(590, 131);
            checkBoxEnrolled.Name = "checkBoxEnrolled";
            checkBoxEnrolled.Size = new Size(69, 19);
            checkBoxEnrolled.TabIndex = 8;
            checkBoxEnrolled.Text = "Enrolled";
            checkBoxEnrolled.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotEnrolled
            // 
            checkBoxNotEnrolled.AutoSize = true;
            checkBoxNotEnrolled.Location = new Point(666, 131);
            checkBoxNotEnrolled.Name = "checkBoxNotEnrolled";
            checkBoxNotEnrolled.Size = new Size(92, 19);
            checkBoxNotEnrolled.TabIndex = 9;
            checkBoxNotEnrolled.Text = "Not Enrolled";
            checkBoxNotEnrolled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 159);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 14;
            label5.Text = "Course Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(606, 185);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 16;
            label6.Text = "Year Level";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(535, 185);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 15;
            label7.Text = "Year Level :";
            // 
            // ButtonViewRecords
            // 
            ButtonViewRecords.Location = new Point(535, 243);
            ButtonViewRecords.Name = "ButtonViewRecords";
            ButtonViewRecords.Size = new Size(220, 44);
            ButtonViewRecords.TabIndex = 17;
            ButtonViewRecords.Text = "View Current Enrollment Record";
            ButtonViewRecords.UseVisualStyleBackColor = true;
            ButtonViewRecords.Click += ButtonViewRecords_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 513);
            Controls.Add(ButtonViewRecords);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBoxFullyPaid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBoxNotEnrolled);
            Controls.Add(checkBoxEnrolled);
            Controls.Add(LabelName);
            Controls.Add(label1);
            Controls.Add(dataGridViewFinancialReport);
            Name = "AccountManagement";
            Text = "AccountManagement";
            Load += AccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinancialReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFinancialReport;
        private Label label1;
        private Label LabelName;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxFullyPaid;
        private Label label4;
        private CheckBox checkBoxEnrolled;
        private CheckBox checkBoxNotEnrolled;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ButtonViewRecords;
        private Button ButtonUndo1;
    }
}