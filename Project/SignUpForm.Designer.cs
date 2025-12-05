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
            LabelEmailValidation = new Label();
            LabelPasswordValidation = new Label();
            LabelConfirmPasswordValidation = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(334, 179);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 15);
            LogIn.TabIndex = 17;
            // 
            // TextBoxEmailSignUp
            // 
            TextBoxEmailSignUp.BorderStyle = BorderStyle.None;
            TextBoxEmailSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmailSignUp.ForeColor = Color.Gray;
            TextBoxEmailSignUp.Location = new Point(260, 87);
            TextBoxEmailSignUp.Name = "TextBoxEmailSignUp";
            TextBoxEmailSignUp.Size = new Size(230, 16);
            TextBoxEmailSignUp.TabIndex = 15;
            TextBoxEmailSignUp.Text = "Enter Email";
            TextBoxEmailSignUp.TextChanged += TextBoxEmailSignUp_TextChanged;
            TextBoxEmailSignUp.Enter += TextBoxEmailSignUp_Enter;
            TextBoxEmailSignUp.Leave += TextBoxEmailSignUp_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(256, 26);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 14;
            label1.Text = "User Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(196, 179);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 21;
            label2.Text = "Confirm :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.ForeColor = Color.Navy;
            LabelPassword.Location = new Point(190, 133);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(63, 15);
            LabelPassword.TabIndex = 13;
            LabelPassword.Text = "Password :";
            // 
            // TextBoxConfirmPasswordSignUp
            // 
            TextBoxConfirmPasswordSignUp.BorderStyle = BorderStyle.None;
            TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxConfirmPasswordSignUp.ForeColor = Color.Gray;
            TextBoxConfirmPasswordSignUp.Location = new Point(259, 181);
            TextBoxConfirmPasswordSignUp.Name = "TextBoxConfirmPasswordSignUp";
            TextBoxConfirmPasswordSignUp.Size = new Size(230, 16);
            TextBoxConfirmPasswordSignUp.TabIndex = 22;
            TextBoxConfirmPasswordSignUp.Text = "Enter Password";
            TextBoxConfirmPasswordSignUp.TextChanged += TextBoxConfirmPasswordSignUp_TextChanged;
            TextBoxConfirmPasswordSignUp.Enter += TextBoxConfirmPasswordSignUp_Enter;
            TextBoxConfirmPasswordSignUp.Leave += TextBoxConfirmPasswordSignUp_Leave;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.ForeColor = Color.Navy;
            LabelName.Location = new Point(211, 87);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(42, 15);
            LabelName.TabIndex = 12;
            LabelName.Text = "Email :";
            // 
            // LinkLabelLogin
            // 
            LinkLabelLogin.AutoSize = true;
            LinkLabelLogin.LinkColor = Color.Gray;
            LinkLabelLogin.Location = new Point(362, 274);
            LinkLabelLogin.Name = "LinkLabelLogin";
            LinkLabelLogin.Size = new Size(124, 15);
            LinkLabelLogin.TabIndex = 23;
            LinkLabelLogin.TabStop = true;
            LinkLabelLogin.Text = "Already a user? LOGIN";
            LinkLabelLogin.LinkClicked += LinkLabelLogin_LinkClicked;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.DarkBlue;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = SystemColors.ControlLightLight;
            ButtonLogin.Location = new Point(256, 230);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(230, 33);
            ButtonLogin.TabIndex = 11;
            ButtonLogin.Text = "Sign Up";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // TextBoxPasswordSignUp
            // 
            TextBoxPasswordSignUp.BorderStyle = BorderStyle.None;
            TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxPasswordSignUp.ForeColor = Color.Gray;
            TextBoxPasswordSignUp.Location = new Point(260, 134);
            TextBoxPasswordSignUp.Name = "TextBoxPasswordSignUp";
            TextBoxPasswordSignUp.Size = new Size(230, 16);
            TextBoxPasswordSignUp.TabIndex = 16;
            TextBoxPasswordSignUp.Text = "Enter Password";
            TextBoxPasswordSignUp.TextChanged += TextBoxPasswordSignUp_TextChanged;
            TextBoxPasswordSignUp.Enter += TextBoxPasswordSignUp_Enter;
            TextBoxPasswordSignUp.Leave += TextBoxPasswordSignUp_Leave;
            // 
            // LabelEmailValidation
            // 
            LabelEmailValidation.AutoSize = true;
            LabelEmailValidation.ForeColor = Color.Red;
            LabelEmailValidation.Location = new Point(186, 109);
            LabelEmailValidation.MinimumSize = new Size(300, 0);
            LabelEmailValidation.Name = "LabelEmailValidation";
            LabelEmailValidation.Size = new Size(300, 15);
            LabelEmailValidation.TabIndex = 24;
            LabelEmailValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelPasswordValidation
            // 
            LabelPasswordValidation.AutoSize = true;
            LabelPasswordValidation.ForeColor = Color.Red;
            LabelPasswordValidation.Location = new Point(186, 155);
            LabelPasswordValidation.MinimumSize = new Size(300, 0);
            LabelPasswordValidation.Name = "LabelPasswordValidation";
            LabelPasswordValidation.Size = new Size(300, 15);
            LabelPasswordValidation.TabIndex = 25;
            LabelPasswordValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelConfirmPasswordValidation
            // 
            LabelConfirmPasswordValidation.AutoSize = true;
            LabelConfirmPasswordValidation.ForeColor = Color.Red;
            LabelConfirmPasswordValidation.Location = new Point(187, 203);
            LabelConfirmPasswordValidation.MinimumSize = new Size(300, 0);
            LabelConfirmPasswordValidation.Name = "LabelConfirmPasswordValidation";
            LabelConfirmPasswordValidation.Size = new Size(300, 15);
            LabelConfirmPasswordValidation.TabIndex = 26;
            LabelConfirmPasswordValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Location = new Point(256, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 23);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Location = new Point(256, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 23);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.Location = new Point(256, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 23);
            panel3.TabIndex = 29;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 398);
            Controls.Add(LabelConfirmPasswordValidation);
            Controls.Add(LabelPasswordValidation);
            Controls.Add(LabelEmailValidation);
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
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            Text = "UserSignIn";
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
        private Label LabelEmailValidation;
        private Label LabelPasswordValidation;
        private Label LabelConfirmPasswordValidation;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}