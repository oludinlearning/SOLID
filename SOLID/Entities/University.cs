using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Entities
{
    public class University
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
    }
}
