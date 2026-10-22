using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class EmployeePage : Form
    {
        private readonly dbEntities db;

        public EmployeePage(dbEntities db)
        {
            InitializeComponent();

            this.db = db;
        }
    }
}
