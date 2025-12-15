using Microsoft.VisualBasic.ApplicationServices;
using Project.HelperClass;
using Project.StudentClassModels;
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
        private LoginForm LoginForm;

        //CONSTRUCTOR==========================================================================
        #region
        public SignUpForm(LoginForm loginForm) {
            InitializeComponent();
            this.Size = new Size(816, 489);
            this.StartPosition = FormStartPosition.CenterScreen;
            LoginForm = loginForm;
        }
        #endregion

        //TEXT BOX UI=============================================================================
        #region
        private void TextBoxEmailSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxEmailSignUp.Text == " Enter Email") {
                TextBoxEmailSignUp.Text = string.Empty;
                TextBoxEmailSignUp.ForeColor = Color.Black;
                TextBoxEmailSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxEmailSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxEmailSignUp.Text == string.Empty) {
                TextBoxEmailSignUp.Text = " Enter Email";
                TextBoxEmailSignUp.ForeColor = Color.Gray;
                TextBoxEmailSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxPasswordSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxPasswordSignUp.Text == " Enter Password") {
                TextBoxPasswordSignUp.Text = string.Empty;
                TextBoxPasswordSignUp.ForeColor = Color.Black;
                TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxPasswordSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxPasswordSignUp.Text == string.Empty) {
                TextBoxPasswordSignUp.Text = " Enter Password";
                TextBoxPasswordSignUp.ForeColor = Color.Gray;
                TextBoxPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxConfirmPasswordSignUp_Enter(object sender, EventArgs e) {
            if (TextBoxConfirmPasswordSignUp.Text == " Confirm Password") {
                TextBoxConfirmPasswordSignUp.Text = string.Empty;
                TextBoxConfirmPasswordSignUp.ForeColor = Color.Black;
                TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxConfirmPasswordSignUp_Leave(object sender, EventArgs e) {
            if (TextBoxConfirmPasswordSignUp.Text == string.Empty) {
                TextBoxConfirmPasswordSignUp.Text = " Confirm Password";
                TextBoxConfirmPasswordSignUp.ForeColor = Color.Gray;
                TextBoxConfirmPasswordSignUp.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        #endregion

        //LINK LABEL=============================================================================
        #region
        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
            LoginForm.Show();
        }
        #endregion

        //BUTTON SIGNUP=============================================================================
        #region
        private void ButtonSignUp_Click(object sender, EventArgs e) {
            StudentRepository repository = new StudentRepository();

            string email = TextBoxEmailSignUp.Text.Trim();
            string password = TextBoxPasswordSignUp.Text.Trim();
            string confirmPassword = TextBoxConfirmPasswordSignUp.Text.Trim();

            if (Validator.EmailSignUp(email) != string.Empty || Validator.Password(password) != string.Empty) {
                LabelEmailValidation.Text = Validator.EmailSignUp(email);
                return;
            }
            if (Validator.Password(password) != string.Empty || Validator.ConfirmPassword(password, confirmPassword) != string.Empty) {
                LabelPasswordValidation.Text = Validator.Password(password);
                LabelConfirmPasswordValidation.Text = Validator.ConfirmPassword(password, confirmPassword);
                return;
            }

            //Add user to database---------------------------------------------------------------------------
            var userToSave = new StudentModel();
            var userDataToSave = new StudentInformationModel();
            var userSubjectsToSave = new StudentSubjectsModel();

            userToSave.Email = email;
            userToSave.Password = password;

            bool isSaved = repository.AddStudent(userToSave, userDataToSave, userSubjectsToSave);
            if (isSaved) {
                MessageBox.Show("Succesfully signed in!\nWaiting for Admin Verification.\nProceed to Login?", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                LoginForm.Show();
            } else {
                MessageBox.Show("Unsuccesfull!\nTry Again", "Successful!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        #endregion

        //LABEL FEEDBACK RESET =======================================================================
        #region
        private void TextBoxEmailSignUp_TextChanged(object sender, EventArgs e) {
            LabelEmailValidation.Text = string.Empty;
        }
        private void TextBoxPasswordSignUp_TextChanged(object sender, EventArgs e) {
            LabelPasswordValidation.Text = string.Empty;
        }
        private void TextBoxConfirmPasswordSignUp_TextChanged(object sender, EventArgs e) {
            LabelConfirmPasswordValidation.Text = string.Empty;
        }
        #endregion
    }
}

