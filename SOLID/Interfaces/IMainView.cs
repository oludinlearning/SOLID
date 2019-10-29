using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID
{
    interface IMainView
    {
        //void ShowDataGridView_GPA(int page, int rowcount);
        void SetDataGridViewRow_GPA(int rownumber, GPA gpa);
    }
}
