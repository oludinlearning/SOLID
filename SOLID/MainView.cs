using System;
using System.Windows.Forms;
using SOLID.Entities;

namespace SOLID
{
    public partial class MainView : Form, IMainView
    {
        public void ShowDataGridView_GPA(int page, int rowcount)
        {

        }
        public void SetDataGridViewRow_GPA(int rownumber, GPA gpa)
        {

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
