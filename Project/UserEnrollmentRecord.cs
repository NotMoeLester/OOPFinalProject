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

        private StudentUser User;
        public UserEnrollmentRecord(StudentUser user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            User = user;
            LabelEmailUER.Text = User.Email;
        }


        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e) {
            this.Hide();
            XXXUserEnrollmentInformation form = new XXXUserEnrollmentInformation(User);
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void ButtonViewSubjectInformation_Click_1(object sender, EventArgs e) {
            this.Hide();
            XXXUserEnrollmentInformation mainForm = new XXXUserEnrollmentInformation(User);
            mainForm.Show();
        }

        private void UserEnrollmentRecord_Load(object sender, EventArgs e) {

        }

        private void ButtonViewStudentInformation_Click(object sender, EventArgs e) {
            this.Hide();
            UserInformationForm form = new UserInformationForm(User);
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
