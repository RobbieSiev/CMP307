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
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // AddAsset
            // 
            this.AddAsset.Controls.Add(this.notesBox);
            this.AddAsset.Controls.Add(this.purchaseDatePicker);
            this.AddAsset.Controls.Add(this.purchaseDateLabel);
            this.AddAsset.Controls.Add(this.nameOfItemLabel);
            this.AddAsset.Controls.Add(this.assetNameInput);
            this.AddAsset.Controls.Add(this.addAssetButton);
            this.AddAsset.Location = new System.Drawing.Point(8, 39);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Padding = new System.Windows.Forms.Padding(3);
            this.AddAsset.Size = new System.Drawing.Size(760, 378);
            this.AddAsset.TabIndex = 0;
            this.AddAsset.Text = "Add Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(219, 237);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(252, 85);
            this.notesBox.TabIndex = 8;
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.CustomFormat = "dd/MM/yyyy";
            this.purchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseDatePicker.Location = new System.Drawing.Point(229, 150);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(242, 31);
            this.purchaseDatePicker.TabIndex = 7;
            this.purchaseDatePicker.Value = new System.DateTime(2026, 10, 20, 0, 0, 0, 0);
            // 
            // purchaseDateLabel
            // 
            this.purchaseDateLabel.AutoSize = true;
            this.purchaseDateLabel.Location = new System.Drawing.Point(226, 109);
            this.purchaseDateLabel.Name = "purchaseDateLabel";
            this.purchaseDateLabel.Size = new System.Drawing.Size(148, 25);
            this.purchaseDateLabel.TabIndex = 6;
            this.purchaseDateLabel.Text = "PurchaseDate";
            // 
            // nameOfItemLabel
            // 
            this.nameOfItemLabel.AutoSize = true;
            this.nameOfItemLabel.Location = new System.Drawing.Point(229, 37);
            this.nameOfItemLabel.Name = "nameOfItemLabel";
            this.nameOfItemLabel.Size = new System.Drawing.Size(138, 25);
            this.nameOfItemLabel.TabIndex = 2;
            this.nameOfItemLabel.Text = "Name of item";
            // 
            // assetNameInput
            // 
            this.assetNameInput.Location = new System.Drawing.Point(229, 65);
            this.assetNameInput.Name = "assetNameInput";
            this.assetNameInput.Size = new System.Drawing.Size(242, 31);
            this.assetNameInput.TabIndex = 1;
            // 
            // addAssetButton
            // 
            this.addAssetButton.Location = new System.Drawing.Point(275, 328);
            this.addAssetButton.Name = "addAssetButton";
            this.addAssetButton.Size = new System.Drawing.Size(99, 44);
            this.addAssetButton.TabIndex = 0;
            this.addAssetButton.Text = "Add";
            this.addAssetButton.UseVisualStyleBackColor = true;
            this.addAssetButton.Click += new System.EventHandler(this.addAssetButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AssetsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
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
    }
}