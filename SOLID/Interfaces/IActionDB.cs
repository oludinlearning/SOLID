using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID.Interfaces
{
    interface IActionDB
    {
        void AddStudents(string connectionString, IStudent students);
        void ReadStudent(string connectionString, out Table<IStudent> tab);

    }
}
