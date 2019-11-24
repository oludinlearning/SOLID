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
            IMainView.Set_label_PageNumber(page);
            int DBRecordID = page * rowcount - rowcount + 1;
            FillDataGridView_GPA(rowcount - 1);
            DBRecordCount = IModel.Get_DBRecordCount();
            int maxpage = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(DBRecordCount)) / (Convert.ToDouble(rowcount))));// + 1;
            int maxrow = DBRecordCount % rowcount;
            if (page != maxpage){ maxrow = rowcount; } else { if (maxrow == 0) { maxrow = rowcount; } }
                for (int i = 0; i < maxrow; i++)
                {
                    gpa = IModel.GetGPA(DBRecordID);
                    DBRecordID++;
                    IMainView.SetDataGridViewRow_GPA(i, gpa);
                }
            if(page == 1 && page != maxpage)
            {
                IMainView.SetNextButtonActive();
                IMainView.SetPrevButtonNotActive();
            }
            else if(page == 1 && page == maxpage)
            {
                IMainView.SetNextButtonNotActive();
                IMainView.SetPrevButtonNotActive();
            }
            else if(page != 1 && page == maxpage)
            {
                IMainView.SetNextButtonNotActive();
                IMainView.SetPrevButtonActive();
            }
            else
            {
                IMainView.SetNextButtonActive();
                IMainView.SetPrevButtonActive();
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

        void SetLanguage(string language)
        {
            //System.Windows.Forms.MessageBox.Show(language);
            IMainView.SetLanguage(language);
        }

        public Presenter(IMainView _IView, IModel _IModel)
        {
            IMainView = _IView;
            IModel = _IModel;
            int page = IMainView.GetOutputPage();
            int rowcount = IMainView.GetOutputRowMaxCount();
            FillDataGridView_GPA(rowcount);
            IMainView.onRowCountChanged += ShowDataGridView_GPA;
            IMainView.onPageChanged += ShowDataGridView_GPA;
            IMainView.OutputBySetSelectedIndex(0);
            IMainView.onLangaugeChanged += SetLanguage;
            IMainView.SettoolStripComboBox_Language_SelectedIndex(0);
            //ShowDataGridView_GPA(page, rowcount);
        }
    }
}
