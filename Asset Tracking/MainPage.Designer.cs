namespace Asset_Tracking
{
    partial class MainPage
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
            this.AssetsButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssetsButton
            // 
            this.AssetsButton.Location = new System.Drawing.Point(72, 106);
            this.AssetsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AssetsButton.Name = "AssetsButton";
            this.AssetsButton.Size = new System.Drawing.Size(110, 36);
            this.AssetsButton.TabIndex = 0;
            this.AssetsButton.Text = "Edit Assets";
            this.AssetsButton.UseVisualStyleBackColor = true;
            this.AssetsButton.Click += new System.EventHandler(this.AssetsButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(214, 106);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(110, 36);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "Edit Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.title.Location = new System.Drawing.Point(52, 25);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 37);
            this.title.TabIndex = 2;
            this.title.Text = "Asset Tracking App";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.title);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.AssetsButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.Text = "Asset Tracking App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AssetsButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Label title;
    }
}

