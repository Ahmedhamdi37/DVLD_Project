namespace DVLD_Project
{
    partial class frmDrivers
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
            this.lblDriverNumbers = new System.Windows.Forms.Label();
            this.lblCountDrivers = new System.Windows.Forms.Label();
            this.txtFilterDrivers = new System.Windows.Forms.TextBox();
            this.cbDriversFilterBy = new System.Windows.Forms.ComboBox();
            this.lblDriversFilterBy = new System.Windows.Forms.Label();
            this.lblManageDrivers = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersoneInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersoneLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverNumbers
            // 
            this.lblDriverNumbers.AutoSize = true;
            this.lblDriverNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNumbers.Location = new System.Drawing.Point(107, 534);
            this.lblDriverNumbers.Name = "lblDriverNumbers";
            this.lblDriverNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblDriverNumbers.TabIndex = 23;
            this.lblDriverNumbers.Text = "0";
            // 
            // lblCountDrivers
            // 
            this.lblCountDrivers.AutoSize = true;
            this.lblCountDrivers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDrivers.Location = new System.Drawing.Point(12, 534);
            this.lblCountDrivers.Name = "lblCountDrivers";
            this.lblCountDrivers.Size = new System.Drawing.Size(93, 21);
            this.lblCountDrivers.TabIndex = 22;
            this.lblCountDrivers.Text = "# Records:";
            // 
            // txtFilterDrivers
            // 
            this.txtFilterDrivers.Location = new System.Drawing.Point(279, 249);
            this.txtFilterDrivers.Multiline = true;
            this.txtFilterDrivers.Name = "txtFilterDrivers";
            this.txtFilterDrivers.Size = new System.Drawing.Size(177, 22);
            this.txtFilterDrivers.TabIndex = 20;
            this.txtFilterDrivers.TextChanged += new System.EventHandler(this.txtFilterDrivers_TextChanged);
            this.txtFilterDrivers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDrivers_KeyPress);
            // 
            // cbDriversFilterBy
            // 
            this.cbDriversFilterBy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbDriversFilterBy.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDriversFilterBy.FormattingEnabled = true;
            this.cbDriversFilterBy.Location = new System.Drawing.Point(97, 249);
            this.cbDriversFilterBy.Name = "cbDriversFilterBy";
            this.cbDriversFilterBy.Size = new System.Drawing.Size(177, 25);
            this.cbDriversFilterBy.TabIndex = 19;
            this.cbDriversFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbDriversFilterBy_SelectedIndexChanged);
            // 
            // lblDriversFilterBy
            // 
            this.lblDriversFilterBy.AutoSize = true;
            this.lblDriversFilterBy.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriversFilterBy.Location = new System.Drawing.Point(10, 249);
            this.lblDriversFilterBy.Name = "lblDriversFilterBy";
            this.lblDriversFilterBy.Size = new System.Drawing.Size(82, 21);
            this.lblDriversFilterBy.TabIndex = 18;
            this.lblDriversFilterBy.Text = "Filter By :";
            // 
            // lblManageDrivers
            // 
            this.lblManageDrivers.AutoSize = true;
            this.lblManageDrivers.BackColor = System.Drawing.SystemColors.Control;
            this.lblManageDrivers.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageDrivers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageDrivers.Location = new System.Drawing.Point(406, 202);
            this.lblManageDrivers.Name = "lblManageDrivers";
            this.lblManageDrivers.Size = new System.Drawing.Size(186, 27);
            this.lblManageDrivers.TabIndex = 16;
            this.lblManageDrivers.Text = "Manage Drivers";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersoneInfoToolStripMenuItem,
            this.issueInternationalLicenseToolStripMenuItem,
            this.showPersoneLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 118);
            // 
            // showPersoneInfoToolStripMenuItem
            // 
            this.showPersoneInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersoneInfoToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_322;
            this.showPersoneInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersoneInfoToolStripMenuItem.Name = "showPersoneInfoToolStripMenuItem";
            this.showPersoneInfoToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.showPersoneInfoToolStripMenuItem.Text = "Show Persone Info";
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.International_322;
            this.issueInternationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            // 
            // showPersoneLicenseHistoryToolStripMenuItem
            // 
            this.showPersoneLicenseHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.showPersoneLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersoneLicenseHistoryToolStripMenuItem.Name = "showPersoneLicenseHistoryToolStripMenuItem";
            this.showPersoneLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.showPersoneLicenseHistoryToolStripMenuItem.Text = "Show Persone License History";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(843, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 36);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbDrivers
            // 
            this.pbDrivers.Image = global::DVLD_Project.Properties.Resources.Driver_Main;
            this.pbDrivers.Location = new System.Drawing.Point(375, 20);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(249, 169);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrivers.TabIndex = 17;
            this.pbDrivers.TabStop = false;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(14, 280);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 45;
            this.dgvDrivers.RowTemplate.Height = 24;
            this.dgvDrivers.Size = new System.Drawing.Size(970, 240);
            this.dgvDrivers.TabIndex = 24;
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 570);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.lblDriverNumbers);
            this.Controls.Add(this.lblCountDrivers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFilterDrivers);
            this.Controls.Add(this.cbDriversFilterBy);
            this.Controls.Add(this.lblDriversFilterBy);
            this.Controls.Add(this.pbDrivers);
            this.Controls.Add(this.lblManageDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Drivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverNumbers;
        private System.Windows.Forms.Label lblCountDrivers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilterDrivers;
        private System.Windows.Forms.ComboBox cbDriversFilterBy;
        private System.Windows.Forms.Label lblDriversFilterBy;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.Label lblManageDrivers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersoneInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersoneLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDrivers;
    }
}