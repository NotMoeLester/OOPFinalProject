
using Project.AdministratorUserData;
using Project.HelperClass;

namespace Project {
    public partial class LoginForm : Form {

        private readonly System.Windows.Forms.Timer passwordTimer;
        private StudentRepository repository = new StudentRepository();

        //CONSTRUCTOR====================================================================================
        #region
        public LoginForm() {
            InitializeComponent();
            this.Size = new Size(816, 489);
            this.StartPosition = FormStartPosition.CenterScreen;
            passwordTimer = new System.Windows.Forms.Timer();
            passwordTimer.Interval = 1000;
            passwordTimer.Tick += PasswordTimer_Tick; 
        }
        #endregion

        //LOAD =========================================================================================
        #region
        private void LoginForm_Load(object sender, EventArgs e) {
            ComboBoxUser.SelectedIndex = 0;
        }
        #endregion

        //LOG IN BUTTON====================================================================================
        #region
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
                StudentRepository repository = new StudentRepository();
                if (!repository.IsUser(email)) {
                    MessageBox.Show("Account doesn't exist", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StudentModel student = repository.GetUserByEmailAndPassword(email, password);
                if (student == null) {
                    LabelPasswordValidator.Text = "Incorrect Password";
                    return;
                }
                if (!student.Verification) {
                    MessageBox.Show("Account is not yet verified", "Contact Admin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                student.StudentInformation = repository.GetStudentData(student.StudentId)?.StudentInformation ?? new StudentInformationModel();

                //Open main Form (Login Form - User Account)-------------------------------------------------
                StudentEnrollmentRecordManagement mainForm = new StudentEnrollmentRecordManagement(student);
                mainForm.FormClosed += (s, args) => this.Close();
                this.Hide();
                mainForm.Show();

                //ADMINISTRATOR USER LOGIN=========================================================================
            } else if (usertype == "Administrator") {
                AdminStudentManagement adminForm = new AdminStudentManagement();
                this.Hide();
                adminForm.FormClosed += (s, args) => this.Show();
                adminForm.Show();
            }
        }
        #endregion

        //LINK LABEL=======================================================================================
        #region
        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignUpForm signUpForm = new SignUpForm(this);
            this.Enabled = false;
            signUpForm.FormClosed += (s, args) => this.Enabled = true;
            signUpForm.Show();
        }
        #endregion

        //TEXT BOX USER INTERACTION ========================================================================
        #region
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
        #endregion

        //FEEDBACK FOR EMAIL & PASSWORD =====================================================================
        #region
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
        private void PasswordTimer_Tick(object? sender, EventArgs e) {
            if (!string.IsNullOrEmpty(TextBoxPassword.Text)) {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
            passwordTimer.Stop();
        }
        #endregion
    }
}
