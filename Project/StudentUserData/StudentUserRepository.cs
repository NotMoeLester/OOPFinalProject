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
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "StudentUserData.db");
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<StudentUser>();
        }

        //CREATE
        public bool Add(StudentUser user) {
            _connection.Insert(user);
            return true;
        }

        //READ
        public List<StudentUser> GetAll() {
            return _connection.Table<StudentUser>().ToList();
        }
        public StudentUser Get(int id) {
            return _connection.Find<StudentUser>(id);
        }

        //UPDATE
        public bool UpdateStudent(StudentUser user) {
            _connection.Update(user);
            return true;
        }

        //DELETE
        public bool DeleteStudent(StudentUser user) {
            _connection.Delete(user);
            return true;
        }

        public StudentUser GetUserByEmailAndPassword(string email, string password) {
            return _connection.Table<StudentUser>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public bool IsUser(string email) {
            StudentUser user = _connection.Table<StudentUser>().FirstOrDefault(u => u.Email == email);
            return user != null;
        }
    }
}
