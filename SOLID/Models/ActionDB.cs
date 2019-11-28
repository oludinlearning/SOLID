using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;
using SOLID.Interfaces;
using System.Configuration;
using SOLID.Entities;

namespace SOLID.Models
{
    class ActionDB : IActionDB
    {
        public int Count { get; set; } = 0;
        public void AddRecordofStudent(DataContext db, GPA gpa)
        {
            db.GetTable<GPA>().InsertOnSubmit(gpa);
            db.SubmitChanges();
        }
        public void GetRecordofStudent(ref IQueryable<GPA> gpa, DataContext db, int pageNumber, int pageSize)
        {
            Count = db.GetTable<GPA>().Count();
            if (Count > pageNumber * pageSize)
            {
                gpa = db.GetTable<GPA>().Skip(pageNumber * pageSize).Take(pageSize);
            }
        }
        public void DeleteRecordofStudent(int idRecord, DataContext db)
        {
            var rec = from order in db.GetTable<GPA>()
                      where order.IdRecord == idRecord
                      select order;
            foreach(var gpa in rec)
            db.GetTable<GPA>().DeleteOnSubmit(gpa);
            db.SubmitChanges();
        }
    }
}
