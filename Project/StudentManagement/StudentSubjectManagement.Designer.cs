namespace Project.SubjectManagement {
    partial class StudentSubjectManagement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            ButtonAdd = new Button();
            dataGridViewAvailableSubjects = new DataGridView();
            LabelStudentID = new Label();
            LabelStudentName = new Label();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DGVEnrollmentList = new DataGridView();
            ButtonDrop = new Button();
            ButtonSave = new Button();
            label5 = new Label();
            LabelTotalUnits = new Label();
            label6 = new Label();
            label7 = new Label();
            LabelSchool = new Label();
            LabelCourse = new Label();
            LabelSchoolYear = new Label();
            LabelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvailableSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVEnrollmentList).BeginInit();
            SuspendLayout();
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.Teal;
            ButtonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(377, 541);
            ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(117, 43);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "ADD SUBJECT";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // dataGridViewAvailableSubjects
            // 
            dataGridViewAvailableSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAvailableSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvailableSubjects.Location = new Point(85, 189);
            dataGridViewAvailableSubjects.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAvailableSubjects.Name = "dataGridViewAvailableSubjects";
            dataGridViewAvailableSubjects.RowHeadersWidth = 51;
            dataGridViewAvailableSubjects.Size = new Size(720, 143);
            dataGridViewAvailableSubjects.TabIndex = 1;
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentID.ForeColor = Color.White;
            LabelStudentID.Location = new Point(6, 4);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(191, 41);
            LabelStudentID.TabIndex = 2;
            LabelStudentID.Text = "[Student ID]";
            // 
            // LabelStudentName
            // 
            LabelStudentName.AutoSize = true;
            LabelStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentName.ForeColor = Color.White;
            LabelStudentName.Location = new Point(177, 4);
            LabelStudentName.Name = "LabelStudentName";
            LabelStudentName.Size = new Size(220, 41);
            LabelStudentName.TabIndex = 5;
            LabelStudentName.Text = "Student Name";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label1.ForeColor = Color.LemonChiffon;
            Label1.Location = new Point(14, 52);
            Label1.Name = "Label1";
            Label1.Size = new Size(75, 20);
            Label1.TabIndex = 6;
            Label1.Text = "SCHOOL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LemonChiffon;
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 7;
            label2.Text = "COURSE AND YEAR LEVEL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.LemonChiffon;
            label3.Location = new Point(14, 107);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 8;
            label3.Text = "SCHOOL YEAR :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.LemonChiffon;
            label4.Location = new Point(14, 133);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "STATUS :";
            // 
            // DGVEnrollmentList
            // 
            DGVEnrollmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVEnrollmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEnrollmentList.Location = new Point(85, 376);
            DGVEnrollmentList.Margin = new Padding(3, 4, 3, 4);
            DGVEnrollmentList.Name = "DGVEnrollmentList";
            DGVEnrollmentList.RowHeadersWidth = 51;
            DGVEnrollmentList.Size = new Size(720, 143);
            DGVEnrollmentList.TabIndex = 11;
            // 
            // ButtonDrop
            // 
            ButtonDrop.BackColor = Color.FromArgb(192, 0, 0);
            ButtonDrop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDrop.ForeColor = Color.White;
            ButtonDrop.Location = new Point(517, 541);
            ButtonDrop.Margin = new Padding(3, 4, 3, 4);
            ButtonDrop.Name = "ButtonDrop";
            ButtonDrop.Size = new Size(117, 43);
            ButtonDrop.TabIndex = 12;
            ButtonDrop.Text = "DROP SUBJECT";
            ButtonDrop.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.Green;
            ButtonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(658, 541);
            ButtonSave.Margin = new Padding(3, 4, 3, 4);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(146, 43);
            ButtonSave.TabIndex = 13;
            ButtonSave.Text = "SAVE ENROLLMENT";
            ButtonSave.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(85, 547);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "TOTAL UNITS :";
            // 
            // LabelTotalUnits
            // 
            LabelTotalUnits.AutoSize = true;
            LabelTotalUnits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTotalUnits.ForeColor = Color.LawnGreen;
            LabelTotalUnits.Location = new Point(197, 545);
            LabelTotalUnits.Name = "LabelTotalUnits";
            LabelTotalUnits.Size = new Size(34, 20);
            LabelTotalUnits.TabIndex = 15;
            LabelTotalUnits.Text = "/29";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(634, 160);
            label6.Name = "label6";
            label6.Size = new Size(184, 23);
            label6.TabIndex = 16;
            label6.Text = "AVAILABLE SUBJECTS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Khaki;
            label7.Location = new Point(637, 347);
            label7.Name = "label7";
            label7.Size = new Size(182, 23);
            label7.TabIndex = 17;
            label7.Text = "ENROLLED SUBJECTS";
            // 
            // LabelSchool
            // 
            LabelSchool.AutoSize = true;
            LabelSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSchool.ForeColor = Color.White;
            LabelSchool.Location = new Point(89, 52);
            LabelSchool.Name = "LabelSchool";
            LabelSchool.Size = new Size(190, 20);
            LabelSchool.TabIndex = 18;
            LabelSchool.Text = "School Department Name";
            // 
            // LabelCourse
            // 
            LabelCourse.AutoSize = true;
            LabelCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelCourse.ForeColor = Color.White;
            LabelCourse.Location = new Point(194, 80);
            LabelCourse.Name = "LabelCourse";
            LabelCourse.Size = new Size(187, 20);
            LabelCourse.TabIndex = 19;
            LabelCourse.Text = "Course Name - Year Level";
            // 
            // LabelSchoolYear
            // 
            LabelSchoolYear.AutoSize = true;
            LabelSchoolYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSchoolYear.ForeColor = Color.White;
            LabelSchoolYear.Location = new Point(126, 107);
            LabelSchoolYear.Name = "LabelSchoolYear";
            LabelSchoolYear.Size = new Size(114, 20);
            LabelSchoolYear.TabIndex = 20;
            LabelSchoolYear.Text = "S.Y. 2025-2026";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelStatus.ForeColor = Color.White;
            LabelStatus.Location = new Point(88, 133);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(161, 20);
            LabelStatus.TabIndex = 21;
            LabelStatus.Text = "Enrolled/Not Enrolled";
            // 
            // StudentSubjectManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(914, 600);
            Controls.Add(LabelStatus);
            Controls.Add(LabelSchoolYear);
            Controls.Add(LabelCourse);
            Controls.Add(LabelSchool);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LabelTotalUnits);
            Controls.Add(label5);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonDrop);
            Controls.Add(DGVEnrollmentList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(LabelStudentName);
            Controls.Add(LabelStudentID);
            Controls.Add(dataGridViewAvailableSubjects);
            Controls.Add(ButtonAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentSubjectManagement";
            Text = "StudentSubjectManagement";
            Load += StudentSubjectManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvailableSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVEnrollmentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAdd;
        private DataGridView dataGridViewAvailableSubjects;
        private Label LabelStudentID;
        private Label LabelStudentName;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView DGVEnrollmentList;
        private Button ButtonDrop;
        private Button ButtonSave;
        private Label label5;
        private Label LabelTotalUnits;
        private Label label6;
        private Label label7;
        private Label LabelSchool;
        private Label LabelCourse;
        private Label LabelSchoolYear;
        private Label LabelStatus;
    }
}