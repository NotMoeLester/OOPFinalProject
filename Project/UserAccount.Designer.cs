namespace Project
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            ButtonViewStudentInformation = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkBox3 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            LabelName = new Label();
            LabelEmailUER = new Label();
            dataGridView1 = new DataGridView();
            ButtonViewSubjectInformation = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonViewStudentInformation
            // 
            ButtonViewStudentInformation.BackColor = Color.Navy;
            ButtonViewStudentInformation.FlatStyle = FlatStyle.Flat;
            ButtonViewStudentInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonViewStudentInformation.ForeColor = Color.White;
            ButtonViewStudentInformation.Location = new Point(69, 485);
            ButtonViewStudentInformation.Margin = new Padding(3, 4, 3, 4);
            ButtonViewStudentInformation.Name = "ButtonViewStudentInformation";
            ButtonViewStudentInformation.Size = new Size(251, 44);
            ButtonViewStudentInformation.TabIndex = 46;
            ButtonViewStudentInformation.Text = "View Student Information";
            ButtonViewStudentInformation.UseVisualStyleBackColor = false;
            ButtonViewStudentInformation.Click += ButtonViewStudentInformation_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Navy;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(153, 353);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 45;
            label6.Text = "Year Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Navy;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 353);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 44;
            label7.Text = "Year Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(131, 319);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 43;
            label5.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 319);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 42;
            label4.Text = "Course :";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Navy;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(203, 385);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 24);
            checkBox3.TabIndex = 41;
            checkBox3.Text = "Fully Paid";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 385);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 40;
            label3.Text = "Financial Report :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 119);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 39;
            label2.Text = "User Account";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Navy;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(224, 281);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 24);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "Not Enrolled";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Navy;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(135, 281);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 24);
            checkBox1.TabIndex = 37;
            checkBox1.Text = "Enrolled";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BackColor = Color.Navy;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelName.ForeColor = Color.White;
            LabelName.Location = new Point(69, 281);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(61, 20);
            LabelName.TabIndex = 36;
            LabelName.Text = "Status :";
            // 
            // LabelEmailUER
            // 
            LabelEmailUER.AutoSize = true;
            LabelEmailUER.BackColor = Color.Navy;
            LabelEmailUER.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEmailUER.ForeColor = Color.White;
            LabelEmailUER.Location = new Point(69, 76);
            LabelEmailUER.Name = "LabelEmailUER";
            LabelEmailUER.Size = new Size(95, 41);
            LabelEmailUER.TabIndex = 35;
            LabelEmailUER.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 175);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(821, 54);
            dataGridView1.TabIndex = 34;
            // 
            // ButtonViewSubjectInformation
            // 
            ButtonViewSubjectInformation.BackColor = Color.Navy;
            ButtonViewSubjectInformation.FlatStyle = FlatStyle.Flat;
            ButtonViewSubjectInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonViewSubjectInformation.ForeColor = Color.White;
            ButtonViewSubjectInformation.Location = new Point(69, 429);
            ButtonViewSubjectInformation.Margin = new Padding(3, 4, 3, 4);
            ButtonViewSubjectInformation.Name = "ButtonViewSubjectInformation";
            ButtonViewSubjectInformation.Size = new Size(251, 44);
            ButtonViewSubjectInformation.TabIndex = 50;
            ButtonViewSubjectInformation.Text = "View Subject Information";
            ButtonViewSubjectInformation.UseVisualStyleBackColor = false;
            ButtonViewSubjectInformation.Click += ButtonViewSubjectInformation_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(172, 568);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 95);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(982, 752);
            Controls.Add(pictureBox1);
            Controls.Add(ButtonViewSubjectInformation);
            Controls.Add(ButtonViewStudentInformation);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(LabelName);
            Controls.Add(LabelEmailUER);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserAccount";
            Text = "UserEnrollmentRecord";
            Load += UserEnrollmentRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonViewStudentInformation;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private CheckBox checkBox3;
        private Label label3;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label LabelName;
        private Label LabelEmailUER;
        private DataGridView dataGridView1;
        private Button ButtonViewSubjectInformation;
        private PictureBox pictureBox1;
    }
}