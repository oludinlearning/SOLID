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
        void ShowDataGridView_GPA(int page, int rowcount)
        {
            for (int i = 0; i < rowcount; i++)
            {
                gpa = IModel.GetGPA(i);
                IMainView.SetDataGridViewRow_GPA(i, gpa);
            }
        }
        public Presenter(IMainView _IView, IModel _IModel)
        {
            IMainView = _IView;
            IModel = _IModel;
            int page = 1;
            int rowcount = 1;
            this.ShowDataGridView_GPA(page, rowcount);
        }
    }
}
