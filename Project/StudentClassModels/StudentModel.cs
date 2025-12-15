using Project.GeneralModel;
using Project.StudentClassModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentModel : UserModel {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; set; }

        public bool Verification { get; set; } = false;
        public bool IsEnrolled { get; set; } = false;

        [Ignore]
        [Browsable(false)]
        public StudentInformationModel StudentInformation { get; set; } = new StudentInformationModel();

        [Ignore]
        [Browsable(false)]
        public StudentSubjectsModel StudentSubject { get; set; } = new StudentSubjectsModel();

        public StudentModel() { 
        
        
        }
    }
}
