namespace Project
{
    partial class XXXUserEnrollmentInformation
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            ButtonViewSubjectInformation = new Button();
            ButtonView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
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
            // ButtonViewSubjectInformation
            // 
            ButtonViewSubjectInformation.BackColor = Color.Navy;
            ButtonViewSubjectInformation.FlatStyle = FlatStyle.Flat;
            ButtonViewSubjectInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonViewSubjectInformation.ForeColor = Color.White;
            ButtonViewSubjectInformation.Location = new Point(342, 395);
            ButtonViewSubjectInformation.Name = "ButtonViewSubjectInformation";
            ButtonViewSubjectInformation.Size = new Size(220, 27);
            ButtonViewSubjectInformation.TabIndex = 52;
            ButtonViewSubjectInformation.Text = "View Subject Information";
            ButtonViewSubjectInformation.UseVisualStyleBackColor = false;
            ButtonViewSubjectInformation.Click += ButtonViewSubjectInformation_Click;
            // 
            // ButtonView
            // 
            ButtonView.BackColor = Color.Navy;
            ButtonView.FlatStyle = FlatStyle.Flat;
            ButtonView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonView.ForeColor = Color.White;
            ButtonView.Location = new Point(568, 395);
            ButtonView.Name = "ButtonView";
            ButtonView.Size = new Size(220, 27);
            ButtonView.TabIndex = 51;
            ButtonView.Text = "View Financial Record";
            ButtonView.UseVisualStyleBackColor = false;
            ButtonView.Click += ButtonView_Click;
            // 
            // UserEnrollmentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonViewSubjectInformation);
            Controls.Add(ButtonView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "UserEnrollmentInformation";
            Text = "EnrollmentInformation";
            Load += EnrollmentInformation_Load;
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
        private Button ButtonViewSubjectInformation;
        private Button ButtonView;
    }
}