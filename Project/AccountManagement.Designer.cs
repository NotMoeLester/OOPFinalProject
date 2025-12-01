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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            LabelName = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox3 = new CheckBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ButtonView = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(457, 295);
            dataGridView1.TabIndex = 0;
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
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(638, 209);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(77, 19);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "Fully Paid";
            checkBox3.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(590, 131);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Enrolled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(663, 131);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Not Enrolled";
            checkBox2.UseVisualStyleBackColor = true;
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
            // ButtonView
            // 
            ButtonView.Location = new Point(535, 243);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(220, 44);
            ButtonView.TabIndex = 17;
            ButtonView.Text = "View Current Enrollment Record";
            ButtonView.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.right;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(744, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.left;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(710, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 513);
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
            Name = "AccountManagement";
            Text = "AccountManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label LabelName;
        private Label label2;
        private Label label3;
        private CheckBox checkBox3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ButtonView;
        private Button button2;
        private Button button1;
    }
}