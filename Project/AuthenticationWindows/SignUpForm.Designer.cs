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
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(364, 254);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 15);
            LogIn.TabIndex = 17;
            // 
            // TextBoxEmailSignUp
            // 
            TextBoxEmailSignUp.BorderStyle = BorderStyle.None;
            TextBoxEmailSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxEmailSignUp.ForeColor = Color.Gray;
            TextBoxEmailSignUp.Location = new Point(3, 3);
            TextBoxEmailSignUp.Name = "TextBoxEmailSignUp";
            TextBoxEmailSignUp.Size = new Size(224, 16);
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
            label1.Location = new Point(286, 82);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 14;
            label1.Text = "User Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(286, 249);
            label2.Name = "label2";
            label2.Size = new Size(41, 12);
            label2.TabIndex = 21;
            label2.Text = "Confirm :";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Segoe UI", 6.75F);
            LabelPassword.ForeColor = Color.Navy;
            LabelPassword.Location = new Point(286, 186);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(47, 12);
            LabelPassword.TabIndex = 13;
            LabelPassword.Text = "Password :";
            // 
            // TextBoxConfirmPasswordSignUp
            // 
            TextBoxConfirmPasswordSignUp.BorderStyle = BorderStyle.None;
            TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TextBoxConfirmPasswordSignUp.ForeColor = Color.Gray;
            TextBoxConfirmPasswordSignUp.Location = new Point(3, 3);
            TextBoxConfirmPasswordSignUp.Name = "TextBoxConfirmPasswordSignUp";
            TextBoxConfirmPasswordSignUp.Size = new Size(224, 16);
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
            LabelName.Location = new Point(286, 124);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(31, 12);
            LabelName.TabIndex = 12;
            LabelName.Text = "Email :";
            // 
            // LinkLabelLogin
            // 
            LinkLabelLogin.AutoSize = true;
            LinkLabelLogin.LinkColor = Color.Gray;
            LinkLabelLogin.Location = new Point(392, 361);
            LinkLabelLogin.Name = "LinkLabelLogin";
            LinkLabelLogin.Size = new Size(124, 15);
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
            ButtonSignUp.Location = new Point(286, 319);
            ButtonSignUp.Name = "ButtonSignUp";
            ButtonSignUp.Size = new Size(230, 33);
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
            TextBoxPasswordSignUp.Location = new Point(289, 205);
            TextBoxPasswordSignUp.Name = "TextBoxPasswordSignUp";
            TextBoxPasswordSignUp.Size = new Size(224, 16);
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
            LabelEmailValidation.Location = new Point(216, 165);
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
            LabelPasswordValidation.Location = new Point(216, 227);
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
            LabelConfirmPasswordValidation.Location = new Point(217, 289);
            LabelConfirmPasswordValidation.MinimumSize = new Size(300, 0);
            LabelConfirmPasswordValidation.Name = "LabelConfirmPasswordValidation";
            LabelConfirmPasswordValidation.Size = new Size(300, 15);
            LabelConfirmPasswordValidation.TabIndex = 26;
            LabelConfirmPasswordValidation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TextBoxEmailSignUp);
            panel1.Location = new Point(286, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 23);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(286, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 23);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextBoxConfirmPasswordSignUp);
            panel3.Location = new Point(286, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 23);
            panel3.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(152, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 403);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-165, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(981, 50);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(724, 384);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 66);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(6, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 66);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(668, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(175, 136);
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(-10, 227);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(175, 136);
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
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
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            Text = "UserSignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}