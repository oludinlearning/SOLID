using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using SOLID.Interfaces;

namespace SOLID.Entities
{
    [Table(Name = "GPA")]
    class GPA : IGPA
    {
        [Column(IsPrimaryKey = true, Name = "IdRecord", IsDbGenerated = true)]
        public int IdRecord { get; set; }
        [Column(Name = "gpa")]
        public int Gpa { get; set; }
        [Column]
        public int IdStudent { get; set; }
        private EntityRef<Student> _Student;
        [Association(Storage = "_Student", ThisKey = "IdStudent")]
        public Student Student
        {
            get { return _Student.Entity; }
            set { _Student.Entity = value; }
        }
        [Column]
        public int IdSubject { get; set; }
        private EntityRef<Subject> _Subject;
        [Association(Storage = "_Subject", ThisKey = "IdSubject")]
        public Subject Subject
        {
            get { return _Subject.Entity; }
            set { _Subject.Entity = value; }
        }


    }
}
