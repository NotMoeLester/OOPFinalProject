using Microsoft.VisualBasic.ApplicationServices;
using Project.StudentClassModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentRepository {
        private readonly SQLiteConnection _connection;

        public StudentRepository() {
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "StudentUserData.db" );
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<StudentModel>();
            _connection.CreateTable<StudentInformationModel>();
            _connection.CreateTable<StudentSubjectsModel>();
        }

        //CREATE
        #region
        public bool AddStudent(StudentModel student, StudentInformationModel studentInformation, StudentSubjectsModel studentSubject) {
            _connection.Insert(student);

            studentInformation.StudentId = student.StudentId;
            studentSubject.StudentId = student.StudentId;

            _connection.Insert(studentInformation); 
            _connection.Insert(studentSubject);

            return true;
        }
        #endregion

        //READ
        #region
        public List<StudentModel> GetAll() {
            return _connection.Table<StudentModel>().ToList();
        }
        public StudentModel Get(int id) {
            return _connection.Find<StudentModel>(id);
        }
        public StudentModel? GetStudentData(int studentId) {
            var student = _connection.Find<StudentModel>(studentId);
            if (student != null) {
                student.StudentInformation = _connection.Table<StudentInformationModel>().FirstOrDefault(d => d.StudentId == studentId) ?? new StudentInformationModel();
            }
            return student;
        }
        public StudentModel? GetFullStudentUser(string email, string password) {
            var student = GetUserByEmailAndPassword(email, password);
            if (student != null) {
                student.StudentInformation = GetStudentData(student.StudentId)?.StudentInformation ?? new StudentInformationModel() ?? new StudentInformationModel();
            }
            return student;
        }
        public List<SubjectModel> GetStudentSubjects(int studentId) {
            var studentSubjects = _connection.Table<StudentSubjectsModel>().FirstOrDefault(s => s.StudentId == studentId);
            if (studentSubjects != null) {
                return studentSubjects.Subjects;
            }
            return new List<SubjectModel>();
        }

        #endregion  

        //UPDATE USER ACC
        public bool UpdateStudentAndStudentData(StudentModel student, StudentInformationModel studentInformation, StudentSubjectsModel studentSubject) {
            student.StudentInformation = studentInformation;
            student.StudentSubject = studentSubject;
            _connection.Update(student);
            if (student.StudentInformation != null) {
                _connection.Update(student.StudentInformation);
                _connection.Update(studentSubject);
            }
            return true;
        }
        public bool UpdateStudentSubjects(int studentId, List<SubjectModel> subjects) {
            var studentSubjects = _connection.Table<StudentSubjectsModel>().FirstOrDefault(s => s.StudentId == studentId);
            if (studentSubjects != null) {
                studentSubjects.Subjects = subjects;
                _connection.Update(studentSubjects);
                return true;
            }
            return false;
        }

        //DELETE USER ACC ====================================================================================================
        #region
        public bool DeleteStudentAndStudentData(StudentModel student) {
            _connection.Delete(student);
            DeleteStudentInformation(student.StudentId);
            DeleteStudentSujectsInformation(student.StudentId);
            return true;
        }
        public bool DeleteStudentInformation(int studentId) {
            var userData = _connection.Table<StudentInformationModel>().FirstOrDefault(d => d.StudentId == studentId);
            if (userData != null)
                _connection.Delete(userData);
            return true;
        }
        public bool DeleteStudentSujectsInformation(int studentId) {
            var studentSubjectInformation = _connection.Table<StudentSubjectsModel>().FirstOrDefault(d => d.StudentId == studentId);
            if (studentSubjectInformation != null)
                _connection.Delete(studentSubjectInformation);
            return true;
        }
        #endregion

        //CHECK CREDENTIALS ============================================================================================
        #region
        public StudentModel GetUserByEmailAndPassword(string email, string password) {
            return _connection.Table<StudentModel>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //CHECK IF CURRENTLY USER =====================================================================================
        public bool IsUser(string email) {
            StudentModel user = _connection.Table<StudentModel>().FirstOrDefault(u => u.Email == email);
            return user != null;
        }

        //CHECK IF USER ACCOUNT IS VALIDATED
        public bool IsAccoundValid(string email) {
            StudentModel user = _connection.Table<StudentModel>().FirstOrDefault(u => u.Email == email);
            return user != null && user.Verification;
        }
        #endregion

    }
}
