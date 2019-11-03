using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID
{
    class Presenter
    {
        IModel IModel;
        IMainView IMainView;
        GPA gpa = new GPA();
        int DBRecordCount;
        

        void ShowDataGridView_GPA(int page, int rowcount)
        {
            int DBRecordID = page * rowcount - rowcount;
            FillDataGridView_GPA(rowcount - 1);
            DBRecordCount = IModel.Get_DBRecordCount();
            int maxpage = DBRecordCount / rowcount + 1;
            int maxrow = DBRecordCount % rowcount;
            if (page != maxpage) { maxrow = rowcount; }
                for (int i = 0; i < maxrow; i++)
                {
                    gpa = IModel.GetGPA(DBRecordID);
                    DBRecordID++;
                    IMainView.SetDataGridViewRow_GPA(i, gpa);
                }
            
            
        }
        void FillDataGridView_GPA(int rowcount)
        {
            IMainView.DelDataGridViewRows();
            for(int i = 0; i < rowcount; i++)
            {               
                IMainView.AddDataGridViewRow_GPA();
            }
        }
         
        public Presenter(IMainView _IView, IModel _IModel)
        {
            IMainView = _IView;
            IModel = _IModel;
            int page = IMainView.GetOutputPage();
            int rowcount = IMainView.GetOutputRowMaxCount();
            FillDataGridView_GPA(rowcount);
            IMainView.onRowCountChanged += ShowDataGridView_GPA;
            IMainView.OutputBySetSelectedIndex(0);
            //ShowDataGridView_GPA(page, rowcount);
        }
    }
}
