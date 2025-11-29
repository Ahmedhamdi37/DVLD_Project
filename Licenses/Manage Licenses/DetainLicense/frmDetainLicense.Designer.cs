namespace DVLD_Project
{
    partial class frmDetainLicense
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
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.txtFineFeesResult = new System.Windows.Forms.TextBox();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainIDResult = new System.Windows.Forms.Label();
            this.lblDeainDateResult = new System.Windows.Forms.Label();
            this.lblDetainLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblCreatedByResult = new System.Windows.Forms.Label();
            this.lblDetainLicenseIDResult = new System.Windows.Forms.Label();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblDetainLicenseTitle = new System.Windows.Forms.Label();
            this.btnLicenseDetain = new System.Windows.Forms.Button();
            this.btnLicenseClose = new System.Windows.Forms.Button();
            this.pbLicense = new System.Windows.Forms.PictureBox();
            this.ucDriverLicenseInfo1 = new DVLD_Project.UCDriverLicenseInfo();
            this.gbLicense.SuspendLayout();
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLicense
            // 
            this.gbLicense.Controls.Add(this.pbLicense);
            this.gbLicense.Controls.Add(this.txtLicenseID);
            this.gbLicense.Controls.Add(this.lblLicenseID);
            this.gbLicense.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLicense.Location = new System.Drawing.Point(12, 97);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(593, 101);
            this.gbLicense.TabIndex = 8;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "Filter";
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenseID.Location = new System.Drawing.Point(129, 43);
            this.txtLicenseID.Multiline = true;
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(301, 23);
            this.txtLicenseID.TabIndex = 10;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(19, 43);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(104, 23);
            this.lblLicenseID.TabIndex = 8;
            this.lblLicenseID.Text = "License ID:";
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.lblDetainDate);
            this.gbDetainInfo.Controls.Add(this.lblFineFees);
            this.gbDetainInfo.Controls.Add(this.lblDetainLicenseIDResult);
            this.gbDetainInfo.Controls.Add(this.lblCreatedByResult);
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Controls.Add(this.lblDetainLicenseID);
            this.gbDetainInfo.Controls.Add(this.lblDeainDateResult);
            this.gbDetainInfo.Controls.Add(this.lblDetainIDResult);
            this.gbDetainInfo.Controls.Add(this.txtFineFeesResult);
            this.gbDetainInfo.Controls.Add(this.lblDetainID);
            this.gbDetainInfo.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetainInfo.Location = new System.Drawing.Point(12, 602);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(941, 189);
            this.gbDetainInfo.TabIndex = 9;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // txtFineFeesResult
            // 
            this.txtFineFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFineFeesResult.Location = new System.Drawing.Point(206, 108);
            this.txtFineFeesResult.Multiline = true;
            this.txtFineFeesResult.Name = "txtFineFeesResult";
            this.txtFineFeesResult.Size = new System.Drawing.Size(117, 27);
            this.txtFineFeesResult.TabIndex = 15;
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(23, 40);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(85, 22);
            this.lblDetainID.TabIndex = 14;
            this.lblDetainID.Text = "DetainID:";
            // 
            // lblDetainIDResult
            // 
            this.lblDetainIDResult.AutoSize = true;
            this.lblDetainIDResult.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDResult.Location = new System.Drawing.Point(206, 38);
            this.lblDetainIDResult.Name = "lblDetainIDResult";
            this.lblDetainIDResult.Size = new System.Drawing.Size(50, 25);
            this.lblDetainIDResult.TabIndex = 59;
            this.lblDetainIDResult.Text = "[???]";
            // 
            // lblDeainDateResult
            // 
            this.lblDeainDateResult.AutoSize = true;
            this.lblDeainDateResult.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeainDateResult.Location = new System.Drawing.Point(206, 73);
            this.lblDeainDateResult.Name = "lblDeainDateResult";
            this.lblDeainDateResult.Size = new System.Drawing.Size(119, 25);
            this.lblDeainDateResult.TabIndex = 60;
            this.lblDeainDateResult.Text = "22/Sep/2020";
            // 
            // lblDetainLicenseID
            // 
            this.lblDetainLicenseID.AutoSize = true;
            this.lblDetainLicenseID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainLicenseID.Location = new System.Drawing.Point(427, 38);
            this.lblDetainLicenseID.Name = "lblDetainLicenseID";
            this.lblDetainLicenseID.Size = new System.Drawing.Size(104, 23);
            this.lblDetainLicenseID.TabIndex = 61;
            this.lblDetainLicenseID.Text = "License ID:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(429, 76);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(102, 23);
            this.lblCreatedBy.TabIndex = 62;
            this.lblCreatedBy.Text = "CreatedBy:";
            // 
            // lblCreatedByResult
            // 
            this.lblCreatedByResult.AutoSize = true;
            this.lblCreatedByResult.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByResult.Location = new System.Drawing.Point(622, 76);
            this.lblCreatedByResult.Name = "lblCreatedByResult";
            this.lblCreatedByResult.Size = new System.Drawing.Size(79, 23);
            this.lblCreatedByResult.TabIndex = 63;
            this.lblCreatedByResult.Text = "Saqer77";
            // 
            // lblDetainLicenseIDResult
            // 
            this.lblDetainLicenseIDResult.AutoSize = true;
            this.lblDetainLicenseIDResult.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainLicenseIDResult.Location = new System.Drawing.Point(622, 38);
            this.lblDetainLicenseIDResult.Name = "lblDetainLicenseIDResult";
            this.lblDetainLicenseIDResult.Size = new System.Drawing.Size(50, 25);
            this.lblDetainLicenseIDResult.TabIndex = 64;
            this.lblDetainLicenseIDResult.Text = "[???]";
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseHistory.Location = new System.Drawing.Point(12, 805);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(177, 22);
            this.llShowLicenseHistory.TabIndex = 58;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(23, 112);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(89, 22);
            this.lblFineFees.TabIndex = 65;
            this.lblFineFees.Text = "Fine Fees:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(23, 76);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(108, 22);
            this.lblDetainDate.TabIndex = 66;
            this.lblDetainDate.Text = "Detain Date:";
            this.lblDetainDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowLicenseInfo.Location = new System.Drawing.Point(214, 805);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(155, 22);
            this.llShowLicenseInfo.TabIndex = 59;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            // 
            // lblDetainLicenseTitle
            // 
            this.lblDetainLicenseTitle.AutoSize = true;
            this.lblDetainLicenseTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblDetainLicenseTitle.Font = new System.Drawing.Font("Tahoma", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainLicenseTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDetainLicenseTitle.Location = new System.Drawing.Point(399, 36);
            this.lblDetainLicenseTitle.Name = "lblDetainLicenseTitle";
            this.lblDetainLicenseTitle.Size = new System.Drawing.Size(229, 35);
            this.lblDetainLicenseTitle.TabIndex = 60;
            this.lblDetainLicenseTitle.Text = "Detain License";
            // 
            // btnLicenseDetain
            // 
            this.btnLicenseDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicenseDetain.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicenseDetain.Image = global::DVLD_Project.Properties.Resources.International_323;
            this.btnLicenseDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicenseDetain.Location = new System.Drawing.Point(815, 797);
            this.btnLicenseDetain.Name = "btnLicenseDetain";
            this.btnLicenseDetain.Size = new System.Drawing.Size(138, 39);
            this.btnLicenseDetain.TabIndex = 56;
            this.btnLicenseDetain.Text = "Detain";
            this.btnLicenseDetain.UseVisualStyleBackColor = true;
            // 
            // btnLicenseClose
            // 
            this.btnLicenseClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicenseClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicenseClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnLicenseClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicenseClose.Location = new System.Drawing.Point(670, 797);
            this.btnLicenseClose.Name = "btnLicenseClose";
            this.btnLicenseClose.Size = new System.Drawing.Size(138, 39);
            this.btnLicenseClose.TabIndex = 55;
            this.btnLicenseClose.Text = "Close";
            this.btnLicenseClose.UseVisualStyleBackColor = true;
            // 
            // pbLicense
            // 
            this.pbLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.pbLicense.Location = new System.Drawing.Point(494, 30);
            this.pbLicense.Name = "pbLicense";
            this.pbLicense.Size = new System.Drawing.Size(73, 53);
            this.pbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLicense.TabIndex = 11;
            this.pbLicense.TabStop = false;
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(12, 204);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(941, 392);
            this.ucDriverLicenseInfo1.TabIndex = 0;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 849);
            this.Controls.Add(this.lblDetainLicenseTitle);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.btnLicenseDetain);
            this.Controls.Add(this.btnLicenseClose);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.gbLicense);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.gbLicense.ResumeLayout(false);
            this.gbLicense.PerformLayout();
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCDriverLicenseInfo ucDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox gbLicense;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.TextBox txtFineFeesResult;
        private System.Windows.Forms.Label lblDeainDateResult;
        private System.Windows.Forms.Label lblDetainIDResult;
        private System.Windows.Forms.Label lblDetainLicenseIDResult;
        private System.Windows.Forms.Label lblCreatedByResult;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainLicenseID;
        private System.Windows.Forms.Button btnLicenseDetain;
        private System.Windows.Forms.Button btnLicenseClose;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.Label lblDetainLicenseTitle;
        private System.Windows.Forms.PictureBox pbLicense;
    }
}