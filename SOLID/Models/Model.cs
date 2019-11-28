using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;
using SOLID.Interfaces;
using SOLID.Models;

namespace SOLID
{
    class Model : IModel
    {
        IActionDB actionDb;
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        DataContext db;
        IQueryable<GPA> gpa;
        public Model()
        {
            actionDb = new ActionDB();
            db = new DataContext(connectionString);

        }
        public int Get_DBRecordCount()
        {
            return actionDb.Count;
        }  
        public IQueryable<GPA> GetGPA(int pageNumber, int pageSize)
        {
            actionDb.GetRecordofStudent(ref gpa, db, pageNumber, pageSize);
            return gpa;
        }

        public void DeleteGPA(int id)
        {
            actionDb.DeleteRecordofStudent(id, db);
        }

        public void SetGPA(GPA gpa)
        {
            actionDb.AddRecordofStudent(db,gpa);
        }
    }
}
