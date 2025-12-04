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
    public partial class EnrollmentInformation : Form
    {
        public EnrollmentInformation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonViewSubjectInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentInformation mainForm = new EnrollmentInformation();
            mainForm.Show();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountManagement mainForm = new AccountManagement();
            mainForm.Show();
        }

        private void EnrollmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
