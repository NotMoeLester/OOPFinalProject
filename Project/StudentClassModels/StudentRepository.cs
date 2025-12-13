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
        public bool AddStudent(StudentModel student, StudentInformationModel studentInformation, StudentSubjectsModel studentSubjet ) {
            _connection.Insert(student);

            studentInformation.StudentId = student.StudentId;
            studentSubjet.StudentId = student.StudentId;

            _connection.Insert(studentInformation); 
            _connection.Insert(studentSubjet);

            return true;
        }

        //READ
        public List<StudentModel> GetAll() {
            return _connection.Table<StudentModel>().ToList();
        }
        public StudentModel Get(int id) {
            return _connection.Find<StudentModel>(id);
        }

        //UPDATE USER ACC
        public bool UpdateStudentAndStudentData(StudentModel student) {
            _connection.Update(student);
            if (student.StudentInformation != null) {
                _connection.Update(student.StudentInformation);
            }
            return true;
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

        //CHECK IF PASSWORD MATCH ============================================================================================
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

        //=============================================================================================================


        // READ USER DATA
        public StudentModel GetStudentData(int studentId) {
            var user = _connection.Find<StudentModel>(studentId);
            if (user != null) {
                user.StudentInformation = _connection.Table<StudentInformationModel>().FirstOrDefault(d => d.StudentId == studentId);
            }
            return user;
        }
        public StudentModel GetFullStudentUser(string email, string password) {
            var user = GetUserByEmailAndPassword(email, password);
            if (user != null) {
                user.StudentInformation = GetStudentData(user.StudentId)?.StudentInformation ?? new StudentInformationModel();
            }
            return user;
        }


        //DELETE USER DATA

    }
}
