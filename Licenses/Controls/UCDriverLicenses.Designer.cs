namespace DVLD_Project
{
    partial class UCDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicnese = new System.Windows.Forms.TabControl();
            this.tpLocalLicense = new System.Windows.Forms.TabPage();
            this.lblDriverLicensesNumbers = new System.Windows.Forms.Label();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.lblCountDriverLicenses = new System.Windows.Forms.Label();
            this.lblLocalLicensesHistory = new System.Windows.Forms.Label();
            this.tpLicenseInternational = new System.Windows.Forms.TabPage();
            this.lblInternationalLicensesRecordK = new System.Windows.Forms.Label();
            this.dtvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.lblInternationalLicensesRecord = new System.Windows.Forms.Label();
            this.lblInternationalLicensesHistory = new System.Windows.Forms.Label();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicnese.SuspendLayout();
            this.tpLocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.tpLicenseInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicnese);
            this.gbDriverLicenses.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDriverLicenses.Location = new System.Drawing.Point(0, 0);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(960, 326);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicnese
            // 
            this.tcDriverLicnese.Controls.Add(this.tpLocalLicense);
            this.tcDriverLicnese.Controls.Add(this.tpLicenseInternational);
            this.tcDriverLicnese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDriverLicnese.Location = new System.Drawing.Point(3, 22);
            this.tcDriverLicnese.Name = "tcDriverLicnese";
            this.tcDriverLicnese.SelectedIndex = 0;
            this.tcDriverLicnese.Size = new System.Drawing.Size(954, 301);
            this.tcDriverLicnese.TabIndex = 0;
            this.tcDriverLicnese.SelectedIndexChanged += new System.EventHandler(this.tcDriverLicnese_SelectedIndexChanged);
            // 
            // tpLocalLicense
            // 
            this.tpLocalLicense.Controls.Add(this.lblDriverLicensesNumbers);
            this.tpLocalLicense.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocalLicense.Controls.Add(this.lblCountDriverLicenses);
            this.tpLocalLicense.Controls.Add(this.lblLocalLicensesHistory);
            this.tpLocalLicense.Location = new System.Drawing.Point(4, 27);
            this.tpLocalLicense.Name = "tpLocalLicense";
            this.tpLocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicense.Size = new System.Drawing.Size(946, 270);
            this.tpLocalLicense.TabIndex = 0;
            this.tpLocalLicense.Text = "Local";
            this.tpLocalLicense.UseVisualStyleBackColor = true;
            // 
            // lblDriverLicensesNumbers
            // 
            this.lblDriverLicensesNumbers.AutoSize = true;
            this.lblDriverLicensesNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverLicensesNumbers.Location = new System.Drawing.Point(126, 200);
            this.lblDriverLicensesNumbers.Name = "lblDriverLicensesNumbers";
            this.lblDriverLicensesNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblDriverLicensesNumbers.TabIndex = 27;
            this.lblDriverLicensesNumbers.Text = "0";
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.AllowUserToOrderColumns = true;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(25, 42);
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 45;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 24;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(898, 145);
            this.dgvLocalLicensesHistory.TabIndex = 3;
            // 
            // lblCountDriverLicenses
            // 
            this.lblCountDriverLicenses.AutoSize = true;
            this.lblCountDriverLicenses.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDriverLicenses.Location = new System.Drawing.Point(31, 200);
            this.lblCountDriverLicenses.Name = "lblCountDriverLicenses";
            this.lblCountDriverLicenses.Size = new System.Drawing.Size(93, 21);
            this.lblCountDriverLicenses.TabIndex = 26;
            this.lblCountDriverLicenses.Text = "# Records:";
            // 
            // lblLocalLicensesHistory
            // 
            this.lblLocalLicensesHistory.AutoSize = true;
            this.lblLocalLicensesHistory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesHistory.Location = new System.Drawing.Point(22, 21);
            this.lblLocalLicensesHistory.Name = "lblLocalLicensesHistory";
            this.lblLocalLicensesHistory.Size = new System.Drawing.Size(181, 18);
            this.lblLocalLicensesHistory.TabIndex = 2;
            this.lblLocalLicensesHistory.Text = "Local Licenses History:";
            // 
            // tpLicenseInternational
            // 
            this.tpLicenseInternational.Controls.Add(this.lblInternationalLicensesRecordK);
            this.tpLicenseInternational.Controls.Add(this.dtvInternationalLicenses);
            this.tpLicenseInternational.Controls.Add(this.lblInternationalLicensesRecord);
            this.tpLicenseInternational.Controls.Add(this.lblInternationalLicensesHistory);
            this.tpLicenseInternational.Location = new System.Drawing.Point(4, 27);
            this.tpLicenseInternational.Name = "tpLicenseInternational";
            this.tpLicenseInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpLicenseInternational.Size = new System.Drawing.Size(946, 270);
            this.tpLicenseInternational.TabIndex = 1;
            this.tpLicenseInternational.Text = "International";
            this.tpLicenseInternational.UseVisualStyleBackColor = true;
            // 
            // lblInternationalLicensesRecordK
            // 
            this.lblInternationalLicensesRecordK.AutoSize = true;
            this.lblInternationalLicensesRecordK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecordK.Location = new System.Drawing.Point(127, 214);
            this.lblInternationalLicensesRecordK.Name = "lblInternationalLicensesRecordK";
            this.lblInternationalLicensesRecordK.Size = new System.Drawing.Size(19, 21);
            this.lblInternationalLicensesRecordK.TabIndex = 31;
            this.lblInternationalLicensesRecordK.Text = "0";
            // 
            // dtvInternationalLicenses
            // 
            this.dtvInternationalLicenses.AllowUserToAddRows = false;
            this.dtvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dtvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dtvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dtvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvInternationalLicenses.Location = new System.Drawing.Point(26, 56);
            this.dtvInternationalLicenses.Name = "dtvInternationalLicenses";
            this.dtvInternationalLicenses.ReadOnly = true;
            this.dtvInternationalLicenses.RowHeadersWidth = 45;
            this.dtvInternationalLicenses.RowTemplate.Height = 24;
            this.dtvInternationalLicenses.Size = new System.Drawing.Size(898, 145);
            this.dtvInternationalLicenses.TabIndex = 29;
            // 
            // lblInternationalLicensesRecord
            // 
            this.lblInternationalLicensesRecord.AutoSize = true;
            this.lblInternationalLicensesRecord.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecord.Location = new System.Drawing.Point(32, 214);
            this.lblInternationalLicensesRecord.Name = "lblInternationalLicensesRecord";
            this.lblInternationalLicensesRecord.Size = new System.Drawing.Size(93, 21);
            this.lblInternationalLicensesRecord.TabIndex = 30;
            this.lblInternationalLicensesRecord.Text = "# Records:";
            // 
            // lblInternationalLicensesHistory
            // 
            this.lblInternationalLicensesHistory.AutoSize = true;
            this.lblInternationalLicensesHistory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesHistory.Location = new System.Drawing.Point(23, 35);
            this.lblInternationalLicensesHistory.Name = "lblInternationalLicensesHistory";
            this.lblInternationalLicensesHistory.Size = new System.Drawing.Size(235, 18);
            this.lblInternationalLicensesHistory.TabIndex = 28;
            this.lblInternationalLicensesHistory.Text = "International Licenses History";
            // 
            // UCDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "UCDriverLicenses";
            this.Size = new System.Drawing.Size(969, 326);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicnese.ResumeLayout(false);
            this.tpLocalLicense.ResumeLayout(false);
            this.tpLocalLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.tpLicenseInternational.ResumeLayout(false);
            this.tpLicenseInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcDriverLicnese;
        private System.Windows.Forms.TabPage tpLocalLicense;
        private System.Windows.Forms.TabPage tpLicenseInternational;
        private System.Windows.Forms.Label lblLocalLicensesHistory;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.Label lblDriverLicensesNumbers;
        private System.Windows.Forms.Label lblCountDriverLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecordK;
        private System.Windows.Forms.DataGridView dtvInternationalLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecord;
        private System.Windows.Forms.Label lblInternationalLicensesHistory;
    }
}
