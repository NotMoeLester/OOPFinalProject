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
            // USER ACCOUNT
            labelStudentID.Text = _user.StudentId.ToString();
            labelEmail.Text = _user.Email;
            labelPassword.Text = _user.Password;
            labelVerification.Text = _user.Verification ? "Verified" : "Non-Verified";

            // STUDENT PERSONAL INFO
            if (_user.UserInfo != null) {
                var info = _user.UserInfo;

                labelFirstName.Text = info.FirstName;
                labelMiddleInitial.Text = info.MiddleInitial;
                labelLastName.Text = info.LastName;
                labelPrefixSuffix.Text = info.PrefixSuffix;

                labelSex.Text = info.Sex;
                labelBirthday.Text = info.BirthDay.ToShortDateString();
                labelAge.Text = info.Age.ToString();
                labelNationality.Text = info.Nationality;
                labelContactNumber.Text = info.ContactNumber;
               
                labelAddress.Text = info.Address;

                labelCourse.Text = info.Course;
                labelYearLevel.Text = info.YearLevel.ToString();
                labelPreviousSchool.Text = info.PreviousSchool;
            }
        }
    }
}
