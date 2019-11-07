using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SOLID.Models
{
    class ReadDB : IReadDB
    {
        public Table<IStudent> tab;
        public void ReadStudent(string connectionString, out Table<IStudent> tab)
        {
            DataContext db = new DataContext(connectionString);
            Table<IStudent> table1 = db.GetTable<IStudent>();
            tab = table1;
        }
    }
}
