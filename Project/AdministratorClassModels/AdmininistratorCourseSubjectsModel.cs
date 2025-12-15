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

            // ------------------ AB IN POLITICAL SCIENCE ------------------
            if (course.Contains("AB in Political Science")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PS101", Subject = "Introduction to Political Science", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "PS101", Instructor = "Prof. Mendoza" },
                    new SubjectModel { Code = "PS102", Subject = "Philippine Government and Politics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "PS102", Instructor = "Prof. Rivera" },
                    new SubjectModel { Code = "PS103", Subject = "Comparative Politics", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "PS103", Instructor = "Prof. Aquino" }
                };
            }

            // ------------------ AB IN PSYCHOLOGY ------------------
            if (course.Contains("AB in Psychology")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PSY101", Subject = "General Psychology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "PSY101", Instructor = "Prof. Diaz" },
                    new SubjectModel { Code = "PSY102", Subject = "Developmental Psychology", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "PSY102", Instructor = "Prof. Torres" },
                    new SubjectModel { Code = "PSY103", Subject = "Abnormal Psychology", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "PSY103", Instructor = "Prof. Ramos" }
                };
            }

            // ------------------ AB IN SOCIOLOGY ------------------
            if (course.Contains("AB in Sociology")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "SOC101", Subject = "Introduction to Sociology", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "SOC101", Instructor = "Prof. Fernandez" },
                    new SubjectModel { Code = "SOC102", Subject = "Social Problems", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "SOC102", Instructor = "Prof. Bautista" },
                    new SubjectModel { Code = "SOC103", Subject = "Philippine Society and Culture", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "SOC103", Instructor = "Prof. Dela Cruz" }
                };
            }

            // ------------------ BA IN COMMUNICATION ------------------
            if (course.Contains("BA in Communication")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "COMM101", Subject = "Fundamentals of Communication", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "COM101", Instructor = "Prof. Santiago" },
                    new SubjectModel { Code = "COMM102", Subject = "Media and Society", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "COM102", Instructor = "Prof. Villamar" },
                    new SubjectModel { Code = "COMM103", Subject = "Public Speaking", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "COM103", Instructor = "Prof. Morales" }
                };
            }

            // ------------------ BACHELOR OF LAWS ------------------
            if (course.Contains("Bachelor of Laws")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "LAW101", Subject = "Legal Research and Writing", Unit = 3, Schedule = "TTH 6:00-8:00 PM", Room = "LAW101", Instructor = "Atty. Gonzales" },
                    new SubjectModel { Code = "LAW102", Subject = "Constitutional Law", Unit = 4, Schedule = "MW 6:00-8:00 PM", Room = "LAW102", Instructor = "Atty. Rodriguez" },
                    new SubjectModel { Code = "LAW103", Subject = "Civil Law", Unit = 4, Schedule = "TTH 8:00-10:00 PM", Room = "LAW103", Instructor = "Atty. Martinez" }
                };
            }

            // ------------------ BEED IN ELEMENTARY EDUCATION ------------------
            if (course.Contains("BEEd in Elementary Education")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ED101", Subject = "Child and Adolescent Development", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "ED101", Instructor = "Prof. Valencia" },
                    new SubjectModel { Code = "ED102", Subject = "Teaching Mathematics in Elementary", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "ED102", Instructor = "Prof. Navarro" },
                    new SubjectModel { Code = "ED103", Subject = "Teaching Science in Elementary", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "ED103", Instructor = "Prof. Castillo" }
                };
            }

            // ------------------ BPED IN PHYSICAL EDUCATION ------------------
            if (course.Contains("BPEd in Physical Education")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PE101", Subject = "Fundamentals of Physical Education", Unit = 3, Schedule = "MWF 7:00-8:00 AM", Room = "GYM1", Instructor = "Prof. Velasco" },
                    new SubjectModel { Code = "PE102", Subject = "Team Sports", Unit = 3, Schedule = "TTH 7:00-8:30 AM", Room = "GYM2", Instructor = "Prof. Ortega" },
                    new SubjectModel { Code = "PE103", Subject = "Exercise Physiology", Unit = 3, Schedule = "MWF 9:00-10:00 AM", Room = "PE103", Instructor = "Prof. Mercado" }
                };
            }

            // ------------------ BS IN ACCOUNTANCY ------------------
            if (course.Contains("BS in Accountancy")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ACC101", Subject = "Financial Accounting 1", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "ACC101", Instructor = "Prof. Tan" },
                    new SubjectModel { Code = "ACC102", Subject = "Cost Accounting", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "ACC102", Instructor = "Prof. Lim" },
                    new SubjectModel { Code = "ACC103", Subject = "Auditing Principles", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "ACC103", Instructor = "Prof. Chua" }
                };
            }

            // ------------------ BS IN BIOLOGY ------------------
            if (course.Contains("BS in Biology")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "BIO101", Subject = "General Biology", Unit = 4, Schedule = "MWF 8:00-9:00 AM", Room = "BIO101", Instructor = "Prof. Castro" },
                    new SubjectModel { Code = "BIO102", Subject = "Microbiology", Unit = 4, Schedule = "TTH 9:00-11:00 AM", Room = "BIO102", Instructor = "Prof. Pascual" },
                    new SubjectModel { Code = "BIO103", Subject = "Genetics", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "BIO103", Instructor = "Prof. Salazar" }
                };
            }

            // ------------------ BS IN BUSINESS ADMINISTRATION ------------------
            if (course.Contains("BS in Business Administration")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "BA101", Subject = "Principles of Management", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "BA101", Instructor = "Prof. Soriano" },
                    new SubjectModel { Code = "BA102", Subject = "Business Economics", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "BA102", Instructor = "Prof. Espinosa" },
                    new SubjectModel { Code = "BA103", Subject = "Operations Management", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "BA103", Instructor = "Prof. Velasquez" }
                };
            }

            // ------------------ BS IN COMPUTER ENGINEERING ------------------
            if (course.Contains("BS in Computer Engineering")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "CPE101", Subject = "Logic Circuits and Design", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "CPE101", Instructor = "Prof. Aguilar" },
                    new SubjectModel { Code = "CPE102", Subject = "Microprocessor Systems", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "CPE102", Instructor = "Prof. Miranda" },
                    new SubjectModel { Code = "CPE103", Subject = "Computer Architecture", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "CPE103", Instructor = "Prof. Rosales" }
                };
            }

            // ------------------ BS IN ENTREPRENEURSHIP ------------------
            if (course.Contains("BS in Entrepreneurship")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "ENT101", Subject = "Introduction to Entrepreneurship", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "ENT101", Instructor = "Prof. Abad" },
                    new SubjectModel { Code = "ENT102", Subject = "Business Planning", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "ENT102", Instructor = "Prof. Romualdez" },
                    new SubjectModel { Code = "ENT103", Subject = "Innovation Management", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "ENT103", Instructor = "Prof. Tolentino" }
                };
            }

            // ------------------ BS IN HUMAN RESOURCE MANAGEMENT ------------------
            if (course.Contains("BS in Human Resource Management")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "HRM101", Subject = "Human Resource Management", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "HRM101", Instructor = "Prof. Ocampo" },
                    new SubjectModel { Code = "HRM102", Subject = "Compensation and Benefits", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "HRM102", Instructor = "Prof. Estrada" },
                    new SubjectModel { Code = "HRM103", Subject = "Labor Relations", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "HRM103", Instructor = "Prof. Pineda" }
                };
            }

            // ------------------ BS IN MARKETING MANAGEMENT ------------------
            if (course.Contains("BS in Marketing Management")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "MKT101", Subject = "Principles of Marketing", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "MKT101", Instructor = "Prof. Cortez" },
                    new SubjectModel { Code = "MKT102", Subject = "Consumer Behavior", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "MKT102", Instructor = "Prof. Delgado" },
                    new SubjectModel { Code = "MKT103", Subject = "Digital Marketing", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "MKT103", Instructor = "Prof. Hernandez" }
                };
            }

            // ------------------ BS IN MEDICAL TECHNOLOGY ------------------
            if (course.Contains("BS in Medical Technology")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "MT101", Subject = "Clinical Chemistry", Unit = 4, Schedule = "MWF 8:00-10:00 AM", Room = "MT101", Instructor = "Prof. Domingo" },
                    new SubjectModel { Code = "MT102", Subject = "Hematology", Unit = 4, Schedule = "TTH 9:00-11:00 AM", Room = "MT102", Instructor = "Prof. Perez" },
                    new SubjectModel { Code = "MT103", Subject = "Clinical Microscopy", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "MT103", Instructor = "Prof. Chavez" }
                };
            }

            // ------------------ BS IN NURSING ------------------
            if (course.Contains("BS in Nursing")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "NUR101", Subject = "Fundamentals of Nursing", Unit = 4, Schedule = "MWF 8:00-10:00 AM", Room = "NUR101", Instructor = "Prof. Salvador" },
                    new SubjectModel { Code = "NUR102", Subject = "Anatomy and Physiology", Unit = 4, Schedule = "TTH 9:00-11:00 AM", Room = "NUR102", Instructor = "Prof. Gutierrez" },
                    new SubjectModel { Code = "NUR103", Subject = "Health Assessment", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "NUR103", Instructor = "Prof. Manalo" }
                };
            }

            // ------------------ BS IN PHARMACY ------------------
            if (course.Contains("BS in Pharmacy")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "PHAR101", Subject = "Pharmaceutical Chemistry", Unit = 4, Schedule = "MWF 8:00-10:00 AM", Room = "PHAR101", Instructor = "Prof. Valdez" },
                    new SubjectModel { Code = "PHAR102", Subject = "Pharmacology", Unit = 4, Schedule = "TTH 9:00-11:00 AM", Room = "PHAR102", Instructor = "Prof. Jimenez" },
                    new SubjectModel { Code = "PHAR103", Subject = "Pharmaceutics", Unit = 3, Schedule = "MWF 1:00-2:00 PM", Room = "PHAR103", Instructor = "Prof. Medina" }
                };
            }

            // ------------------ JURIS DOCTOR ------------------
            if (course.Contains("Juris Doctor")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "JD101", Subject = "Legal Method", Unit = 3, Schedule = "TTH 6:00-8:00 PM", Room = "JD101", Instructor = "Atty. Ramirez" },
                    new SubjectModel { Code = "JD102", Subject = "Criminal Law", Unit = 4, Schedule = "MW 6:00-8:00 PM", Room = "JD102", Instructor = "Atty. Moreno" },
                    new SubjectModel { Code = "JD103", Subject = "Torts and Damages", Unit = 3, Schedule = "TTH 8:00-10:00 PM", Room = "JD103", Instructor = "Atty. Alvarez" }
                };
            }

            // ------------------ GENERAL STUDIES ------------------
            if (course.Contains("General Studies")) {
                return new List<SubjectModel> {
                    new SubjectModel { Code = "GEN101", Subject = "Critical Thinking", Unit = 3, Schedule = "MWF 8:00-9:00 AM", Room = "GEN101", Instructor = "Prof. Montero" },
                    new SubjectModel { Code = "GEN102", Subject = "World History", Unit = 3, Schedule = "TTH 9:00-10:30 AM", Room = "GEN102", Instructor = "Prof. Zamora" },
                    new SubjectModel { Code = "GEN103", Subject = "Philosophy and Ethics", Unit = 3, Schedule = "MWF 10:00-11:00 AM", Room = "GEN103", Instructor = "Prof. Lazaro" }
                };
            }

            return new List<SubjectModel>();
        }
    }
}
