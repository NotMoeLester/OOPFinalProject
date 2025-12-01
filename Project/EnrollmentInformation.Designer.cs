namespace Project
{
    partial class EnrollmentInformation
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 295);
            dataGridView1.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.right;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(755, 12);
            button2.Name = "button2";
            button2.Size = new Size(33, 23);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.left;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(721, 12);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 35;
            label1.Text = "Name of User";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(197, 12);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 36;
            label8.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 37;
            label2.Text = "Cellphone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 60);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 38;
            label3.Text = "Email";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Screenshot_2025_12_01_172347;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(36, 123);
            button3.Name = "button3";
            button3.Size = new Size(731, 269);
            button3.TabIndex = 39;
            button3.UseVisualStyleBackColor = true;
            // 
            // EnrollmentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "EnrollmentInformation";
            Text = "EnrollmentInformation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}