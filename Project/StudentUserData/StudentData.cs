using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentData {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
        public string PreviousSchool { get; set; }

        [Ignore]
        public int Age { get { return calculateAge(BirthDay); } }

        public StudentData() { }
        public StudentData(int id, string firstName, string middleName, string lastName, string sex, DateTime birthday, string nationality, string contactNumber, string address, string course, int yearLevel, string previousSchool) {
            StudentId = id;
            FirstName = firstName;
            MiddleInitial = middleName;
            LastName = lastName;
            Sex = sex;
            BirthDay = birthday;
            Nationality = nationality;
            ContactNumber = contactNumber;
            Address = address;
            Course = course;
            YearLevel = yearLevel;
            PreviousSchool = previousSchool;
        }

        private int calculateAge(DateTime birthday) {
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday > DateTime.Today.AddYears(-age)) {
                age--;
            }
            return age;
        }
    }
}
