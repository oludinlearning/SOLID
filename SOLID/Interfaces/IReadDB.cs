using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using SOLID.Models;

namespace SOLID.Interfaces
{
    public interface IReadDB
    {
        void ReadStudent(string connectionString, out Table<IStudent> tab);
    }
}
