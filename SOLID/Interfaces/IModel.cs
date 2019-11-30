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
        IQueryable<IGPA> GetGPA(int pageNumber, int pageSize);
        void SetGPA(GPA gpa);
        void DeleteGPA(int id);
        int Get_DBRecordCount();
    }
}
