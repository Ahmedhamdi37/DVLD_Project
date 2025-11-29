namespace DVLD_Project
{
    partial class FrmManageApplicationTypes
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
            this.lblManageApplicationTypes = new System.Windows.Forms.Label();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.lblApplicationsTypesNumbers = new System.Windows.Forms.Label();
            this.lblCountApplicationTypes = new System.Windows.Forms.Label();
            this.btnApplicationTypes = new System.Windows.Forms.Button();
            this.pbManageApplicationTypes = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageApplicationTypes
            // 
            this.lblManageApplicationTypes.AutoSize = true;
            this.lblManageApplicationTypes.BackColor = System.Drawing.SystemColors.Control;
            this.lblManageApplicationTypes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApplicationTypes.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageApplicationTypes.Location = new System.Drawing.Point(212, 193);
            this.lblManageApplicationTypes.Name = "lblManageApplicationTypes";
            this.lblManageApplicationTypes.Size = new System.Drawing.Size(324, 29);
            this.lblManageApplicationTypes.TabIndex = 22;
            this.lblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToOrderColumns = true;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(14, 262);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.RowHeadersWidth = 45;
            this.dgvApplicationTypes.RowTemplate.Height = 24;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(720, 227);
            this.dgvApplicationTypes.TabIndex = 21;
            // 
            // lblApplicationsTypesNumbers
            // 
            this.lblApplicationsTypesNumbers.AutoSize = true;
            this.lblApplicationsTypesNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationsTypesNumbers.Location = new System.Drawing.Point(105, 504);
            this.lblApplicationsTypesNumbers.Name = "lblApplicationsTypesNumbers";
            this.lblApplicationsTypesNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblApplicationsTypesNumbers.TabIndex = 26;
            this.lblApplicationsTypesNumbers.Text = "0";
            // 
            // lblCountApplicationTypes
            // 
            this.lblCountApplicationTypes.AutoSize = true;
            this.lblCountApplicationTypes.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountApplicationTypes.Location = new System.Drawing.Point(10, 504);
            this.lblCountApplicationTypes.Name = "lblCountApplicationTypes";
            this.lblCountApplicationTypes.Size = new System.Drawing.Size(93, 21);
            this.lblCountApplicationTypes.TabIndex = 25;
            this.lblCountApplicationTypes.Text = "# Records:";
            // 
            // btnApplicationTypes
            // 
            this.btnApplicationTypes.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationTypes.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnApplicationTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationTypes.Location = new System.Drawing.Point(618, 496);
            this.btnApplicationTypes.Name = "btnApplicationTypes";
            this.btnApplicationTypes.Size = new System.Drawing.Size(116, 36);
            this.btnApplicationTypes.TabIndex = 24;
            this.btnApplicationTypes.Text = "Close";
            this.btnApplicationTypes.UseVisualStyleBackColor = true;
            this.btnApplicationTypes.Click += new System.EventHandler(this.btnApplicationTypes_Click);
            // 
            // pbManageApplicationTypes
            // 
            this.pbManageApplicationTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbManageApplicationTypes.Image = global::DVLD_Project.Properties.Resources.Application_Types_512;
            this.pbManageApplicationTypes.Location = new System.Drawing.Point(0, 0);
            this.pbManageApplicationTypes.Name = "pbManageApplicationTypes";
            this.pbManageApplicationTypes.Size = new System.Drawing.Size(749, 169);
            this.pbManageApplicationTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApplicationTypes.TabIndex = 23;
            this.pbManageApplicationTypes.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 42);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.editToolStripMenuItem.Text = "Edit Application Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // FrmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 545);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblApplicationsTypesNumbers);
            this.Controls.Add(this.lblCountApplicationTypes);
            this.Controls.Add(this.btnApplicationTypes);
            this.Controls.Add(this.pbManageApplicationTypes);
            this.Controls.Add(this.lblManageApplicationTypes);
            this.Controls.Add(this.dgvApplicationTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageApplicationTypes";
            this.Load += new System.EventHandler(this.FrmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbManageApplicationTypes;
        private System.Windows.Forms.Label lblManageApplicationTypes;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Label lblApplicationsTypesNumbers;
        private System.Windows.Forms.Label lblCountApplicationTypes;
        private System.Windows.Forms.Button btnApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}