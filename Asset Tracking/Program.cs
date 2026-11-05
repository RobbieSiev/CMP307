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
                    throw new Exception("Asset table is empty or inaccessible. Auth with firewall.\nIf table is actually empty, ignore");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    GetFullExceptionMessage(exception),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //return; // comment out if asset table is actually empty
            }
            // show main form
            Application.Run(new MainPage(db));

            // kill db when program closed
            db?.Dispose();
            DatabaseConnection.CreateContext().Dispose();
        }

        private static string GetFullExceptionMessage(Exception exception)
        {
            var messages = new System.Collections.Generic.List<string>();

            while (exception != null)
            {
                messages.Add(exception.Message);
                exception = exception.InnerException;
            }

            string error = string.Join(
                Environment.NewLine + Environment.NewLine,
                messages);
            Console.WriteLine(error);
            return error;
        }
    }
}
