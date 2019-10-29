using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Entities
{
    public class Student
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }

        protected string surname;
        public string Surname { get { return surname; } set { surname = value; } }

        protected string patronimic;
        public string Patronimic { get { return patronimic; } set { patronimic = value; } }

        protected Faculty faculty;
        public Faculty Faculty { get { return faculty; } set { faculty = value; } }

        //protected University university;
        //public University University { get { return university; } set { university = value; } }
    }
}