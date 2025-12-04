using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    internal class Validator {
        public static bool Password(string password) {
            if (string.IsNullOrEmpty(password) || password == "Enter Password") {
                MessageBox.Show("Password Field Empty", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Length < 8) {
                MessageBox.Show("Passsword must me be atleast 8 characters", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsPunctuation)) {
                MessageBox.Show("Passsword must contain atleast one Uppercase character|  Lowercase character | Number | Symbol", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool Email(string email) {
            if (string.IsNullOrEmpty(email) || email == "Enter Email") {
                MessageBox.Show("Email Field Empty");
                return false;
            }
            if (!(email.Contains('@') && email.Split('@')[1].Contains('.') && email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_'))) {
                MessageBox.Show("Invalid email syntax", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!email.StartsWith("hed-") || !email.EndsWith("@smu.edu.ph")) {
                MessageBox.Show("Use your HED account", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
