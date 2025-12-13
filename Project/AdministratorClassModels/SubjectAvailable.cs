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
        public SubjectAvailable () {
        }

        public List<SubjectModel> GetSubjectsForCourse(string course) {
            if (string.IsNullOrEmpty(course)) return new List<SubjectModel>();

            // ------------------ CIVIL ENGINEERING ------------------
            if (course == "Civil Engineering") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CE101", Subject = "Statics", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "C101", Instructor = "Prof. Reyes" },
                    new SubjectModel { Code = "CE102", Subject = "Mechanics of Materials", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "C102", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "CE103", Subject = "Surveying", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "C103", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ ELECTRONICS ENGINEERING ------------------
            if (course == "Electronics Engineering") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "EE101", Subject = "Circuit Analysis", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "E101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "EE102", Subject = "Digital Electronics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "E102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "EE103", Subject = "Signals and Systems", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "E103", Instructor = "Prof. Johnson" }
                };
            }

            // ------------------ ELECTRICAL ENGINEERING ------------------
            if (course == "Electrical Engineering") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ELE101", Subject = "Circuit Theory", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "EL101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "ELE102", Subject = "Electromagnetics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "EL102", Instructor = "Prof. Cruz" },
                    new SubjectModel { Code = "ELE103", Subject = "Power Systems", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "EL103", Instructor = "Prof. Reyes" }
                };
            }

            // ------------------ MECHANICAL ENGINEERING ------------------
            if (course == "Mechanical Engineering") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ME101", Subject = "Thermodynamics", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "M101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "ME102", Subject = "Fluid Mechanics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "M102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "ME103", Subject = "Dynamics", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "M103", Instructor = "Prof. Johnson" }
                };
            }

            // ------------------ ARCHITECTURE ------------------
            if (course == "Architecture") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ARC101", Subject = "Design Fundamentals", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "A101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "ARC102", Subject = "Architectural Graphics", Unit = 3, Schedule = "TTH 10:00-11:30 AM", Room = "A102", Instructor = "Prof. Garcia" },
                    new SubjectModel { Code = "ARC103", Subject = "Materials and Construction", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "A103", Instructor = "Prof. Santos" }
                };
            }

            // ------------------ INFORMATION TECHNOLOGY ------------------
            if (course == "Information Technology") {
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
            if (course == "Computer Science") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CS101", Subject = "Programming Logic", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "CS101", Instructor = "Prof. Reyes" },
                    new SubjectModel { Code = "CS102", Subject = "Database Systems", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "CS102", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "CS103", Subject = "Software Engineering", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "CS103", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ INFORMATION SYSTEMS ------------------
            if (course == "Information Systems") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "IS101", Subject = "Information Systems Fundamentals", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "IS101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "IS102", Subject = "Systems Analysis and Design", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "IS102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ ELEMENTARY EDUCATION ------------------
            if (course == "Elementary Education") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ED101", Subject = "Child Development", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "ED101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "ED102", Subject = "Teaching Methods", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "ED102", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ SECONDARY EDUCATION ------------------
            if (course == "Secondary Education") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "SED101", Subject = "Adolescent Psychology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "SE101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "SED102", Subject = "Curriculum Development", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "SE102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ PHYSICAL EDUCATION ------------------
            if (course == "Physical Education") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PE101", Subject = "Sports Science", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "PE101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "PE102", Subject = "Fitness and Health", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "PE102", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ COMMUNICATION ------------------
            if (course == "Communication") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "COM101", Subject = "Public Speaking", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "COM101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "COM102", Subject = "Media Writing", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "COM102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ BUSINESS / ACCOUNTANCY ------------------
            if (course == "Accountancy") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ACC101", Subject = "Financial Accounting", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "B101", Instructor = "Prof. Reyes" },
                    new SubjectModel { Code = "ACC102", Subject = "Cost Accounting", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "B102", Instructor = "Prof. Santos" }
                };
            }

            if (course == "Business Administration") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "BA101", Subject = "Marketing Management", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "BA101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "BA102", Subject = "Human Resource Management", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "BA102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ HUMAN RESOURCE MANAGEMENT ------------------
            if (course == "Human Resource Management") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "HR101", Subject = "Organizational Behavior", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "HR101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "HR102", Subject = "Compensation and Benefits", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "HR102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ TOURISM MANAGEMENT ------------------
            if (course == "Tourism Managemnet") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "TM101", Subject = "Travel Agency Management", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "TM101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "TM102", Subject = "Tourism Planning", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "TM102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ HOSPITALITY MANAGEMENT ------------------
            if (course == "Hospitality Management") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "HM101", Subject = "Hotel Operations", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "HM101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "HM102", Subject = "Food and Beverage Management", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "HM102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ NURSING ------------------
            if (course == "Nursing") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "NUR101", Subject = "Anatomy and Physiology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "N101", Instructor = "Prof. Cruz" },
                    new SubjectModel { Code = "NUR102", Subject = "Pharmacology", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "N102", Instructor = "Prof. Lee" }
                };
            }

            // ------------------ PHARMACY ------------------
            if (course == "Pharmacy") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PHA101", Subject = "Pharmacology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "P101", Instructor = "Prof. Cruz" },
                    new SubjectModel { Code = "PHA102", Subject = "Pharmaceutical Chemistry", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "P102", Instructor = "Prof. Lee" }
                };
            }

            // ------------------ BIOLOGY ------------------
            if (course == "Biology") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "BIO101", Subject = "General Biology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "B101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "BIO102", Subject = "Microbiology", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "B102", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ MEDICAL TECHNOLOGY ------------------
            if (course == "Medical Technology") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "MT101", Subject = "Clinical Chemistry", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "MT101", Instructor = "Prof. Lopez" },
                    new SubjectModel { Code = "MT102", Subject = "Hematology", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "MT102", Instructor = "Prof. Garcia" }
                };
            }

            // ------------------ LAW / JURIS DOCTOR ------------------
            if (course == "Law" || course == "Juris Doctor") {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "LAW101", Subject = "Constitutional Law", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "L101", Instructor = "Prof. Santos" },
                    new SubjectModel { Code = "LAW102", Subject = "Criminal Law", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "L102", Instructor = "Prof. Cruz" }
                };
            }

            // ------------------ DEFAULT ------------------
            return new List<SubjectModel>();
        }

    }
}
