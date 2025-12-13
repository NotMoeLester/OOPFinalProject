using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Project.StudentClassModels {
    public class StudentSubjectsModel {
        [PrimaryKey]
        public int StudentId { get; set; }
        public string SubjectsJson { get; set; } = "";

        [Ignore]
        public List<SubjectModel> Subjects {
            get => string.IsNullOrEmpty(SubjectsJson) ? new List<SubjectModel>() : JsonConvert.DeserializeObject<List<SubjectModel>>(SubjectsJson);
            set => SubjectsJson = JsonConvert.SerializeObject(value);
        }
    }
}
