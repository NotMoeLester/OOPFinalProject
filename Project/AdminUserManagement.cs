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
    public partial class AdminUserManagement : Form {
        public AdminUserManagement() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //FIELDS
        StudentUserRepository repository = new StudentUserRepository();
        private DataGridViewRow selectedRow;
        private int selectedStudentId = -1;

        //READ
        private void ButtonView_Click(object sender, EventArgs e) {
            LoadUsers();
        }

        //UPDATE
        private void ButtonUpdate_Click(object sender, EventArgs e) {
            if (selectedStudentId == -1 || selectedRow == null) return;

            StudentUser user = repository.Get(selectedStudentId);

            user.FullName = selectedRow.Cells["FullName"].Value?.ToString() ?? "";
            user.Email = selectedRow.Cells["Email"].Value?.ToString() ?? "";
            user.Password = selectedRow.Cells["Password"].Value?.ToString() ?? "";
            user.Verification = Convert.ToBoolean(selectedRow.Cells["Verification"].Value);

            repository.UpdateStudent(user);
            MessageBox.Show("User updated successfully!");
            LoadUsers();
        }

        //DELETE
        private void ButtonDelete_Click(object sender, EventArgs e) {
            if (selectedStudentId == -1) return;
            StudentUser user = repository.Get(selectedStudentId);
            bool isDeleted = repository.DeleteStudent(user);
            if (isDeleted) MessageBox.Show("Successfully Removed");
            LoadUsers();
        }

        //GET INDEX
        private void DataGridViewUserList_CellClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            selectedRow = DataGridViewUserList.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);
        }

        //LOAD USERS
        private void LoadUsers() {
            List<StudentUser> users = repository.GetAll();
            DataGridViewUserList.DataSource = users;
        }

        private void ButtonCreate_Click(object sender, EventArgs e) {
            StudentUser user = new StudentUser();
            user.FullName = string.Empty;
            user.Email = string.Empty;
            user.Password = string.Empty;

            repository.Add(user);
            LoadUsers();
        }
    }
}
