using Project.AdministratorClassModels;
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
        public StudentSubjectManagement(StudentModel student) {
            InitializeComponent();
            Student = student;
        }

        private void StudentSubjectManagement_Load(object sender, EventArgs e) {
            SubjectAvailable subjectAvailable = new SubjectAvailable();
            var availableSubjects = subjectAvailable.GetSubjectsForCourse(Student.StudentInformation.Course);
            dataGridViewAvailableSubjects.DataSource = availableSubjects;

        }


    }
}
