using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentData {
        [PrimaryKey]
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleInitial { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PrefixSuffix {  get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string ContactInformation { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public int YearLevel { get; set; }
        public string PreviousSchool { get; set; } = string.Empty;

        [Ignore]
        public int Age { get { return calculateAge(BirthDay); } }

        public StudentData() { }

        private int calculateAge(DateTime birthday) {
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday > DateTime.Today.AddYears(-age)) {
                age--;
            }
            return age;
        }
    }
}
