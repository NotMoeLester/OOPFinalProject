using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class Validator {
        public static bool Password(string password) {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) {
                MessageBox.Show("Passsword must me be atleast 8 characters");
                return false;
            }
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsPunctuation)) {
                MessageBox.Show("Passsword must contain atleast one Uppercase character|  Lowercase character | Number | Symbol");
                return false;
            }
            return true;
        }
        public static bool Password(string password, string newPassword) {
            if (password == newPassword) {
                MessageBox.Show("");
                return false;
            }
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 8) {
                MessageBox.Show("Passsword must me be atleast 8 characters");
                return false;
            }
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsPunctuation)) {
                MessageBox.Show("Passsword must contain atleast one Uppercase character|  Lowercase character | Number | Symbol");
                return false;
            }
            return true;
        }


        public static bool Email(string email) {
            if (string.IsNullOrEmpty(email)) return false;
            if (!(email.Contains('@') && email.Split('@')[1].Contains('.') && email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_'))) {
                return false;
            }
            if (!email.StartsWith("hed-") || !email.EndsWith("@smu.edu.ph")) {
                return false;
            }
            return true;
        }
        public static bool Email(string email, string newEmail) {
            if (email == newEmail) return false;
            if (string.IsNullOrEmpty(email)) return false;
            if (!(email.Contains('@') && email.Split('@')[1].Contains('.') && email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_'))) {
                return false;
            }
            return true;
        }
    }
}
