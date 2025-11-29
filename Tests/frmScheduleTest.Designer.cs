namespace DVLD_Project
{
    partial class frmScheduleTest
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
            this.lblScheduleTest = new System.Windows.Forms.Label();
            this.gbScheduleTest = new System.Windows.Forms.GroupBox();
            this.lblLockedMessage = new System.Windows.Forms.Label();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.pbNumberTrial = new System.Windows.Forms.PictureBox();
            this.pbApplicantName = new System.Windows.Forms.PictureBox();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.pbLDLAppID = new System.Windows.Forms.PictureBox();
            this.ucRetakeTest1 = new DVLD_Project.UCRetakeTest();
            this.dtpScheduleTest = new System.Windows.Forms.DateTimePicker();
            this.btnScheduleTestSave = new System.Windows.Forms.Button();
            this.lblApplicationFeesK = new System.Windows.Forms.Label();
            this.lblDlAppIDk = new System.Windows.Forms.Label();
            this.lblDClassNameK = new System.Windows.Forms.Label();
            this.lblApplicantNameK = new System.Windows.Forms.Label();
            this.lblTrialK = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblDlAppID = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.pbScheduleTest = new System.Windows.Forms.PictureBox();
            this.btnScheduleTestClose = new System.Windows.Forms.Button();
            this.gbScheduleTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberTrial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicantName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLDLAppID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScheduleTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScheduleTest
            // 
            this.lblScheduleTest.AutoSize = true;
            this.lblScheduleTest.BackColor = System.Drawing.SystemColors.Control;
            this.lblScheduleTest.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleTest.ForeColor = System.Drawing.Color.DarkRed;
            this.lblScheduleTest.Location = new System.Drawing.Point(182, 162);
            this.lblScheduleTest.Name = "lblScheduleTest";
            this.lblScheduleTest.Size = new System.Drawing.Size(165, 27);
            this.lblScheduleTest.TabIndex = 22;
            this.lblScheduleTest.Text = "Schedule Test";
            // 
            // gbScheduleTest
            // 
            this.gbScheduleTest.Controls.Add(this.lblLockedMessage);
            this.gbScheduleTest.Controls.Add(this.pbFees);
            this.gbScheduleTest.Controls.Add(this.pbDate);
            this.gbScheduleTest.Controls.Add(this.pbNumberTrial);
            this.gbScheduleTest.Controls.Add(this.pbApplicantName);
            this.gbScheduleTest.Controls.Add(this.pbLicenseClass);
            this.gbScheduleTest.Controls.Add(this.pbLDLAppID);
            this.gbScheduleTest.Controls.Add(this.ucRetakeTest1);
            this.gbScheduleTest.Controls.Add(this.dtpScheduleTest);
            this.gbScheduleTest.Controls.Add(this.btnScheduleTestSave);
            this.gbScheduleTest.Controls.Add(this.lblApplicationFeesK);
            this.gbScheduleTest.Controls.Add(this.lblDlAppIDk);
            this.gbScheduleTest.Controls.Add(this.lblDClassNameK);
            this.gbScheduleTest.Controls.Add(this.lblApplicantNameK);
            this.gbScheduleTest.Controls.Add(this.lblTrialK);
            this.gbScheduleTest.Controls.Add(this.lblDate);
            this.gbScheduleTest.Controls.Add(this.lblApplicationFees);
            this.gbScheduleTest.Controls.Add(this.lblDlAppID);
            this.gbScheduleTest.Controls.Add(this.lblApplicantName);
            this.gbScheduleTest.Controls.Add(this.lblTrial);
            this.gbScheduleTest.Controls.Add(this.lblClassName);
            this.gbScheduleTest.Controls.Add(this.pbScheduleTest);
            this.gbScheduleTest.Controls.Add(this.lblScheduleTest);
            this.gbScheduleTest.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheduleTest.Location = new System.Drawing.Point(8, 25);
            this.gbScheduleTest.Name = "gbScheduleTest";
            this.gbScheduleTest.Size = new System.Drawing.Size(528, 595);
            this.gbScheduleTest.TabIndex = 24;
            this.gbScheduleTest.TabStop = false;
            this.gbScheduleTest.Text = "ScheduleTest";
            // 
            // lblLockedMessage
            // 
            this.lblLockedMessage.AutoSize = true;
            this.lblLockedMessage.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockedMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLockedMessage.Location = new System.Drawing.Point(58, 205);
            this.lblLockedMessage.Name = "lblLockedMessage";
            this.lblLockedMessage.Size = new System.Drawing.Size(412, 21);
            this.lblLockedMessage.TabIndex = 89;
            this.lblLockedMessage.Text = "Person Already sat for the test, Appointment Loacked.";
            this.lblLockedMessage.Visible = false;
            // 
            // pbFees
            // 
            this.pbFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbFees.Location = new System.Drawing.Point(145, 432);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(30, 24);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 88;
            this.pbFees.TabStop = false;
            // 
            // pbDate
            // 
            this.pbDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbDate.Location = new System.Drawing.Point(145, 397);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(30, 24);
            this.pbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDate.TabIndex = 87;
            this.pbDate.TabStop = false;
            // 
            // pbNumberTrial
            // 
            this.pbNumberTrial.Image = global::DVLD_Project.Properties.Resources.Count_32;
            this.pbNumberTrial.Location = new System.Drawing.Point(145, 362);
            this.pbNumberTrial.Name = "pbNumberTrial";
            this.pbNumberTrial.Size = new System.Drawing.Size(30, 24);
            this.pbNumberTrial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNumberTrial.TabIndex = 86;
            this.pbNumberTrial.TabStop = false;
            // 
            // pbApplicantName
            // 
            this.pbApplicantName.Image = global::DVLD_Project.Properties.Resources.Person_32;
            this.pbApplicantName.Location = new System.Drawing.Point(145, 326);
            this.pbApplicantName.Name = "pbApplicantName";
            this.pbApplicantName.Size = new System.Drawing.Size(30, 24);
            this.pbApplicantName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicantName.TabIndex = 85;
            this.pbApplicantName.TabStop = false;
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = global::DVLD_Project.Properties.Resources.New_Driving_License_321;
            this.pbLicenseClass.Location = new System.Drawing.Point(145, 291);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(30, 24);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 84;
            this.pbLicenseClass.TabStop = false;
            // 
            // pbLDLAppID
            // 
            this.pbLDLAppID.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbLDLAppID.Location = new System.Drawing.Point(145, 256);
            this.pbLDLAppID.Name = "pbLDLAppID";
            this.pbLDLAppID.Size = new System.Drawing.Size(30, 24);
            this.pbLDLAppID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLDLAppID.TabIndex = 83;
            this.pbLDLAppID.TabStop = false;
            // 
            // ucRetakeTest1
            // 
            this.ucRetakeTest1.Location = new System.Drawing.Point(0, 472);
            this.ucRetakeTest1.Margin = new System.Windows.Forms.Padding(4);
            this.ucRetakeTest1.Name = "ucRetakeTest1";
            this.ucRetakeTest1.Size = new System.Drawing.Size(525, 72);
            this.ucRetakeTest1.TabIndex = 80;
            this.ucRetakeTest1.OnRetakeApplicationID += new System.Action<int>(this.ucRetakeTest1_OnRetakeApplicationID);
            // 
            // dtpScheduleTest
            // 
            this.dtpScheduleTest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScheduleTest.Location = new System.Drawing.Point(196, 397);
            this.dtpScheduleTest.Name = "dtpScheduleTest";
            this.dtpScheduleTest.Size = new System.Drawing.Size(128, 24);
            this.dtpScheduleTest.TabIndex = 79;
            // 
            // btnScheduleTestSave
            // 
            this.btnScheduleTestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleTestSave.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleTestSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnScheduleTestSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleTestSave.Location = new System.Drawing.Point(405, 551);
            this.btnScheduleTestSave.Name = "btnScheduleTestSave";
            this.btnScheduleTestSave.Size = new System.Drawing.Size(123, 36);
            this.btnScheduleTestSave.TabIndex = 78;
            this.btnScheduleTestSave.Text = "Save";
            this.btnScheduleTestSave.UseVisualStyleBackColor = true;
            this.btnScheduleTestSave.Click += new System.EventHandler(this.btnVisionScheduleTestSave_Click);
            // 
            // lblApplicationFeesK
            // 
            this.lblApplicationFeesK.AutoSize = true;
            this.lblApplicationFeesK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesK.Location = new System.Drawing.Point(192, 434);
            this.lblApplicationFeesK.Name = "lblApplicationFeesK";
            this.lblApplicationFeesK.Size = new System.Drawing.Size(28, 21);
            this.lblApplicationFeesK.TabIndex = 70;
            this.lblApplicationFeesK.Text = "10";
            // 
            // lblDlAppIDk
            // 
            this.lblDlAppIDk.AutoSize = true;
            this.lblDlAppIDk.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDlAppIDk.Location = new System.Drawing.Point(192, 258);
            this.lblDlAppIDk.Name = "lblDlAppIDk";
            this.lblDlAppIDk.Size = new System.Drawing.Size(28, 21);
            this.lblDlAppIDk.TabIndex = 76;
            this.lblDlAppIDk.Text = "31";
            // 
            // lblDClassNameK
            // 
            this.lblDClassNameK.AutoSize = true;
            this.lblDClassNameK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDClassNameK.Location = new System.Drawing.Point(192, 293);
            this.lblDClassNameK.Name = "lblDClassNameK";
            this.lblDClassNameK.Size = new System.Drawing.Size(254, 21);
            this.lblDClassNameK.TabIndex = 75;
            this.lblDClassNameK.Text = "Class3 _ Ordinary driving License";
            // 
            // lblApplicantNameK
            // 
            this.lblApplicantNameK.AutoSize = true;
            this.lblApplicantNameK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantNameK.Location = new System.Drawing.Point(192, 328);
            this.lblApplicantNameK.Name = "lblApplicantNameK";
            this.lblApplicantNameK.Size = new System.Drawing.Size(187, 21);
            this.lblApplicantNameK.TabIndex = 74;
            this.lblApplicantNameK.Text = "Khalid Ali Maher Hamed";
            // 
            // lblTrialK
            // 
            this.lblTrialK.AutoSize = true;
            this.lblTrialK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrialK.Location = new System.Drawing.Point(192, 364);
            this.lblTrialK.Name = "lblTrialK";
            this.lblTrialK.Size = new System.Drawing.Size(19, 21);
            this.lblTrialK.TabIndex = 73;
            this.lblTrialK.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(87, 399);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 21);
            this.lblDate.TabIndex = 72;
            this.lblDate.Text = "Date:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(88, 434);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(51, 21);
            this.lblApplicationFees.TabIndex = 71;
            this.lblApplicationFees.Text = "Fees:";
            // 
            // lblDlAppID
            // 
            this.lblDlAppID.AutoSize = true;
            this.lblDlAppID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDlAppID.Location = new System.Drawing.Point(41, 258);
            this.lblDlAppID.Name = "lblDlAppID";
            this.lblDlAppID.Size = new System.Drawing.Size(98, 21);
            this.lblDlAppID.TabIndex = 69;
            this.lblDlAppID.Text = "D.L.App ID:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName.Location = new System.Drawing.Point(80, 328);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(59, 21);
            this.lblApplicantName.TabIndex = 68;
            this.lblApplicantName.Text = "Name:";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.Location = new System.Drawing.Point(90, 364);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(49, 21);
            this.lblTrial.TabIndex = 67;
            this.lblTrial.Text = "Trial:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(62, 293);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(77, 21);
            this.lblClassName.TabIndex = 66;
            this.lblClassName.Text = "D. Class:";
            // 
            // pbScheduleTest
            // 
            this.pbScheduleTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbScheduleTest.Image = global::DVLD_Project.Properties.Resources.Vision_512;
            this.pbScheduleTest.Location = new System.Drawing.Point(3, 20);
            this.pbScheduleTest.Name = "pbScheduleTest";
            this.pbScheduleTest.Size = new System.Drawing.Size(522, 127);
            this.pbScheduleTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScheduleTest.TabIndex = 23;
            this.pbScheduleTest.TabStop = false;
            // 
            // btnScheduleTestClose
            // 
            this.btnScheduleTestClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleTestClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleTestClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnScheduleTestClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleTestClose.Location = new System.Drawing.Point(216, 626);
            this.btnScheduleTestClose.Name = "btnScheduleTestClose";
            this.btnScheduleTestClose.Size = new System.Drawing.Size(116, 36);
            this.btnScheduleTestClose.TabIndex = 26;
            this.btnScheduleTestClose.Text = "Close";
            this.btnScheduleTestClose.UseVisualStyleBackColor = true;
            this.btnScheduleTestClose.Click += new System.EventHandler(this.btnVisionScheduleTestClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 670);
            this.Controls.Add(this.btnScheduleTestClose);
            this.Controls.Add(this.gbScheduleTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmAddVisionAppointmen_Load);
            this.gbScheduleTest.ResumeLayout(false);
            this.gbScheduleTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberTrial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicantName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLDLAppID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScheduleTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScheduleTest;
        private System.Windows.Forms.Label lblScheduleTest;
        private System.Windows.Forms.GroupBox gbScheduleTest;
        private System.Windows.Forms.Label lblDlAppIDk;
        private System.Windows.Forms.Label lblDClassNameK;
        private System.Windows.Forms.Label lblApplicantNameK;
        private System.Windows.Forms.Label lblTrialK;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationFeesK;
        private System.Windows.Forms.Label lblDlAppID;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnScheduleTestClose;
        private System.Windows.Forms.Button btnScheduleTestSave;
        private System.Windows.Forms.DateTimePicker dtpScheduleTest;
        private UCRetakeTest ucRetakeTest1;
        private System.Windows.Forms.PictureBox pbApplicantName;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.PictureBox pbLDLAppID;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.PictureBox pbNumberTrial;
        private System.Windows.Forms.Label lblLockedMessage;
    }
}