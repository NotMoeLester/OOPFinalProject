namespace Project
{
    partial class Form1
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
            ButtonEnter = new Button();
            LabelName = new Label();
            LabelPassword = new Label();
            label1 = new Label();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            ButtonClear = new Button();
            LogIn = new Label();
            SuspendLayout();
            // 
            // ButtonEnter
            // 
            ButtonEnter.Location = new Point(477, 205);
            ButtonEnter.Name = "ButtonEnter";
            ButtonEnter.Size = new Size(160, 23);
            ButtonEnter.TabIndex = 0;
            ButtonEnter.Text = "Enter";
            ButtonEnter.UseVisualStyleBackColor = true;
            ButtonEnter.Click += ButtonEnter_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(145, 209);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(60, 15);
            LabelName.TabIndex = 1;
            LabelName.Text = "Username";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(145, 242);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 2;
            LabelPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 154);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 3;
            label1.Text = "Admin Log In";
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(221, 205);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(230, 23);
            TextBoxUsername.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(221, 237);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(230, 23);
            TextBoxPassword.TabIndex = 5;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(477, 238);
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
            LogIn.BorderStyle = BorderStyle.FixedSingle;
            LogIn.Location = new Point(221, 280);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(2, 17);
            LogIn.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogIn);
            Controls.Add(ButtonClear);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(label1);
            Controls.Add(LabelPassword);
            Controls.Add(LabelName);
            Controls.Add(ButtonEnter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonEnter;
        private Label LabelName;
        private Label LabelPassword;
        private Label label1;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private Button ButtonClear;
        private Label LogIn;
    }
}
