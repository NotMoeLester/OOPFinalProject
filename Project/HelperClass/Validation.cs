using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HelperClass {
    internal class Validation {
        public static string Password(string password) {
            if (string.IsNullOrEmpty(password) || password == "Enter Password") {
                return "Password Field Empty";
            }
            if (password.Length < 8) {
                return "Passsword must me be atleast 8 characters";
            }
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsPunctuation)) {
                return "Passsword must contain atleast one Uppercase|Lowercase|Numeric|Symbol";
            }
            return "";
        }

        public static string Email(string email) {
            StudentRepository repository = new StudentRepository();
            if (string.IsNullOrEmpty(email) || email == "Enter Email" || email == "Confirm Email") {
                return "Email Field Empty";
            }
            if (!(email.Contains('@') && email.Split('@')[1].Contains('.') && email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_'))) {
                return "Invalid email syntax";
            }
            if (!email.StartsWith("hed-") || !email.EndsWith("@smu.edu.ph")) {
                return "Use your HED account";
            }
            return "";
        }
        public static string ConfirmPassword(string password, string confirmPassword) {
            if (string.IsNullOrEmpty(confirmPassword) || confirmPassword == "Confirm Password") {
                return "Password Field Empty";
            }
            if (password != confirmPassword) {
                return "Passwords do not match!";
            }
            return "";
        }
        public static string EmailSignUp(string email) {
            StudentRepository repository = new StudentRepository();
            if (string.IsNullOrEmpty(email) || email == "Enter Email" || email == "Confirm Email") {
                return "Email Field Empty";
            }
            if (!(email.Contains('@') && email.Split('@')[1].Contains('.') && email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.' || c == '-' || c == '_'))) {
                return "Invalid email syntax";
            }
            if (!email.StartsWith("hed-") || !email.EndsWith("@smu.edu.ph")) {
                return "Use your HED account";
            }
            if (repository.IsUser(email)) {
                return "Account already exists";
            }
            return "";
        }
        public static string ContactNumber(string num) {
            num = num.Trim();
            if (string.IsNullOrEmpty(num)) {
                return "Contact Number Field cannot be empty";
            }
            if (!num.All(char.IsDigit)) {
                return "Contact Number should only be numeric";
            }
            return "";
        }

        public static string StringEmpty(string prompt) { 
            if (string.IsNullOrEmpty(prompt)) {
                return "Field cannot be empty";
            }
            return "";
        }
    }
}
