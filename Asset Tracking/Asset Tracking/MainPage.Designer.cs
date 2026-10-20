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
            this.SuspendLayout();
            // 
            // AssetsButton
            // 
            this.AssetsButton.Location = new System.Drawing.Point(89, 203);
            this.AssetsButton.Name = "AssetsButton";
            this.AssetsButton.Size = new System.Drawing.Size(220, 70);
            this.AssetsButton.TabIndex = 0;
            this.AssetsButton.Text = "Edit Assets";
            this.AssetsButton.UseVisualStyleBackColor = true;
            this.AssetsButton.Click += new System.EventHandler(this.AssetsButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.Location = new System.Drawing.Point(429, 203);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(220, 70);
            this.employeeButton.TabIndex = 1;
            this.employeeButton.Text = "Edit Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.AssetsButton);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AssetsButton;
        private System.Windows.Forms.Button employeeButton;
    }
}

