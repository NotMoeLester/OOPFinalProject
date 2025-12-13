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
    public partial class XXXUserAccount : Form {

        private StudentModel User;
        public XXXUserAccount(StudentModel user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.User = user;
            LabelEmailUER.Text = user.Email;

        }


        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e) {
            this.Hide();
            XXXUserEnrollmentInformation form = new XXXUserEnrollmentInformation(User);
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }


        private void ButtonViewStudentInformation_Click(object sender, EventArgs e) {
            this.Hide();
            StudentInformationManagement form = new StudentInformationManagement(User);
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void LabelEmailUER_Click(object sender, EventArgs e) {

        }

        private void UserAccount_Load(object sender, EventArgs e) {

        }
    }
}
