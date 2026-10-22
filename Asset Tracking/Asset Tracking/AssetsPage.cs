using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class AssetsPage : Form
    {
        public AssetsPage()
        {
            InitializeComponent();
            FormClosed += AssetsPage_FormClosed;

            // load employee names into the combo box
            var employees = DatabaseConnection.CreateContext().employees
                .Select(e => e)
                .ToList();
            foreach (var employee in employees)
            {
                employeePicker.Items.Add(employee.eid.ToString() +"\t"+ employee.fname.Trim()+ " " + employee.lname.Trim());
            }   

        }

        private void AssetsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addAssetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assetNameInput.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (purchaseDatePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Purchase date cannot be in the future.");
                return;
            }

            if (string.IsNullOrWhiteSpace(notesBox.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to add this asset without any notes?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                // disable add button to prevent spam
                addAssetButton.Enabled = false;


                using (var db = DatabaseConnection.CreateContext())
                {
                    var newAsset = new asset
                    {
                        name = assetNameInput.Text.Trim(),
                        purchaseDate = purchaseDatePicker.Value,
                        notes = notesBox.Text.Trim(),
                        eid = 1

                    };

                    db.assets.Add(newAsset);
                    db.SaveChanges();
                }

                MessageBox.Show("Asset added successfully!");

                // clear input fields
                assetNameInput.Clear();
                purchaseDatePicker.Value = DateTime.Now;
                notesBox.Clear();
            }
            catch (DbUpdateException dbException)
            {
                MessageBox.Show(
                    GetFullExceptionMessage(dbException),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    GetFullExceptionMessage(exception),
                    "Error Adding Asset",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // re-enable add button after operation
            finally
            {
                // ew, finally
                addAssetButton.Enabled = true;
            }
        }

        private static string GetFullExceptionMessage(Exception exception)
        {
            // get full exception message including inner exceptions
            // also sql errors as they get hidden
            var messages = new System.Collections.Generic.List<string>();

            while (exception != null)
            {
                messages.Add(exception.Message);
                exception = exception.InnerException;
            }

            return string.Join(
                Environment.NewLine + Environment.NewLine,
                messages);
        }

        private void purchaseDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void assetNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAsset_Click(object sender, EventArgs e)
        {

        }
    }
}
