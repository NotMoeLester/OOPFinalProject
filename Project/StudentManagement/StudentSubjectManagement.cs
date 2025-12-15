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
            LoadStudentInformation();
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

            // Set IsEnrolled to true when adding
            subject.IsEnrolled = true;

            enrolledSubjects.Add(subject);
            UpdateTotalUnitsFromStudent();
            UpdateStatus();
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

            var result = MessageBox.Show($"Are you sure you want to drop {subject.Subject}?", "Confirm Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            // Set IsEnrolled to false when dropping
            subject.IsEnrolled = false;

            enrolledSubjects.Remove(subject);
            UpdateTotalUnitsFromStudent();
            UpdateStatus();

            MessageBox.Show($"Successfully dropped {subject.Subject}.");
        }
        #endregion

        //SAVE TO DATABASE ===============================================================================
        #region
        private void ButtonSave_Click(object sender, EventArgs e) {
            // Update Student.StudentSubject.Subjects to trigger JSON serialization
            Student.StudentSubject.Subjects = enrolledSubjects.ToList();

            repository.UpdateStudentSubjects(Student.StudentId, enrolledSubjects.ToList());

            repository.UpdateStudentAndStudentData(Student, Student.StudentInformation, Student.StudentSubject);

            originalSubjects = enrolledSubjects.Select(s => new SubjectModel { Code = s.Code, Subject = s.Subject, Unit = s.Unit, Schedule = s.Schedule, Room = s.Room, Instructor = s.Instructor, IsEnrolled = s.IsEnrolled }).ToList();

            UpdateStatus();

            MessageBox.Show("Subjects and total units updated successfully!");
        }
        #endregion

        //RESET DATAGRIDVIEW COLUMN SIZES ===============================================================================
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
        }
        #endregion

        //LOAD SUBJECTS ===============================================================================
        #region
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

            originalSubjects = enrolledSubjectList.Select(s => new SubjectModel { Code = s.Code, Subject = s.Subject, Unit = s.Unit, Schedule = s.Schedule, Room = s.Room, Instructor = s.Instructor, IsEnrolled = s.IsEnrolled }).ToList();

            Student.StudentSubject = new StudentSubjectsModel { StudentId = Student.StudentId, Subjects = enrolledSubjects.ToList() };

            enrolledSubjects.ListChanged += (s, e) => { Student.StudentSubject.Subjects = enrolledSubjects.ToList(); UpdateTotalUnitsFromStudent(); };

            UpdateTotalUnitsFromStudent();
        }
        private void LoadStudentInformation() {
            LabelStudentID.Text = Student.StudentId.ToString();
            LabelStudentName.Text = Student.StudentInformation?.FullName ?? "Student Name";
            LabelSchool.Text = Student.StudentInformation?.Department ?? "Department";
            string course = Student.StudentInformation?.Course ?? "Course";
            string yearLevel = Student.StudentInformation?.YearLevel?.ToString() ?? "0";
            LabelCourse.Text = $"{course} - Year {yearLevel}";
            LabelSchoolYear.Text = "S.Y. 2025-2026";
            var enrolledSubjectList = repository.GetStudentSubjects(Student.StudentId);
            bool isEnrolled = enrolledSubjectList.Any();
            LabelStatus.Text = isEnrolled ? "Enrolled" : "Not Enrolled";
        }
        #endregion

        // BACK BUTTON ===============================================================================
        #region
        private void ButtonBack_Click(object sender, EventArgs e) {
            bool hasChanges = !enrolledSubjects.Select(s => s.Code).SequenceEqual(originalSubjects.Select(s => s.Code));

            if (hasChanges) {
                var result = MessageBox.Show("You have unsaved changes. Do you want to exit and discard changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
            }
            this.Close();
        }
        #endregion

        //UPDATE ===============================================================================
        #region
        private void UpdateTotalUnitsFromStudent() {
            if (Student?.StudentInformation == null || Student.StudentSubject == null)
                return;
            int totalUnits = Student.StudentSubject.Subjects?.Sum(s => s.Unit) ?? 0;
            Student.StudentInformation.TotalUnits = totalUnits;
            if (LabelTotalUnits != null)
                LabelTotalUnits.Text = $"{totalUnits}";
        }

        private void UpdateStatus() {
            bool isEnrolled = enrolledSubjects.Any();
            LabelStatus.Text = isEnrolled ? "Enrolled" : "Not Enrolled";
        }
        #endregion
    }
}