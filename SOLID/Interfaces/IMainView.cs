using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;
using SOLID.Interfaces;

namespace SOLID
{
    interface IMainView
    {
        //void ShowDataGridView_GPA(int page, int rowcount);
        event MainView.RowCountChanged onRowCountChanged;
        event MainView.PrevNextClicked onPageChanged;
        event MainView.LanguageChanged onLangaugeChanged;
        void SetDataGridViewRow_GPA(int rownumber, IGPA gpa);
        int GetOutputRowMaxCount();
        int GetOutputPage();
        void SetOutputByPage(int pagenumber);
        void AddDataGridViewRow_GPA();
        void OutputBySetSelectedIndex(int index);
        void DelDataGridViewRows();
        void Set_label_PageNumber(int page);
        void SetPrevButtonNotActive();
        void SetNextButtonNotActive();
        void SetPrevButtonActive();
        void SetNextButtonActive();
        void SettoolStripComboBox_Language_SelectedIndex(int index);
        void SetLanguage(string language);
    }
}
