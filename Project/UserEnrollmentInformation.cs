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
    public partial class UserEnrollmentInformation : Form
    {
        private StudentUser User;
        public UserEnrollmentInformation(StudentUser user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            User = user;
        }

        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEnrollmentInformation mainForm = new UserEnrollmentInformation(User);
            mainForm.Show();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccountManagement mainForm = new UserAccountManagement(User);
            mainForm.Show();
        }

        private void EnrollmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
