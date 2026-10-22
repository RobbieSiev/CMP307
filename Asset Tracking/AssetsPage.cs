using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Asset_Tracking
{
    public partial class AssetsPage : Form
    {
        private readonly dbEntities db;

        public AssetsPage(dbEntities db)
        {
            InitializeComponent();

            this.db = db;
            // DB Max lengths
            assetNameInput.MaxLength = 32;
            notesBox.MaxLength = 255;

            // load add page by default
            addAssetTab_Click(null, null);
        }

        private void addAssetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(assetNameInput.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (dateCheckbox.Checked && purchaseDatePicker.Value > DateTime.Now)
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
                addAssetButton.Enabled = false;
                // gets eid from employeePicker in not nice way
                // (gets before \t)
                int eid = int.Parse(employeePicker.SelectedItem.ToString().Split('\t')[0]);
                // checks if purchase date is used and if valid
                DateTime? purchaseDate = dateCheckbox.Checked ? purchaseDatePicker.Value : (DateTime?)null;
                var newAsset = new asset
                {
                    name = assetNameInput.Text.Trim(),
                    // set the purchase date to be null if checkbox not ticked
                    purchaseDate = purchaseDate,
                    notes = notesBox.Text.Trim(),
                    eid = eid
                };

                db.assets.Add(newAsset);
                db.SaveChanges();

                MessageBox.Show("Asset added successfully!");

                assetNameInput.Clear();
                purchaseDatePicker.Value = DateTime.Now;
                notesBox.Clear();
                addAssetButton.Enabled=false;
            }
            catch (DbUpdateException dbException)
            {
                MessageBox.Show(
                    GetFullExceptionMessage(dbException),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (DbEntityValidationException validationException)
            {
                // If database rejects values (usually because of data constraint mismatch) 
                // show error message given by db

                // e.g if the database has maxlength of 32 and e.f. has 16
                // you'll get this error and need to regenerate e.f. model

                var errorMessages = validationException.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                MessageBox.Show(
                    string.Join(Environment.NewLine, errorMessages),
                    "DB Validation Error",
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
            finally
            {
                enableAddAssetButton();
            }
        }



        private void addAssetTab_Click(object sender, EventArgs e)
        {
            employeePicker.Items.Clear();

            var employees = db.employees
                .ToList();

            foreach (var employee in employees)
            {
                employeePicker.Items.Add(
                    employee.eid + "\t" +
                    employee.fname.Trim() + " " +
                    employee.lname.Trim());
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

        private void displayAssets_Click(object sender, EventArgs e)
        {
            //displayListAssets.Items.Clear();
            assetTable.Controls.Clear();

            // Add headers to the table layout panel
            assetTable.Controls.Add(new Label
            {
                Text = "ID",
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(5)
            });
            assetTable.Controls.Add(new Label
            {
                Text = "Name",
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(5)
            });
            assetTable.Controls.Add(new Label
            {
                Text = "Employee",
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(5)
            });
            assetTable.Controls.Add(new Label
            {
                Text = "Purchase Date",
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(5)
            });
            assetTable.Controls.Add(new Label
            {
                Text = "Notes",
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold),
                Margin = new Padding(5)
            });

            var assets = db.assets
                .ToList();

            //displayListAssets.Items.Add("ID\tName\tEmployee\t\tPurchase Date\tNotes");
            foreach (var asset in assets)
            {
                // display each asset in the table layout panel
                assetTable.Controls.Add(new Label
                {
                    Text = asset.id.ToString(),
                    AutoSize = true,
                    Margin = new Padding(5)
                });
                assetTable.Controls.Add(new Label
                {
                    Text = asset.name.Trim(),
                    AutoSize = true,
                    Margin = new Padding(5)
                });
                assetTable.Controls.Add(new Label
                {
                    Text = asset.employee.fname.Trim() + " " + asset.employee.lname.Trim(),
                    AutoSize = true,
                    Margin = new Padding(5)
                });
                assetTable.Controls.Add(new Label
                {
                    Text = asset.purchaseDate?.ToString("dd/MM/yyyy") ?? "N/A",
                    AutoSize = true,
                    Margin = new Padding(5)
                });
                assetTable.Controls.Add(new Label
                {
                    Text = asset.notes.Trim(),
                    AutoSize = true,
                    Margin = new Padding(5)
                });

                // old thing 
                //displayListAssets.Items.Add(
                //    asset.id + "\t" +
                //    asset.name.Trim() + "\t" +
                //    asset.employee.fname.Trim() + " " +
                //    asset.employee.lname.Trim() + "\t" +
                //    asset.purchaseDate.ToString() +"\t"+
                //    asset.notes.Trim()
                //);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select the tab

            if (tabControl1.SelectedIndex == 0)
            {
                addAssetTab_Click(null, null);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                displayAssets_Click(null, null);
            }
        }
        private void enableAddAssetButton()
        {
            // checks to see if user has entered all required fields
            // if dateCheckbox ticked, check date is valid aswell
            addAssetButton.Enabled = !string.IsNullOrWhiteSpace(assetNameInput.Text)
                && employeePicker.SelectedIndex >= 0 && employeePicker.SelectedItem != null
                && (!dateCheckbox.Checked || (purchaseDatePicker.Value != DateTime.MinValue
                && purchaseDatePicker.Value <= DateTime.Now));
        }
        private void purchaseDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // see above
            enableAddAssetButton();
        }

        private void assetNameInput_TextChanged(object sender, EventArgs e)
        {
            // see above
            enableAddAssetButton();
        }

        private void employeePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // see above
            enableAddAssetButton();
        }

        private void dateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckbox.Checked)
            {
                purchaseDatePicker.Enabled = true;
            }
            else
            {
                purchaseDatePicker.Enabled = false;
            }
        }
    }
}
