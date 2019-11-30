using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;


namespace SOLID.Interfaces
{
    interface IActionDB
    {
        int Count { get; set; }
        void AddRecordofStudent(DataContext db, GPA gpa);
        void GetRecordofStudent(ref IQueryable<IGPA> gpa, DataContext db, int pageNumber, int pageSize);
        void DeleteRecordofStudent(int idRecord, DataContext db);

    }
}
