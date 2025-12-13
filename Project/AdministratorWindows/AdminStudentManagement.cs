using Project.HelperClass;
using Project.StudentClassModels;
using Project.SubjectManagement;
using System.Windows.Forms;

namespace Project {
    public partial class AdminStudentManagement : Form {

        private StudentRepository repository = new StudentRepository();
        private DataGridViewRow? selectedRow;
        private int selectedStudentId = -1;

        //CONSTRUCTOR =======================================================
        #region
        public AdminStudentManagement() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        //CREATE =======================================================
        #region
        private void ButtonCreate_Click(object sender, EventArgs e) {
            var student = new StudentModel();
            var studentInformation = new StudentInformationModel();
            var studentSubjectInformation = new StudentSubjectsModel();

            student.Email = "Placeholder";
            student.Password = "Placeholder";

            repository.AddStudent(student, studentInformation, studentSubjectInformation);
            LoadUsers();
        }
        #endregion

        //READ =======================================================
        #region
        private void ButtonView_Click(object sender, EventArgs e) {
            LoadUsers();
        }

        private void ButtonViewAccountInformation_Click_1(object sender, EventArgs e) {
            if (selectedStudentId == -1) {
                MessageBox.Show("Please select a user first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StudentModel? student = repository.GetStudentData(selectedStudentId);

            if (student != null) {
                if (student.StudentInformation == null) {
                    student.StudentInformation = new StudentInformationModel();
                }

                var dialog = new ViewAccountDialog(student);
                dialog.ShowDialog();
            } else {
                MessageBox.Show("Unable to load student information.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //UPDATE =======================================================
        #region
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

            StudentModel student = repository.Get(selectedStudentId);
            var studentInformation = student.StudentInformation ?? new StudentInformationModel();
            var studentSubjectsInformation = student.StudentSubject ?? new StudentSubjectsModel();

            student.Email = email;
            student.Password = password;
            student.Verification = Convert.ToBoolean(selectedRow.Cells["Verification"].Value);
            student.IsEnrolled = Convert.ToBoolean(selectedRow.Cells["IsEnrolled"].Value);

            repository.UpdateStudentAndStudentData(student, studentInformation, studentSubjectsInformation);
            ResetSelected();
            MessageBox.Show("Student updated successfully!");
            LoadUsers();
        }
        #endregion

        //DELETE =======================================================
        #region
        private void ButtonDelete_Click(object sender, EventArgs e) {
            if (selectedStudentId == -1 || selectedRow == null) {
                MessageBox.Show("Please select a user first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudentModel student = repository.Get(selectedStudentId);
            bool isDeleted = repository.DeleteStudentAndStudentData(student);
            ResetSelected();
            if (isDeleted) MessageBox.Show("Successfully Removed");
            LoadUsers();
            SetCellSizes();
        }
        #endregion

        //GET RESET INDEX =======================================================
        #region
        private void DataGridViewUserList_CellClick_1(object? sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            selectedRow = DataGridViewUserList.Rows[e.RowIndex];
            selectedStudentId = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);
        }

        private void ResetSelected() {
            selectedStudentId = -1;
            selectedRow = null;
        }

        #endregion

        //LOAD USERS =======================================================
        #region
        private void LoadUsers() {
            List<StudentModel> students = repository.GetAll();
            DataGridViewUserList.DataSource = students;
        }
        private void SetCellSizes() {
            DataGridViewUserList.Columns["StudentId"].MinimumWidth = 150;
            DataGridViewUserList.Columns["Email"].MinimumWidth = 200;
            DataGridViewUserList.Columns["Password"].MinimumWidth = 200;
            DataGridViewUserList.Columns["Verification"].MinimumWidth = 50;
            DataGridViewUserList.Columns["IsEnrolled"].MinimumWidth = 50;
        }

        private void AdminUserManagement_Load(object sender, EventArgs e) {
            LoadUsers();
            SetCellSizes();
        }

        private void ButtonBack_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

    }
}