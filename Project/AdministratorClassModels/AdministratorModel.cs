using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GeneralModel;

namespace Project {
    internal class AdministratorModel : UserModel {
        public int AccessLevel { get; set; } = 0;
    }
}
