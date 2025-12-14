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
        private List<SubjectModel> originalSubjects = new List<SubjectModel>();

        private BindingList<SubjectModel>? availableSubjects;
        private StudentRepository repository = new StudentRepository();

        public StudentSubjectManagement(StudentModel student) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Student = student;
        }

        private void StudentSubjectManagement_Load(object sender, EventArgs e) {
            LoadAvailableSubjects();
            LoadEnrolledSubjects();
            ResetSizes();
        }

        //ADD SUBJECT ===============================================================================
        #region
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
            UpdateTotalUnitsFromStudent();
        }
        #endregion

        //DROP SUBJECT===============================================================================
        #region
        private void ButtonDrop_Click(object sender, EventArgs e) {
            if (dataGridViewEnrolledSubjects.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a subject to drop.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewEnrolledSubjects.SelectedRows[0];
            var subject = (SubjectModel)selectedRow.DataBoundItem;

            enrolledSubjects.Remove(subject);
            UpdateTotalUnitsFromStudent();

            MessageBox.Show($"Successfully dropped {subject.Subject}.");
        }
        #endregion

        //SAVE TO DATABASE ===============================================================================
        #region
        private void ButtonSave_Click(object sender, EventArgs e) {
            repository.UpdateStudentSubjects(Student.StudentId, enrolledSubjects.ToList());

            repository.UpdateStudentAndStudentData(Student, Student.StudentInformation, Student.StudentSubject);

            originalSubjects = enrolledSubjects.Select(s => new SubjectModel {Code = s.Code, Subject = s.Subject, Unit = s.Unit, Schedule = s.Schedule, Room = s.Room, Instructor = s.Instructor, IsEnrolled = s.IsEnrolled }).ToList();

            MessageBox.Show("Subjects and total units updated successfully!");
        }
        #endregion

        //RESET DATAGRIDVIEW COLUMN SIZES
        #region
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
            #endregion
        }

        private void LoadAvailableSubjects() {
            AdmininistratorCourseSubjectsModel subjectAvailable = new AdmininistratorCourseSubjectsModel();
            string course = Student?.StudentInformation?.Course ?? "";
            availableSubjects = new BindingList<SubjectModel>(
                subjectAvailable.GetSubjectsForCourse(course)
            );
            dataGridViewAvailableSubjects.DataSource = availableSubjects;
        }
        private void LoadEnrolledSubjects() {
            var enrolledSubjectList = repository.GetStudentSubjects(Student.StudentId);
            enrolledSubjects = new BindingList<SubjectModel>(enrolledSubjectList);
            dataGridViewEnrolledSubjects.DataSource = enrolledSubjects;

            // Keep a copy for change detection
            originalSubjects = enrolledSubjectList.Select(s => new SubjectModel { Code = s.Code, Subject = s.Subject, Unit = s.Unit, Schedule = s.Schedule, Room = s.Room, Instructor = s.Instructor, IsEnrolled = s.IsEnrolled}).ToList();

            Student.StudentSubject = new StudentSubjectsModel {StudentId = Student.StudentId, Subjects = enrolledSubjects.ToList() };

            enrolledSubjects.ListChanged += (s, e) => { Student.StudentSubject.Subjects = enrolledSubjects.ToList(); UpdateTotalUnitsFromStudent(); };

            UpdateTotalUnitsFromStudent();
        }
        private void UpdateTotalUnitsFromStudent() {
            if (Student?.StudentInformation == null || Student.StudentSubject == null)
                return;

            int totalUnits = Student.StudentSubject.Subjects?.Sum(s => s.Unit) ?? 0;
            Student.StudentInformation.TotalUnits = totalUnits;

            if (LabelTotalUnits != null)
                LabelTotalUnits.Text = $"Total Units: {totalUnits}";
        }

        private void ButtonBack_Click(object sender, EventArgs e) {
            bool hasChanges = !enrolledSubjects.Select(s => s.Code).SequenceEqual(originalSubjects.Select(s => s.Code));

            if (hasChanges) {
                var result = MessageBox.Show("You have unsaved changes. Do you want to exit and discard changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
            }
            this.Close();
        }
    }
}
