using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class StudentUser {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool Verification { get; set; } = false;

        [Ignore]
        [Browsable(false)]
        public StudentData UserInfo { get; set; } = new StudentData();

        public StudentUser() { 
        
        
        }
    }
}
