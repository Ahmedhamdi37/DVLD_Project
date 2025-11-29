namespace DVLD_Project
{
    partial class FrmNewInternationalLicenseApplication
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
            this.lblInternationalLicenseApplication = new System.Windows.Forms.Label();
            this.LLblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.LLblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ucInternationalApplicationInfo1 = new DVLD_Project.UCInternationalApplicationInfo();
            this.ucDriverLicenseInfo1 = new DVLD_Project.UCDriverLicenseInfo();
            this.ucLicenseFilter1 = new DVLD_Project.UCLicenseFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInternationalLicenseApplication
            // 
            this.lblInternationalLicenseApplication.AutoSize = true;
            this.lblInternationalLicenseApplication.BackColor = System.Drawing.SystemColors.Control;
            this.lblInternationalLicenseApplication.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicenseApplication.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInternationalLicenseApplication.Location = new System.Drawing.Point(229, 37);
            this.lblInternationalLicenseApplication.Name = "lblInternationalLicenseApplication";
            this.lblInternationalLicenseApplication.Size = new System.Drawing.Size(408, 29);
            this.lblInternationalLicenseApplication.TabIndex = 1;
            this.lblInternationalLicenseApplication.Text = "International License Application";
            // 
            // LLblShowLicenseHistory
            // 
            this.LLblShowLicenseHistory.AutoSize = true;
            this.LLblShowLicenseHistory.Enabled = false;
            this.LLblShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLblShowLicenseHistory.Location = new System.Drawing.Point(23, 728);
            this.LLblShowLicenseHistory.Name = "LLblShowLicenseHistory";
            this.LLblShowLicenseHistory.Size = new System.Drawing.Size(167, 21);
            this.LLblShowLicenseHistory.TabIndex = 61;
            this.LLblShowLicenseHistory.TabStop = true;
            this.LLblShowLicenseHistory.Text = "Show License History";
            this.LLblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // LLblShowLicenseInfo
            // 
            this.LLblShowLicenseInfo.AutoSize = true;
            this.LLblShowLicenseInfo.Enabled = false;
            this.LLblShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLblShowLicenseInfo.Location = new System.Drawing.Point(206, 728);
            this.LLblShowLicenseInfo.Name = "LLblShowLicenseInfo";
            this.LLblShowLicenseInfo.Size = new System.Drawing.Size(144, 21);
            this.LLblShowLicenseInfo.TabIndex = 62;
            this.LLblShowLicenseInfo.TabStop = true;
            this.LLblShowLicenseInfo.Text = "Show License Info";
            this.LLblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblShowLicenseInfo_LinkClicked);
            // 
            // ucInternationalApplicationInfo1
            // 
            this.ucInternationalApplicationInfo1.Location = new System.Drawing.Point(29, 527);
            this.ucInternationalApplicationInfo1.Name = "ucInternationalApplicationInfo1";
            this.ucInternationalApplicationInfo1.Size = new System.Drawing.Size(812, 198);
            this.ucInternationalApplicationInfo1.TabIndex = 4;
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(27, 180);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(812, 341);
            this.ucDriverLicenseInfo1.TabIndex = 3;
            this.ucDriverLicenseInfo1.evPersonNationalNo += new System.Action<string>(this.ucDriverLicenseInfo1_evPersonNationalNo);
            // 
            // ucLicenseFilter1
            // 
            this.ucLicenseFilter1.Location = new System.Drawing.Point(27, 80);
            this.ucLicenseFilter1.Name = "ucLicenseFilter1";
            this.ucLicenseFilter1.Size = new System.Drawing.Size(594, 94);
            this.ucLicenseFilter1.TabIndex = 2;
            this.ucLicenseFilter1.evLicenseID += new System.Action<int, int, bool>(this.ucLicenseFilter1_evLicenseID);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(573, 731);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(709, 731);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(130, 36);
            this.btnIssue.TabIndex = 11;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // FrmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 777);
            this.Controls.Add(this.LLblShowLicenseInfo);
            this.Controls.Add(this.LLblShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ucInternationalApplicationInfo1);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.ucLicenseFilter1);
            this.Controls.Add(this.lblInternationalLicenseApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.FrmNewInternationalLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInternationalLicenseApplication;
        private UCLicenseFilter ucLicenseFilter1;
        private UCDriverLicenseInfo ucDriverLicenseInfo1;
        private UCInternationalApplicationInfo ucInternationalApplicationInfo1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel LLblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel LLblShowLicenseInfo;
    }
}