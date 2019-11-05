using System;
using System.Windows.Forms;
using SOLID.Entities;

namespace SOLID
{
    public partial class MainView : Form, IMainView
    {
        public delegate void RowCountChanged(int page, int rowcount);
        public event RowCountChanged onRowCountChanged;

        public delegate void PrevNextClicked(int page, int rowcount);
        public event PrevNextClicked onPageChanged;

        public delegate void LanguageChanged(string language);
        public event LanguageChanged onLangaugeChanged;

        public readonly string[] outputbyselectrownumber = { "5", "10", "15", "20" };
        IUIStrings IUIstrings;



        protected int RowMaxCount { get; set; }
        public int GetOutputRowMaxCount()
        {
            return this.RowMaxCount;
        }

        private int Page { get; set; } = 1;
        public int GetOutputPage()
        {
            return Page;
        }
        public void SetOutputByPage(int pagenumber)
        {
            Page = pagenumber;
        }

        public void AddDataGridViewRow_GPA()
        {
            DataGridView_GPA.Rows.Add();
        }

        public void DelDataGridViewRows()
        {
            DataGridView_GPA.Rows.Clear();
        }
        public void OutputBySetSelectedIndex(int index)
        {
            OutputBy.SelectedIndex = index;
        }

        public void SettoolStripComboBox_Language_SelectedIndex(int index)
        {
            toolStripComboBox_Language.SelectedIndex = index;        }
        public void SetDataGridViewRow_GPA(int rownumber, GPA gpa)
        {
            this.DataGridView_GPA.Rows[rownumber].Cells["ID"].Value = gpa.ID;
            this.DataGridView_GPA.Rows[rownumber].Cells["University"].Value = gpa.Student.Faculty.University.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["Faculty"].Value = gpa.Student.Faculty.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["StudentFullName"].Value = gpa.Student.GetStudentFullName();
            this.DataGridView_GPA.Rows[rownumber].Cells["Subject"].Value = gpa.Subject.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["GPA"].Value = ((uint)gpa.GradePointAverage).ToString();
        }

        public void Set_label_PageNumber(int page) {
            label_PageNumber.Text = page.ToString();
        }

        public void SetLanguage(string language)
        {
            string lang;
            if(language == "English")
            {
                lang = "ru-en";
                IUIstrings.SetLanguage(lang);
            }
            else if(language == "Русский")
            {
                IUIstrings.SetDefaultLanguage();                
            }
            SetFormStrings();
        }
        public void SetFormStrings()
        {
            Text = IUIstrings.FormName;
            FileToolStripMenuItem.Text = IUIstrings.MenuFile;
            EditToolStripMenuItem.Text = IUIstrings.MenuEdit;
            toolStripLabel_OutputBy.Text = IUIstrings.OutputBy;
            toolStripLabel_Language.Text = IUIstrings.Language;
            label_Page.Text = IUIstrings.Page;
            button_Next.Text = IUIstrings.ButtonNext;
            button_Previous.Text = IUIstrings.ButtonPrev;
        }
        public MainView()
        {
            InitializeComponent();
            IUIstrings = new UI_strings();
            OutputBy.Items.AddRange(outputbyselectrownumber);
            RowMaxCount = Convert.ToInt32(outputbyselectrownumber[0]);
            toolStripComboBox_Language.Items.AddRange(IUIstrings.language);
            SetFormStrings();

            //OutputBy.SelectedIndex = 0;
            //RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
        }

        private void OutputBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
            Page = 1;
            onRowCountChanged(Page, RowMaxCount);
        }



        #region Обработка кнопок "Следующая" и "Предыдущая"
        public void SetNextButtonNotActive()
        {
            button_Next.Enabled = false;
        }

        public void SetPrevButtonNotActive()
        {
            button_Previous.Enabled = false;
        }

        public void SetNextButtonActive()
        {
            button_Next.Enabled = true;
        }

        public void SetPrevButtonActive()
        {
            button_Previous.Enabled = true;
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
            onPageChanged(++Page, RowMaxCount);
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
            onPageChanged(--Page, RowMaxCount);
        }
        #endregion

        private void ToolStripComboBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            onLangaugeChanged(toolStripComboBox_Language.Text);
        }
    }
}