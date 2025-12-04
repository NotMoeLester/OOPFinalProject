using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project {
    public partial class SignUpForm : Form {

        public SignUpForm() {
            InitializeComponent();
        }

        //TEXT BOX UI=============================================================================
        private void TextBoxEmailSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxEmailSignUp.Text == "Enter Email") {
                TextBoxEmailSignUp.Text = string.Empty;
                TextBoxEmailSignUp.ForeColor = Color.Black;
                TextBoxEmailSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxEmailSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxEmailSignUp.Text == string.Empty) {
                TextBoxEmailSignUp.Text = "Enter Email";
                TextBoxEmailSignUp.ForeColor = Color.Gray;
                TextBoxEmailSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxPasswordSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxPasswordSignUp.Text == "Enter Password") {
                TextBoxPasswordSignUp.Text = string.Empty;
                TextBoxPasswordSignUp.ForeColor = Color.Black;
                TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxPasswordSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxPasswordSignUp.Text == string.Empty) {
                TextBoxPasswordSignUp.Text = "Enter Password";
                TextBoxPasswordSignUp.ForeColor = Color.Gray;
                TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxConfirmPasswordSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxConfirmPasswordSignUp.Text == "Enter Password") {
                TextBoxConfirmPasswordSignUp.Text = string.Empty;
                TextBoxConfirmPasswordSignUp.ForeColor = Color.Black;
                TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxConfirmPasswordSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxConfirmPasswordSignUp.Text == string.Empty) {
                TextBoxConfirmPasswordSignUp.Text = "Enter Password";
                TextBoxConfirmPasswordSignUp.ForeColor = Color.Gray;
                TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }

        //LINK LABEL=============================================================================
        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            loginForm.Show();
        }

        //BUTTON LOGIN=============================================================================
        private void ButtonLogin_Click(object sender, EventArgs e) {
            StudentUserRepository repository = new StudentUserRepository();

            string email = TextBoxEmailSignUp.Text.Trim();
            string password = TextBoxPasswordSignUp.Text.Trim();
            string confirmPassword = TextBoxConfirmPasswordSignUp.Text.Trim();

            if (!Validator.Email(email) || !Validator.Password(password) || !Validator.Password(confirmPassword)) {
                MessageBox.Show("Invalid Email or Password Syntax");
                return;
            }
            if (password != confirmPassword) {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            if (repository.IsUser(email)) {
                MessageBox.Show("Account already exists");
                return;
            }

            StudentUser userToSave = new StudentUser();
            userToSave.Email = email;
            userToSave.Password = password;

            bool isSaved = repository.Add(userToSave);

            if (isSaved) {
                MessageBox.Show("Account has Been Saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SignUpForm_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}

