using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Entities
{
    public class GPA //Grade point average (Средний балл)
    {
        public enum gpa
        {
             bad = 2,
             satisfactory = 3,
             good = 4,
             great = 5
        }

        protected int id;
        public int ID { get { return id; } set { id = value; } }
        protected gpa gradepointaverage;
        public gpa GradePointAverage { get { return gradepointaverage; } set { gradepointaverage = value; } }
        protected Student student;
        public Student Student { get { return student; } set { student = value; } }
        protected Subject subject;
        public Subject Subject { get { return subject; } set { subject = value; } }
    }
}
