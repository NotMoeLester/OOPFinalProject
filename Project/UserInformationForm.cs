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

            var info = User.UserInfo;

            info.FirstName = textBoxFirstName.Text;
            info.MiddleInitial = textBoxMI.Text;
            info.LastName = textBoxLastName.Text;
            info.PrefixSuffix = textBoxPrefixSuffix.Text;

            info.Sex = checkBoxMale.Checked ? "Male" : "Female";
            info.BirthDay = dateTimePickerBirthday.Value;

            info.Nationality = comboBoxNationality.Text;
            info.ContactNumber = comboBoxContactNumber.Text;
            info.ContactInformation = textBoxContactInformation.Text.All(char.IsDigit) ? textBoxContactInformation.Text : "";

            info.Address = textBoxHomeAddress.Text;

            info.Course = comboBoxCourseProgram.Text;
            info.YearLevel = (int)numericUpDownYear.Value;
            info.PreviousSchool = textBoxPreviousSchool.Text;

            User.UserInfo = info;


            if (checkBoxConfirmation.Checked == false) {
                MessageBox.Show("Please confirm that the information provided above is true.", "Confirmation Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StudentUserRepository repository = new StudentUserRepository();
            bool isUpdated = repository.UpdateStudentAndStudentData(User);
            if (isUpdated) MessageBox.Show("Info Succesfully Updated!", "Successful!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            checkBoxConfirmation.Enabled = false;
        }

        private void UserInformationForm_Load(object sender, EventArgs e) {
            loadInfo();
        }

        private void loadInfo() {

            var info = User.UserInfo;
            textBoxLastName.Text = info.LastName;
            textBoxFirstName.Text = info.FirstName;
            textBoxMI.Text = info.MiddleInitial;
            textBoxPrefixSuffix.Text = info.PrefixSuffix;

            checkBoxMale.Checked = info.Sex == "Male";
            checkBoxFemale.Checked = info.Sex == "Female";

            if (info.BirthDay > dateTimePickerBirthday.MinDate)
                dateTimePickerBirthday.Value = info.BirthDay;
            else
                dateTimePickerBirthday.Value = DateTime.Today;

            textBoxAge.Text = info.Age.ToString();
            comboBoxNationality.SelectedItem = info.Nationality;
            comboBoxContactNumber.SelectedItem = info.ContactNumber;
            textBoxContactInformation.Text = info.ContactInformation;
            textBoxHomeAddress.Text = info.Address;
            comboBoxCourseProgram.SelectedItem = info.Course;
            numericUpDownYear.Value = info.YearLevel;
            textBoxPreviousSchool.Text = info.PreviousSchool;
            ButtonConfirm.Enabled = false;
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e) {
            checkBoxFemale.Checked = false;
        }
        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e) {
             checkBoxMale.Checked = false;
        }

        private void checkBoxConfirmation_CheckedChanged(object sender, EventArgs e) {
            ButtonConfirm.Enabled = true;
        }

        private void comboBoxContactNumber_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxContactInformation.Text = $"{comboBoxContactNumber.Text}{textBoxContactInformation.Text}";

        }

    }
}

