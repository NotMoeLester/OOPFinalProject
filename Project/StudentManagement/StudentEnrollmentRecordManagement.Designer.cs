namespace Project
{
    partial class StudentEnrollmentRecordManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEnrollmentRecordManagement));
            ButtonViewStudentInformation = new Button();
            LabelYearLevel = new Label();
            label7 = new Label();
            LabelCourseName = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CheckBoxStatusNotEnrolled = new CheckBox();
            CheckBoxStatusEnrolled = new CheckBox();
            LabelName = new Label();
            LabelEmailUER = new Label();
            dataGridView1 = new DataGridView();
            ButtonViewSubjectInformation = new Button();
            pictureBox1 = new PictureBox();
            LabelFullNameUER = new Label();
            LabelContactNumberUER = new Label();
            LabelStudentID = new Label();
            LabelDepartmentName = new Label();
            buttoneksit = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ButtonViewStudentInformation
            // 
            ButtonViewStudentInformation.BackColor = Color.Navy;
            ButtonViewStudentInformation.FlatStyle = FlatStyle.Flat;
            ButtonViewStudentInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonViewStudentInformation.ForeColor = Color.White;
            ButtonViewStudentInformation.Location = new Point(549, 279);
            ButtonViewStudentInformation.Name = "ButtonViewStudentInformation";
            ButtonViewStudentInformation.Size = new Size(220, 33);
            ButtonViewStudentInformation.TabIndex = 46;
            ButtonViewStudentInformation.Text = "View Student Information";
            ButtonViewStudentInformation.UseVisualStyleBackColor = false;
            ButtonViewStudentInformation.Click += ButtonViewStudentInformation_Click;
            // 
            // LabelYearLevel
            // 
            LabelYearLevel.AutoSize = true;
            LabelYearLevel.BackColor = Color.Navy;
            LabelYearLevel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelYearLevel.ForeColor = Color.White;
            LabelYearLevel.Location = new Point(623, 180);
            LabelYearLevel.Name = "LabelYearLevel";
            LabelYearLevel.Size = new Size(64, 15);
            LabelYearLevel.TabIndex = 45;
            LabelYearLevel.Text = "Year Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Navy;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(549, 180);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 44;
            label7.Text = "Year Level :";
            // 
            // LabelCourseName
            // 
            LabelCourseName.AutoSize = true;
            LabelCourseName.BackColor = Color.Navy;
            LabelCourseName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelCourseName.ForeColor = Color.White;
            LabelCourseName.Location = new Point(604, 155);
            LabelCourseName.Name = "LabelCourseName";
            LabelCourseName.Size = new Size(81, 15);
            LabelCourseName.TabIndex = 43;
            LabelCourseName.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(549, 155);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 42;
            label4.Text = "Course :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(549, 204);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 40;
            label3.Text = "Department :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(59, 104);
            label2.Name = "label2";
            label2.Size = new Size(117, 13);
            label2.TabIndex = 39;
            label2.Text = "ENROLLED SUBJECTS";
            label2.Click += label2_Click;
            // 
            // CheckBoxStatusNotEnrolled
            // 
            CheckBoxStatusNotEnrolled.AutoSize = true;
            CheckBoxStatusNotEnrolled.BackColor = Color.Navy;
            CheckBoxStatusNotEnrolled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckBoxStatusNotEnrolled.ForeColor = Color.White;
            CheckBoxStatusNotEnrolled.Location = new Point(685, 126);
            CheckBoxStatusNotEnrolled.Name = "CheckBoxStatusNotEnrolled";
            CheckBoxStatusNotEnrolled.Size = new Size(95, 19);
            CheckBoxStatusNotEnrolled.TabIndex = 38;
            CheckBoxStatusNotEnrolled.Text = "Not Enrolled";
            CheckBoxStatusNotEnrolled.UseVisualStyleBackColor = false;
            // 
            // CheckBoxStatusEnrolled
            // 
            CheckBoxStatusEnrolled.AutoSize = true;
            CheckBoxStatusEnrolled.BackColor = Color.Navy;
            CheckBoxStatusEnrolled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CheckBoxStatusEnrolled.ForeColor = Color.White;
            CheckBoxStatusEnrolled.Location = new Point(607, 126);
            CheckBoxStatusEnrolled.Name = "CheckBoxStatusEnrolled";
            CheckBoxStatusEnrolled.Size = new Size(71, 19);
            CheckBoxStatusEnrolled.TabIndex = 37;
            CheckBoxStatusEnrolled.Text = "Enrolled";
            CheckBoxStatusEnrolled.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BackColor = Color.Navy;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelName.ForeColor = Color.White;
            LabelName.Location = new Point(549, 126);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(48, 15);
            LabelName.TabIndex = 36;
            LabelName.Text = "Status :";
            // 
            // LabelEmailUER
            // 
            LabelEmailUER.AutoSize = true;
            LabelEmailUER.BackColor = Color.Navy;
            LabelEmailUER.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelEmailUER.ForeColor = Color.White;
            LabelEmailUER.Location = new Point(59, 74);
            LabelEmailUER.Name = "LabelEmailUER";
            LabelEmailUER.Size = new Size(36, 15);
            LabelEmailUER.TabIndex = 35;
            LabelEmailUER.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 295);
            dataGridView1.TabIndex = 34;
            // 
            // ButtonViewSubjectInformation
            // 
            ButtonViewSubjectInformation.BackColor = Color.Navy;
            ButtonViewSubjectInformation.FlatStyle = FlatStyle.Flat;
            ButtonViewSubjectInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonViewSubjectInformation.ForeColor = Color.White;
            ButtonViewSubjectInformation.Location = new Point(549, 237);
            ButtonViewSubjectInformation.Name = "ButtonViewSubjectInformation";
            ButtonViewSubjectInformation.Size = new Size(220, 33);
            ButtonViewSubjectInformation.TabIndex = 50;
            ButtonViewSubjectInformation.Text = "View Subject Information";
            ButtonViewSubjectInformation.UseVisualStyleBackColor = false;
            ButtonViewSubjectInformation.Click += ButtonViewSubjectInformation_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(637, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 71);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // LabelFullNameUER
            // 
            LabelFullNameUER.AutoSize = true;
            LabelFullNameUER.BackColor = Color.Navy;
            LabelFullNameUER.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFullNameUER.ForeColor = Color.White;
            LabelFullNameUER.Location = new Point(59, 42);
            LabelFullNameUER.Name = "LabelFullNameUER";
            LabelFullNameUER.Size = new Size(129, 32);
            LabelFullNameUER.TabIndex = 52;
            LabelFullNameUER.Text = "Full Name";
            // 
            // LabelContactNumberUER
            // 
            LabelContactNumberUER.AutoSize = true;
            LabelContactNumberUER.BackColor = Color.Navy;
            LabelContactNumberUER.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelContactNumberUER.ForeColor = Color.White;
            LabelContactNumberUER.Location = new Point(256, 74);
            LabelContactNumberUER.Name = "LabelContactNumberUER";
            LabelContactNumberUER.Size = new Size(99, 15);
            LabelContactNumberUER.TabIndex = 53;
            LabelContactNumberUER.Text = "Contact Number";
            // 
            // LabelStudentID
            // 
            LabelStudentID.AutoSize = true;
            LabelStudentID.BackColor = Color.Navy;
            LabelStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelStudentID.ForeColor = Color.White;
            LabelStudentID.Location = new Point(588, 60);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(135, 32);
            LabelStudentID.TabIndex = 54;
            LabelStudentID.Text = "Student ID";
            // 
            // LabelDepartmentName
            // 
            LabelDepartmentName.AutoSize = true;
            LabelDepartmentName.BackColor = Color.Navy;
            LabelDepartmentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelDepartmentName.ForeColor = Color.White;
            LabelDepartmentName.Location = new Point(637, 204);
            LabelDepartmentName.Name = "LabelDepartmentName";
            LabelDepartmentName.Size = new Size(112, 15);
            LabelDepartmentName.TabIndex = 55;
            LabelDepartmentName.Text = "Department Name";
            // 
            // buttoneksit
            // 
            buttoneksit.BackColor = Color.Firebrick;
            buttoneksit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoneksit.ForeColor = Color.White;
            buttoneksit.Location = new Point(549, 385);
            buttoneksit.Name = "buttoneksit";
            buttoneksit.Size = new Size(220, 30);
            buttoneksit.TabIndex = 56;
            buttoneksit.Text = "Log Out";
            buttoneksit.UseVisualStyleBackColor = false;
            buttoneksit.Click += buttoneksit_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(-14, 327);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(175, 136);
            pictureBox5.TabIndex = 57;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(368, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 136);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // StudentEnrollmentRecordManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(822, 464);
            Controls.Add(buttoneksit);
            Controls.Add(LabelDepartmentName);
            Controls.Add(LabelStudentID);
            Controls.Add(LabelContactNumberUER);
            Controls.Add(LabelFullNameUER);
            Controls.Add(ButtonViewSubjectInformation);
            Controls.Add(ButtonViewStudentInformation);
            Controls.Add(LabelYearLevel);
            Controls.Add(label7);
            Controls.Add(LabelCourseName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CheckBoxStatusNotEnrolled);
            Controls.Add(CheckBoxStatusEnrolled);
            Controls.Add(LabelName);
            Controls.Add(LabelEmailUER);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "StudentEnrollmentRecordManagement";
            Text = " User Enrollment Record";
            Load += StudentEnrollmentRecordManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonViewStudentInformation;
        private Label LabelYearLevel;
        private Label label7;
        private Label LabelCourseName;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox CheckBoxStatusNotEnrolled;
        private CheckBox CheckBoxStatusEnrolled;
        private Label LabelName;
        private Label LabelEmailUER;
        private DataGridView dataGridView1;
        private Button ButtonViewSubjectInformation;
        private PictureBox pictureBox1;
        private Label LabelFullNameUER;
        private Label LabelContactNumberUER;
        private Label LabelStudentID;
        private Label LabelDepartmentName;
        private Button buttoneksit;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
    }
}