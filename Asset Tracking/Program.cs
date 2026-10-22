using System;
using System.CodeDom;
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
                    "Cannot access the database.\r\n\r\n" + exception.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Application.Run(new MainPage(db));
                db?.Dispose();
                DatabaseConnection.CreateContext().Dispose();
        }
    }
}
