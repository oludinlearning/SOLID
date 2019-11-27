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
        void AddRecordofStudent(DataContext db, IGPA gpa);
        void GetRecordofStudent(ref IQueryable<GPA> gpa, DataContext db, int pageNumber, int pageSize);

    }
}
