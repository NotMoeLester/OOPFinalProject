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

        public string ContactInformation { get; set; } = string.Empty;
        public string ContactCountryCode { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;


        public string Address { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public int YearLevel { get; set; }
        public string PreviousSchool { get; set; } = string.Empty;
        public string Department { get { return GetDepartment(Course); } }
        public string School { get { return GetSchool(Course); } }


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

        private string GetSchool(string course) {
            if (string.IsNullOrEmpty(course)) return "";
            if (course.Contains("Civil Engineering") || course.Contains("Computer Engineering") || course.Contains("Electronics Engineering") || course.Contains("Electrical Engineering") || course.Contains("Mechanical Engineering") || course.Contains("Architecture") || course.Contains("Computer Science") || course.Contains("Information Technology") || course.Contains("Information Systems")) {
                return "School of Engineering, Architecture and Information Technology";

            } else if (course.Contains("Elementary Education") || course.Contains("Physical Education") || course.Contains("Secondary Education") || course.Contains("Communication") || course.Contains("Political Science") || course.Contains("Psychology") || course.Contains("Sociology")) {
                return "School of Teacher Education and Humanities";

            } else if (course.Contains("Accountancy") || course.Contains("Business Administration") || course.Contains("Entrepreneurship") || course.Contains("Human Resource Management") || course.Contains("Marketing Management") || course.Contains("Tourism Managemnet") || course.Contains("Hospitality Management")) {
                return "School of Accountancy and Business";

            } else if (course.Contains("Biology") || course.Contains("Medical Technology") || course.Contains("Nursing") || course.Contains("Pharmacy")) {
                return "School of Health and Natural Sciences";

            } else if (course.Contains("Law") || course.Contains("Juris Doctor") || course.Contains("JD")) {
                return "College of Law";
            }
            return "General Studies";
        }

        private string GetDepartment(string course) {
            if (string.IsNullOrEmpty(course)) return "";
            if (course.Contains("Civil Engineering") || course.Contains("Electronics Engineering") || course.Contains("Electrical Engineering") || course.Contains("Mechanical Engineering")) {
                return "Department of Engineering";

            } else if (course.Contains("Architecture")) {
                return "Department of Architechture";

            } else if (course.Contains("Computer Engineering") || course.Contains("Computer Engineering") || course.Contains("Computer Science") || course.Contains("Information Technology") || course.Contains("Information Systems")) {
                return "Department of Information Communication Technology";

            } else if (course.Contains("Elementary Education") || course.Contains("Physical Education") || course.Contains("Secondary Education") || course.Contains("Communication")) {
                return "Department of Education";

            } else if (course.Contains("Political Science") || course.Contains("Psychology") || course.Contains("Sociology")) {
                return "Department of Social Sciences";

            } else if (course.Contains("Accountancy") || course.Contains("Business Administration") || course.Contains("Entrepreneurship") || course.Contains("Marketing Management")) {
                return "Department of Business";

            } else if (course.Contains("Human Resource Management") || course.Contains("Tourism Managemnet") || course.Contains("Hospitality Management")) {
                return "Department of Hospitality & Tourism Management";

            } else if (course.Contains("Biology") || course.Contains("Medical Technology") || course.Contains("Nursing") || course.Contains("Pharmacy")) {
                return "Department of Nursing and Medical Technology";

            } else if (course.Contains("Biology") || course.Contains("Pharmacy")) {
                return "Department of Biology and Pharmacy";

            } else if (course.Contains("Law") || course.Contains("Juris Doctor")) {
                return "Department of Law";
            }
            return "General Studies";
        }


    }
}
