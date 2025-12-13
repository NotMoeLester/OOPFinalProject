using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.StudentClassModels {
    public abstract class SubjectModel {

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int Unit { get; set; }
        public string Schedule { get; set; }
        public string Room { get; set; }
        public string Instructor { get; set; }

        public bool IsEnrolled { get; set; }
        public bool enoughUnits { get; set; }

        private bool checkUnits() {
            return enoughUnits;
        }
    }
}
