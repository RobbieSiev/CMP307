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

            this.db = db;
            FormClosed += MainPage_FormClosed;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AssetsButton_Click(object sender, EventArgs e)
        {
            var assetsForm = new AssetsPage(db);

            assetsForm.FormClosed += ChildForm_FormClosed;
            assetsForm.Show();
            Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeePage(db);

            employeeForm.FormClosed += ChildForm_FormClosed;
            employeeForm.Show();
            Hide();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
