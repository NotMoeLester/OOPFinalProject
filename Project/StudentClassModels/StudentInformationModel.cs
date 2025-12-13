using Microsoft.VisualBasic.Devices;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentInformationModel {
        [PrimaryKey]
        public int StudentId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Prefix {  get; set; } = string.Empty;
        public string Suffix { get; set; } = string.Empty;
        public string FullName { get { return GetName(Prefix, FirstName, MiddleName, LastName, Suffix); } }


        public string Sex { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;


        public string ContactCountryCode { get; set; } = string.Empty;
        public string ContactInformation { get; set; } = string.Empty;
        public string ContactNumber { get { return GetContactNumber(ContactCountryCode, ContactInformation); } }


        public string Course { get; set; } = string.Empty;
        public int YearLevel { get; set; }
        public string Department { get { return GetDepartment(Course); } }
        public string School { get { return GetSchool(Course); } }
        public string PreviousSchool { get; set; } = string.Empty;


        [Ignore]
        public int Age { get { return CalculateAge(BirthDay); } }

        public StudentInformationModel() { }

        private int CalculateAge(DateTime birthday) {
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday > DateTime.Today.AddYears(-age)) {
                age--;
            }
            return age;
        }

        private string GetName(string firstName, string middleName, string lastName, string prefix, string suffix) {
            string name = prefix + " " + firstName + " " + middleName + " " + lastName + " " + suffix;
            return name;
        }

        private string GetContactNumber(string contactCountryCode, string contactInformation) {
            string contactNumber = contactCountryCode + contactInformation;
            return contactNumber;
        }

        private string GetSchool(string course) {
            if (string.IsNullOrEmpty(course)) return "";
            if (course.Contains("BS in Civil Engineering") || course.Contains("BS in Computer Engineering") || course.Contains("BS in Electronics Engineering") || course.Contains("BS in Electrical Engineering") || course.Contains("BS in Mechanical Engineering") || course.Contains("BS in Architecture") || course.Contains("BS in Computer Science") || course.Contains("BS in Information Technology") || course.Contains("BS in Information Systems")) { return "School of Engineering, Architecture and Information Technology"; } 
            else if (course.Contains("BEEd in Elementary Education") || course.Contains("BPEd in Physical Education") || course.Contains("BA in Communication") || course.Contains("AB in Political Science") || course.Contains("AB in Psychology") || course.Contains("AB in Sociology")) { return "School of Teacher Education and Humanities"; } 
            else if (course.Contains("BS in Accountancy") || course.Contains("BS in Business Administration") || course.Contains("BS in Entrepreneurship") || course.Contains("BS in Human Resource Management") || course.Contains("BS in Marketing Management")) { return "School of Accountancy and Business"; } 
            else if (course.Contains("BS in Biology") || course.Contains("BS in Medical Technology") || course.Contains("BS in Nursing") || course.Contains("BS in Pharmacy")) { return "School of Health and Natural Sciences"; } 
            else if (course.Contains("Bachelor of Laws") || course.Contains("Juris Doctor")) { return "College of Law"; }
            return "General Studies";
        }

        private string GetDepartment(string course) {
            if (string.IsNullOrEmpty(course)) return "";
            if (course.Contains("BS in Civil Engineering") || course.Contains("BS in Electronics Engineering") || course.Contains("BS in Electrical Engineering") || course.Contains("BS in Mechanical Engineering")) { return "Department of Engineering"; } 
            else if (course.Contains("BS in Architecture")) { return "Department of Architechture"; } 
            else if (course.Contains("BS in Computer Engineering") || course.Contains("BS in Computer Science") || course.Contains("BS in Information Technology") || course.Contains("BS in Information Systems")) { return "Department of Information Communication Technology"; } 
            else if (course.Contains("BEEd in Elementary Education") || course.Contains("BPEd in Physical Education") || course.Contains("BA in Communication")) { return "Department of Education"; } 
            else if (course.Contains("AB in Political Science") || course.Contains("AB in Psychology") || course.Contains("AB in Sociology")) { return "Department of Social Sciences"; } 
            else if (course.Contains("BS in Accountancy") || course.Contains("BS in Business Administration") || course.Contains("BS in Entrepreneurship") || course.Contains("BS in Marketing Management")) { return "Department of Business"; }
            else if (course.Contains("BS in Human Resource Management") || course.Contains("BS in Tourism Management") || course.Contains("BS in Hospitality Management")) { return "Department of Hospitality & Tourism Management"; } 
            else if (course.Contains("BS in Biology") || course.Contains("BS in Pharmacy")) { return "Department of Biology and Pharmacy"; } 
            else if (course.Contains("BS in Medical Technology") || course.Contains("BS in Nursing")) { return "Department of Nursing and Medical Technology"; } 
            else if (course.Contains("Bachelor of Laws") || course.Contains("Juris Doctor")) { return "Department of Law"; }
            return "General Studies";
        }
    }
}
