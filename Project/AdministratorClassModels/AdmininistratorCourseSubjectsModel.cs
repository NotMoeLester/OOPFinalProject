using Microsoft.VisualBasic.Devices;
using Project.StudentClassModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdministratorClassModels {
    public class AdmininistratorCourseSubjectsModel {
        public AdmininistratorCourseSubjectsModel () {
        }

        public List<SubjectModel> GetSubjectsForCourse(string course) {
            if (string.IsNullOrEmpty(course)) return new List<SubjectModel>();

            // ------------------ CIVIL ENGINEERING ------------------
            if (course.Contains("BS in Civil Engineering")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CE101", Subject = "Statics", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "C101", Instructor = "Prof. Reyes" },
                    new SubjectModel { Code = "CE102", Subject = "Mechanics of Materials", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "C102", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "CE103", Subject = "Surveying", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "C103", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ ELECTRONICS ENGINEERING ------------------
            if (course.Contains("BS in Electronics Engineering")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "EE101", Subject = "Circuit Analysis", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "E101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "EE102", Subject = "Digital Electronics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "E102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "EE103", Subject = "Signals and Systems", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "E103", Instructor = "Prof. Johnson" }
                };
            }

            // ------------------ ELECTRICAL ENGINEERING ------------------
            if (course.Contains("BS in Electrical Engineering")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ELE101", Subject = "Circuit Theory", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "EL101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "ELE102", Subject = "Electromagnetics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "EL102", Instructor = "Prof. Cruz" },
                    new SubjectModel { Code = "ELE103", Subject = "Power Systems", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "EL103", Instructor = "Prof. Reyes" }
                };
            }

            // ------------------ MECHANICAL ENGINEERING ------------------
            if (course.Contains("BS in Mechanical Engineering")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ME101", Subject = "Thermodynamics", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "M101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "ME102", Subject = "Fluid Mechanics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "M102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "ME103", Subject = "Dynamics", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "M103", Instructor = "Prof. Johnson" }
                };
            }

            // ------------------ ARCHITECTURE ------------------
            if (course.Contains("BS in Architecture")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ARC101", Subject = "Design Fundamentals", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "A101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "ARC102", Subject = "Architectural Graphics", Unit = 3, Schedule = "TTH 10:00-11:30 AM", Room = "A102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "ARC103", Subject = "Materials and Construction", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "A103", Instructor = "Prof. Santos" }
                };
            }

            // ------------------ INFORMATION TECHNOLOGY ------------------
            if (course.Contains("BS in Information Technology")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CC101", Subject = "Introduction to Computing", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "AP 102", Instructor = "Prof. Smith" },
                    new SubjectModel { Code = "CC102", Subject = "Computer Programming 1", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "AP 202", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "CC103", Subject = "Computer Programming 2", Unit = 3, Schedule = "TTH 10:00-11:30 AM", Room = "VR 201", Instructor = "Prof. Johnson" },
                    new SubjectModel { Code = "CC104", Subject = "Data Structures and Algorithm", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "PT 202", Instructor = "Prof. Lee" },
                    new SubjectModel { Code = "PF101", Subject = "Object Oriented Programming", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "TT 105", Instructor = "Prof. Williams" },
                    new SubjectModel { Code = "PF102", Subject = "Event Driven Programming", Unit = 3, Schedule = "TTH 2:00-3:00 PM", Room = "BN 304", Instructor = "Prof. Brown" },
                    new SubjectModel { Code = "HCI101", Subject = "Human Computer Interaction", Unit = 3, Schedule = "SAT 8:00-11:00 AM", Room = "MN 404", Instructor = "Prof. Santos" }
                };
            }

            // ------------------ COMPUTER SCIENCE ------------------
            if (course.Contains("BS in Computer Science")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CS101", Subject = "Programming Logic", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "CS101", Instructor = "Prof. Reyes" },
                    new SubjectModel { Code = "CS102", Subject = "Database Systems", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "CS102", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "CS103", Subject = "Software Engineering", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "CS103", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ INFORMATION SYSTEMS ------------------
            if (course.Contains("BS in Information Systems")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "IS101", Subject = "Information Systems Fundamentals", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "IS101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "IS102", Subject = "Systems Analysis and Design", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "IS102", Instructor = "Prof. Garcia" }
                };
            }

            // ... continue for all the rest of the courses (BA, BS, JD, etc.) exactly the same way ...

            // ------------------ DEFAULT ------------------
            return new List<SubjectModel>();
        }


    }
}
