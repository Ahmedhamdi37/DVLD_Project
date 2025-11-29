namespace DVLD_Project
{
    partial class frmLocalDrivinglicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.dgvLocalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicatiionsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersoneLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLocalDrivingLicenseApplications = new System.Windows.Forms.Label();
            this.btnLocalLicenseApplicatonsClose = new System.Windows.Forms.Button();
            this.btnAddLocalLicenseApplication = new System.Windows.Forms.Button();
            this.pbLocalLicenseApplications = new System.Windows.Forms.PictureBox();
            this.pbLocalApplications = new System.Windows.Forms.PictureBox();
            this.cbLocalLicenseFilterBy = new System.Windows.Forms.ComboBox();
            this.lblLocalLicenseFilterBy = new System.Windows.Forms.Label();
            this.txtFilterLocalLicense = new System.Windows.Forms.TextBox();
            this.lblLocalLicenseApplicationsNumbers = new System.Windows.Forms.Label();
            this.lblCountLocalLicenseApplications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocalLicenseApplications
            // 
            this.dgvLocalLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApplications.AllowUserToOrderColumns = true;
            this.dgvLocalLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicenseApplications.Location = new System.Drawing.Point(9, 303);
            this.dgvLocalLicenseApplications.Name = "dgvLocalLicenseApplications";
            this.dgvLocalLicenseApplications.ReadOnly = true;
            this.dgvLocalLicenseApplications.RowHeadersWidth = 45;
            this.dgvLocalLicenseApplications.RowTemplate.Height = 24;
            this.dgvLocalLicenseApplications.Size = new System.Drawing.Size(1070, 227);
            this.dgvLocalLicenseApplications.TabIndex = 9;
            this.dgvLocalLicenseApplications.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalLicenseApplications_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicatiionsDetailsToolStripMenuItem,
            this.editApplicationsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.schduleTestsToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.sToolStripMenuItem,
            this.showPersoneLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(260, 330);
            // 
            // showApplicatiionsDetailsToolStripMenuItem
            // 
            this.showApplicatiionsDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_323;
            this.showApplicatiionsDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicatiionsDetailsToolStripMenuItem.Name = "showApplicatiionsDetailsToolStripMenuItem";
            this.showApplicatiionsDetailsToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.showApplicatiionsDetailsToolStripMenuItem.Text = "Show Applicatiion Details";
            this.showApplicatiionsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicatiionsDetailsToolStripMenuItem_Click);
            // 
            // editApplicationsToolStripMenuItem
            // 
            this.editApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_321;
            this.editApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationsToolStripMenuItem.Name = "editApplicationsToolStripMenuItem";
            this.editApplicationsToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.editApplicationsToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Delete_322;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schduleTestsToolStripMenuItem
            // 
            this.schduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schduleVisionTestToolStripMenuItem,
            this.scheduleWrittenToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.schduleTestsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Schedule_Test_32;
            this.schduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schduleTestsToolStripMenuItem.Name = "schduleTestsToolStripMenuItem";
            this.schduleTestsToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.schduleTestsToolStripMenuItem.Text = "Schdule Tests";
            // 
            // schduleVisionTestToolStripMenuItem
            // 
            this.schduleVisionTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.schduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schduleVisionTestToolStripMenuItem.Name = "schduleVisionTestToolStripMenuItem";
            this.schduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.schduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.schduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenToolStripMenuItem
            // 
            this.scheduleWrittenToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Written_Test_32;
            this.scheduleWrittenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenToolStripMenuItem.Name = "scheduleWrittenToolStripMenuItem";
            this.scheduleWrittenToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.scheduleWrittenToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(204, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License(First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.License_View_321;
            this.sToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.sToolStripMenuItem.Text = "show License";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // showPersoneLicenseHistoryToolStripMenuItem
            // 
            this.showPersoneLicenseHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_321;
            this.showPersoneLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersoneLicenseHistoryToolStripMenuItem.Name = "showPersoneLicenseHistoryToolStripMenuItem";
            this.showPersoneLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.showPersoneLicenseHistoryToolStripMenuItem.Text = "Show Persone License History";
            this.showPersoneLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersoneLicenseHistoryToolStripMenuItem_Click);
            // 
            // lblLocalDrivingLicenseApplications
            // 
            this.lblLocalDrivingLicenseApplications.AutoSize = true;
            this.lblLocalDrivingLicenseApplications.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocalDrivingLicenseApplications.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicenseApplications.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLocalDrivingLicenseApplications.Location = new System.Drawing.Point(327, 189);
            this.lblLocalDrivingLicenseApplications.Name = "lblLocalDrivingLicenseApplications";
            this.lblLocalDrivingLicenseApplications.Size = new System.Drawing.Size(391, 27);
            this.lblLocalDrivingLicenseApplications.TabIndex = 8;
            this.lblLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            // 
            // btnLocalLicenseApplicatonsClose
            // 
            this.btnLocalLicenseApplicatonsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalLicenseApplicatonsClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalLicenseApplicatonsClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnLocalLicenseApplicatonsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicenseApplicatonsClose.Location = new System.Drawing.Point(963, 536);
            this.btnLocalLicenseApplicatonsClose.Name = "btnLocalLicenseApplicatonsClose";
            this.btnLocalLicenseApplicatonsClose.Size = new System.Drawing.Size(116, 36);
            this.btnLocalLicenseApplicatonsClose.TabIndex = 13;
            this.btnLocalLicenseApplicatonsClose.Text = "Close";
            this.btnLocalLicenseApplicatonsClose.UseVisualStyleBackColor = true;
            this.btnLocalLicenseApplicatonsClose.Click += new System.EventHandler(this.btnLocalLicenseApplicatonsClose_Click);
            // 
            // btnAddLocalLicenseApplication
            // 
            this.btnAddLocalLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocalLicenseApplication.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnAddLocalLicenseApplication.Location = new System.Drawing.Point(1000, 231);
            this.btnAddLocalLicenseApplication.Name = "btnAddLocalLicenseApplication";
            this.btnAddLocalLicenseApplication.Size = new System.Drawing.Size(78, 66);
            this.btnAddLocalLicenseApplication.TabIndex = 12;
            this.btnAddLocalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddLocalLicenseApplication.Click += new System.EventHandler(this.btnAddLocalLicenseApplication_Click);
            // 
            // pbLocalLicenseApplications
            // 
            this.pbLocalLicenseApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLocalLicenseApplications.Image = global::DVLD_Project.Properties.Resources.Local_321;
            this.pbLocalLicenseApplications.Location = new System.Drawing.Point(568, 76);
            this.pbLocalLicenseApplications.Name = "pbLocalLicenseApplications";
            this.pbLocalLicenseApplications.Size = new System.Drawing.Size(56, 46);
            this.pbLocalLicenseApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalLicenseApplications.TabIndex = 15;
            this.pbLocalLicenseApplications.TabStop = false;
            // 
            // pbLocalApplications
            // 
            this.pbLocalApplications.Image = global::DVLD_Project.Properties.Resources.Applications;
            this.pbLocalApplications.Location = new System.Drawing.Point(412, 28);
            this.pbLocalApplications.Name = "pbLocalApplications";
            this.pbLocalApplications.Size = new System.Drawing.Size(212, 143);
            this.pbLocalApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalApplications.TabIndex = 14;
            this.pbLocalApplications.TabStop = false;
            // 
            // cbLocalLicenseFilterBy
            // 
            this.cbLocalLicenseFilterBy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLocalLicenseFilterBy.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalLicenseFilterBy.FormattingEnabled = true;
            this.cbLocalLicenseFilterBy.Location = new System.Drawing.Point(98, 265);
            this.cbLocalLicenseFilterBy.Name = "cbLocalLicenseFilterBy";
            this.cbLocalLicenseFilterBy.Size = new System.Drawing.Size(177, 25);
            this.cbLocalLicenseFilterBy.TabIndex = 29;
            this.cbLocalLicenseFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbPeopleFilterBy_SelectedIndexChanged);
            // 
            // lblLocalLicenseFilterBy
            // 
            this.lblLocalLicenseFilterBy.AutoSize = true;
            this.lblLocalLicenseFilterBy.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseFilterBy.Location = new System.Drawing.Point(12, 267);
            this.lblLocalLicenseFilterBy.Name = "lblLocalLicenseFilterBy";
            this.lblLocalLicenseFilterBy.Size = new System.Drawing.Size(82, 21);
            this.lblLocalLicenseFilterBy.TabIndex = 31;
            this.lblLocalLicenseFilterBy.Text = "Filter By :";
            // 
            // txtFilterLocalLicense
            // 
            this.txtFilterLocalLicense.Enabled = false;
            this.txtFilterLocalLicense.Location = new System.Drawing.Point(279, 266);
            this.txtFilterLocalLicense.Multiline = true;
            this.txtFilterLocalLicense.Name = "txtFilterLocalLicense";
            this.txtFilterLocalLicense.Size = new System.Drawing.Size(177, 22);
            this.txtFilterLocalLicense.TabIndex = 30;
            this.txtFilterLocalLicense.TextChanged += new System.EventHandler(this.txtFilterPeople_TextChanged);
            // 
            // lblLocalLicenseApplicationsNumbers
            // 
            this.lblLocalLicenseApplicationsNumbers.AutoSize = true;
            this.lblLocalLicenseApplicationsNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseApplicationsNumbers.Location = new System.Drawing.Point(100, 544);
            this.lblLocalLicenseApplicationsNumbers.Name = "lblLocalLicenseApplicationsNumbers";
            this.lblLocalLicenseApplicationsNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblLocalLicenseApplicationsNumbers.TabIndex = 33;
            this.lblLocalLicenseApplicationsNumbers.Text = "0";
            // 
            // lblCountLocalLicenseApplications
            // 
            this.lblCountLocalLicenseApplications.AutoSize = true;
            this.lblCountLocalLicenseApplications.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLocalLicenseApplications.Location = new System.Drawing.Point(5, 544);
            this.lblCountLocalLicenseApplications.Name = "lblCountLocalLicenseApplications";
            this.lblCountLocalLicenseApplications.Size = new System.Drawing.Size(93, 21);
            this.lblCountLocalLicenseApplications.TabIndex = 32;
            this.lblCountLocalLicenseApplications.Text = "# Records:";
            // 
            // frmLocalDrivinglicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 581);
            this.Controls.Add(this.lblLocalLicenseApplicationsNumbers);
            this.Controls.Add(this.lblCountLocalLicenseApplications);
            this.Controls.Add(this.cbLocalLicenseFilterBy);
            this.Controls.Add(this.lblLocalLicenseFilterBy);
            this.Controls.Add(this.txtFilterLocalLicense);
            this.Controls.Add(this.btnLocalLicenseApplicatonsClose);
            this.Controls.Add(this.btnAddLocalLicenseApplication);
            this.Controls.Add(this.dgvLocalLicenseApplications);
            this.Controls.Add(this.lblLocalDrivingLicenseApplications);
            this.Controls.Add(this.pbLocalLicenseApplications);
            this.Controls.Add(this.pbLocalApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDrivinglicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving license Applications";
            this.Load += new System.EventHandler(this.frmLocalDrivinglicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLocalApplications;
        private System.Windows.Forms.Button btnLocalLicenseApplicatonsClose;
        private System.Windows.Forms.Button btnAddLocalLicenseApplication;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApplications;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplications;
        private System.Windows.Forms.PictureBox pbLocalLicenseApplications;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicatiionsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersoneLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbLocalLicenseFilterBy;
        private System.Windows.Forms.Label lblLocalLicenseFilterBy;
        private System.Windows.Forms.TextBox txtFilterLocalLicense;
        private System.Windows.Forms.Label lblLocalLicenseApplicationsNumbers;
        private System.Windows.Forms.Label lblCountLocalLicenseApplications;
    }
}