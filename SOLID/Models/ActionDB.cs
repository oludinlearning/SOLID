using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;
using SOLID.Interfaces;

namespace SOLID.Models
{
    class ActionDB //: IActionDB
    {
        public void AddStudents(string connectionString, IStudent students)
        {
            DataContext db = new DataContext(connectionString);
            db.GetTable<IStudent>().InsertOnSubmit(students);
            db.SubmitChanges();
        }
        public Table<IStudent> ReadStudent(string connectionString)
        {
            DataContext db = new DataContext(connectionString);
            return /*Table<IStudent> table1 =*/ db.GetTable<IStudent>();
        }
    }
}
