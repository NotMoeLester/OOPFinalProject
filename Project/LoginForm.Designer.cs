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
        private void InitializeComponent()
        {
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
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.DarkBlue;
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = SystemColors.ControlLightLight;
            ButtonLogin.Location = new Point(263, 273);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(230, 33);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(208, 204);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(42, 15);
            LabelName.TabIndex = 1;
            LabelName.Text = "Email :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(187, 237);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(63, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(263, 91);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 3;
            label1.Text = "User Log In";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmail.ForeColor = Color.Gray;
            TextBoxEmail.Location = new Point(263, 200);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(230, 23);
            TextBoxEmail.TabIndex = 4;
            TextBoxEmail.Text = "Enter Email";
            TextBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            TextBoxEmail.Enter += TextBoxEmail_Enter;
            TextBoxEmail.Leave += TextBoxEmail_Leave;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxPassword.ForeColor = Color.Gray;
            TextBoxPassword.Location = new Point(263, 232);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(230, 23);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.Text = "Enter Password";
            TextBoxPassword.Enter += TextBoxPassword_Enter;
            TextBoxPassword.Leave += TextBoxPassword_Leave;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(519, 164);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 15);
            LogIn.TabIndex = 7;
            // 
            // ComboBoxUser
            // 
            ComboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUser.FormattingEnabled = true;
            ComboBoxUser.Items.AddRange(new object[] { "Student", "Administrator" });
            ComboBoxUser.Location = new Point(263, 154);
            ComboBoxUser.Name = "ComboBoxUser";
            ComboBoxUser.Size = new Size(230, 23);
            ComboBoxUser.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(262, 139);
            label2.Name = "label2";
            label2.Size = new Size(60, 12);
            label2.TabIndex = 9;
            label2.Text = "Choose User";
            // 
            // LinkLabelSignUp
            // 
            LinkLabelSignUp.AutoSize = true;
            LinkLabelSignUp.LinkColor = Color.Gray;
            LinkLabelSignUp.Location = new Point(330, 314);
            LinkLabelSignUp.Name = "LinkLabelSignUp";
            LinkLabelSignUp.Size = new Size(149, 15);
            LinkLabelSignUp.TabIndex = 11;
            LinkLabelSignUp.TabStop = true;
            LinkLabelSignUp.Text = "Need an account? SIGN UP";
            LinkLabelSignUp.LinkClicked += LinkLabelSignUp_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
    }
}
