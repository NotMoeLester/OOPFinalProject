namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ButtonLogin = new Button();
            LabelName = new Label();
            LabelPassword = new Label();
            label1 = new Label();
            TextBoxEmail = new TextBox();
            TextBoxPassword = new TextBox();
            LogIn = new Label();
            ComboBoxUser = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            LinkLabelSignUp = new LinkLabel();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.DarkBlue;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = SystemColors.ControlLightLight;
            ButtonLogin.Location = new Point(297, 346);
            ButtonLogin.Margin = new Padding(3, 4, 3, 4);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(273, 44);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BackColor = Color.Navy;
            LabelName.Font = new Font("Segoe UI", 7.8F);
            LabelName.ForeColor = Color.White;
            LabelName.Location = new Point(297, 199);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(46, 17);
            LabelName.TabIndex = 1;
            LabelName.Text = "Email :";
            LabelName.Click += LabelName_Click;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Navy;
            LabelPassword.Font = new Font("Segoe UI", 7.8F);
            LabelPassword.ForeColor = Color.White;
            LabelPassword.Location = new Point(297, 261);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(71, 17);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password :";
            LabelPassword.Click += LabelPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 81);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 3;
            label1.Text = "User Log In";
            label1.Click += label1_Click;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmail.ForeColor = Color.Gray;
            TextBoxEmail.Location = new Point(307, 225);
            TextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(262, 20);
            TextBoxEmail.TabIndex = 4;
            TextBoxEmail.Text = "Enter Email";
            TextBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            TextBoxEmail.Enter += TextBoxEmail_Enter;
            TextBoxEmail.Leave += TextBoxEmail_Leave;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BorderStyle = BorderStyle.None;
            TextBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxPassword.ForeColor = Color.Gray;
            TextBoxPassword.Location = new Point(307, 287);
            TextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(262, 20);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.Text = "Enter Password";
            TextBoxPassword.Enter += TextBoxPassword_Enter;
            TextBoxPassword.Leave += TextBoxPassword_Leave;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(593, 173);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 20);
            LogIn.TabIndex = 7;
            // 
            // ComboBoxUser
            // 
            ComboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUser.FormattingEnabled = true;
            ComboBoxUser.Items.AddRange(new object[] { "Student", "Administrator" });
            ComboBoxUser.Location = new Point(297, 159);
            ComboBoxUser.Margin = new Padding(3, 4, 3, 4);
            ComboBoxUser.Name = "ComboBoxUser";
            ComboBoxUser.Size = new Size(272, 28);
            ComboBoxUser.TabIndex = 8;
            ComboBoxUser.SelectedIndexChanged += ComboBoxUser_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(297, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 9;
            label2.Text = "Choose User";
            // 
            // LinkLabelSignUp
            // 
            LinkLabelSignUp.AutoSize = true;
            LinkLabelSignUp.BackColor = Color.Navy;
            LinkLabelSignUp.ForeColor = Color.White;
            LinkLabelSignUp.LinkColor = Color.White;
            LinkLabelSignUp.Location = new Point(377, 405);
            LinkLabelSignUp.Name = "LinkLabelSignUp";
            LinkLabelSignUp.Size = new Size(187, 20);
            LinkLabelSignUp.TabIndex = 11;
            LinkLabelSignUp.TabStop = true;
            LinkLabelSignUp.Text = "Need an account? SIGN UP";
            LinkLabelSignUp.LinkClicked += LinkLabelSignUp_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(569, 320);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 13;
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Location = new Point(297, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 32);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Location = new Point(297, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 32);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(186, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 498);
            panel3.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(LinkLabelSignUp);
            Controls.Add(label2);
            Controls.Add(ComboBoxUser);
            Controls.Add(LogIn);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxEmail);
            Controls.Add(label1);
            Controls.Add(LabelPassword);
            Controls.Add(LabelName);
            Controls.Add(ButtonLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private Label LabelName;
        private Label LabelPassword;
        private Label label1;
        private TextBox TextBoxEmail;
        private TextBox TextBoxPassword;
        private Label LogIn;
        private ComboBox ComboBoxUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private LinkLabel LinkLabelSignUp;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
