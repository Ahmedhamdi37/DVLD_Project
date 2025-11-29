namespace DVLD_Project
{
    partial class FrmManageTestTypes
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
            this.lblTestTypesNumbers = new System.Windows.Forms.Label();
            this.lblCountTestTypes = new System.Windows.Forms.Label();
            this.lblManageTestTypes = new System.Windows.Forms.Label();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTestTypes = new System.Windows.Forms.Button();
            this.pbManageTestTypes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTestTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTypesNumbers
            // 
            this.lblTestTypesNumbers.AutoSize = true;
            this.lblTestTypesNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypesNumbers.Location = new System.Drawing.Point(111, 501);
            this.lblTestTypesNumbers.Name = "lblTestTypesNumbers";
            this.lblTestTypesNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblTestTypesNumbers.TabIndex = 32;
            this.lblTestTypesNumbers.Text = "0";
            // 
            // lblCountTestTypes
            // 
            this.lblCountTestTypes.AutoSize = true;
            this.lblCountTestTypes.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTestTypes.Location = new System.Drawing.Point(16, 501);
            this.lblCountTestTypes.Name = "lblCountTestTypes";
            this.lblCountTestTypes.Size = new System.Drawing.Size(93, 21);
            this.lblCountTestTypes.TabIndex = 31;
            this.lblCountTestTypes.Text = "# Records:";
            // 
            // lblManageTestTypes
            // 
            this.lblManageTestTypes.AutoSize = true;
            this.lblManageTestTypes.BackColor = System.Drawing.SystemColors.Control;
            this.lblManageTestTypes.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageTestTypes.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageTestTypes.Location = new System.Drawing.Point(259, 196);
            this.lblManageTestTypes.Name = "lblManageTestTypes";
            this.lblManageTestTypes.Size = new System.Drawing.Size(241, 29);
            this.lblManageTestTypes.TabIndex = 28;
            this.lblManageTestTypes.Text = "Manage Test Types";
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToOrderColumns = true;
            this.dgvTestTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypes.Location = new System.Drawing.Point(20, 260);
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersWidth = 45;
            this.dgvTestTypes.RowTemplate.Height = 24;
            this.dgvTestTypes.Size = new System.Drawing.Size(720, 227);
            this.dgvTestTypes.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 42);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(162, 38);
            this.editToolStripMenuItem.Text = "Edit Test Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // btnTestTypes
            // 
            this.btnTestTypes.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestTypes.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestTypes.Location = new System.Drawing.Point(624, 493);
            this.btnTestTypes.Name = "btnTestTypes";
            this.btnTestTypes.Size = new System.Drawing.Size(116, 36);
            this.btnTestTypes.TabIndex = 30;
            this.btnTestTypes.Text = "Close";
            this.btnTestTypes.UseVisualStyleBackColor = true;
            this.btnTestTypes.Click += new System.EventHandler(this.btnTestTypes_Click);
            // 
            // pbManageTestTypes
            // 
            this.pbManageTestTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbManageTestTypes.Image = global::DVLD_Project.Properties.Resources.TestType_512;
            this.pbManageTestTypes.Location = new System.Drawing.Point(0, 0);
            this.pbManageTestTypes.Name = "pbManageTestTypes";
            this.pbManageTestTypes.Size = new System.Drawing.Size(752, 169);
            this.pbManageTestTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageTestTypes.TabIndex = 29;
            this.pbManageTestTypes.TabStop = false;
            // 
            // FrmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 536);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblTestTypesNumbers);
            this.Controls.Add(this.lblCountTestTypes);
            this.Controls.Add(this.btnTestTypes);
            this.Controls.Add(this.pbManageTestTypes);
            this.Controls.Add(this.lblManageTestTypes);
            this.Controls.Add(this.dgvTestTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageTestTypes";
            this.Load += new System.EventHandler(this.FrmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTestTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTypesNumbers;
        private System.Windows.Forms.Label lblCountTestTypes;
        private System.Windows.Forms.Button btnTestTypes;
        private System.Windows.Forms.PictureBox pbManageTestTypes;
        private System.Windows.Forms.Label lblManageTestTypes;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}