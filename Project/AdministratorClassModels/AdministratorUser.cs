using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    internal class AdministratorUser {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int AccessLevel { get; set; } = 0;
    }
}
