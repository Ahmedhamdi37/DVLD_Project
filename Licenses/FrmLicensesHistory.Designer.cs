namespace DVLD_Project
{
    partial class FrmLicensesHistory
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
            this.pbDriverLicense = new System.Windows.Forms.PictureBox();
            this.ucPersonefo1 = new DVLD_Project.UCPersonefo();
            this.ucFilters1 = new DVLD_Project.UCFilters();
            this.ucDriverLicenses1 = new DVLD_Project.UCDriverLicenses();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLicenseHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDriverLicense
            // 
            this.pbDriverLicense.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_512;
            this.pbDriverLicense.Location = new System.Drawing.Point(12, 219);
            this.pbDriverLicense.Name = "pbDriverLicense";
            this.pbDriverLicense.Size = new System.Drawing.Size(168, 178);
            this.pbDriverLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverLicense.TabIndex = 7;
            this.pbDriverLicense.TabStop = false;
            // 
            // ucPersonefo1
            // 
            this.ucPersonefo1.Location = new System.Drawing.Point(215, 171);
            this.ucPersonefo1.Name = "ucPersonefo1";
            this.ucPersonefo1.Size = new System.Drawing.Size(754, 275);
            this.ucPersonefo1.TabIndex = 1;
            // 
            // ucFilters1
            // 
            this.ucFilters1.Location = new System.Drawing.Point(215, 76);
            this.ucFilters1.Name = "ucFilters1";
            this.ucFilters1.Size = new System.Drawing.Size(754, 89);
            this.ucFilters1.TabIndex = 0;
            this.ucFilters1.evResultPersonAdded += new System.Action<int>(this.ucFilters1_evResultPersonAdded);
            // 
            // ucDriverLicenses1
            // 
            this.ucDriverLicenses1.Location = new System.Drawing.Point(12, 452);
            this.ucDriverLicenses1.Name = "ucDriverLicenses1";
            this.ucDriverLicenses1.Size = new System.Drawing.Size(974, 326);
            this.ucDriverLicenses1.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(839, 784);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.BackColor = System.Drawing.SystemColors.Control;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseHistory.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLicenseHistory.Location = new System.Drawing.Point(408, 37);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(182, 27);
            this.lblLicenseHistory.TabIndex = 10;
            this.lblLicenseHistory.Text = "License History";
            // 
            // FrmLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 832);
            this.Controls.Add(this.lblLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucDriverLicenses1);
            this.Controls.Add(this.pbDriverLicense);
            this.Controls.Add(this.ucPersonefo1);
            this.Controls.Add(this.ucFilters1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licenses History";
            this.Load += new System.EventHandler(this.FrmLicensesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCFilters ucFilters1;
        private UCPersonefo ucPersonefo1;
        private System.Windows.Forms.PictureBox pbDriverLicense;
        private UCDriverLicenses ucDriverLicenses1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLicenseHistory;
    }
}