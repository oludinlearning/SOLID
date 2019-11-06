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
    class AddStudent : IAddStudent
    {
        public void AddStudents(string connectionString, IStudent students)
        {
            DataContext db = new DataContext(connectionString);
            // добавляем его в таблицу Users
            db.GetTable<IStudent>().InsertOnSubmit(students);
            db.SubmitChanges();
        }
    }
}
