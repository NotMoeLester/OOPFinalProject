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
    public partial class XXXUserEnrollmentInformation : Form
    {
        private StudentModel User;
        public XXXUserEnrollmentInformation(StudentModel user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            User = user;
        }

        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            XXXUserEnrollmentInformation mainForm = new XXXUserEnrollmentInformation(User);
            mainForm.Show();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            this.Hide();
            XXXUserAccountManagement mainForm = new XXXUserAccountManagement(User);
            mainForm.Show();
        }

        private void EnrollmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
