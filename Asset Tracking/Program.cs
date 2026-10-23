using System;
using System.Linq;
using System.Windows.Forms;

namespace Asset_Tracking
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dbEntities db = null;

            try
            {
                // check if db is accessable
                db = DatabaseConnection.CreateContext();

                if (!db.assets.Any())
                {
                    // Database is probably inaccessible
                    throw new Exception("Database is empty or inaccessible. Auth with firewall.");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Auth with firewall.\r\n\r\nCannot access the database.\r\n\r\n" + exception.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // show main form
            Application.Run(new MainPage(db));

            // kill db when program closed
            db?.Dispose();
            DatabaseConnection.CreateContext().Dispose();
        }
    }
}
