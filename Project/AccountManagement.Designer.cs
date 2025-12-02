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
        private void InitializeComponent() {
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
            dataGridViewFinancialReport.Location = new Point(69, 175);
            dataGridViewFinancialReport.Margin = new Padding(3, 4, 3, 4);
            dataGridViewFinancialReport.Name = "dataGridViewFinancialReport";
            dataGridViewFinancialReport.RowHeadersWidth = 51;
            dataGridViewFinancialReport.Size = new Size(522, 393);
            dataGridViewFinancialReport.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 76);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 6;
            label1.Text = "Name of User";
            label1.Click += label1_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(611, 175);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(56, 20);
            LabelName.TabIndex = 7;
            LabelName.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 139);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 10;
            label2.Text = "Financial Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 279);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 11;
            label3.Text = "Financial Report :";
            // 
            // checkBoxFullyPaid
            // 
            checkBoxFullyPaid.AutoSize = true;
            checkBoxFullyPaid.Location = new Point(737, 279);
            checkBoxFullyPaid.Margin = new Padding(3, 4, 3, 4);
            checkBoxFullyPaid.Name = "checkBoxFullyPaid";
            checkBoxFullyPaid.Size = new Size(93, 24);
            checkBoxFullyPaid.TabIndex = 12;
            checkBoxFullyPaid.Text = "Fully Paid";
            checkBoxFullyPaid.UseVisualStyleBackColor = true;
            checkBoxFullyPaid.CheckedChanged += checkBoxFullyPaid_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(611, 212);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 13;
            label4.Text = "Course :";
            // 
            // checkBoxEnrolled
            // 
            checkBoxEnrolled.AutoSize = true;
            checkBoxEnrolled.Location = new Point(674, 175);
            checkBoxEnrolled.Margin = new Padding(3, 4, 3, 4);
            checkBoxEnrolled.Name = "checkBoxEnrolled";
            checkBoxEnrolled.Size = new Size(86, 24);
            checkBoxEnrolled.TabIndex = 8;
            checkBoxEnrolled.Text = "Enrolled";
            checkBoxEnrolled.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotEnrolled
            // 
            checkBoxNotEnrolled.AutoSize = true;
            checkBoxNotEnrolled.Location = new Point(761, 175);
            checkBoxNotEnrolled.Margin = new Padding(3, 4, 3, 4);
            checkBoxNotEnrolled.Name = "checkBoxNotEnrolled";
            checkBoxNotEnrolled.Size = new Size(115, 24);
            checkBoxNotEnrolled.TabIndex = 9;
            checkBoxNotEnrolled.Text = "Not Enrolled";
            checkBoxNotEnrolled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 212);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 14;
            label5.Text = "Course Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 247);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 16;
            label6.Text = "Year Level";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(611, 247);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 15;
            label7.Text = "Year Level :";
            // 
            // ButtonViewRecords
            // 
            ButtonViewRecords.Location = new Point(611, 324);
            ButtonViewRecords.Margin = new Padding(3, 4, 3, 4);
            ButtonViewRecords.Name = "ButtonViewRecords";
            ButtonViewRecords.Size = new Size(251, 59);
            ButtonViewRecords.TabIndex = 17;
            ButtonViewRecords.Text = "View Current Enrollment Record";
            ButtonViewRecords.UseVisualStyleBackColor = true;
            ButtonViewRecords.Click += ButtonViewRecords_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 684);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccountManagement";
            Text = "AccountManagement";
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