using System;
using System.Linq;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class LoginForm : Form
    {
        private readonly dbEntities db;
        public LoginForm(dbEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailInput.Text) || string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the user exists in the database
            var passwordHashed = (PasswordInput.Text);
            var userLoggedIn = db.employees.FirstOrDefault(u => u.email == emailInput.Text && u.passwordHash == passwordHashed);
            if (userLoggedIn != null)
            {
                // login successful, open MainPage
                var mainPage = new MainPage(db, userLoggedIn);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                // login failed, show error message
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
