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
    public partial class UserEnrollmentRecord : Form {

        private string _email;
        public UserEnrollmentRecord(string email) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _email = email;
            LabelEmailUER.Text = _email;
        }

        private void ButtonView_Click(object sender, EventArgs e) {
            this.Hide();
            AccountManagement mainForm = new AccountManagement();
            mainForm.Show();
        }

        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e) {
            this.Hide();
            EnrollmentInformation mainForm = new EnrollmentInformation();
            mainForm.Show();
        }

        private void ButtonViewSubjectInformation_Click_1(object sender, EventArgs e) {
            this.Hide();
            EnrollmentInformation mainForm = new EnrollmentInformation();
            mainForm.Show();
        }

        private void UserEnrollmentRecord_Load(object sender, EventArgs e) {

        }
    }
}
