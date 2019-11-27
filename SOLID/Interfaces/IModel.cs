using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;
using SOLID.Interfaces;

namespace SOLID
{
    interface IModel
    {
        IQueryable<GPA> GetGPA(int pageNumber, int pageSize);
        void SetGPA(IGPA gpa);
        void DeleteGPA(int id);
        int Get_DBRecordCount();
    }
}
