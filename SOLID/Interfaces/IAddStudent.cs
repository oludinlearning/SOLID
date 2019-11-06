using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    interface IAddStudent
    {
        void AddStudents(string connectionString, IStudent students);
    }
}
