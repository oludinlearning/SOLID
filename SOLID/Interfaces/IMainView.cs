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
        event MainView.RowCountChanged onRowCountChanged;
        void SetDataGridViewRow_GPA(int rownumber, GPA gpa);
        int GetOutputRowMaxCount();
        int GetOutputPage();
        void SetOutputByPage(int pagenumber);
        void AddDataGridViewRow_GPA();
        void OutputBySetSelectedIndex(int index);
        void DelDataGridViewRows();
    }
}
