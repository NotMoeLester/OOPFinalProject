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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project {
    public partial class UserInformationForm : Form {
        public StudentUser User;
        public UserInformationForm(StudentUser user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBoxContactNumber.SelectedItem = "+63";
            comboBoxNationality.SelectedItem = "Filipino";
            User = user;
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            buttonEdit.Enabled = false;
            checkBoxConfirmation.Enabled = true;

            textBoxLastName.ReadOnly = false;
            textBoxFirstName.ReadOnly = false;
            textBoxMI.ReadOnly = false;
            textBoxPrefixSuffix.ReadOnly = false;
            checkBoxFemale.Enabled = true;
            checkBoxMale.Enabled = true;
            dateTimePickerBirthday.Enabled = true;
            comboBoxNationality.Enabled = true;
            comboBoxContactNumber.Enabled = true;
            textBoxContactInformation.ReadOnly = false;
            textBoxHomeAddress.ReadOnly = false;
            comboBoxCourseProgram.Enabled = true;
            numericUpDownYear.Enabled = true;
            textBoxPreviousSchool.ReadOnly = false;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e) {

            if (checkBoxConfirmation.Checked == false) {
                MessageBox.Show("Please confirm that the information provided above is true.",
                    "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            buttonEdit.Enabled = true;
            textBoxLastName.ReadOnly = true;
            textBoxFirstName.ReadOnly = true;
            textBoxMI.ReadOnly = true;
            textBoxPrefixSuffix.ReadOnly = true;
            checkBoxFemale.Enabled = false;
            checkBoxMale.Enabled = false;
            dateTimePickerBirthday.Enabled = false;
            comboBoxNationality.Enabled = false;
            comboBoxContactNumber.Enabled = false;
            textBoxContactInformation.ReadOnly = true;
            textBoxHomeAddress.ReadOnly = true;
            comboBoxCourseProgram.Enabled = false;
            numericUpDownYear.Enabled = false;
            textBoxPreviousSchool.ReadOnly = true;

            if (User.UserInfo == null) {
                User.UserInfo = new StudentData();
            }

            var info = User.UserInfo;

            info.FirstName = textBoxFirstName.Text.Trim();
            info.MiddleInitial = textBoxMI.Text.Trim();
            info.LastName = textBoxLastName.Text.Trim();
            info.PrefixSuffix = textBoxPrefixSuffix.Text.Trim();
            info.Sex = checkBoxMale.Checked ? "Male" : "Female";
            info.BirthDay = dateTimePickerBirthday.Value;
            info.Nationality = comboBoxNationality.Text;
            info.ContactNumber = comboBoxContactNumber.Text;
            string contactInfo = textBoxContactInformation.Text.Trim();
            if (contactInfo.StartsWith(comboBoxContactNumber.Text)) {
                contactInfo = contactInfo.Substring(comboBoxContactNumber.Text.Length);
            }
            info.ContactInformation = contactInfo.All(char.IsDigit) ? contactInfo : "";

            info.Address = textBoxHomeAddress.Text.Trim();

            info.Course = comboBoxCourseProgram.Text;
            info.YearLevel = (int)numericUpDownYear.Value;

            info.PreviousSchool = textBoxPreviousSchool.Text.Trim();

            string fullName = "";
            if (!string.IsNullOrEmpty(info.FirstName)) {
                fullName = info.FirstName;
            }
            if (!string.IsNullOrEmpty(info.MiddleInitial)) {
                fullName += " " + info.MiddleInitial + ".";
            }
            if (!string.IsNullOrEmpty(info.LastName)) {
                fullName += " " + info.LastName;
            }
            if (!string.IsNullOrEmpty(info.PrefixSuffix)) {
                fullName += " " + info.PrefixSuffix;
            }
            User.FullName = fullName.Trim();

            User.ContactNumber = info.ContactNumber + info.ContactInformation;
            User.Course = info.Course;
            User.YearLevel = info.YearLevel;
            User.Department = GetDepartmentFromCourse(info.Course);

            User.UserInfo = info;

            StudentUserRepository repository = new StudentUserRepository();
            bool isUpdated = repository.UpdateStudentAndStudentData(User);

            if (isUpdated) {
                MessageBox.Show("Info Successfully Updated!", "Successful!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBoxConfirmation.Enabled = false;
                checkBoxConfirmation.Checked = false;
            } else {
                MessageBox.Show("Failed to update information. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonEdit.Enabled = false;
                checkBoxConfirmation.Enabled = true;
            }
        }

        private string GetDepartmentFromCourse(string course) {
            if (string.IsNullOrEmpty(course)) return "";


            if (course.Contains("Civil Engineering") || course.Contains("Computer Engineering") || course.Contains("Electronics Engineering") || course.Contains("Electrical Engineering") || course.Contains("Mechanical Engineering") || course.Contains("Architecture") || course.Contains("Computer Science") || course.Contains("Information Technology") || course.Contains("Information Systems")) {
                return "School of Engineering, Architecture and Information Technology";

            } else if (course.Contains("Elementary Education") || course.Contains("Physical Education") || course.Contains("Secondary Education") || course.Contains("Communication") || course.Contains("Political Science") || course.Contains("Psychology") || course.Contains("Sociology")) {
                return "School of Teacher Education and Humanities";

            } else if (course.Contains("Accountancy") || course.Contains("Business Administration") || course.Contains("Entrepreneurship") || course.Contains("Human Resource Management") || course.Contains("Marketing Management")) {
                return "School of Accountancy and Business";

            } else if (course.Contains("Biology") || course.Contains("Medical Technology") || course.Contains("Nursing") || course.Contains("Pharmacy")) {
                return "School of Health and Natural Sciences";

            } else if (course.Contains("Law") || course.Contains("Juris Doctor") || course.Contains("JD")) {
                return "College of Law";
            }
            return "General Studies";
        }
        private void UserInformationForm_Load(object sender, EventArgs e) {
            loadInfo();
        }

        private void loadInfo() {
            if (User.UserInfo == null) {
                User.UserInfo = new StudentData();
            }

            var info = User.UserInfo;

            textBoxLastName.Text = info.LastName ?? "";
            textBoxFirstName.Text = info.FirstName ?? "";
            textBoxMI.Text = info.MiddleInitial ?? "";
            textBoxPrefixSuffix.Text = info.PrefixSuffix ?? "";

            checkBoxMale.Checked = info.Sex == "Male";
            checkBoxFemale.Checked = info.Sex == "Female";

            if (info.BirthDay > dateTimePickerBirthday.MinDate && info.BirthDay < DateTime.Now)
                dateTimePickerBirthday.Value = info.BirthDay;
            else
                dateTimePickerBirthday.Value = DateTime.Today.AddYears(-18);

            textBoxAge.Text = info.Age.ToString();

            if (!string.IsNullOrEmpty(info.Nationality))
                comboBoxNationality.SelectedItem = info.Nationality;

            if (!string.IsNullOrEmpty(info.ContactNumber))
                comboBoxContactNumber.SelectedItem = info.ContactNumber;

            textBoxContactInformation.Text = info.ContactInformation ?? "";
            textBoxHomeAddress.Text = info.Address ?? "";

            if (!string.IsNullOrEmpty(info.Course))
                comboBoxCourseProgram.SelectedItem = info.Course;

            if (info.YearLevel > 0)
                numericUpDownYear.Value = info.YearLevel;

            textBoxPreviousSchool.Text = info.PreviousSchool ?? "";

            ButtonConfirm.Enabled = false;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxMale.Checked)
                checkBoxFemale.Checked = false;
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxFemale.Checked)
                checkBoxMale.Checked = false;
        }

        private void checkBoxConfirmation_CheckedChanged(object sender, EventArgs e) {
            ButtonConfirm.Enabled = checkBoxConfirmation.Checked;
        }

        private void comboBoxContactNumber_SelectedIndexChanged(object sender, EventArgs e) {
            if (!textBoxContactInformation.Text.StartsWith(comboBoxContactNumber.Text)) {
                string existingNumber = textBoxContactInformation.Text.Replace("+63", "")
                    .Replace("+1", "").Replace("+", "").Trim();
                textBoxContactInformation.Text = existingNumber;
            }
        }
    }
}