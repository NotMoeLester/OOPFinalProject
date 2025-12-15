using Project.StudentClassModels;
using Project.SubjectManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class StudentEnrollmentRecordManagement : Form {

        private StudentModel User;
        private StudentRepository repository = new StudentRepository();

        public StudentEnrollmentRecordManagement(StudentModel user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            User = user;
        }

        private void ButtonViewSubjectInformation_Click_1(object sender, EventArgs e) {
            this.Hide();
            var form = new StudentSubjectManagement(User);
            form.FormClosed += (s, args) => { this.Show(); RefreshInformation(); };
            form.Show();
        }

        private void ButtonViewStudentInformation_Click(object sender, EventArgs e) {
            this.Hide();
            StudentInformationManagement form = new StudentInformationManagement(User);
            form.FormClosed += (s, args) => { this.Show(); RefreshInformation(); };
            form.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e) {

        }

        private void LoadInformation() {
            LabelEmailUER.Text = User.Email;
            LabelFullNameUER.Text = User.StudentInformation.FullName ?? "Student Name";
            LabelContactNumberUER.Text = User.StudentInformation.ContactNumber ?? "COntact Number";
            LabelYearLevel.Text = User.StudentInformation.YearLevel.ToString() ?? "Year Level";
            LabelCourseName.Text = User.StudentInformation.Course ?? "Course";
            LabelStudentID.Text = User.StudentId.ToString();
            LabelDepartmentName.Text = User.StudentInformation.Department;
            LoadEnrolledSubjects();
            var enrolledSubjects = repository.GetStudentSubjects(User.StudentId);
            bool isEnrolled = enrolledSubjects.Any();
            CheckBoxStatusEnrolled.Checked = isEnrolled;
            CheckBoxStatusNotEnrolled.Checked = !isEnrolled;
        }

        private void LoadEnrolledSubjects() {
            var enrolledSubjects = repository.GetStudentSubjects(User.StudentId);
            dataGridViewEnrolledSubjects.DataSource = new BindingList<SubjectModel>(enrolledSubjects);
        }

        private void RefreshInformation() {
            LoadInformation();
        }

        private void StudentEnrollmentRecordManagement_Load(object sender, EventArgs e) {
            LoadInformation();
            ResetSizes();
        }

        private void ButtonLogout_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        #region
        public void ResetSizes() {
            //Adjust Available Subjects DataGridView Columns
            dataGridViewEnrolledSubjects.Columns["Code"].MinimumWidth = 100;
            dataGridViewEnrolledSubjects.Columns["Subject"].MinimumWidth = 300;
            dataGridViewEnrolledSubjects.Columns["Unit"].MinimumWidth = 50;
            dataGridViewEnrolledSubjects.Columns["Schedule"].MinimumWidth = 250;
            dataGridViewEnrolledSubjects.Columns["Room"].MinimumWidth = 100;
            dataGridViewEnrolledSubjects.Columns["Instructor"].MinimumWidth = 200;
        }
        #endregion

        private void LabelDepartmentName_Click(object sender, EventArgs e) {

        }

        private void CheckBoxStatusNotEnrolled_CheckedChanged(object sender, EventArgs e) {

        }
    }

}