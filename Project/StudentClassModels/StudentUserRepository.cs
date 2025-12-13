using Microsoft.VisualBasic.ApplicationServices;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentUserRepository {
        private readonly SQLiteConnection _connection;

        public StudentUserRepository() {
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "StudentUserData.db" );
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<StudentModel>();
            _connection.CreateTable<StudentData>();
        }

        //CREATE USER ACC
        public bool AddStudentAndStudentData(StudentModel user, StudentData profile) {
            _connection.Insert(user);
            profile.StudentId = user.StudentId;
            _connection.Insert(profile); 
            return true;
        }

        //READ USER ACC
        public List<StudentModel> GetAll() {
            return _connection.Table<StudentModel>().ToList();
        }
        public StudentModel Get(int id) {
            return _connection.Find<StudentModel>(id);
        }

        //UPDATE USER ACC
        public bool UpdateStudentAndStudentData(StudentModel user) {
            _connection.Update(user);
            if (user.UserInfo != null)
                _connection.Update(user.UserInfo);
            return true;
        }

        //DELETE USER ACC
        public bool DeleteStudentAndStudentData(StudentModel user) {
            _connection.Delete(user);
            DeleteStudentData(user.StudentId);
            return true;
        }

        //CHECK IF PASSWORD MATCH
        public StudentModel GetUserByEmailAndPassword(string email, string password) {
            return _connection.Table<StudentModel>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //CHECK IF CURRENTLY USER
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
        //STUDENT DATA
        // READ USER DATA
        public StudentModel GetStudentData(int studentId) {
            var user = _connection.Find<StudentModel>(studentId);
            if (user != null) {
                user.UserInfo = _connection.Table<StudentData>().FirstOrDefault(d => d.StudentId == studentId);
            }
            return user;
        }
        public StudentModel GetFullStudentUser(string email, string password) {
            var user = GetUserByEmailAndPassword(email, password);
            if (user != null) {
                user.UserInfo = GetStudentData(user.StudentId)?.UserInfo ?? new StudentData();
            }
            return user;
        }


        //DELETE USER DATA
        public bool DeleteStudentData(int studentId) {
            var userData = _connection.Table<StudentData>().FirstOrDefault(d => d.StudentId == studentId);
            if (userData != null)
                _connection.Delete(userData);
            return true;
        }
    }
}
