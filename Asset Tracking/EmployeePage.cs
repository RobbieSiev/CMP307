using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class EmployeePage : Form
    {
        private readonly dbEntities db;

        public EmployeePage(dbEntities db)
        {
            InitializeComponent();

            // use exisating db connection
            this.db = db;
        }
    }
}
