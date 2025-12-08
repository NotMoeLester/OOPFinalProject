using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project {
    public partial class AdminUserManagement : Form {
        public AdminUserManagement() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //FIELDS
        StudentUserRepository repository = new StudentUserRepository();
        private DataGridViewRow? selectedRow;
        private int selectedStudentId = -1;

        //CREATE
        private void ButtonCreate_Click(object sender, EventArgs e) {
            StudentUser user = new StudentUser();
            StudentData data = new StudentData();
            user.Email = string.Empty;
            user.Password = string.Empty;

            repository.AddStudentAndStudentData(user, data);
            LoadUsers();
        }

        //READ
        private void ButtonView_Click(object sender, EventArgs e) {
            LoadUsers();
        }

        //UPDATE
        private void ButtonUpdate_Click(object sender, EventArgs e) {
            if (selectedStudentId == -1 || selectedRow == null) return;

            string email = selectedRow.Cells["Email"].Value?.ToString() ?? "";
            string password = selectedRow.Cells["Password"].Value?.ToString() ?? "";

            string emailError = Validator.Email(email);
            string passwordError = Validator.Password(password);
            if (!string.IsNullOrEmpty(emailError)) {
                MessageBox.Show($"Invalid Email: {emailError}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(passwordError)) {
                MessageBox.Show($"Invalid Password: {passwordError}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentUser user = repository.Get(selectedStudentId);
            user.Email = email;
            user.Password = password;
            user.Verification = Convert.ToBoolean(selectedRow.Cells["Verification"].Value);
            repository.UpdateStudentAndStudentData(user);

            MessageBox.Show("User updated successfully!");
            LoadUsers();
        }

        //DELETE
        private void ButtonDelete_Click(object sender, EventArgs e) {
            if (selectedStudentId == -1) return;
            StudentUser user = repository.Get(selectedStudentId);
            bool isDeleted = repository.DeleteStudentAndStudentData(user);
            if (isDeleted) MessageBox.Show("Successfully Removed");
            LoadUsers();
        }

        //GET INDEX
        private void DataGridViewUserList_CellClick_1(object? sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            selectedRow = DataGridViewUserList.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);
        }

        //LOAD USERS
        private void LoadUsers() {
            List<StudentUser> users = repository.GetAll();
            DataGridViewUserList.DataSource = users;
        }

        private void AdminUserManagement_Load(object sender, EventArgs e) {
            LoadUsers();
        }

        private void ButtonBack_Click(object sender, EventArgs e) {

           this.Close();

        }
    }
}
