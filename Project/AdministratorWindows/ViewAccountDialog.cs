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
    public partial class ViewAccountDialog : Form {
        private StudentModel Student;

        public ViewAccountDialog(StudentModel student) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            Student = student;
            LoadUserDetails();
        }

        private void LoadUserDetails() {
            // USER ACCOUNT==================================
            #region
            labelStudentID.Text = Student.StudentId.ToString();
            labelEmail.Text = string.IsNullOrEmpty(Student.Email) ? "Not set" : Student.Email;
            labelPassword.Text = string.IsNullOrEmpty(Student.Password) ? "Not set" : new string('*', Student.Password.Length);
            labelVerification.Text = Student.Verification ? "Verified" : "Not Verified";
            #endregion

            // STUDENT PERSONAL INFO==================================
            #region
            if (Student.StudentInformation != null)
            {
                var info = Student.StudentInformation;

                labelFirstName.Text = string.IsNullOrEmpty(info.FirstName) ? "Not filled" : info.FirstName;
                labelMiddleName.Text = string.IsNullOrEmpty(info.MiddleName) ? "N/A" : info.MiddleName;
                labelLastName.Text = string.IsNullOrEmpty(info.LastName) ? "Not filled" : info.LastName;

                labelPrefix.Text = string.IsNullOrEmpty(info.Prefix) ? "N/A" : info.Prefix;
                labelSuffix.Text = string.IsNullOrEmpty(info.Suffix) ? "N/A" : info.Suffix;

                labelSex.Text = string.IsNullOrEmpty(info.Sex) ? "Not specified" : info.Sex;

                if (info.BirthDay > DateTime.MinValue && info.BirthDay < DateTime.Now)
                    labelBirthday.Text = info.BirthDay.ToShortDateString();
                else
                    labelBirthday.Text = "Not set";

                labelAge.Text = info.Age > 0 ? info.Age.ToString() : "N/A";
                labelNationality.Text = string.IsNullOrEmpty(info.Nationality) ? "Not specified" : info.Nationality;
                labelAddress.Text = string.IsNullOrEmpty(info.Address) ? "Not provided" : info.Address;
                labelContactNumber.Text = string.IsNullOrEmpty(info.ContactNumber.Trim()) ? "Not provided" : info.ContactNumber;

                labelSchool.Text = string.IsNullOrEmpty(info.School) ? "Not specified" : info.School;
                labelDepartment.Text = string.IsNullOrEmpty(info.Department) ? "Not specified" : info.Department;
                labelCourse.Text = string.IsNullOrEmpty(info.Course) ? "Not enrolled" : info.Course;
                labelYearLevel.Text = info.YearLevel > 0 ? info.YearLevel.ToString() : "N/A";
                labelPreviousSchool.Text = string.IsNullOrEmpty(info.PreviousSchool) ? "Not provided" : info.PreviousSchool;

            }
            else
            {
                labelFirstName.Text = "Not filled";
                labelMiddleName.Text = "N/A";
                labelLastName.Text = "Not filled";
                labelPrefix.Text = "N/A";
                labelSuffix.Text = "N/A";
                labelSex.Text = "Not specified";
                labelBirthday.Text = "Not set";
                labelAge.Text = "N/A";
                labelNationality.Text = "Not specified";
                labelContactNumber.Text = "Not provided";
                labelAddress.Text = "Not provided";
                labelDepartment.Text = "Not specified";
                labelCourse.Text = "Not enrolled";
                labelYearLevel.Text = "N/A";
                labelPreviousSchool.Text = "Not provided";
            }
            #endregion
        }
    }
}