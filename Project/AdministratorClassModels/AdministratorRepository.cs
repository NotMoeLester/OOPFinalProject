using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdministratorUserData {
    internal class AdministratorRepository {
        private readonly SQLiteConnection _connection;
        public AdministratorRepository() {
            string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AdministratorUserData.db");
            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<AdministratorModel>();
        }
        public bool Add(AdministratorModel user) {
            _connection.Insert(user);
            return true;
        }

        public AdministratorModel GetUserByEmailAndPassword(string email, string password) {
            return _connection.Table<AdministratorModel>().FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public bool IsUser(string email) {
            AdministratorModel user = _connection.Table<AdministratorModel>().FirstOrDefault(u => u.Email == email);
            return user != null;
        }


    }
}
