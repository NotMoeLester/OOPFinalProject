using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.StudentClassModels {
    public class SubjectModel {

        public SubjectModel() {

        }
        public string? Code { get; set; }
        public string? Subject { get; set; }
        public int? Unit { get; set; }
        public string? Schedule { get; set; }
        public string? Room { get; set; }
        public string? Instructor { get; set; }
        public bool IsEnrolled { get; set; }

        public bool CheckUnits(int units) {
            if (units <= 0 ||  units > 30) {
                return false;
            }
            return true;
        }


    }
}
