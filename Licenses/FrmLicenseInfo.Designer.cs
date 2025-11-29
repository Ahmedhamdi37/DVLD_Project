namespace DVLD_Project
{
    partial class FrmLicenseInfo
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
            this.lblDriverLicense = new System.Windows.Forms.Label();
            this.pbLicense = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucDriverLicenseInfo1 = new DVLD_Project.UCDriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverLicense
            // 
            this.lblDriverLicense.AutoSize = true;
            this.lblDriverLicense.BackColor = System.Drawing.SystemColors.Control;
            this.lblDriverLicense.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverLicense.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDriverLicense.Location = new System.Drawing.Point(330, 158);
            this.lblDriverLicense.Name = "lblDriverLicense";
            this.lblDriverLicense.Size = new System.Drawing.Size(224, 27);
            this.lblDriverLicense.TabIndex = 7;
            this.lblDriverLicense.Text = "Driver License Info";
            // 
            // pbLicense
            // 
            this.pbLicense.Image = global::DVLD_Project.Properties.Resources.LicenseView_400;
            this.pbLicense.Location = new System.Drawing.Point(369, 12);
            this.pbLicense.Name = "pbLicense";
            this.pbLicense.Size = new System.Drawing.Size(147, 128);
            this.pbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicense.TabIndex = 8;
            this.pbLicense.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(12, 188);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(859, 366);
            this.ucDriverLicenseInfo1.TabIndex = 9;
            // 
            // FrmLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 602);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.pbLicense);
            this.Controls.Add(this.lblDriverLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.FrmLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLicense;
        private System.Windows.Forms.Label lblDriverLicense;
        private UCDriverLicenseInfo ucDriverLicenseInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}