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
            LabelNameOfUser = new Label();
            LabelStatus = new Label();
            LabelCourse = new Label();
            LabelCourseInfo = new Label();
            LabelYearLevelInfo = new Label();
            LabelYearLevel = new Label();
            ButtonViewRecords = new Button();
            LabelStatusInfo = new Label();
            LabelDepartmentName = new Label();
            LabelDepartmentNameInfo = new Label();
            LabelStudentID = new Label();
            LabelVerification = new Label();
            LabelEmail = new Label();
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
            // LabelNameOfUser
            // 
            LabelNameOfUser.AutoSize = true;
            LabelNameOfUser.BackColor = Color.Navy;
            LabelNameOfUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNameOfUser.ForeColor = Color.White;
            LabelNameOfUser.Location = new Point(60, 57);
            LabelNameOfUser.Name = "LabelNameOfUser";
            LabelNameOfUser.Size = new Size(170, 32);
            LabelNameOfUser.TabIndex = 6;
            LabelNameOfUser.Text = "Name of User";
            LabelNameOfUser.Click += label1_Click;
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.ForeColor = Color.White;
            LabelStatus.Location = new Point(577, 211);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(45, 15);
            LabelStatus.TabIndex = 7;
            LabelStatus.Text = "Status :";
            // 
            // LabelCourse
            // 
            LabelCourse.AutoSize = true;
            LabelCourse.ForeColor = Color.White;
            LabelCourse.Location = new Point(577, 239);
            LabelCourse.Name = "LabelCourse";
            LabelCourse.Size = new Size(50, 15);
            LabelCourse.TabIndex = 13;
            LabelCourse.Text = "Course :";
            // 
            // LabelCourseInfo
            // 
            LabelCourseInfo.AutoSize = true;
            LabelCourseInfo.ForeColor = Color.White;
            LabelCourseInfo.Location = new Point(633, 239);
            LabelCourseInfo.Name = "LabelCourseInfo";
            LabelCourseInfo.Size = new Size(79, 15);
            LabelCourseInfo.TabIndex = 14;
            LabelCourseInfo.Text = "Course Name";
            // 
            // LabelYearLevelInfo
            // 
            LabelYearLevelInfo.AutoSize = true;
            LabelYearLevelInfo.ForeColor = Color.White;
            LabelYearLevelInfo.Location = new Point(648, 265);
            LabelYearLevelInfo.Name = "LabelYearLevelInfo";
            LabelYearLevelInfo.Size = new Size(59, 15);
            LabelYearLevelInfo.TabIndex = 16;
            LabelYearLevelInfo.Text = "Year Level";
            LabelYearLevelInfo.Click += label6_Click;
            // 
            // LabelYearLevel
            // 
            LabelYearLevel.AutoSize = true;
            LabelYearLevel.ForeColor = Color.White;
            LabelYearLevel.Location = new Point(577, 265);
            LabelYearLevel.Name = "LabelYearLevel";
            LabelYearLevel.Size = new Size(65, 15);
            LabelYearLevel.TabIndex = 15;
            LabelYearLevel.Text = "Year Level :";
            // 
            // ButtonViewRecords
            // 
            ButtonViewRecords.Location = new Point(577, 323);
            ButtonViewRecords.Name = "ButtonViewRecords";
            ButtonViewRecords.Size = new Size(220, 44);
            ButtonViewRecords.TabIndex = 17;
            ButtonViewRecords.Text = "View Current Enrollment Record";
            ButtonViewRecords.UseVisualStyleBackColor = true;
            ButtonViewRecords.Click += ButtonViewRecords_Click;
            // 
            // LabelStatusInfo
            // 
            LabelStatusInfo.AutoSize = true;
            LabelStatusInfo.ForeColor = Color.White;
            LabelStatusInfo.Location = new Point(628, 211);
            LabelStatusInfo.Name = "LabelStatusInfo";
            LabelStatusInfo.Size = new Size(121, 15);
            LabelStatusInfo.TabIndex = 18;
            LabelStatusInfo.Text = "Enrolled/Not Enrolled";
            // 
            // LabelDepartmentName
            // 
            LabelDepartmentName.AutoSize = true;
            LabelDepartmentName.ForeColor = Color.White;
            LabelDepartmentName.Location = new Point(577, 292);
            LabelDepartmentName.Name = "LabelDepartmentName";
            LabelDepartmentName.Size = new Size(76, 15);
            LabelDepartmentName.TabIndex = 19;
            LabelDepartmentName.Text = "Department :";
            // 
            // LabelDepartmentNameInfo
            // 
            LabelDepartmentNameInfo.AutoSize = true;
            LabelDepartmentNameInfo.ForeColor = Color.White;
            LabelDepartmentNameInfo.Location = new Point(659, 292);
            LabelDepartmentNameInfo.Name = "LabelDepartmentNameInfo";
            LabelDepartmentNameInfo.Size = new Size(105, 15);
            LabelDepartmentNameInfo.TabIndex = 20;
            LabelDepartmentNameInfo.Text = "Department Name";
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.BackColor = Color.Navy;
            LabelStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentID.ForeColor = Color.White;
            LabelStudentID.Location = new Point(614, 131);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(135, 32);
            LabelStudentID.TabIndex = 21;
            LabelStudentID.Text = "Student ID";
            // 
            // LabelVerification
            // 
            LabelVerification.AutoSize = true;
            LabelVerification.ForeColor = Color.White;
            LabelVerification.Location = new Point(399, 113);
            LabelVerification.Name = "LabelVerification";
            LabelVerification.Size = new Size(118, 15);
            LabelVerification.TabIndex = 22;
            LabelVerification.Text = "Verified/Non-Verified";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.ForeColor = Color.White;
            LabelEmail.Location = new Point(69, 89);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 23;
            LabelEmail.Text = "Email";
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(886, 513);
            Controls.Add(LabelEmail);
            Controls.Add(LabelVerification);
            Controls.Add(LabelStudentID);
            Controls.Add(LabelDepartmentNameInfo);
            Controls.Add(LabelDepartmentName);
            Controls.Add(LabelStatusInfo);
            Controls.Add(ButtonViewRecords);
            Controls.Add(LabelYearLevelInfo);
            Controls.Add(LabelYearLevel);
            Controls.Add(LabelCourseInfo);
            Controls.Add(LabelCourse);
            Controls.Add(LabelStatus);
            Controls.Add(LabelNameOfUser);
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
        private Label LabelNameOfUser;
        private Label LabelStatus;
        private Label LabelCourse;
        private Label LabelCourseInfo;
        private Label LabelYearLevelInfo;
        private Label LabelYearLevel;
        private Button ButtonViewRecords;
        private Button ButtonUndo1;
        private Label LabelStatusInfo;
        private Label LabelDepartmentName;
        private Label LabelDepartmentNameInfo;
        private Label LabelStudentID;
        private Label LabelVerification;
        private Label LabelEmail;
    }
}