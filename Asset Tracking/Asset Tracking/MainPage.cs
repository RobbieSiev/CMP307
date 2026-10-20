using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Asset_Tracking;

namespace Asset_Tracking
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            string username = "mssql2401087"; // choice is yours where to put this
            string password = "pzjAQZ6zsU";
            // get base connection string from config
            string entityConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbEntities"].ConnectionString; // the name used in the Wizard and found in the App.config file
                                                                                                                                             // extract the SQL part from the Entity connection string
            var entityBuilder = new EntityConnectionStringBuilder(entityConnectionString);
            var sqlBuilder = new SqlConnectionStringBuilder(entityBuilder.ProviderConnectionString)
            {
                UserID = username, // right-hand sides are the user input variables declared above
                Password = password // left-hand side are built-in variables for connection string
            };
            // rebuild the Entity connection string
            entityBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;
            string finalConnectionString = entityBuilder.ConnectionString;
            // do stuffs
            using (var assetEntities = new dbEntities(finalConnectionString))
            {
                MessageBox.Show("Connection successful!");
                var employees = assetEntities.employees.ToList();
                MessageBox.Show($"Number of employees: {employees.Count}");
                // Perform database operations here
                // select all employees from the database
            }
        }
    }
}
