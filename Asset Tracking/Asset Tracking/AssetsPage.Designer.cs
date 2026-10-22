namespace Asset_Tracking
{
    partial class AssetsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddAsset = new System.Windows.Forms.TabPage();
            this.employeePickerLabel = new System.Windows.Forms.Label();
            this.employeePicker = new System.Windows.Forms.ListBox();
            this.notesBoxLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseDateLabel = new System.Windows.Forms.Label();
            this.nameOfItemLabel = new System.Windows.Forms.Label();
            this.assetNameInput = new System.Windows.Forms.TextBox();
            this.addAssetButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.AddAsset.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddAsset);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // AddAsset
            // 
            this.AddAsset.Controls.Add(this.employeePickerLabel);
            this.AddAsset.Controls.Add(this.employeePicker);
            this.AddAsset.Controls.Add(this.notesBoxLabel);
            this.AddAsset.Controls.Add(this.notesBox);
            this.AddAsset.Controls.Add(this.purchaseDatePicker);
            this.AddAsset.Controls.Add(this.purchaseDateLabel);
            this.AddAsset.Controls.Add(this.nameOfItemLabel);
            this.AddAsset.Controls.Add(this.assetNameInput);
            this.AddAsset.Controls.Add(this.addAssetButton);
            this.AddAsset.Location = new System.Drawing.Point(4, 22);
            this.AddAsset.Margin = new System.Windows.Forms.Padding(2);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Padding = new System.Windows.Forms.Padding(2);
            this.AddAsset.Size = new System.Drawing.Size(554, 360);
            this.AddAsset.TabIndex = 0;
            this.AddAsset.Text = "Add Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            this.AddAsset.Click += new System.EventHandler(this.AddAsset_Click);
            // 
            // employeePickerLabel
            // 
            this.employeePickerLabel.AutoSize = true;
            this.employeePickerLabel.Location = new System.Drawing.Point(212, 33);
            this.employeePickerLabel.Name = "employeePickerLabel";
            this.employeePickerLabel.Size = new System.Drawing.Size(138, 13);
            this.employeePickerLabel.TabIndex = 11;
            this.employeePickerLabel.Text = "Employee assigned to asset";
            // 
            // employeePicker
            // 
            this.employeePicker.FormattingEnabled = true;
            this.employeePicker.Location = new System.Drawing.Point(215, 49);
            this.employeePicker.Name = "employeePicker";
            this.employeePicker.Size = new System.Drawing.Size(128, 56);
            this.employeePicker.TabIndex = 10;
            // 
            // notesBoxLabel
            // 
            this.notesBoxLabel.AutoSize = true;
            this.notesBoxLabel.Location = new System.Drawing.Point(212, 218);
            this.notesBoxLabel.Name = "notesBoxLabel";
            this.notesBoxLabel.Size = new System.Drawing.Size(64, 13);
            this.notesBoxLabel.TabIndex = 9;
            this.notesBoxLabel.Text = "Asset Notes";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(215, 233);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(128, 46);
            this.notesBox.TabIndex = 8;
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.purchaseDatePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.purchaseDatePicker.CustomFormat = "dd/MM/yyyy";
            this.purchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDatePicker.Location = new System.Drawing.Point(215, 181);
            this.purchaseDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(128, 20);
            this.purchaseDatePicker.TabIndex = 7;
            this.purchaseDatePicker.Value = new System.DateTime(2026, 10, 20, 0, 0, 0, 0);
            this.purchaseDatePicker.ValueChanged += new System.EventHandler(this.purchaseDatePicker_ValueChanged);
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Location = new System.Drawing.Point(212, 166);
            this.purchaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(107, 13);
            this.purchaseDateLabel.TabIndex = 6;
            this.purchaseDateLabel.Text = "Asset Purchase Date";
            // 
            // nameOfItemLabel
            // 
            this.nameOfItemLabel.AutoSize = true;
            this.nameOfItemLabel.Location = new System.Drawing.Point(212, 117);
            this.nameOfItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameOfItemLabel.Name = "nameOfItemLabel";
            this.nameOfItemLabel.Size = new System.Drawing.Size(76, 13);
            this.nameOfItemLabel.TabIndex = 2;
            this.nameOfItemLabel.Text = "Name of Asset";
            // 
            // assetNameInput
            // 
            this.assetNameInput.Location = new System.Drawing.Point(215, 132);
            this.assetNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.assetNameInput.Name = "assetNameInput";
            this.assetNameInput.Size = new System.Drawing.Size(128, 20);
            this.assetNameInput.TabIndex = 1;
            this.assetNameInput.TextChanged += new System.EventHandler(this.assetNameInput_TextChanged);
            // 
            // addAssetButton
            // 
            this.addAssetButton.Location = new System.Drawing.Point(251, 296);
            this.addAssetButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAssetButton.Name = "addAssetButton";
            this.addAssetButton.Size = new System.Drawing.Size(50, 23);
            this.addAssetButton.TabIndex = 0;
            this.addAssetButton.Text = "Add";
            this.addAssetButton.UseVisualStyleBackColor = true;
            this.addAssetButton.Click += new System.EventHandler(this.addAssetButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(554, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AssetsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 404);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AssetsPage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddAsset.ResumeLayout(false);
            this.AddAsset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddAsset;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label nameOfItemLabel;
        private System.Windows.Forms.TextBox assetNameInput;
        private System.Windows.Forms.Button addAssetButton;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
        private System.Windows.Forms.Label purchaseDateLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label notesBoxLabel;
        private System.Windows.Forms.ListBox employeePicker;
        private System.Windows.Forms.Label employeePickerLabel;
    }
}