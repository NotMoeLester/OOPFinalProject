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
        public UserEnrollmentInformation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEnrollmentInformation mainForm = new UserEnrollmentInformation();
            mainForm.Show();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccountManagement mainForm = new UserAccountManagement();
            mainForm.Show();
        }

        private void EnrollmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
