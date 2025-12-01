namespace Project
{
    partial class EnrollmentRecord
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
            ButtonViewFinancialRecord = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkBoxStudentFullyPaid = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            checkBoxStudentNotEnrolled = new CheckBox();
            checkBoxStudentEnrolled = new CheckBox();
            LabelName = new Label();
            label1 = new Label();
            dataGridViewEnrollmentRecords = new DataGridView();
            ButtonUndo2 = new Button();
            ButtonRedo2 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrollmentRecords).BeginInit();
            SuspendLayout();
            // 
            // ButtonViewFinancialRecord
            // 
            ButtonViewFinancialRecord.Location = new Point(532, 235);
            ButtonViewFinancialRecord.Name = "ButtonViewFinancialRecord";
            ButtonViewFinancialRecord.Size = new Size(220, 44);
            ButtonViewFinancialRecord.TabIndex = 30;
            ButtonViewFinancialRecord.Text = "View Financial Record";
            ButtonViewFinancialRecord.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 177);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 29;
            label6.Text = "Year Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 177);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 28;
            label7.Text = "Year Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 151);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 27;
            label5.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 151);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 26;
            label4.Text = "Course :";
            // 
            // checkBoxStudentFullyPaid
            // 
            checkBoxStudentFullyPaid.AutoSize = true;
            checkBoxStudentFullyPaid.Location = new Point(635, 201);
            checkBoxStudentFullyPaid.Name = "checkBoxStudentFullyPaid";
            checkBoxStudentFullyPaid.Size = new Size(77, 19);
            checkBoxStudentFullyPaid.TabIndex = 25;
            checkBoxStudentFullyPaid.Text = "Fully Paid";
            checkBoxStudentFullyPaid.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 201);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 24;
            label3.Text = "Financial Report :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 96);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 23;
            label2.Text = "Enrollment Records";
            // 
            // checkBoxStudentNotEnrolled
            // 
            checkBoxStudentNotEnrolled.AutoSize = true;
            checkBoxStudentNotEnrolled.Location = new Point(660, 123);
            checkBoxStudentNotEnrolled.Name = "checkBoxStudentNotEnrolled";
            checkBoxStudentNotEnrolled.Size = new Size(92, 19);
            checkBoxStudentNotEnrolled.TabIndex = 22;
            checkBoxStudentNotEnrolled.Text = "Not Enrolled";
            checkBoxStudentNotEnrolled.UseVisualStyleBackColor = true;
            // 
            // checkBoxStudentEnrolled
            // 
            checkBoxStudentEnrolled.AutoSize = true;
            checkBoxStudentEnrolled.Location = new Point(587, 123);
            checkBoxStudentEnrolled.Name = "checkBoxStudentEnrolled";
            checkBoxStudentEnrolled.Size = new Size(69, 19);
            checkBoxStudentEnrolled.TabIndex = 21;
            checkBoxStudentEnrolled.Text = "Enrolled";
            checkBoxStudentEnrolled.UseVisualStyleBackColor = true;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(532, 123);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(45, 15);
            LabelName.TabIndex = 20;
            LabelName.Text = "Status :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 49);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 19;
            label1.Text = "Name of User";
            // 
            // dataGridViewEnrollmentRecords
            // 
            dataGridViewEnrollmentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnrollmentRecords.Location = new Point(57, 123);
            dataGridViewEnrollmentRecords.Name = "dataGridViewEnrollmentRecords";
            dataGridViewEnrollmentRecords.Size = new Size(457, 295);
            dataGridViewEnrollmentRecords.TabIndex = 18;
            // 
            // ButtonUndo2
            // 
            ButtonUndo2.BackgroundImage = Properties.Resources.left;
            ButtonUndo2.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonUndo2.Location = new Point(712, 12);
            ButtonUndo2.Name = "ButtonUndo2";
            ButtonUndo2.Size = new Size(33, 23);
            ButtonUndo2.TabIndex = 31;
            ButtonUndo2.UseVisualStyleBackColor = true;
            // 
            // ButtonRedo2
            // 
            ButtonRedo2.BackgroundImage = Properties.Resources.right;
            ButtonRedo2.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonRedo2.Location = new Point(746, 12);
            ButtonRedo2.Name = "ButtonRedo2";
            ButtonRedo2.Size = new Size(33, 23);
            ButtonRedo2.TabIndex = 32;
            ButtonRedo2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(233, 49);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 33;
            label8.Text = "Student ID";
            // 
            // EnrollmentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(ButtonRedo2);
            Controls.Add(ButtonUndo2);
            Controls.Add(ButtonViewFinancialRecord);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBoxStudentFullyPaid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBoxStudentNotEnrolled);
            Controls.Add(checkBoxStudentEnrolled);
            Controls.Add(LabelName);
            Controls.Add(label1);
            Controls.Add(dataGridViewEnrollmentRecords);
            Name = "EnrollmentRecord";
            Text = "EnrollmentRecord";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrollmentRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonViewFinancialRecord;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private CheckBox checkBoxStudentFullyPaid;
        private Label label3;
        private Label label2;
        private CheckBox checkBoxStudentNotEnrolled;
        private CheckBox checkBoxStudentEnrolled;
        private Label LabelName;
        private Label label1;
        private DataGridView dataGridViewEnrollmentRecords;
        private Button ButtonUndo2;
        private Button ButtonRedo2;
        private Label label8;
    }
}