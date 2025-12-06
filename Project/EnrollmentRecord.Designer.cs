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
        private void InitializeComponent() {
            ButtonView = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonView
            // 
            ButtonView.BackColor = Color.Navy;
            ButtonView.FlatStyle = FlatStyle.Flat;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonView.ForeColor = Color.White;
            ButtonView.Location = new Point(550, 247);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(220, 33);
            ButtonView.TabIndex = 63;
            ButtonView.Text = "View Financial Record";
            ButtonView.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Navy;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(624, 191);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 62;
            label6.Text = "Year Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Navy;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(550, 191);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 61;
            label7.Text = "Year Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(605, 166);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 60;
            label5.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(550, 166);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 59;
            label4.Text = "Course :";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Navy;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(668, 215);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(77, 19);
            checkBox3.TabIndex = 58;
            checkBox3.Text = "Fully Paid";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Navy;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(550, 215);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 57;
            label3.Text = "Financial Report :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 89);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 56;
            label2.Text = "Enrollment Records";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Navy;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(686, 137);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(95, 19);
            checkBox2.TabIndex = 55;
            checkBox2.Text = "Not Enrolled";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Navy;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(608, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 54;
            checkBox1.Text = "Enrolled";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BackColor = Color.Navy;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelName.ForeColor = Color.White;
            LabelName.Location = new Point(550, 137);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(48, 15);
            LabelName.TabIndex = 53;
            LabelName.Text = "Status :";
            // 
            // LabelEmailUER
            // 
            LabelEmailUER.AutoSize = true;
            LabelEmailUER.BackColor = Color.Navy;
            LabelEmailUER.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEmailUER.ForeColor = Color.White;
            LabelEmailUER.Location = new Point(60, 57);
            LabelEmailUER.Name = "LabelEmailUER";
            LabelEmailUER.Size = new Size(76, 32);
            LabelEmailUER.TabIndex = 52;
            LabelEmailUER.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 295);
            dataGridView1.TabIndex = 51;
            // 
            // EnrollmentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonView);
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
            Name = "EnrollmentRecord";
            Text = "EnrollmentRecord";
            Load += EnrollmentRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonView;
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
    }
}