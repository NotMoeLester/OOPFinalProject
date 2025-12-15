using Microsoft.VisualBasic.ApplicationServices;
using Project.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private void UserInformationForm_Load(object sender, EventArgs e) {
            loadInfo();
        }

        //EDIT ===============================================================================
        #region
        private void buttonEdit_Click(object sender, EventArgs e) {
            buttonEdit.Enabled = false;
            checkBoxConfirmation.Enabled = true;

            textBoxLastName.ReadOnly = false;
            textBoxFirstName.ReadOnly = false;
            textBoxMiddleName.ReadOnly = false;
            textBoxPrefix.ReadOnly = false;
            textBoxSuffix.ReadOnly = false;
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
        #endregion

        // CONFIRM ===============================================================================
        #region
        private void ButtonConfirm_Click(object sender, EventArgs e) {

            bool hasError = HasError();

            if (hasError) {
                MessageBox.Show("Please fill out all fields.", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (checkBoxConfirmation.Checked == false) {
                MessageBox.Show("Please confirm that the information provided above is true.", "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LockFields();

            if (User.StudentInformation == null) {
                User.StudentInformation = new StudentInformationModel();
            }

            var info = User.StudentInformation;

            info.FirstName = textBoxFirstName.Text.Trim();
            info.MiddleName = textBoxMiddleName.Text.Trim();
            info.LastName = textBoxLastName.Text.Trim();
            info.Suffix = textBoxSuffix.Text.Trim();

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

            bool isUpdated = repository.UpdateStudentAndStudentData(User, User.StudentInformation, User.StudentSubject);

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
        #endregion

        // LOAD INFO ===============================================================================
        #region
        private void loadInfo() {
            if (User.StudentInformation == null) {
                User.StudentInformation = new StudentInformationModel();
            }

            var info = User.StudentInformation;

            textBoxLastName.Text = info.LastName ?? "";
            textBoxFirstName.Text = info.FirstName ?? "";
            textBoxMiddleName.Text = info.MiddleName ?? "";
            textBoxSuffix.Text = info.Suffix ?? "";

            checkBoxMale.Checked = info.Sex == "Male";
            checkBoxFemale.Checked = info.Sex == "Female";

            dateTimePickerBirthday.Value = (info.BirthDay > dateTimePickerBirthday.MinDate && info.BirthDay < DateTime.Now) ? info.BirthDay : DateTime.Today.AddYears(-18);

            textBoxAge.Text = info.Age.ToString();

            if (!string.IsNullOrEmpty(info.Nationality))
                comboBoxNationality.SelectedItem = info.Nationality;

            if (!string.IsNullOrEmpty(info.ContactCountryCode))
                comboBoxContactCountryCode.SelectedItem = info.ContactCountryCode;

            textBoxContactInformation.Text = info.ContactInformation ?? "";
            textBoxHomeAddress.Text = info.Address ?? "";

            if (!string.IsNullOrEmpty(info.Course))
                comboBoxCourseProgram.SelectedItem = info.Course;

            numericUpDownYear.Value = (info.YearLevel.HasValue && info.YearLevel.Value > 0) ? info.YearLevel.Value : numericUpDownYear.Minimum;

            textBoxPreviousSchool.Text = info.PreviousSchool ?? "";

            ButtonConfirm.Enabled = false;
        }
        #endregion

        // USER INTERACTION ===============================================================================
        #region
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
        private void textBoxContactInformation_TextChanged(object sender, EventArgs e) {
            labelContactInformationValidator.Text = String.Empty;
        }
        #endregion

        // BACK ===============================================================================
        #region
        private void ButtonBack_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        //CHANGE STATE
        #region
        private void LockFields() {
            buttonEdit.Enabled = true;
            textBoxLastName.ReadOnly = true;
            textBoxFirstName.ReadOnly = true;
            textBoxMiddleName.ReadOnly = true;
            textBoxPrefix.ReadOnly = true;
            textBoxSuffix.ReadOnly = true;
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
        }
        #endregion

        //HAS ERROR
        #region
        private bool HasError() {
            string firstNameError = Validation.StringEmpty(textBoxFirstName.Text);
            string lastNameError = Validation.StringEmpty(textBoxLastName.Text);
            string contactInformationError = Validation.ContactNumber(textBoxContactInformation.Text);
            string homeAddressError = Validation.StringEmpty(textBoxHomeAddress.Text);

            string courseError = Validation.StringEmpty(comboBoxCourseProgram.Text);

            if (firstNameError != String.Empty || lastNameError != String.Empty || contactInformationError != String.Empty || homeAddressError != String.Empty)
                return true;

            return false;
        }
        #endregion


    }
}