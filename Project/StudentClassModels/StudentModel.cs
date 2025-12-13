using Project.StudentClassModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentModel {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Verification { get; set; } = false;
        public bool IsEnrolled { get; set; } = false;

        [Ignore]
        [Browsable(false)]
        public StudentInformationModel StudentInformation { get; set; } = new StudentInformationModel();

        [Ignore]
        [Browsable(false)]
        public SubjectModel StudentSubject { get; set; } = new SubjectModel();


        public StudentModel() { 
        
        
        }
    }
}
