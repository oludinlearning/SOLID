using System;
using System.Windows.Forms;
using SOLID.Entities;

namespace SOLID
{
    public partial class MainView : Form, IMainView
    {
        public delegate void RowCountChanged(int page, int rowcount);
        public event RowCountChanged onRowCountChanged;

        public readonly string[] outputbyselectrownumber = { "5", "10", "15", "20" };

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
        public void SetDataGridViewRow_GPA(int rownumber, GPA gpa)
        {            
            this.DataGridView_GPA.Rows[rownumber].Cells["University"].Value = gpa.Student.Faculty.University.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["Faculty"].Value = gpa.Student.Faculty.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["StudentFullName"].Value = gpa.Student.GetStudentFullName();
            this.DataGridView_GPA.Rows[rownumber].Cells["Subject"].Value = gpa.Subject.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["GPA"].Value = ((uint)gpa.GradePointAverage).ToString();
        }

        public MainView()
        {
            InitializeComponent();
            OutputBy.Items.AddRange(outputbyselectrownumber);
            RowMaxCount = Convert.ToInt32(outputbyselectrownumber[0]);
            //OutputBy.SelectedIndex = 0;
            //RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
        }

        private void OutputBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowMaxCount = Convert.ToInt32(OutputBy.Items[OutputBy.SelectedIndex]);
            
            onRowCountChanged(Page, RowMaxCount);
        }
    }
}