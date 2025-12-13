using Microsoft.VisualBasic.Devices;
using Project.StudentClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdministratorClassModels {
    public class SubjectAvailable {
        public string Course = string.Empty;
        public SubjectAvailable(string course) {
            Course = course;
        }

        public List<SubjectModel> GetAvailableSubject() {  
            //if (Course == "BSIT") {
                List<SubjectModel> BSITsubjects = new List<SubjectModel> {
                new SubjectModel { Code = "CC101", Subject = "Introduction to Computing", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "AP 102", Instructor = "Prof. Smith" },
                new SubjectModel { Code = "CC102", Subject = "Computer Programming 1", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "AP 202", Instructor = "Prof. Garcia" },
                new SubjectModel { Code = "CC103", Subject = "Computer Programming 2", Unit = 3, Schedule = "TTH 10:00-11:30 AM", Room = "VR 201", Instructor = "Prof. Johnson" },
                new SubjectModel { Code = "CC104", Subject = "Data Structures And Algorithm", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "PT 202", Instructor = "Prof. Lee" },
                new SubjectModel { Code = "PF101", Subject = "Object Oriented Programming", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "TT 105", Instructor = "Prof. Williams" },
                new SubjectModel { Code = "PF102", Subject = "Event Driven Programming", Unit = 3, Schedule = "TTH 2:00-3:00 PM", Room = "BN 304", Instructor = "Prof. Brown" },
                new SubjectModel { Code = "HCI101", Subject = "Human Computer Interaction", Unit = 3, Schedule = "SAT 8:00-11:00 AM", Room = "MN 404", Instructor = "Prof. Santos" }
                };
                return BSITsubjects;
            //}
            //return null;
        }
    }
}
