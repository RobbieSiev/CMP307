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
        }

        private static string GetFullExceptionMessage(Exception exception)
        {
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
    }
}
