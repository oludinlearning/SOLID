using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID
{
    interface IModel
    {
        GPA GetGPA(int id);
        void SetGPA(int id, GPA gpa);
        void DeleteGPA(int id);
    }
}
