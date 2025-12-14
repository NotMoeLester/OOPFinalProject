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
            dataGridViewEnrolledSubjects = new DataGridView();
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
            ButtonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvailableSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrolledSubjects).BeginInit();
            SuspendLayout();
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.Teal;
            ButtonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(330, 458);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(102, 32);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "ADD SUBJECT";
            ButtonAdd.UseVisualStyleBackColor = false;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // dataGridViewAvailableSubjects
            // 
            dataGridViewAvailableSubjects.AllowUserToAddRows = false;
            dataGridViewAvailableSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAvailableSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAvailableSubjects.Location = new Point(74, 142);
            dataGridViewAvailableSubjects.Name = "dataGridViewAvailableSubjects";
            dataGridViewAvailableSubjects.ReadOnly = true;
            dataGridViewAvailableSubjects.RowHeadersWidth = 51;
            dataGridViewAvailableSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAvailableSubjects.Size = new Size(630, 134);
            dataGridViewAvailableSubjects.TabIndex = 1;
            dataGridViewAvailableSubjects.CellContentClick += dataGridViewAvailableSubjects_CellContentClick;
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentID.ForeColor = Color.White;
            LabelStudentID.Location = new Point(5, 3);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(153, 32);
            LabelStudentID.TabIndex = 2;
            LabelStudentID.Text = "[Student ID]";
            // 
            // LabelStudentName
            // 
            LabelStudentName.AutoSize = true;
            LabelStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentName.ForeColor = Color.White;
            LabelStudentName.Location = new Point(155, 3);
            LabelStudentName.Name = "LabelStudentName";
            LabelStudentName.Size = new Size(176, 32);
            LabelStudentName.TabIndex = 5;
            LabelStudentName.Text = "Student Name";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label1.ForeColor = Color.LemonChiffon;
            Label1.Location = new Point(12, 39);
            Label1.Name = "Label1";
            Label1.Size = new Size(60, 15);
            Label1.TabIndex = 6;
            Label1.Text = "SCHOOL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LemonChiffon;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 7;
            label2.Text = "COURSE AND YEAR LEVEL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.LemonChiffon;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 8;
            label3.Text = "SCHOOL YEAR :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.LemonChiffon;
            label4.Location = new Point(12, 100);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "STATUS :";
            // 
            // dataGridViewEnrolledSubjects
            // 
            dataGridViewEnrolledSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEnrolledSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnrolledSubjects.Location = new Point(74, 301);
            dataGridViewEnrolledSubjects.Name = "dataGridViewEnrolledSubjects";
            dataGridViewEnrolledSubjects.RowHeadersWidth = 51;
            dataGridViewEnrolledSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEnrolledSubjects.Size = new Size(630, 140);
            dataGridViewEnrolledSubjects.TabIndex = 11;
            dataGridViewEnrolledSubjects.CellContentClick += dataGridViewEnrolledSubjects_CellContentClick;
            // 
            // ButtonDrop
            // 
            ButtonDrop.BackColor = Color.FromArgb(192, 0, 0);
            ButtonDrop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDrop.ForeColor = Color.White;
            ButtonDrop.Location = new Point(452, 458);
            ButtonDrop.Name = "ButtonDrop";
            ButtonDrop.Size = new Size(102, 32);
            ButtonDrop.TabIndex = 12;
            ButtonDrop.Text = "DROP SUBJECT";
            ButtonDrop.UseVisualStyleBackColor = false;
            ButtonDrop.Click += ButtonDrop_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.Green;
            ButtonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(576, 458);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(128, 32);
            ButtonSave.TabIndex = 13;
            ButtonSave.Text = "SAVE ENROLLMENT";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(74, 462);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 14;
            label5.Text = "TOTAL UNITS :";
            // 
            // LabelTotalUnits
            // 
            LabelTotalUnits.AutoSize = true;
            LabelTotalUnits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTotalUnits.ForeColor = Color.LawnGreen;
            LabelTotalUnits.Location = new Point(172, 461);
            LabelTotalUnits.Name = "LabelTotalUnits";
            LabelTotalUnits.Size = new Size(26, 15);
            LabelTotalUnits.TabIndex = 15;
            LabelTotalUnits.Text = "/29";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(555, 120);
            label6.Name = "label6";
            label6.Size = new Size(149, 19);
            label6.TabIndex = 16;
            label6.Text = "AVAILABLE SUBJECTS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Khaki;
            label7.Location = new Point(557, 279);
            label7.Name = "label7";
            label7.Size = new Size(147, 19);
            label7.TabIndex = 17;
            label7.Text = "ENROLLED SUBJECTS";
            // 
            // LabelSchool
            // 
            LabelSchool.AutoSize = true;
            LabelSchool.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSchool.ForeColor = Color.White;
            LabelSchool.Location = new Point(78, 39);
            LabelSchool.Name = "LabelSchool";
            LabelSchool.Size = new Size(152, 15);
            LabelSchool.TabIndex = 18;
            LabelSchool.Text = "School Department Name";
            // 
            // LabelCourse
            // 
            LabelCourse.AutoSize = true;
            LabelCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelCourse.ForeColor = Color.White;
            LabelCourse.Location = new Point(170, 60);
            LabelCourse.Name = "LabelCourse";
            LabelCourse.Size = new Size(149, 15);
            LabelCourse.TabIndex = 19;
            LabelCourse.Text = "Course Name - Year Level";
            // 
            // LabelSchoolYear
            // 
            LabelSchoolYear.AutoSize = true;
            LabelSchoolYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSchoolYear.ForeColor = Color.White;
            LabelSchoolYear.Location = new Point(110, 80);
            LabelSchoolYear.Name = "LabelSchoolYear";
            LabelSchoolYear.Size = new Size(90, 15);
            LabelSchoolYear.TabIndex = 20;
            LabelSchoolYear.Text = "S.Y. 2025-2026";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelStatus.ForeColor = Color.White;
            LabelStatus.Location = new Point(77, 100);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(126, 15);
            LabelStatus.TabIndex = 21;
            LabelStatus.Text = "Enrolled/Not Enrolled";
            // 
            // ButtonBack
            // 
            ButtonBack.BackgroundImage = Properties.Resources.left;
            ButtonBack.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonBack.Location = new Point(666, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(38, 32);
            ButtonBack.TabIndex = 44;
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // StudentSubjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 516);
            Controls.Add(ButtonBack);
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
            Controls.Add(dataGridViewEnrolledSubjects);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(LabelStudentName);
            Controls.Add(LabelStudentID);
            Controls.Add(dataGridViewAvailableSubjects);
            Controls.Add(ButtonAdd);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "StudentSubjectManagement";
            Text = "StudentSubjectManagement";
            Load += StudentSubjectManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAvailableSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnrolledSubjects).EndInit();
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
        private DataGridView dataGridViewEnrolledSubjects;
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
        private Button ButtonBack;
    }
}