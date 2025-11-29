namespace DVLD_Project
{
    partial class frmPeople
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
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetiailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btnPeopleClose = new System.Windows.Forms.Button();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.lblPeopleNumbers = new System.Windows.Forms.Label();
            this.lblCountPeople = new System.Windows.Forms.Label();
            this.txtFilterPeople = new System.Windows.Forms.TextBox();
            this.cbPeopleFilterBy = new System.Windows.Forms.ComboBox();
            this.lblPeopleFilterBy = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.BackColor = System.Drawing.SystemColors.Control;
            this.lblManagePeople.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManagePeople.Location = new System.Drawing.Point(596, 158);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(180, 27);
            this.lblManagePeople.TabIndex = 0;
            this.lblManagePeople.Text = "Manage People";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetiailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersoneToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 244);
            // 
            // showDetiailsToolStripMenuItem
            // 
            this.showDetiailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.showDetiailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetiailsToolStripMenuItem.Name = "showDetiailsToolStripMenuItem";
            this.showDetiailsToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.showDetiailsToolStripMenuItem.Text = "Show Detiails";
            this.showDetiailsToolStripMenuItem.Click += new System.EventHandler(this.showDetiailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // addNewPersoneToolStripMenuItem
            // 
            this.addNewPersoneToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.AddPerson_32;
            this.addNewPersoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersoneToolStripMenuItem.Name = "addNewPersoneToolStripMenuItem";
            this.addNewPersoneToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.addNewPersoneToolStripMenuItem.Text = "Add New Persone";
            this.addNewPersoneToolStripMenuItem.Click += new System.EventHandler(this.addNewPersoneToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(12, 226);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 45;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.Size = new System.Drawing.Size(1251, 227);
            this.dgvPeople.TabIndex = 2;
            // 
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD_Project.Properties.Resources.People_400;
            this.pbPeople.Location = new System.Drawing.Point(612, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(147, 128);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 6;
            this.pbPeople.TabStop = false;
            // 
            // btnPeopleClose
            // 
            this.btnPeopleClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnPeopleClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeopleClose.Location = new System.Drawing.Point(1152, 459);
            this.btnPeopleClose.Name = "btnPeopleClose";
            this.btnPeopleClose.Size = new System.Drawing.Size(111, 36);
            this.btnPeopleClose.TabIndex = 3;
            this.btnPeopleClose.Text = "Close";
            this.btnPeopleClose.UseVisualStyleBackColor = true;
            this.btnPeopleClose.Click += new System.EventHandler(this.btnPeopleClose_Click);
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Image = global::DVLD_Project.Properties.Resources.Add_Person_40;
            this.btnAddPeople.Location = new System.Drawing.Point(1162, 176);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(101, 45);
            this.btnAddPeople.TabIndex = 1;
            this.btnAddPeople.UseVisualStyleBackColor = true;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click_1);
            // 
            // lblPeopleNumbers
            // 
            this.lblPeopleNumbers.AutoSize = true;
            this.lblPeopleNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNumbers.Location = new System.Drawing.Point(103, 468);
            this.lblPeopleNumbers.Name = "lblPeopleNumbers";
            this.lblPeopleNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblPeopleNumbers.TabIndex = 25;
            this.lblPeopleNumbers.Text = "0";
            // 
            // lblCountPeople
            // 
            this.lblCountPeople.AutoSize = true;
            this.lblCountPeople.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPeople.Location = new System.Drawing.Point(8, 468);
            this.lblCountPeople.Name = "lblCountPeople";
            this.lblCountPeople.Size = new System.Drawing.Size(93, 21);
            this.lblCountPeople.TabIndex = 24;
            this.lblCountPeople.Text = "# Records:";
            // 
            // txtFilterPeople
            // 
            this.txtFilterPeople.Enabled = false;
            this.txtFilterPeople.Location = new System.Drawing.Point(279, 199);
            this.txtFilterPeople.Multiline = true;
            this.txtFilterPeople.Name = "txtFilterPeople";
            this.txtFilterPeople.Size = new System.Drawing.Size(177, 22);
            this.txtFilterPeople.TabIndex = 27;
            this.txtFilterPeople.TextChanged += new System.EventHandler(this.txtFilterPeople_TextChanged);
            this.txtFilterPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterPeople_KeyPress);
            // 
            // cbPeopleFilterBy
            // 
            this.cbPeopleFilterBy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbPeopleFilterBy.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeopleFilterBy.FormattingEnabled = true;
            this.cbPeopleFilterBy.Location = new System.Drawing.Point(98, 198);
            this.cbPeopleFilterBy.Name = "cbPeopleFilterBy";
            this.cbPeopleFilterBy.Size = new System.Drawing.Size(177, 25);
            this.cbPeopleFilterBy.TabIndex = 26;
            this.cbPeopleFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbPeopleFilterBy_SelectedIndexChanged);
            // 
            // lblPeopleFilterBy
            // 
            this.lblPeopleFilterBy.AutoSize = true;
            this.lblPeopleFilterBy.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleFilterBy.Location = new System.Drawing.Point(12, 200);
            this.lblPeopleFilterBy.Name = "lblPeopleFilterBy";
            this.lblPeopleFilterBy.Size = new System.Drawing.Size(82, 21);
            this.lblPeopleFilterBy.TabIndex = 28;
            this.lblPeopleFilterBy.Text = "Filter By :";
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 500);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.cbPeopleFilterBy);
            this.Controls.Add(this.lblPeopleFilterBy);
            this.Controls.Add(this.lblPeopleNumbers);
            this.Controls.Add(this.lblCountPeople);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnPeopleClose);
            this.Controls.Add(this.btnAddPeople);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.txtFilterPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button btnPeopleClose;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetiailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblPeopleNumbers;
        private System.Windows.Forms.Label lblCountPeople;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtFilterPeople;
        private System.Windows.Forms.ComboBox cbPeopleFilterBy;
        private System.Windows.Forms.Label lblPeopleFilterBy;
    }
}