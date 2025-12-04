
namespace Project
{
    public partial class LoginForm : Form
    {

        StudentUserRepository repository = new StudentUserRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ComboBoxUser.SelectedIndex = 0;

        }

        //TEXT BOX UI=============================================================================
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "Enter Email")
            {
                TextBoxEmail.Text = string.Empty;
                TextBoxEmail.ForeColor = Color.Black;
                TextBoxEmail.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            }
        }
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == string.Empty)
            {
                TextBoxEmail.Text = "Enter Email";
                TextBoxEmail.ForeColor = Color.Gray;
                TextBoxEmail.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Enter Password")
            {
                TextBoxPassword.Text = string.Empty;
                TextBoxPassword.UseSystemPasswordChar = true;
                TextBoxPassword.ForeColor = Color.Black;
                TextBoxPassword.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == string.Empty)
            {
                TextBoxPassword.Text = "Enter Password";
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.ForeColor = Color.Gray;
                TextBoxPassword.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
        }

        //LINK LABEL=============================================================================
        private void LinkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();

            signUpForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            signUpForm.Show();
        }

        //LOG IN BUTTON=============================================================================
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            if (!Validator.Email(email) || !Validator.Password(password))
            {
                MessageBox.Show("Invalid Email or Password Syntax");
                return;
            }
            StudentUserRepository repository = new StudentUserRepository();
            if (!repository.IsUser(email))
            {
                MessageBox.Show("Account doesn't exist");
                return;
            }
            StudentUser user = repository.GetUserByEmailAndPassword(email, password);
            if (user == null)
            {
                MessageBox.Show("Incorrect Password");
                return;
            }

            UserEnrollmentRecord mainForm = new UserEnrollmentRecord();

            mainForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            mainForm.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {




        }
    }
}
