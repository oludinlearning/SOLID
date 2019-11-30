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
    class Presenter
    {
        IModel IModel;
        IMainView IMainView;
        IQueryable<IGPA> gpa;
        int DBRecordCount;
        

        void ShowDataGridView_GPA(int page, int rowcount)
        {
            IMainView.Set_label_PageNumber(page);
            FillDataGridView_GPA(rowcount - 1);
            gpa = IModel.GetGPA(page, rowcount);
            DBRecordCount = IModel.Get_DBRecordCount();
            int maxpage = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(DBRecordCount)) / (Convert.ToDouble(rowcount))));// + 1;
            int maxrow = DBRecordCount % rowcount;
            int i = 0;
            foreach(var quer in gpa)
            {
                IMainView.SetDataGridViewRow_GPA(i,quer);
                i++;
            }
            if(page == 0 && page != maxpage)
            {
                IMainView.SetNextButtonActive();
                IMainView.SetPrevButtonNotActive();
            }
            else if(page == 0 && page == maxpage)
            {
                IMainView.SetNextButtonNotActive();
                IMainView.SetPrevButtonNotActive();
            }
            else if(page != 0 && page == maxpage)
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
