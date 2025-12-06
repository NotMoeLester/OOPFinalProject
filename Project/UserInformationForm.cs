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
    public partial class UserInformationForm : Form {
        public UserInformationForm() {
            InitializeComponent();
            comboBoxContactNumber.SelectedItem = "+63";
        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e) {
            DateTime birthday = dateTimePickerBirthday.Value;
            int age = DateTime.Today.Year - birthday.Year;

            if (birthday > DateTime.Today.AddYears(-age)) {
                age--;
            }

            textBoxAge.Text = age.ToString();
        }
    }
}
