using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Entities
{
    class Faculty
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }

        protected University university;
        public University University { get { return university; } set { university = value; } }
    }
}
