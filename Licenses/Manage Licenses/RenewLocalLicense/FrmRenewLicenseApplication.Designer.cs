namespace DVLD_Project
{
    partial class FrmRenewLicenseApplication
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
            this.lblRenewLocalLicenseApplication = new System.Windows.Forms.Label();
            this.LLblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LLblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.ucApplicationNewLicenseInfo1 = new DVLD_Project.UCApplicationNewLicenseInfo();
            this.ucDriverLicenseInfo1 = new DVLD_Project.UCDriverLicenseInfo();
            this.ucLicenseFilter1 = new DVLD_Project.UCLicenseFilter();
            this.SuspendLayout();
            // 
            // lblRenewLocalLicenseApplication
            // 
            this.lblRenewLocalLicenseApplication.AutoSize = true;
            this.lblRenewLocalLicenseApplication.BackColor = System.Drawing.SystemColors.Control;
            this.lblRenewLocalLicenseApplication.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLocalLicenseApplication.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRenewLocalLicenseApplication.Location = new System.Drawing.Point(309, 36);
            this.lblRenewLocalLicenseApplication.Name = "lblRenewLocalLicenseApplication";
            this.lblRenewLocalLicenseApplication.Size = new System.Drawing.Size(309, 27);
            this.lblRenewLocalLicenseApplication.TabIndex = 35;
            this.lblRenewLocalLicenseApplication.Text = "Renew License Application";
            // 
            // LLblShowNewLicenseInfo
            // 
            this.LLblShowNewLicenseInfo.AutoSize = true;
            this.LLblShowNewLicenseInfo.Enabled = false;
            this.LLblShowNewLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLblShowNewLicenseInfo.Location = new System.Drawing.Point(204, 858);
            this.LLblShowNewLicenseInfo.Name = "LLblShowNewLicenseInfo";
            this.LLblShowNewLicenseInfo.Size = new System.Drawing.Size(182, 21);
            this.LLblShowNewLicenseInfo.TabIndex = 66;
            this.LLblShowNewLicenseInfo.TabStop = true;
            this.LLblShowNewLicenseInfo.Text = "Show New License Info";
            this.LLblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblShowNewLicenseInfo_LinkClicked);
            // 
            // LLblShowLicenseHistory
            // 
            this.LLblShowLicenseHistory.AutoSize = true;
            this.LLblShowLicenseHistory.Enabled = false;
            this.LLblShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLblShowLicenseHistory.Location = new System.Drawing.Point(21, 858);
            this.LLblShowLicenseHistory.Name = "LLblShowLicenseHistory";
            this.LLblShowLicenseHistory.Size = new System.Drawing.Size(167, 21);
            this.LLblShowLicenseHistory.TabIndex = 65;
            this.LLblShowLicenseHistory.TabStop = true;
            this.LLblShowLicenseHistory.Text = "Show License History";
            this.LLblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLblShowLicenseHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(643, 849);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 36);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_323;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(779, 849);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(130, 36);
            this.btnIssue.TabIndex = 63;
            this.btnIssue.Text = "Renew";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ucApplicationNewLicenseInfo1
            // 
            this.ucApplicationNewLicenseInfo1.Location = new System.Drawing.Point(25, 526);
            this.ucApplicationNewLicenseInfo1.Name = "ucApplicationNewLicenseInfo1";
            this.ucApplicationNewLicenseInfo1.Size = new System.Drawing.Size(884, 317);
            this.ucApplicationNewLicenseInfo1.TabIndex = 36;
            this.ucApplicationNewLicenseInfo1.evLocked += new System.Action<bool>(this.ucApplicationNewLicenseInfo1_evLocked);
            // 
            // ucDriverLicenseInfo1
            // 
            this.ucDriverLicenseInfo1.Location = new System.Drawing.Point(25, 177);
            this.ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            this.ucDriverLicenseInfo1.Size = new System.Drawing.Size(884, 343);
            this.ucDriverLicenseInfo1.TabIndex = 1;
            // 
            // ucLicenseFilter1
            // 
            this.ucLicenseFilter1.Location = new System.Drawing.Point(25, 77);
            this.ucLicenseFilter1.Name = "ucLicenseFilter1";
            this.ucLicenseFilter1.Size = new System.Drawing.Size(594, 94);
            this.ucLicenseFilter1.TabIndex = 0;
            this.ucLicenseFilter1.evLicenseID += new System.Action<int, int, bool>(this.ucLicenseFilter1_evLicenseID);
            // 
            // FrmRenewLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 898);
            this.Controls.Add(this.LLblShowNewLicenseInfo);
            this.Controls.Add(this.LLblShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ucApplicationNewLicenseInfo1);
            this.Controls.Add(this.lblRenewLocalLicenseApplication);
            this.Controls.Add(this.ucDriverLicenseInfo1);
            this.Controls.Add(this.ucLicenseFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRenewLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew License Application";
            this.Load += new System.EventHandler(this.FrmRenewLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCLicenseFilter ucLicenseFilter1;
        private UCDriverLicenseInfo ucDriverLicenseInfo1;
        private System.Windows.Forms.Label lblRenewLocalLicenseApplication;
        private UCApplicationNewLicenseInfo ucApplicationNewLicenseInfo1;
        private System.Windows.Forms.LinkLabel LLblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel LLblShowLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}