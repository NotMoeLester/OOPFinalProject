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
        public bool Add(StudentUser user) {
            _connection.Insert(user);
            return true;
        }

        public List<User> GetAll() {
            return _connection.Table<User>().ToList();
        }

        public User Get(int id) {S
            return _connection.Find<User>(id);
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
