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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonView
            // 
            ButtonView.Location = new Point(532, 235);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(220, 44);
            ButtonView.TabIndex = 30;
            ButtonView.Text = "View Financial Record";
            ButtonView.UseVisualStyleBackColor = true;
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
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(635, 201);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(77, 19);
            checkBox3.TabIndex = 25;
            checkBox3.Text = "Fully Paid";
            checkBox3.UseVisualStyleBackColor = true;
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(660, 123);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Not Enrolled";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(587, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Enrolled";
            checkBox1.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(457, 295);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.left;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(712, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.right;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(746, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 32;
            button2.UseVisualStyleBackColor = true;
            // 
            // EnrollmentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "EnrollmentRecord";
            Text = "EnrollmentRecord";
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
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}