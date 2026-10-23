using System;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class MainPage : Form
    {
        private readonly dbEntities db;

        public MainPage(dbEntities db)
        {
            InitializeComponent();
            // use existing db
            this.db = db;
            FormClosed += MainPage_FormClosed;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // KILL IT
            Application.Exit();
        }

        private void AssetsButton_Click(object sender, EventArgs e)
        {
            // Show aSSET PAGE
            var assetsForm = new AssetsPage(db);
            // When asset form closed, show this one
            assetsForm.FormClosed += ChildForm_FormClosed;
            assetsForm.Show();
            Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            // Show Eployee Form
            var employeeForm = new EmployeePage(db);
            // When Employee FOrm closed, show this one
            employeeForm.FormClosed += ChildForm_FormClosed;
            employeeForm.Show();
            Hide();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // show this one
            Show();
        }
    }
}
