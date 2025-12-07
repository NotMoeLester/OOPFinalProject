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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ButtonLogin = new Button();
            LabelName = new Label();
            LabelPassword = new Label();
            label1 = new Label();
            TextBoxEmail = new TextBox();
            TextBoxPassword = new TextBox();
            ComboBoxUser = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            LinkLabelSignUp = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonShowPassword = new Button();
            LabelPasswordValidator = new Label();
            LabelEmailValidator = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.DarkBlue;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = SystemColors.ControlLightLight;
            ButtonLogin.Location = new Point(293, 325);
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
            LabelName.Location = new Point(293, 155);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(46, 17);
            LabelName.TabIndex = 1;
            LabelName.Text = "Email :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Navy;
            LabelPassword.Font = new Font("Segoe UI", 7.8F);
            LabelPassword.ForeColor = Color.White;
            LabelPassword.Location = new Point(293, 231);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(71, 17);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(293, 35);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 3;
            label1.Text = "User Log In";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.Cursor = Cursors.IBeam;
            TextBoxEmail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmail.ForeColor = Color.Gray;
            TextBoxEmail.Location = new Point(303, 181);
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
            TextBoxPassword.Location = new Point(303, 256);
            TextBoxPassword.Margin = new Padding(3, 4, 3, 4);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(222, 20);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.Text = "Enter Password";
            TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;
            TextBoxPassword.Enter += TextBoxPassword_Enter;
            TextBoxPassword.Leave += TextBoxPassword_Leave;
            // 
            // ComboBoxUser
            // 
            ComboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxUser.FormattingEnabled = true;
            ComboBoxUser.Items.AddRange(new object[] { "Student", "Administrator" });
            ComboBoxUser.Location = new Point(293, 112);
            ComboBoxUser.Margin = new Padding(3, 4, 3, 4);
            ComboBoxUser.Name = "ComboBoxUser";
            ComboBoxUser.Size = new Size(271, 28);
            ComboBoxUser.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(293, 93);
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
            LinkLabelSignUp.Location = new Point(394, 385);
            LinkLabelSignUp.Name = "LinkLabelSignUp";
            LinkLabelSignUp.Size = new Size(187, 20);
            LinkLabelSignUp.TabIndex = 11;
            LinkLabelSignUp.TabStop = true;
            LinkLabelSignUp.Text = "Need an account? SIGN UP";
            LinkLabelSignUp.LinkClicked += LinkLabelSignUp_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(293, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 32);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(buttonShowPassword);
            panel2.Location = new Point(293, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 32);
            panel2.TabIndex = 15;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.BackgroundImage = (Image)resources.GetObject("buttonShowPassword.BackgroundImage");
            buttonShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonShowPassword.Location = new Point(240, 1);
            buttonShowPassword.Margin = new Padding(3, 4, 3, 4);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(27, 29);
            buttonShowPassword.TabIndex = 19;
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // LabelPasswordValidator
            // 
            LabelPasswordValidator.AutoSize = true;
            LabelPasswordValidator.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelPasswordValidator.ForeColor = Color.Firebrick;
            LabelPasswordValidator.Location = new Point(265, 285);
            LabelPasswordValidator.MinimumSize = new Size(299, 0);
            LabelPasswordValidator.Name = "LabelPasswordValidator";
            LabelPasswordValidator.Size = new Size(299, 20);
            LabelPasswordValidator.TabIndex = 16;
            LabelPasswordValidator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelEmailValidator
            // 
            LabelEmailValidator.AutoSize = true;
            LabelEmailValidator.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelEmailValidator.ForeColor = Color.Firebrick;
            LabelEmailValidator.ImageAlign = ContentAlignment.MiddleRight;
            LabelEmailValidator.Location = new Point(265, 209);
            LabelEmailValidator.MinimumSize = new Size(299, 0);
            LabelEmailValidator.Name = "LabelEmailValidator";
            LabelEmailValidator.RightToLeft = RightToLeft.No;
            LabelEmailValidator.Size = new Size(299, 20);
            LabelEmailValidator.TabIndex = 17;
            LabelEmailValidator.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(139, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 537);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            CancelButton = ButtonLogin;
            ClientSize = new Size(914, 600);
            Controls.Add(LabelEmailValidator);
            Controls.Add(LabelPasswordValidator);
            Controls.Add(LinkLabelSignUp);
            Controls.Add(label2);
            Controls.Add(ComboBoxUser);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxEmail);
            Controls.Add(label1);
            Controls.Add(LabelPassword);
            Controls.Add(LabelName);
            Controls.Add(ButtonLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ComboBox ComboBoxUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private LinkLabel LinkLabelSignUp;
        private Panel panel1;
        private Panel panel2;
        private Label LabelPasswordValidator;
        private Label LabelEmailValidator;
        private PictureBox pictureBox1;
        private Button buttonShowPassword;
    }
}
