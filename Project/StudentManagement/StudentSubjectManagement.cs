using Project.AdministratorClassModels;
using Project.StudentClassModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.SubjectManagement {
    public partial class StudentSubjectManagement : Form {
        private StudentModel Student;
        private BindingList<SubjectModel> enrolledSubjects = new BindingList<SubjectModel>();
        private BindingList<SubjectModel> availableSubjects;
        public StudentSubjectManagement(StudentModel student) {
            InitializeComponent();
            Student = student;
        }

        private void StudentSubjectManagement_Load(object sender, EventArgs e) {
            var repository = new StudentRepository();

            CourseSubjectsModel subjectAvailable = new CourseSubjectsModel();
            availableSubjects = new BindingList<SubjectModel>(
                subjectAvailable.GetSubjectsForCourse(Student.StudentInformation.Course)
            );
            dataGridViewAvailableSubjects.DataSource = availableSubjects;

            // Load enrolled subjects into a BindingList
            var enrolledSubjectList = repository.GetStudentSubjects(Student.StudentId);
            enrolledSubjects = new BindingList<SubjectModel>(enrolledSubjectList);
            dataGridViewEnrolledSubjects.DataSource = enrolledSubjects;

            ResetSizes();
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            if (dataGridViewAvailableSubjects.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a subject to enroll.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewAvailableSubjects.SelectedRows[0];
            var subject = (SubjectModel)selectedRow.DataBoundItem;

            if (enrolledSubjects.Any(s => s.Code == subject.Code)) {
                MessageBox.Show("You are already enrolled in this subject.");
                return;
            }

            enrolledSubjects.Add(subject);
        }

        public void ResetSizes() {
            //Adjust Available Subjects DataGridView Columns
            dataGridViewAvailableSubjects.Columns["Code"].MinimumWidth = 100;
            dataGridViewAvailableSubjects.Columns["Subject"].MinimumWidth = 300;
            dataGridViewAvailableSubjects.Columns["Unit"].MinimumWidth = 50;
            dataGridViewAvailableSubjects.Columns["Schedule"].MinimumWidth = 250;
            dataGridViewAvailableSubjects.Columns["Room"].MinimumWidth = 100;
            dataGridViewAvailableSubjects.Columns["Instructor"].MinimumWidth = 200;

            //Adjust Enrolled Subjects DataGridView Columns
            dataGridViewEnrolledSubjects.Columns["Code"].MinimumWidth = 100;
            dataGridViewEnrolledSubjects.Columns["Subject"].MinimumWidth = 300;
            dataGridViewEnrolledSubjects.Columns["Unit"].MinimumWidth = 50;
            dataGridViewEnrolledSubjects.Columns["Schedule"].MinimumWidth = 250;
            dataGridViewEnrolledSubjects.Columns["Room"].MinimumWidth = 100;
            dataGridViewEnrolledSubjects.Columns["Instructor"].MinimumWidth = 200;
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            var repository = new StudentRepository();
            repository.UpdateStudentSubjects(Student.StudentId, enrolledSubjects.ToList());
            MessageBox.Show("Subjects updated successfully!");
        }

        private void ButtonDrop_Click(object sender, EventArgs e) {
            if (dataGridViewEnrolledSubjects.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a subject to drop.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewEnrolledSubjects.SelectedRows[0];
            var subject = (SubjectModel)selectedRow.DataBoundItem;

            enrolledSubjects.Remove(subject);

            MessageBox.Show($"Successfully dropped {subject.Subject}.");
        }
    }
}
