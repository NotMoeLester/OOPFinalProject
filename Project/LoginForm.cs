using Microsoft.VisualBasic;

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
        
        //if (comboBox1.selected == "admin"){
        private void ButtonEnter_Click(object sender, EventArgs e)
        {

            string UsernameAdmin = "Admin123";
            string PasswordAdmin = "123456789";

            string PasswordLester = "Lestochs";
            string UsernameLester = "AdminLester";

            string PasswordLance = "Lanzzzzz";
            string UsernameLance = "AdminLance";

            string PasswordKirby = "KirbustOnYOu";
            string UsernameKirby = "AdminKirby";

            string PasswordShadReignerDummac = "Dashadumss";
            string UsernameShadReignerDummac = "AdminShad";


            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text) || string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {

                LogIn.Text = "Cannot Leave Blank!";

            }
            else
            {
                if (TextBoxUsername.Text == UsernameAdmin && TextBoxPassword.Text == PasswordAdmin)
                {

                    LogIn.Text = "Login Succesfull!";

                }
                else if (TextBoxUsername.Text == UsernameLester && TextBoxPassword.Text == PasswordLester)
                {
                    LogIn.Text = "Login Succesfull!";
                    MessageBox.Show("Hello Daddy Admin Lester", "Log In Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TextBoxUsername.Text == UsernameLance && TextBoxPassword.Text == PasswordLance)
                {
                    LogIn.Text = "Login Succesfull!";
                    MessageBox.Show("Hello Admin Lance", "Log In Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (TextBoxUsername.Text == UsernameKirby && TextBoxPassword.Text == PasswordKirby)
                {
                    LogIn.Text = "Login Succesfull!";
                    MessageBox.Show("Hello Admin Kirby", "Log In Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
