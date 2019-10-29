using System;
using System.Windows.Forms;
using SOLID.Entities;

namespace SOLID
{
    public partial class MainView : Form, IMainView
    {
        
        public void SetDataGridViewRow_GPA(int rownumber, GPA gpa)
        {
            this.DataGridView_GPA.Rows[rownumber].Cells["University"].Value = gpa.Student.Faculty.University.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["Faculty"].Value = gpa.Student.Faculty.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["StudentFullName"].Value = gpa.Student.GetStudentFullName();
            this.DataGridView_GPA.Rows[rownumber].Cells["Subject"].Value = gpa.Subject.Name;
            this.DataGridView_GPA.Rows[rownumber].Cells["GPA"].Value = gpa.Student.Faculty.University.Name;
        }

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
