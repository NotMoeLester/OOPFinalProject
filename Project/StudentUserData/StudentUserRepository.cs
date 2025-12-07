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
            _connection.CreateTable<StudentUser>();
            _connection.CreateTable<StudentData>();
        }

        //CREATE USER ACC
        public bool Add(StudentUser user, StudentData profile) {
            _connection.Insert(user);
            profile.StudentId = user.StudentId;
            _connection.Insert(profile); 
            return true;
        }

        //READ USER ACC
        public List<StudentUser> GetAll() {
            return _connection.Table<StudentUser>().ToList();
        }
        public StudentUser Get(int id) {
            return _connection.Find<StudentUser>(id);
        }

        //UPDATE USER ACC
        public bool UpdateStudent(StudentUser user) {
            _connection.Update(user);
            return true;
        }

        //DELETE USER ACC
        public bool DeleteStudent(StudentUser user) {
            _connection.Delete(user);
            DeleteStudentData(user.StudentId);
            return true;
        }

        //CHECK IF PASSWORD MATCH
        public StudentUser GetUserByEmailAndPassword(string email, string password) {
            return _connection.Table<StudentUser>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        //CHECK IF CURRENTLY USER
        public bool IsUser(string email) {
            StudentUser user = _connection.Table<StudentUser>().FirstOrDefault(u => u.Email == email);
            return user != null;
        }

        //CHECK IF USER ACCOUNT IS VALIDATED
        public bool IsAccoundValid(string email) {
            StudentUser user = _connection.Table<StudentUser>().FirstOrDefault(u => u.Email == email);
            return user != null && user.Verification;
        }

        //=============================================================================================================
        //STUDENT DATA

        //READ USER DATA
        public StudentUser GetStudentData(int studentId) {
            var user = _connection.Find<StudentUser>(studentId);
            if (user != null) {
                user.UserInfo = _connection.Table<StudentData>().FirstOrDefault(d => d.StudentId == studentId);
            }
            return user;
        }

        //UPDATE USER DATA
        public bool UpdateStudentData(StudentData data) {
            _connection.Update(data);
            return true;
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
