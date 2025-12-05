using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserManagement : Form {
        public UserManagement() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void UserManagement_Load(object sender, EventArgs e) {

        }

        private void ButtonView_Click(object sender, EventArgs e) {
            StudentUserRepository repository = new StudentUserRepository();
            List<StudentUser> users = repository.GetAll();
            DataGridViewUserList.DataSource = users;
        }
    }
}
