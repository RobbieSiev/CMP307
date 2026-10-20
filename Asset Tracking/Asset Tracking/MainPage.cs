using System;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            FormClosed += MainPage_FormClosed;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AssetsButton_Click(object sender, EventArgs e)
        {
            var assetsForm = new AssetsPage();

            assetsForm.Show();
            Hide();
        }
    }
}
