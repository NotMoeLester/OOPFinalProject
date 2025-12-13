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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            LogIn = new Label();
            TextBoxEmailSignUp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LabelPassword = new Label();
            TextBoxConfirmPasswordSignUp = new TextBox();
            LabelName = new Label();
            LinkLabelLogin = new LinkLabel();
            ButtonSignUp = new Button();
            TextBoxPasswordSignUp = new TextBox();
            LabelEmailValidation = new Label();
            LabelPasswordValidation = new Label();
            LabelConfirmPasswordValidation = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(382, 264);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 20);
            LogIn.TabIndex = 17;
            // 
            // TextBoxEmailSignUp
            // 
            TextBoxEmailSignUp.BorderStyle = BorderStyle.None;
            TextBoxEmailSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmailSignUp.ForeColor = Color.Gray;
            TextBoxEmailSignUp.Location = new Point(3, 4);
            TextBoxEmailSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxEmailSignUp.Name = "TextBoxEmailSignUp";
            TextBoxEmailSignUp.Size = new Size(256, 20);
            TextBoxEmailSignUp.TabIndex = 15;
            TextBoxEmailSignUp.Text = " Enter Email";
            TextBoxEmailSignUp.TextChanged += TextBoxEmailSignUp_TextChanged;
            TextBoxEmailSignUp.Enter += TextBoxEmailSignUp_Enter;
            TextBoxEmailSignUp.Leave += TextBoxEmailSignUp_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(293, 35);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 14;
            label1.Text = "User Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(293, 257);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 21;
            label2.Text = "Confirm :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Segoe UI", 6.75F);
            LabelPassword.ForeColor = Color.Navy;
            LabelPassword.Location = new Point(293, 173);
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
            TextBoxConfirmPasswordSignUp.Location = new Point(3, 4);
            TextBoxConfirmPasswordSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxConfirmPasswordSignUp.Name = "TextBoxConfirmPasswordSignUp";
            TextBoxConfirmPasswordSignUp.Size = new Size(256, 20);
            TextBoxConfirmPasswordSignUp.TabIndex = 22;
            TextBoxConfirmPasswordSignUp.Text = " Confirm Password";
            TextBoxConfirmPasswordSignUp.TextChanged += TextBoxConfirmPasswordSignUp_TextChanged;
            TextBoxConfirmPasswordSignUp.Enter += TextBoxConfirmPasswordSignUp_Enter;
            TextBoxConfirmPasswordSignUp.Leave += TextBoxConfirmPasswordSignUp_Leave;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 6.75F);
            LabelName.ForeColor = Color.Navy;
            LabelName.Location = new Point(293, 91);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(42, 15);
            LabelName.TabIndex = 12;
            LabelName.Text = "Email :";
            // 
            // LinkLabelLogin
            // 
            LinkLabelLogin.AutoSize = true;
            LinkLabelLogin.LinkColor = Color.Gray;
            LinkLabelLogin.Location = new Point(414, 407);
            LinkLabelLogin.Name = "LinkLabelLogin";
            LinkLabelLogin.Size = new Size(156, 20);
            LinkLabelLogin.TabIndex = 23;
            LinkLabelLogin.TabStop = true;
            LinkLabelLogin.Text = "Already a user? LOGIN";
            LinkLabelLogin.LinkClicked += LinkLabelLogin_LinkClicked;
            // 
            // ButtonSignUp
            // 
            ButtonSignUp.BackColor = Color.DarkBlue;
            ButtonSignUp.FlatStyle = FlatStyle.Flat;
            ButtonSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSignUp.ForeColor = SystemColors.ControlLightLight;
            ButtonSignUp.Location = new Point(293, 351);
            ButtonSignUp.Margin = new Padding(3, 4, 3, 4);
            ButtonSignUp.Name = "ButtonSignUp";
            ButtonSignUp.Size = new Size(263, 44);
            ButtonSignUp.TabIndex = 11;
            ButtonSignUp.Text = "Sign Up";
            ButtonSignUp.UseVisualStyleBackColor = false;
            ButtonSignUp.Click += ButtonSignUp_Click;
            // 
            // TextBoxPasswordSignUp
            // 
            TextBoxPasswordSignUp.BorderStyle = BorderStyle.None;
            TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxPasswordSignUp.ForeColor = Color.Gray;
            TextBoxPasswordSignUp.Location = new Point(296, 199);
            TextBoxPasswordSignUp.Margin = new Padding(3, 4, 3, 4);
            TextBoxPasswordSignUp.Name = "TextBoxPasswordSignUp";
            TextBoxPasswordSignUp.Size = new Size(256, 20);
            TextBoxPasswordSignUp.TabIndex = 16;
            TextBoxPasswordSignUp.Text = " Enter Password";
            TextBoxPasswordSignUp.TextChanged += TextBoxPasswordSignUp_TextChanged;
            TextBoxPasswordSignUp.Enter += TextBoxPasswordSignUp_Enter;
            TextBoxPasswordSignUp.Leave += TextBoxPasswordSignUp_Leave;
            // 
            // LabelEmailValidation
            // 
            LabelEmailValidation.AutoSize = true;
            LabelEmailValidation.ForeColor = Color.Red;
            LabelEmailValidation.Location = new Point(213, 145);
            LabelEmailValidation.MinimumSize = new Size(343, 0);
            LabelEmailValidation.Name = "LabelEmailValidation";
            LabelEmailValidation.Size = new Size(343, 20);
            LabelEmailValidation.TabIndex = 24;
            LabelEmailValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelPasswordValidation
            // 
            LabelPasswordValidation.AutoSize = true;
            LabelPasswordValidation.ForeColor = Color.Red;
            LabelPasswordValidation.Location = new Point(213, 228);
            LabelPasswordValidation.MinimumSize = new Size(343, 0);
            LabelPasswordValidation.Name = "LabelPasswordValidation";
            LabelPasswordValidation.Size = new Size(343, 20);
            LabelPasswordValidation.TabIndex = 25;
            LabelPasswordValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelConfirmPasswordValidation
            // 
            LabelConfirmPasswordValidation.AutoSize = true;
            LabelConfirmPasswordValidation.ForeColor = Color.Red;
            LabelConfirmPasswordValidation.Location = new Point(214, 311);
            LabelConfirmPasswordValidation.MinimumSize = new Size(343, 0);
            LabelConfirmPasswordValidation.Name = "LabelConfirmPasswordValidation";
            LabelConfirmPasswordValidation.Size = new Size(343, 20);
            LabelConfirmPasswordValidation.TabIndex = 26;
            LabelConfirmPasswordValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TextBoxEmailSignUp);
            panel1.Location = new Point(293, 111);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 30);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(293, 193);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 30);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextBoxConfirmPasswordSignUp);
            panel3.Location = new Point(293, 276);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 30);
            panel3.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(139, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(571, 537);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 573);
            Controls.Add(LabelConfirmPasswordValidation);
            Controls.Add(LogIn);
            Controls.Add(TextBoxPasswordSignUp);
            Controls.Add(ButtonSignUp);
            Controls.Add(LinkLabelLogin);
            Controls.Add(label1);
            Controls.Add(LabelName);
            Controls.Add(label2);
            Controls.Add(LabelPassword);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(LabelEmailValidation);
            Controls.Add(LabelPasswordValidation);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "SignUpForm";
            Text = "UserSignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button ButtonSignUp;
        private TextBox TextBoxPasswordSignUp;
        private Label LabelEmailValidation;
        private Label LabelPasswordValidation;
        private Label LabelConfirmPasswordValidation;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}