namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {

            TextBoxUsername.Text = string.Empty;
            TextBoxPassword.Text = string.Empty;

        }


        private void ButtonEnter_Click(object sender, EventArgs e)
        {

            string Username = "Admin123";
            string Password = "123456789";

            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text) || string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {

                LogIn.Text = "Cannot Leave Blank!";

            }
            else
            {
                if (TextBoxUsername.Text == Username && TextBoxPassword.Text == Password)
                {

                    LogIn.Text = "Login Succesfull!";

                }
                else
                {
                    LogIn.Text = "Incorrect Username or Password!";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
