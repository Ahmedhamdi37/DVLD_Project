namespace DVLD_Project
{
    partial class frmTestAppointments
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
            this.lblAppointments = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTestAppointments = new System.Windows.Forms.Label();
            this.dgvVisionTestAppointments = new System.Windows.Forms.DataGridView();
            this.lblVisionTestAppointmentsNumbers = new System.Windows.Forms.Label();
            this.lblVisionTestAppointmentsRecords = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.pbTestAppointments = new System.Windows.Forms.PictureBox();
            this.btnLocalLicenseApplicatonsClose = new System.Windows.Forms.Button();
            this.ucApplicationInfo1 = new DVLD_Project.UCApplicationInfo();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisionTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(3, 533);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(137, 21);
            this.lblAppointments.TabIndex = 18;
            this.lblAppointments.Text = "Appointments:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.dateTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_322;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // dateTestToolStripMenuItem
            // 
            this.dateTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Test_32;
            this.dateTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dateTestToolStripMenuItem.Name = "dateTestToolStripMenuItem";
            this.dateTestToolStripMenuItem.Size = new System.Drawing.Size(138, 38);
            this.dateTestToolStripMenuItem.Text = "Take Test";
            this.dateTestToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // lblTestAppointments
            // 
            this.lblTestAppointments.AutoSize = true;
            this.lblTestAppointments.BackColor = System.Drawing.SystemColors.Control;
            this.lblTestAppointments.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAppointments.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTestAppointments.Location = new System.Drawing.Point(278, 109);
            this.lblTestAppointments.Name = "lblTestAppointments";
            this.lblTestAppointments.Size = new System.Drawing.Size(48, 27);
            this.lblTestAppointments.TabIndex = 20;
            this.lblTestAppointments.Text = "???";
            // 
            // dgvVisionTestAppointments
            // 
            this.dgvVisionTestAppointments.AllowUserToAddRows = false;
            this.dgvVisionTestAppointments.AllowUserToDeleteRows = false;
            this.dgvVisionTestAppointments.AllowUserToOrderColumns = true;
            this.dgvVisionTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvVisionTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisionTestAppointments.Location = new System.Drawing.Point(7, 566);
            this.dgvVisionTestAppointments.Name = "dgvVisionTestAppointments";
            this.dgvVisionTestAppointments.ReadOnly = true;
            this.dgvVisionTestAppointments.RowHeadersWidth = 45;
            this.dgvVisionTestAppointments.RowTemplate.Height = 24;
            this.dgvVisionTestAppointments.Size = new System.Drawing.Size(783, 164);
            this.dgvVisionTestAppointments.TabIndex = 24;
            // 
            // lblVisionTestAppointmentsNumbers
            // 
            this.lblVisionTestAppointmentsNumbers.AutoSize = true;
            this.lblVisionTestAppointmentsNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionTestAppointmentsNumbers.Location = new System.Drawing.Point(98, 745);
            this.lblVisionTestAppointmentsNumbers.Name = "lblVisionTestAppointmentsNumbers";
            this.lblVisionTestAppointmentsNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblVisionTestAppointmentsNumbers.TabIndex = 27;
            this.lblVisionTestAppointmentsNumbers.Text = "0";
            // 
            // lblVisionTestAppointmentsRecords
            // 
            this.lblVisionTestAppointmentsRecords.AutoSize = true;
            this.lblVisionTestAppointmentsRecords.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisionTestAppointmentsRecords.Location = new System.Drawing.Point(3, 745);
            this.lblVisionTestAppointmentsRecords.Name = "lblVisionTestAppointmentsRecords";
            this.lblVisionTestAppointmentsRecords.Size = new System.Drawing.Size(93, 21);
            this.lblVisionTestAppointmentsRecords.TabIndex = 26;
            this.lblVisionTestAppointmentsRecords.Text = "# Records:";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Image = global::DVLD_Project.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(743, 526);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(47, 34);
            this.btnAddAppointment.TabIndex = 22;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // pbTestAppointments
            // 
            this.pbTestAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbTestAppointments.Image = global::DVLD_Project.Properties.Resources.Vision_512;
            this.pbTestAppointments.Location = new System.Drawing.Point(0, 0);
            this.pbTestAppointments.Name = "pbTestAppointments";
            this.pbTestAppointments.Size = new System.Drawing.Size(799, 92);
            this.pbTestAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestAppointments.TabIndex = 21;
            this.pbTestAppointments.TabStop = false;
            // 
            // btnLocalLicenseApplicatonsClose
            // 
            this.btnLocalLicenseApplicatonsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalLicenseApplicatonsClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalLicenseApplicatonsClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnLocalLicenseApplicatonsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicenseApplicatonsClose.Location = new System.Drawing.Point(674, 736);
            this.btnLocalLicenseApplicatonsClose.Name = "btnLocalLicenseApplicatonsClose";
            this.btnLocalLicenseApplicatonsClose.Size = new System.Drawing.Size(116, 36);
            this.btnLocalLicenseApplicatonsClose.TabIndex = 17;
            this.btnLocalLicenseApplicatonsClose.Text = "Close";
            this.btnLocalLicenseApplicatonsClose.UseVisualStyleBackColor = true;
            this.btnLocalLicenseApplicatonsClose.Click += new System.EventHandler(this.btnLocalLicenseApplicatonsClose_Click);
            // 
            // ucApplicationInfo1
            // 
            this.ucApplicationInfo1.Location = new System.Drawing.Point(7, 151);
            this.ucApplicationInfo1.Name = "ucApplicationInfo1";
            this.ucApplicationInfo1.Size = new System.Drawing.Size(783, 369);
            this.ucApplicationInfo1.TabIndex = 28;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 784);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ucApplicationInfo1);
            this.Controls.Add(this.lblVisionTestAppointmentsNumbers);
            this.Controls.Add(this.lblVisionTestAppointmentsRecords);
            this.Controls.Add(this.dgvVisionTestAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.pbTestAppointments);
            this.Controls.Add(this.lblTestAppointments);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.btnLocalLicenseApplicatonsClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm Test Appointments";
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisionTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalLicenseApplicatonsClose;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.PictureBox pbTestAppointments;
        private System.Windows.Forms.Label lblTestAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTestToolStripMenuItem;
    
        private System.Windows.Forms.DataGridView dgvVisionTestAppointments;
        private System.Windows.Forms.Label lblVisionTestAppointmentsNumbers;
        private System.Windows.Forms.Label lblVisionTestAppointmentsRecords;
        private UCApplicationInfo ucApplicationInfo1;
    }
}