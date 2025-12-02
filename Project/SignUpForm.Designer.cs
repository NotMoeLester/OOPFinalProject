namespace Project {
    partial class SignUpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            LogIn = new Label();
            TextBoxEmailSignUp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LabelPassword = new Label();
            TextBoxConfirmPasswordSignUp = new TextBox();
            LabelName = new Label();
            LinkLabelLogin = new LinkLabel();
            ButtonLogin = new Button();
            TextBoxPasswordSignUp = new TextBox();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(344, 234);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 20);
            LogIn.TabIndex = 17;
            // 
            // TextBoxEmailSignUp
            // 
            TextBoxEmailSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmailSignUp.ForeColor = Color.Gray;
            TextBoxEmailSignUp.Location = new Point(255, 151);
            TextBoxEmailSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxEmailSignUp.Name = "TextBoxEmailSignUp";
            TextBoxEmailSignUp.Size = new Size(262, 27);
            TextBoxEmailSignUp.TabIndex = 15;
            TextBoxEmailSignUp.Text = "Enter Email";
            TextBoxEmailSignUp.Enter += TextBoxEmailSignUp_Enter;
            TextBoxEmailSignUp.Leave += TextBoxEmailSignUp_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(255, 75);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 14;
            label1.Text = "User Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 234);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 21;
            label2.Text = "Confirm :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(168, 196);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(77, 20);
            LabelPassword.TabIndex = 13;
            LabelPassword.Text = "Password :";
            // 
            // TextBoxConfirmPasswordSignUp
            // 
            TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxConfirmPasswordSignUp.ForeColor = Color.Gray;
            TextBoxConfirmPasswordSignUp.Location = new Point(256, 232);
            TextBoxConfirmPasswordSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxConfirmPasswordSignUp.Name = "TextBoxConfirmPasswordSignUp";
            TextBoxConfirmPasswordSignUp.Size = new Size(262, 27);
            TextBoxConfirmPasswordSignUp.TabIndex = 22;
            TextBoxConfirmPasswordSignUp.Text = "Enter Password";
            TextBoxConfirmPasswordSignUp.Enter += TextBoxConfirmPasswordSignUp_Enter;
            TextBoxConfirmPasswordSignUp.Leave += TextBoxConfirmPasswordSignUp_Leave;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(192, 156);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(53, 20);
            LabelName.TabIndex = 12;
            LabelName.Text = "Email :";
            // 
            // LinkLabelLogin
            // 
            LinkLabelLogin.AutoSize = true;
            LinkLabelLogin.LinkColor = Color.Gray;
            LinkLabelLogin.Location = new Point(361, 339);
            LinkLabelLogin.Name = "LinkLabelLogin";
            LinkLabelLogin.Size = new Size(156, 20);
            LinkLabelLogin.TabIndex = 23;
            LinkLabelLogin.TabStop = true;
            LinkLabelLogin.Text = "Already a user? LOGIN";
            LinkLabelLogin.LinkClicked += LinkLabelLogin_LinkClicked;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.DarkBlue;
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = SystemColors.ControlLightLight;
            ButtonLogin.Location = new Point(255, 288);
            ButtonLogin.Margin = new Padding(3, 4, 3, 4);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(263, 44);
            ButtonLogin.TabIndex = 11;
            ButtonLogin.Text = "Sign Up";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // TextBoxPasswordSignUp
            // 
            TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxPasswordSignUp.ForeColor = Color.Gray;
            TextBoxPasswordSignUp.Location = new Point(255, 193);
            TextBoxPasswordSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxPasswordSignUp.Name = "TextBoxPasswordSignUp";
            TextBoxPasswordSignUp.Size = new Size(262, 27);
            TextBoxPasswordSignUp.TabIndex = 16;
            TextBoxPasswordSignUp.Text = "Enter Password";
            TextBoxPasswordSignUp.Enter += TextBoxPasswordSignUp_Enter;
            TextBoxPasswordSignUp.Leave += TextBoxPasswordSignUp_Leave;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(LogIn);
            Controls.Add(TextBoxPasswordSignUp);
            Controls.Add(ButtonLogin);
            Controls.Add(TextBoxEmailSignUp);
            Controls.Add(LinkLabelLogin);
            Controls.Add(label1);
            Controls.Add(LabelName);
            Controls.Add(label2);
            Controls.Add(TextBoxConfirmPasswordSignUp);
            Controls.Add(LabelPassword);
            Name = "SignUpForm";
            Text = "UserSignIn";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LogIn;
        private TextBox TextBoxEmailSignUp;
        private Label label1;
        private Label label2;
        private Label LabelPassword;
        private TextBox TextBoxConfirmPasswordSignUp;
        private Label LabelName;
        private LinkLabel LinkLabelLogin;
        private Button ButtonLogin;
        private TextBox TextBoxPasswordSignUp;
    }
}