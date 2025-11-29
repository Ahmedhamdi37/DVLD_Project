namespace DVLD_Project
{
    partial class frmNewLocalLicense
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
            this.lblNewLocalDrivingLicenseApplicationTitle = new System.Windows.Forms.Label();
            this.tcAddNewLocalLicenseApplication = new System.Windows.Forms.TabControl();
            this.tbLicensePersonalInfo = new System.Windows.Forms.TabPage();
            this.ucPersonFilterAddNewLocalLicenseApplication = new DVLD_Project.UCFilters();
            this.ucPersonInfoLocalLicenseApplicationWithFilter1 = new DVLD_Project.UCPersonefo();
            this.btnNewLocalLicenseApplication = new System.Windows.Forms.Button();
            this.tbLicenseApplicationInfo = new System.Windows.Forms.TabPage();
            this.pbLocalLicenseCreatedBy = new System.Windows.Forms.PictureBox();
            this.pbLocalLicenseApplicationFees = new System.Windows.Forms.PictureBox();
            this.pbLocalLicenseClass = new System.Windows.Forms.PictureBox();
            this.pbNewLocalLicenseApplicationDate = new System.Windows.Forms.PictureBox();
            this.pbDLApplicationID = new System.Windows.Forms.PictureBox();
            this.cbLocalLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblDLApplicationIDK = new System.Windows.Forms.Label();
            this.lblLocalLicenseCreatedByK = new System.Windows.Forms.Label();
            this.lblNewLocalLicenseApplicationDateK = new System.Windows.Forms.Label();
            this.lblLocalLicenseApplicationFeesK = new System.Windows.Forms.Label();
            this.lblLocalLicenseCreatedBy = new System.Windows.Forms.Label();
            this.lblNewLocalLicenseApplicationDate = new System.Windows.Forms.Label();
            this.lblLocalLicenseClass = new System.Windows.Forms.Label();
            this.lblLocalLicenseApplicationFees = new System.Windows.Forms.Label();
            this.lblDLApplicationID = new System.Windows.Forms.Label();
            this.btnNewLocalLicenseApplicationSave = new System.Windows.Forms.Button();
            this.btnNewLocalLicenseApplicationClose = new System.Windows.Forms.Button();
            this.tcAddNewLocalLicenseApplication.SuspendLayout();
            this.tbLicensePersonalInfo.SuspendLayout();
            this.tbLicenseApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewLocalLicenseApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLApplicationID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewLocalDrivingLicenseApplicationTitle
            // 
            this.lblNewLocalDrivingLicenseApplicationTitle.AutoSize = true;
            this.lblNewLocalDrivingLicenseApplicationTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewLocalDrivingLicenseApplicationTitle.Font = new System.Drawing.Font("Tahoma", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocalDrivingLicenseApplicationTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNewLocalDrivingLicenseApplicationTitle.Location = new System.Drawing.Point(138, 39);
            this.lblNewLocalDrivingLicenseApplicationTitle.Name = "lblNewLocalDrivingLicenseApplicationTitle";
            this.lblNewLocalDrivingLicenseApplicationTitle.Size = new System.Drawing.Size(527, 33);
            this.lblNewLocalDrivingLicenseApplicationTitle.TabIndex = 61;
            this.lblNewLocalDrivingLicenseApplicationTitle.Text = "New Local Driving License Application";
            // 
            // tcAddNewLocalLicenseApplication
            // 
            this.tcAddNewLocalLicenseApplication.Controls.Add(this.tbLicensePersonalInfo);
            this.tcAddNewLocalLicenseApplication.Controls.Add(this.tbLicenseApplicationInfo);
            this.tcAddNewLocalLicenseApplication.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAddNewLocalLicenseApplication.Location = new System.Drawing.Point(10, 91);
            this.tcAddNewLocalLicenseApplication.Name = "tcAddNewLocalLicenseApplication";
            this.tcAddNewLocalLicenseApplication.SelectedIndex = 0;
            this.tcAddNewLocalLicenseApplication.Size = new System.Drawing.Size(783, 493);
            this.tcAddNewLocalLicenseApplication.TabIndex = 62;
            this.tcAddNewLocalLicenseApplication.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAddNewLocalLicenseApplication_Selecting);
            // 
            // tbLicensePersonalInfo
            // 
            this.tbLicensePersonalInfo.Controls.Add(this.ucPersonFilterAddNewLocalLicenseApplication);
            this.tbLicensePersonalInfo.Controls.Add(this.ucPersonInfoLocalLicenseApplicationWithFilter1);
            this.tbLicensePersonalInfo.Controls.Add(this.btnNewLocalLicenseApplication);
            this.tbLicensePersonalInfo.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicensePersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tbLicensePersonalInfo.Name = "tbLicensePersonalInfo";
            this.tbLicensePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLicensePersonalInfo.Size = new System.Drawing.Size(775, 463);
            this.tbLicensePersonalInfo.TabIndex = 0;
            this.tbLicensePersonalInfo.Text = "Personal Info";
            this.tbLicensePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ucPersonFilterAddNewLocalLicenseApplication
            // 
            this.ucPersonFilterAddNewLocalLicenseApplication.Location = new System.Drawing.Point(6, 6);
            this.ucPersonFilterAddNewLocalLicenseApplication.Name = "ucPersonFilterAddNewLocalLicenseApplication";
            this.ucPersonFilterAddNewLocalLicenseApplication.Size = new System.Drawing.Size(757, 75);
            this.ucPersonFilterAddNewLocalLicenseApplication.TabIndex = 3;
            this.ucPersonFilterAddNewLocalLicenseApplication.evResultPersonAdded += new System.Action<int>(this.ucPersonFilterAddNewLocalLicenseApplication_evResultPersonAdded);
            // 
            // ucPersonInfoLocalLicenseApplicationWithFilter1
            // 
            this.ucPersonInfoLocalLicenseApplicationWithFilter1.Location = new System.Drawing.Point(6, 98);
            this.ucPersonInfoLocalLicenseApplicationWithFilter1.Name = "ucPersonInfoLocalLicenseApplicationWithFilter1";
            this.ucPersonInfoLocalLicenseApplicationWithFilter1.Size = new System.Drawing.Size(757, 297);
            this.ucPersonInfoLocalLicenseApplicationWithFilter1.TabIndex = 4;
            // 
            // btnNewLocalLicenseApplication
            // 
            this.btnNewLocalLicenseApplication.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocalLicenseApplication.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.btnNewLocalLicenseApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewLocalLicenseApplication.Location = new System.Drawing.Point(641, 411);
            this.btnNewLocalLicenseApplication.Name = "btnNewLocalLicenseApplication";
            this.btnNewLocalLicenseApplication.Size = new System.Drawing.Size(122, 36);
            this.btnNewLocalLicenseApplication.TabIndex = 5;
            this.btnNewLocalLicenseApplication.Text = "Next";
            this.btnNewLocalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnNewLocalLicenseApplication.Click += new System.EventHandler(this.btnNewLocalLicenseApplication_Click);
            // 
            // tbLicenseApplicationInfo
            // 
            this.tbLicenseApplicationInfo.Controls.Add(this.pbLocalLicenseCreatedBy);
            this.tbLicenseApplicationInfo.Controls.Add(this.pbLocalLicenseApplicationFees);
            this.tbLicenseApplicationInfo.Controls.Add(this.pbLocalLicenseClass);
            this.tbLicenseApplicationInfo.Controls.Add(this.pbNewLocalLicenseApplicationDate);
            this.tbLicenseApplicationInfo.Controls.Add(this.pbDLApplicationID);
            this.tbLicenseApplicationInfo.Controls.Add(this.cbLocalLicenseClass);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblDLApplicationIDK);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblLocalLicenseCreatedByK);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblNewLocalLicenseApplicationDateK);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblLocalLicenseApplicationFeesK);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblLocalLicenseCreatedBy);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblNewLocalLicenseApplicationDate);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblLocalLicenseClass);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblLocalLicenseApplicationFees);
            this.tbLicenseApplicationInfo.Controls.Add(this.lblDLApplicationID);
            this.tbLicenseApplicationInfo.Location = new System.Drawing.Point(4, 26);
            this.tbLicenseApplicationInfo.Name = "tbLicenseApplicationInfo";
            this.tbLicenseApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLicenseApplicationInfo.Size = new System.Drawing.Size(775, 463);
            this.tbLicenseApplicationInfo.TabIndex = 1;
            this.tbLicenseApplicationInfo.Text = "Application Info";
            this.tbLicenseApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pbLocalLicenseCreatedBy
            // 
            this.pbLocalLicenseCreatedBy.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pbLocalLicenseCreatedBy.Location = new System.Drawing.Point(215, 240);
            this.pbLocalLicenseCreatedBy.Name = "pbLocalLicenseCreatedBy";
            this.pbLocalLicenseCreatedBy.Size = new System.Drawing.Size(30, 24);
            this.pbLocalLicenseCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalLicenseCreatedBy.TabIndex = 69;
            this.pbLocalLicenseCreatedBy.TabStop = false;
            // 
            // pbLocalLicenseApplicationFees
            // 
            this.pbLocalLicenseApplicationFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbLocalLicenseApplicationFees.Location = new System.Drawing.Point(215, 200);
            this.pbLocalLicenseApplicationFees.Name = "pbLocalLicenseApplicationFees";
            this.pbLocalLicenseApplicationFees.Size = new System.Drawing.Size(30, 24);
            this.pbLocalLicenseApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalLicenseApplicationFees.TabIndex = 68;
            this.pbLocalLicenseApplicationFees.TabStop = false;
            // 
            // pbLocalLicenseClass
            // 
            this.pbLocalLicenseClass.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.pbLocalLicenseClass.Location = new System.Drawing.Point(215, 162);
            this.pbLocalLicenseClass.Name = "pbLocalLicenseClass";
            this.pbLocalLicenseClass.Size = new System.Drawing.Size(30, 24);
            this.pbLocalLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalLicenseClass.TabIndex = 67;
            this.pbLocalLicenseClass.TabStop = false;
            // 
            // pbNewLocalLicenseApplicationDate
            // 
            this.pbNewLocalLicenseApplicationDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbNewLocalLicenseApplicationDate.Location = new System.Drawing.Point(215, 122);
            this.pbNewLocalLicenseApplicationDate.Name = "pbNewLocalLicenseApplicationDate";
            this.pbNewLocalLicenseApplicationDate.Size = new System.Drawing.Size(30, 24);
            this.pbNewLocalLicenseApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewLocalLicenseApplicationDate.TabIndex = 66;
            this.pbNewLocalLicenseApplicationDate.TabStop = false;
            // 
            // pbDLApplicationID
            // 
            this.pbDLApplicationID.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbDLApplicationID.Location = new System.Drawing.Point(215, 84);
            this.pbDLApplicationID.Name = "pbDLApplicationID";
            this.pbDLApplicationID.Size = new System.Drawing.Size(30, 24);
            this.pbDLApplicationID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDLApplicationID.TabIndex = 65;
            this.pbDLApplicationID.TabStop = false;
            // 
            // cbLocalLicenseClass
            // 
            this.cbLocalLicenseClass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbLocalLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLocalLicenseClass.FormattingEnabled = true;
            this.cbLocalLicenseClass.Location = new System.Drawing.Point(251, 162);
            this.cbLocalLicenseClass.Name = "cbLocalLicenseClass";
            this.cbLocalLicenseClass.Size = new System.Drawing.Size(208, 25);
            this.cbLocalLicenseClass.TabIndex = 64;
            this.cbLocalLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cbLocalLicenseClass_SelectedIndexChanged);
            // 
            // lblDLApplicationIDK
            // 
            this.lblDLApplicationIDK.AutoSize = true;
            this.lblDLApplicationIDK.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationIDK.Location = new System.Drawing.Point(251, 85);
            this.lblDLApplicationIDK.Name = "lblDLApplicationIDK";
            this.lblDLApplicationIDK.Size = new System.Drawing.Size(43, 23);
            this.lblDLApplicationIDK.TabIndex = 63;
            this.lblDLApplicationIDK.Text = "[???]";
            // 
            // lblLocalLicenseCreatedByK
            // 
            this.lblLocalLicenseCreatedByK.AutoSize = true;
            this.lblLocalLicenseCreatedByK.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseCreatedByK.Location = new System.Drawing.Point(251, 241);
            this.lblLocalLicenseCreatedByK.Name = "lblLocalLicenseCreatedByK";
            this.lblLocalLicenseCreatedByK.Size = new System.Drawing.Size(31, 23);
            this.lblLocalLicenseCreatedByK.TabIndex = 62;
            this.lblLocalLicenseCreatedByK.Text = "???";
            // 
            // lblNewLocalLicenseApplicationDateK
            // 
            this.lblNewLocalLicenseApplicationDateK.AutoSize = true;
            this.lblNewLocalLicenseApplicationDateK.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocalLicenseApplicationDateK.Location = new System.Drawing.Point(251, 123);
            this.lblNewLocalLicenseApplicationDateK.Name = "lblNewLocalLicenseApplicationDateK";
            this.lblNewLocalLicenseApplicationDateK.Size = new System.Drawing.Size(31, 23);
            this.lblNewLocalLicenseApplicationDateK.TabIndex = 61;
            this.lblNewLocalLicenseApplicationDateK.Text = "???";
            // 
            // lblLocalLicenseApplicationFeesK
            // 
            this.lblLocalLicenseApplicationFeesK.AutoSize = true;
            this.lblLocalLicenseApplicationFeesK.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseApplicationFeesK.Location = new System.Drawing.Point(251, 201);
            this.lblLocalLicenseApplicationFeesK.Name = "lblLocalLicenseApplicationFeesK";
            this.lblLocalLicenseApplicationFeesK.Size = new System.Drawing.Size(31, 23);
            this.lblLocalLicenseApplicationFeesK.TabIndex = 60;
            this.lblLocalLicenseApplicationFeesK.Text = "???";
            // 
            // lblLocalLicenseCreatedBy
            // 
            this.lblLocalLicenseCreatedBy.AutoSize = true;
            this.lblLocalLicenseCreatedBy.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseCreatedBy.Location = new System.Drawing.Point(98, 244);
            this.lblLocalLicenseCreatedBy.Name = "lblLocalLicenseCreatedBy";
            this.lblLocalLicenseCreatedBy.Size = new System.Drawing.Size(90, 17);
            this.lblLocalLicenseCreatedBy.TabIndex = 44;
            this.lblLocalLicenseCreatedBy.Text = "Created By:";
            // 
            // lblNewLocalLicenseApplicationDate
            // 
            this.lblNewLocalLicenseApplicationDate.AutoSize = true;
            this.lblNewLocalLicenseApplicationDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocalLicenseApplicationDate.Location = new System.Drawing.Point(63, 126);
            this.lblNewLocalLicenseApplicationDate.Name = "lblNewLocalLicenseApplicationDate";
            this.lblNewLocalLicenseApplicationDate.Size = new System.Drawing.Size(125, 17);
            this.lblNewLocalLicenseApplicationDate.TabIndex = 36;
            this.lblNewLocalLicenseApplicationDate.Text = "Application Date:";
            // 
            // lblLocalLicenseClass
            // 
            this.lblLocalLicenseClass.AutoSize = true;
            this.lblLocalLicenseClass.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseClass.Location = new System.Drawing.Point(90, 166);
            this.lblLocalLicenseClass.Name = "lblLocalLicenseClass";
            this.lblLocalLicenseClass.Size = new System.Drawing.Size(98, 17);
            this.lblLocalLicenseClass.TabIndex = 35;
            this.lblLocalLicenseClass.Text = "LicenseClass:";
            // 
            // lblLocalLicenseApplicationFees
            // 
            this.lblLocalLicenseApplicationFees.AutoSize = true;
            this.lblLocalLicenseApplicationFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseApplicationFees.Location = new System.Drawing.Point(64, 204);
            this.lblLocalLicenseApplicationFees.Name = "lblLocalLicenseApplicationFees";
            this.lblLocalLicenseApplicationFees.Size = new System.Drawing.Size(124, 17);
            this.lblLocalLicenseApplicationFees.TabIndex = 34;
            this.lblLocalLicenseApplicationFees.Text = "Application Fees:";
            // 
            // lblDLApplicationID
            // 
            this.lblDLApplicationID.AutoSize = true;
            this.lblDLApplicationID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDLApplicationID.Location = new System.Drawing.Point(52, 88);
            this.lblDLApplicationID.Name = "lblDLApplicationID";
            this.lblDLApplicationID.Size = new System.Drawing.Size(136, 17);
            this.lblDLApplicationID.TabIndex = 33;
            this.lblDLApplicationID.Text = "D.L Application ID:";
            this.lblDLApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewLocalLicenseApplicationSave
            // 
            this.btnNewLocalLicenseApplicationSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLocalLicenseApplicationSave.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocalLicenseApplicationSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnNewLocalLicenseApplicationSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLocalLicenseApplicationSave.Location = new System.Drawing.Point(660, 590);
            this.btnNewLocalLicenseApplicationSave.Name = "btnNewLocalLicenseApplicationSave";
            this.btnNewLocalLicenseApplicationSave.Size = new System.Drawing.Size(129, 36);
            this.btnNewLocalLicenseApplicationSave.TabIndex = 64;
            this.btnNewLocalLicenseApplicationSave.Text = "Save";
            this.btnNewLocalLicenseApplicationSave.UseVisualStyleBackColor = true;
            this.btnNewLocalLicenseApplicationSave.Click += new System.EventHandler(this.btnNewLocalLicenseApplicationSave_Click);
            // 
            // btnNewLocalLicenseApplicationClose
            // 
            this.btnNewLocalLicenseApplicationClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLocalLicenseApplicationClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocalLicenseApplicationClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnNewLocalLicenseApplicationClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLocalLicenseApplicationClose.Location = new System.Drawing.Point(526, 590);
            this.btnNewLocalLicenseApplicationClose.Name = "btnNewLocalLicenseApplicationClose";
            this.btnNewLocalLicenseApplicationClose.Size = new System.Drawing.Size(129, 36);
            this.btnNewLocalLicenseApplicationClose.TabIndex = 63;
            this.btnNewLocalLicenseApplicationClose.Text = "Close";
            this.btnNewLocalLicenseApplicationClose.UseVisualStyleBackColor = true;
            this.btnNewLocalLicenseApplicationClose.Click += new System.EventHandler(this.btnNewLocalLicenseApplicationClose_Click);
            // 
            // frmNewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 635);
            this.Controls.Add(this.btnNewLocalLicenseApplicationSave);
            this.Controls.Add(this.btnNewLocalLicenseApplicationClose);
            this.Controls.Add(this.tcAddNewLocalLicenseApplication);
            this.Controls.Add(this.lblNewLocalDrivingLicenseApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmNewLocalLicense_Load);
            this.tcAddNewLocalLicenseApplication.ResumeLayout(false);
            this.tbLicensePersonalInfo.ResumeLayout(false);
            this.tbLicenseApplicationInfo.ResumeLayout(false);
            this.tbLicenseApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewLocalLicenseApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLApplicationID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewLocalDrivingLicenseApplicationTitle;
        private System.Windows.Forms.Button btnNewLocalLicenseApplicationSave;
        private System.Windows.Forms.Button btnNewLocalLicenseApplicationClose;
        private System.Windows.Forms.TabControl tcAddNewLocalLicenseApplication;
        private System.Windows.Forms.TabPage tbLicensePersonalInfo;
        private System.Windows.Forms.TabPage tbLicenseApplicationInfo;
        private System.Windows.Forms.Label lblNewLocalLicenseApplicationDate;
        private System.Windows.Forms.Label lblLocalLicenseClass;
        private System.Windows.Forms.Label lblLocalLicenseApplicationFees;
        private System.Windows.Forms.Label lblDLApplicationID;
        private System.Windows.Forms.Label lblLocalLicenseCreatedBy;
        private System.Windows.Forms.Label lblDLApplicationIDK;
        private System.Windows.Forms.Label lblLocalLicenseCreatedByK;
        private System.Windows.Forms.Label lblNewLocalLicenseApplicationDateK;
        private System.Windows.Forms.Label lblLocalLicenseApplicationFeesK;
        private System.Windows.Forms.ComboBox cbLocalLicenseClass;
        private UCFilters ucPersonFilterAddNewLocalLicenseApplication;
        private UCPersonefo ucPersonInfoLocalLicenseApplicationWithFilter1;
        private System.Windows.Forms.Button btnNewLocalLicenseApplication;
        private System.Windows.Forms.PictureBox pbLocalLicenseCreatedBy;
        private System.Windows.Forms.PictureBox pbLocalLicenseApplicationFees;
        private System.Windows.Forms.PictureBox pbLocalLicenseClass;
        private System.Windows.Forms.PictureBox pbNewLocalLicenseApplicationDate;
        private System.Windows.Forms.PictureBox pbDLApplicationID;
    }
}