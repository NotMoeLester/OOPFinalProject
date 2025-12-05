using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUndo1_Click(object sender, EventArgs e)
        {
            LoginForm registerForm = new LoginForm();

            registerForm.FormClosed += (s, args) => this.Close();

            this.Hide();
            registerForm.Show();
        }

        private void checkBoxFullyPaid_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void ButtonViewRecords_Click(object sender, EventArgs e)
        {
            //UserEnrollmentRecord Form = new UserEnrollmentRecord();

            //registerForm.FormClosed += (s, args) => this.Close();

            //this.Hide();
            //registerForm.Show();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
