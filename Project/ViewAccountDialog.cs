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
        private StudentUser _user;

        public ViewAccountDialog(StudentUser user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            _user = user;
            LoadUserDetails();
        }

        private void LoadUserDetails() {
            // USER ACCOUNT==================================
            labelStudentID.Text = _user.StudentId.ToString();
            labelEmail.Text = string.IsNullOrEmpty(_user.Email) ? "Not set" : _user.Email;
            labelPassword.Text = string.IsNullOrEmpty(_user.Password) ? "Not set" : new string('*', _user.Password.Length);
            labelVerification.Text = _user.Verification ? "Verified" : "Not Verified";

            // STUDENT PERSONAL INFO==================================
            if (_user.UserInfo != null) {
                var info = _user.UserInfo;

                labelFirstName.Text = string.IsNullOrEmpty(info.FirstName) ? "Not filled" : info.FirstName;
                labelMiddleInitial.Text = string.IsNullOrEmpty(info.MiddleInitial) ? "N/A" : info.MiddleInitial;
                labelLastName.Text = string.IsNullOrEmpty(info.LastName) ? "Not filled" : info.LastName;
                labelPrefixSuffix.Text = string.IsNullOrEmpty(info.PrefixSuffix) ? "N/A" : info.PrefixSuffix;
                labelSex.Text = string.IsNullOrEmpty(info.Sex) ? "Not specified" : info.Sex;

                if (info.BirthDay > DateTime.MinValue && info.BirthDay < DateTime.Now)
                    labelBirthday.Text = info.BirthDay.ToShortDateString();
                else
                    labelBirthday.Text = "Not set";

                labelAge.Text = info.Age > 0 ? info.Age.ToString() : "N/A";
                labelNationality.Text = string.IsNullOrEmpty(info.Nationality) ? "Not specified" : info.Nationality;

                string fullContactNumber = "";
                if (!string.IsNullOrEmpty(info.ContactNumber)) {
                    fullContactNumber = info.ContactNumber;
                }
                if (!string.IsNullOrEmpty(info.ContactInformation)) {
                    fullContactNumber += info.ContactInformation;
                }
                labelContactNumber.Text = string.IsNullOrEmpty(fullContactNumber.Trim()) ? "Not provided" : fullContactNumber;
                labelAddress.Text = string.IsNullOrEmpty(info.Address) ? "Not provided" : info.Address;
                string department = GetDepartmentFromCourse(info.Course);
                labelDepartment.Text = string.IsNullOrEmpty(department) ? "Not specified" : department;
                labelCourse.Text = string.IsNullOrEmpty(info.Course) ? "Not enrolled" : info.Course;
                labelYearLevel.Text = info.YearLevel > 0 ? info.YearLevel.ToString() : "N/A";
                labelPreviousSchool.Text = string.IsNullOrEmpty(info.PreviousSchool) ? "Not provided" : info.PreviousSchool;
            } else {
                labelFirstName.Text = "Not filled";
                labelMiddleInitial.Text = "N/A";
                labelLastName.Text = "Not filled";
                labelPrefixSuffix.Text = "N/A";
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
        }
        private string GetDepartmentFromCourse(string course) {
            if (string.IsNullOrEmpty(course)) return "";


            if (course.Contains("Civil Engineering") ||course.Contains("Computer Engineering") || course.Contains("Electronics Engineering") || course.Contains("Electrical Engineering") ||course.Contains("Mechanical Engineering") || course.Contains("Architecture") ||course.Contains("Computer Science") || course.Contains("Information Technology") || course.Contains("Information Systems")) {
                return "School of Engineering, Architecture and Information Technology";

            } else if (course.Contains("Elementary Education") ||course.Contains("Physical Education") ||course.Contains("Secondary Education") || course.Contains("Communication") || course.Contains("Political Science") || course.Contains("Psychology") ||course.Contains("Sociology")) {
                return "School of Teacher Education and Humanities";

            } else if (course.Contains("Accountancy") || course.Contains("Business Administration") || course.Contains("Entrepreneurship") ||course.Contains("Human Resource Management") || course.Contains("Marketing Management")) {
                return "School of Accountancy and Business";

            } else if (course.Contains("Biology") || course.Contains("Medical Technology") || course.Contains("Nursing") || course.Contains("Pharmacy")) {
                return "School of Health and Natural Sciences";

            } else if (course.Contains("Law") || course.Contains("Juris Doctor") || course.Contains("JD")) {
                return "College of Law";
            }
            return "General Studies";
        }
    }
}