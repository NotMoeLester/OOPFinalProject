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
    public partial class StudentInformationManagement : Form {

        private StudentModel User;
        private StudentRepository repository = new StudentRepository();

        public StudentInformationManagement(StudentModel user) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBoxContactCountryCode.SelectedItem = "+63";
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
            comboBoxContactCountryCode.Enabled = true;
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
            comboBoxContactCountryCode.Enabled = false;
            textBoxContactInformation.ReadOnly = true;
            textBoxHomeAddress.ReadOnly = true;
            comboBoxCourseProgram.Enabled = false;
            numericUpDownYear.Enabled = false;
            textBoxPreviousSchool.ReadOnly = true;

            if (User.StudentInformation == null) {
                User.StudentInformation = new StudentInformationModel();
            }

            var info = User.StudentInformation;

            info.FirstName = textBoxFirstName.Text.Trim();
            info.MiddleName = textBoxMI.Text.Trim();
            info.LastName = textBoxLastName.Text.Trim();
            info.Suffix = textBoxPrefixSuffix.Text.Trim();

            info.Sex = checkBoxMale.Checked ? "Male" : "Female";
            info.BirthDay = dateTimePickerBirthday.Value;
            info.Nationality = comboBoxNationality.Text;

            info.ContactCountryCode = comboBoxContactCountryCode.Text;
            info.ContactInformation = textBoxContactInformation.Text.Trim();

            info.Address = textBoxHomeAddress.Text.Trim();

            info.Course = comboBoxCourseProgram.Text;
            info.YearLevel = (int)numericUpDownYear.Value;

            info.PreviousSchool = textBoxPreviousSchool.Text.Trim();

            info.ContactCountryCode = comboBoxContactCountryCode.Text;
            info.ContactInformation = textBoxContactInformation.Text.Trim();
            info.Course = comboBoxCourseProgram.Text;
            info.YearLevel = (int)numericUpDownYear.Value;

            User.StudentInformation = info;

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

        private void UserInformationForm_Load(object sender, EventArgs e) {
            loadInfo();
        }

        private void loadInfo() {
            if (User.StudentInformation == null) {
                User.StudentInformation = new StudentInformationModel();
            }

            var info = User.StudentInformation;

            textBoxLastName.Text = info.LastName ?? "";
            textBoxFirstName.Text = info.FirstName ?? "";
            textBoxMI.Text = info.MiddleName ?? "";
            textBoxPrefixSuffix.Text = info.Suffix ?? "";

            checkBoxMale.Checked = info.Sex == "Male";
            checkBoxFemale.Checked = info.Sex == "Female";

            if (info.BirthDay > dateTimePickerBirthday.MinDate && info.BirthDay < DateTime.Now)
                dateTimePickerBirthday.Value = info.BirthDay;
            else
                dateTimePickerBirthday.Value = DateTime.Today.AddYears(-18);

            textBoxAge.Text = info.Age.ToString();

            if (!string.IsNullOrEmpty(info.Nationality))
                comboBoxNationality.SelectedItem = info.Nationality;

            if (!string.IsNullOrEmpty(info.ContactCountryCode))
                comboBoxContactCountryCode.SelectedItem = info.ContactCountryCode;

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
            if (!textBoxContactInformation.Text.StartsWith(comboBoxContactCountryCode.Text)) {
                string existingNumber = textBoxContactInformation.Text.Replace("+63", "")
                    .Replace("+1", "").Replace("+", "").Trim();
                textBoxContactInformation.Text = existingNumber;
            }
        }
    }
}