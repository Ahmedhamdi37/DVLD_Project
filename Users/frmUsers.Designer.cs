namespace DVLD_Project
{
    partial class frmUsers
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.lblUserNumbers = new System.Windows.Forms.Label();
            this.txtFilterUsers = new System.Windows.Forms.TextBox();
            this.lblUsersFilterBy = new System.Windows.Forms.Label();
            this.cbUsersFilterBy = new System.Windows.Forms.ComboBox();
            this.cbUserIsActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetiailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUsersClose = new System.Windows.Forms.Button();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(10, 239);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 45;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(806, 302);
            this.dgvUsers.TabIndex = 0;
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.BackColor = System.Drawing.SystemColors.Control;
            this.lblManageUsers.Font = new System.Drawing.Font("Tahoma", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageUsers.Location = new System.Drawing.Point(337, 153);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(166, 27);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.AutoSize = true;
            this.lblCountUsers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUsers.Location = new System.Drawing.Point(6, 555);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(93, 21);
            this.lblCountUsers.TabIndex = 13;
            this.lblCountUsers.Text = "# Records:";
            // 
            // lblUserNumbers
            // 
            this.lblUserNumbers.AutoSize = true;
            this.lblUserNumbers.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumbers.Location = new System.Drawing.Point(101, 555);
            this.lblUserNumbers.Name = "lblUserNumbers";
            this.lblUserNumbers.Size = new System.Drawing.Size(19, 21);
            this.lblUserNumbers.TabIndex = 14;
            this.lblUserNumbers.Text = "0";
            // 
            // txtFilterUsers
            // 
            this.txtFilterUsers.Enabled = false;
            this.txtFilterUsers.Location = new System.Drawing.Point(281, 208);
            this.txtFilterUsers.Multiline = true;
            this.txtFilterUsers.Name = "txtFilterUsers";
            this.txtFilterUsers.Size = new System.Drawing.Size(177, 22);
            this.txtFilterUsers.TabIndex = 16;
            this.txtFilterUsers.Visible = false;
            this.txtFilterUsers.TextChanged += new System.EventHandler(this.txtFilterUsers_TextChanged);
            this.txtFilterUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterUsers_KeyPress);
            // 
            // lblUsersFilterBy
            // 
            this.lblUsersFilterBy.AutoSize = true;
            this.lblUsersFilterBy.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersFilterBy.Location = new System.Drawing.Point(12, 212);
            this.lblUsersFilterBy.Name = "lblUsersFilterBy";
            this.lblUsersFilterBy.Size = new System.Drawing.Size(82, 21);
            this.lblUsersFilterBy.TabIndex = 17;
            this.lblUsersFilterBy.Text = "Filter By :";
            // 
            // cbUsersFilterBy
            // 
            this.cbUsersFilterBy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUsersFilterBy.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsersFilterBy.FormattingEnabled = true;
            this.cbUsersFilterBy.Location = new System.Drawing.Point(98, 210);
            this.cbUsersFilterBy.Name = "cbUsersFilterBy";
            this.cbUsersFilterBy.Size = new System.Drawing.Size(177, 25);
            this.cbUsersFilterBy.TabIndex = 15;
            this.cbUsersFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbUsersFilterBy_SelectedIndexChanged);
            // 
            // cbUserIsActive
            // 
            this.cbUserIsActive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cbUserIsActive.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserIsActive.FormattingEnabled = true;
            this.cbUserIsActive.Location = new System.Drawing.Point(281, 208);
            this.cbUserIsActive.Name = "cbUserIsActive";
            this.cbUserIsActive.Size = new System.Drawing.Size(90, 25);
            this.cbUserIsActive.TabIndex = 18;
            this.cbUserIsActive.Visible = false;
            this.cbUserIsActive.SelectedIndexChanged += new System.EventHandler(this.cbUserIsActive_SelectedIndexChanged);
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
            this.ChangePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.SendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 282);
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
            this.addNewPersoneToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Add_New_User_32;
            this.addNewPersoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersoneToolStripMenuItem.Name = "addNewPersoneToolStripMenuItem";
            this.addNewPersoneToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.addNewPersoneToolStripMenuItem.Text = "Add New User";
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
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Password_321;
            this.ChangePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.send_email_32;
            this.SendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.SendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem1
            // 
            this.phoneCallToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.call_321;
            this.phoneCallToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem1.Name = "phoneCallToolStripMenuItem1";
            this.phoneCallToolStripMenuItem1.Size = new System.Drawing.Size(184, 38);
            this.phoneCallToolStripMenuItem1.Text = "Phone Call";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.Users_2_641;
            this.btnAddUser.Location = new System.Drawing.Point(744, 163);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 70);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUsersClose
            // 
            this.btnUsersClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnUsersClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersClose.Location = new System.Drawing.Point(700, 546);
            this.btnUsersClose.Name = "btnUsersClose";
            this.btnUsersClose.Size = new System.Drawing.Size(116, 36);
            this.btnUsersClose.TabIndex = 11;
            this.btnUsersClose.Text = "Close";
            this.btnUsersClose.UseVisualStyleBackColor = true;
            this.btnUsersClose.Click += new System.EventHandler(this.btnUsersClose_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbUsers.Image = global::DVLD_Project.Properties.Resources.Users_2_400;
            this.pbUsers.Location = new System.Drawing.Point(0, 0);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(828, 128);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 7;
            this.pbUsers.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 595);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtFilterUsers);
            this.Controls.Add(this.cbUsersFilterBy);
            this.Controls.Add(this.lblUsersFilterBy);
            this.Controls.Add(this.lblUserNumbers);
            this.Controls.Add(this.lblCountUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnUsersClose);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.cbUserIsActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.Button btnUsersClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Label lblUserNumbers;
        private System.Windows.Forms.TextBox txtFilterUsers;
        private System.Windows.Forms.Label lblUsersFilterBy;
        private System.Windows.Forms.ComboBox cbUsersFilterBy;
        private System.Windows.Forms.ComboBox cbUserIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetiailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem1;
    }
}