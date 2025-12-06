
using Project.AdministratorUserData;

namespace Project
{
    public partial class LoginForm : Form {

        private System.Windows.Forms.Timer passwordTimer;

        StudentUserRepository repository = new StudentUserRepository();
        public LoginForm() {
            InitializeComponent();
            this.Size = new Size(816, 489);
            this.StartPosition = FormStartPosition.CenterScreen;
            passwordTimer = new System.Windows.Forms.Timer();
            passwordTimer.Interval = 1000; // 2000 ms = 2 seconds
            passwordTimer.Tick += PasswordTimer_Tick;
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            ComboBoxUser.SelectedIndex = 0;

        }

        //TEXT BOX UI=============================================================================
        private void TextBoxEmail_Enter(object sender, EventArgs e) {
            if (TextBoxEmail.Text == "Enter Email") {
                TextBoxEmail.Text = string.Empty;
                TextBoxEmail.ForeColor = Color.Black;
                TextBoxEmail.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            }
        }
        private void TextBoxEmail_Leave(object sender, EventArgs e) {
            if (TextBoxEmail.Text == string.Empty) {
                TextBoxEmail.Text = "Enter Email";
                TextBoxEmail.ForeColor = Color.Gray;
                TextBoxEmail.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxPassword_Enter(object sender, EventArgs e) {
            if (TextBoxPassword.Text == "Enter Password") {
                TextBoxPassword.Text = string.Empty;
                TextBoxPassword.UseSystemPasswordChar = true;
                TextBoxPassword.ForeColor = Color.Black;
                TextBoxPassword.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxPassword_Leave(object sender, EventArgs e) {
            if (TextBoxPassword.Text == string.Empty) {
                TextBoxPassword.Text = "Enter Password";
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.ForeColor = Color.Gray;
                TextBoxPassword.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }

        //LINK LABEL=============================================================================
        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUpForm signUpForm = new SignUpForm();

            signUpForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            signUpForm.Show();
        }

        //LOG IN BUTTON=============================================================================
        private void ButtonLogin_Click(object sender, EventArgs e) {

            string usertype = ComboBoxUser.Text;
            string email = TextBoxEmail.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            //STUDENT USER LOGIN=========================================================================
            if (usertype == "Student") {
                if (Validator.Email(email) != string.Empty) {
                    LabelEmailValidator.Text = Validator.Email(email);
                    return;
                }
                StudentUserRepository repository = new StudentUserRepository();
                if (!repository.IsUser(email)) {
                    MessageBox.Show("Account doesn't exist", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StudentUser user = repository.GetUserByEmailAndPassword(email, password);
                if (user == null) {
                    LabelPasswordValidator.Text = "Incorrect Password";
                    return;
                }

                //Open main Form (Login Form - User Enrollment Record)-------------------------------------------------
                UserEnrollmentRecord mainForm = new UserEnrollmentRecord(email);
                mainForm.FormClosed += (s, args) => this.Close();
                this.Hide();
                mainForm.Show();

                //ADMINISTRATOR USER LOGIN=========================================================================
            } else if (usertype == "Administrator") {
                //AdministratorRepository repository = new AdministratorRepository();
                //if (!repository.IsUser(email)) {
                //    MessageBox.Show("Account doesn't exist", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                //AdministratorUser user = repository.GetUserByEmailAndPassword(email, password);
                //if (user == null) {
                //    MessageBox.Show("Incorrect Password", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                AdminUserManagement mainForm = new AdminUserManagement();
                mainForm.FormClosed += (s, args) => this.Close();
                this.Hide();
                mainForm.Show();
            }
        }

        //FEEDBACK
        private void TextBoxPassword_TextChanged(object sender, EventArgs e) {
            LabelPasswordValidator.Text = string.Empty;
        }
        private void TextBoxEmail_TextChanged(object sender, EventArgs e) {
            LabelEmailValidator.Text = string.Empty;
        }

        private void buttonShowPassword_Click(object sender, EventArgs e) {

            if (!string.IsNullOrEmpty(TextBoxPassword.Text)) {
                TextBoxPassword.UseSystemPasswordChar = false;
                passwordTimer.Start();
            }
        }

        private void PasswordTimer_Tick(object sender, EventArgs e) {

            if (!string.IsNullOrEmpty(TextBoxPassword.Text)) {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
            passwordTimer.Stop();

        }
    }
}
