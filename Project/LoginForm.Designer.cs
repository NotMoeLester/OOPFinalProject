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
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            ButtonClear = new Button();
            LogIn = new Label();
            comboBox1 = new ComboBox();
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
            ButtonLogin.Click += ButtonEnter_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(208, 204);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(36, 15);
            LabelName.TabIndex = 1;
            LabelName.Text = "Email";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(187, 237);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 110);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 3;
            label1.Text = "User Log In";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(263, 200);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(230, 23);
            TextBoxUsername.TabIndex = 4;
            TextBoxUsername.TextChanged += TextBoxUsername_TextChanged;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(263, 232);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(230, 23);
            TextBoxPassword.TabIndex = 5;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(519, 200);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(160, 23);
            ButtonClear.TabIndex = 6;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(519, 164);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 15);
            LogIn.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Administrator" });
            comboBox1.Location = new Point(263, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(LogIn);
            Controls.Add(ButtonClear);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(label1);
            Controls.Add(LabelPassword);
            Controls.Add(LabelName);
            Controls.Add(ButtonLogin);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private Label LabelName;
        private Label LabelPassword;
        private Label label1;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button ButtonClear;
        private Label LogIn;
        private ComboBox comboBox1;
    }
}
