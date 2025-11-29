namespace DVLD_Project
{
    partial class FrmAddNewUser
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
            this.tcAddNewUser = new System.Windows.Forms.TabControl();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucFilters1 = new DVLD_Project.UCFilters();
            this.ucUserInfoWithFilter1 = new DVLD_Project.UCPersonefo();
            this.btnPeopleClose = new System.Windows.Forms.Button();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.lblUserIDInfoK = new System.Windows.Forms.Label();
            this.chBIsActiveInfo = new System.Windows.Forms.CheckBox();
            this.txtPasswordInfo = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordInfo = new System.Windows.Forms.TextBox();
            this.txtUserNameInfo = new System.Windows.Forms.TextBox();
            this.lblUserNameInfo = new System.Windows.Forms.Label();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.lblConfirmPasswordInfo = new System.Windows.Forms.Label();
            this.lblUserIDInfo = new System.Windows.Forms.Label();
            this.lblModeUser = new System.Windows.Forms.Label();
            this.btnUserSaveInfo = new System.Windows.Forms.Button();
            this.btnUserCloseInfo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcAddNewUser.SuspendLayout();
            this.tbPersonalInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAddNewUser
            // 
            this.tcAddNewUser.Controls.Add(this.tbPersonalInfo);
            this.tcAddNewUser.Controls.Add(this.tbLoginInfo);
            this.tcAddNewUser.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAddNewUser.Location = new System.Drawing.Point(10, 84);
            this.tcAddNewUser.Name = "tcAddNewUser";
            this.tcAddNewUser.SelectedIndex = 0;
            this.tcAddNewUser.Size = new System.Drawing.Size(798, 502);
            this.tcAddNewUser.TabIndex = 0;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.Controls.Add(this.ucFilters1);
            this.tbPersonalInfo.Controls.Add(this.ucUserInfoWithFilter1);
            this.tbPersonalInfo.Controls.Add(this.btnPeopleClose);
            this.tbPersonalInfo.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalInfo.Size = new System.Drawing.Size(790, 472);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "PersonalInfo";
            this.tbPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ucFilters1
            // 
            this.ucFilters1.Location = new System.Drawing.Point(15, 22);
            this.ucFilters1.Name = "ucFilters1";
            this.ucFilters1.Size = new System.Drawing.Size(757, 75);
            this.ucFilters1.TabIndex = 0;
            this.ucFilters1.evResultPersonAdded += new System.Action<int>(this.ucFilters1_evResultPersonAdded);
            this.ucFilters1.Load += new System.EventHandler(this.ucFilters1_Load);
            // 
            // ucUserInfoWithFilter1
            // 
            this.ucUserInfoWithFilter1.Location = new System.Drawing.Point(15, 114);
            this.ucUserInfoWithFilter1.Name = "ucUserInfoWithFilter1";
            this.ucUserInfoWithFilter1.Size = new System.Drawing.Size(757, 297);
            this.ucUserInfoWithFilter1.TabIndex = 1;
            this.ucUserInfoWithFilter1.Load += new System.EventHandler(this.ucUserInfoWithFilter1_Load);
            // 
            // btnPeopleClose
            // 
            this.btnPeopleClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeopleClose.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.btnPeopleClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeopleClose.Location = new System.Drawing.Point(650, 427);
            this.btnPeopleClose.Name = "btnPeopleClose";
            this.btnPeopleClose.Size = new System.Drawing.Size(122, 36);
            this.btnPeopleClose.TabIndex = 2;
            this.btnPeopleClose.Text = "Next";
            this.btnPeopleClose.UseVisualStyleBackColor = true;
            this.btnPeopleClose.Click += new System.EventHandler(this.btnPeopleClose_Click);
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.lblUserIDInfoK);
            this.tbLoginInfo.Controls.Add(this.chBIsActiveInfo);
            this.tbLoginInfo.Controls.Add(this.txtPasswordInfo);
            this.tbLoginInfo.Controls.Add(this.txtConfirmPasswordInfo);
            this.tbLoginInfo.Controls.Add(this.txtUserNameInfo);
            this.tbLoginInfo.Controls.Add(this.lblUserNameInfo);
            this.tbLoginInfo.Controls.Add(this.lblPasswordInfo);
            this.tbLoginInfo.Controls.Add(this.lblConfirmPasswordInfo);
            this.tbLoginInfo.Controls.Add(this.lblUserIDInfo);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 26);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(790, 472);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblUserIDInfoK
            // 
            this.lblUserIDInfoK.AutoSize = true;
            this.lblUserIDInfoK.Location = new System.Drawing.Point(238, 91);
            this.lblUserIDInfoK.Name = "lblUserIDInfoK";
            this.lblUserIDInfoK.Size = new System.Drawing.Size(43, 17);
            this.lblUserIDInfoK.TabIndex = 43;
            this.lblUserIDInfoK.Text = "?????";
            // 
            // chBIsActiveInfo
            // 
            this.chBIsActiveInfo.AutoSize = true;
            this.chBIsActiveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBIsActiveInfo.Location = new System.Drawing.Point(238, 250);
            this.chBIsActiveInfo.Name = "chBIsActiveInfo";
            this.chBIsActiveInfo.Size = new System.Drawing.Size(75, 21);
            this.chBIsActiveInfo.TabIndex = 3;
            this.chBIsActiveInfo.Text = "Is Active";
            this.chBIsActiveInfo.UseVisualStyleBackColor = true;
            // 
            // txtPasswordInfo
            // 
            this.txtPasswordInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordInfo.Location = new System.Drawing.Point(238, 162);
            this.txtPasswordInfo.Multiline = true;
            this.txtPasswordInfo.Name = "txtPasswordInfo";
            this.txtPasswordInfo.PasswordChar = '*';
            this.txtPasswordInfo.Size = new System.Drawing.Size(128, 32);
            this.txtPasswordInfo.TabIndex = 1;
            this.txtPasswordInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordInfo_Validating);
            // 
            // txtConfirmPasswordInfo
            // 
            this.txtConfirmPasswordInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordInfo.Location = new System.Drawing.Point(238, 203);
            this.txtConfirmPasswordInfo.Multiline = true;
            this.txtConfirmPasswordInfo.Name = "txtConfirmPasswordInfo";
            this.txtConfirmPasswordInfo.PasswordChar = '*';
            this.txtConfirmPasswordInfo.Size = new System.Drawing.Size(128, 32);
            this.txtConfirmPasswordInfo.TabIndex = 2;
            this.txtConfirmPasswordInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPasswordInfo_Validating);
            this.txtConfirmPasswordInfo.Validated += new System.EventHandler(this.txtConfirmPasswordInfo_Validated);
            // 
            // txtUserNameInfo
            // 
            this.txtUserNameInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameInfo.Location = new System.Drawing.Point(238, 124);
            this.txtUserNameInfo.Multiline = true;
            this.txtUserNameInfo.Name = "txtUserNameInfo";
            this.txtUserNameInfo.Size = new System.Drawing.Size(128, 32);
            this.txtUserNameInfo.TabIndex = 0;
            this.txtUserNameInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNameInfo_KeyPress);
            this.txtUserNameInfo.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserNameInfo_Validating);
            // 
            // lblUserNameInfo
            // 
            this.lblUserNameInfo.AutoSize = true;
            this.lblUserNameInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameInfo.Location = new System.Drawing.Point(105, 130);
            this.lblUserNameInfo.Name = "lblUserNameInfo";
            this.lblUserNameInfo.Size = new System.Drawing.Size(84, 17);
            this.lblUserNameInfo.TabIndex = 36;
            this.lblUserNameInfo.Text = "UserName:";
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo.Location = new System.Drawing.Point(109, 169);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(80, 17);
            this.lblPasswordInfo.TabIndex = 35;
            this.lblPasswordInfo.Text = "Password:";
            // 
            // lblConfirmPasswordInfo
            // 
            this.lblConfirmPasswordInfo.AutoSize = true;
            this.lblConfirmPasswordInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordInfo.Location = new System.Drawing.Point(50, 208);
            this.lblConfirmPasswordInfo.Name = "lblConfirmPasswordInfo";
            this.lblConfirmPasswordInfo.Size = new System.Drawing.Size(139, 17);
            this.lblConfirmPasswordInfo.TabIndex = 34;
            this.lblConfirmPasswordInfo.Text = "Confirm Password:";
            // 
            // lblUserIDInfo
            // 
            this.lblUserIDInfo.AutoSize = true;
            this.lblUserIDInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUserIDInfo.Location = new System.Drawing.Point(128, 91);
            this.lblUserIDInfo.Name = "lblUserIDInfo";
            this.lblUserIDInfo.Size = new System.Drawing.Size(61, 17);
            this.lblUserIDInfo.TabIndex = 33;
            this.lblUserIDInfo.Text = "UserID:";
            this.lblUserIDInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModeUser
            // 
            this.lblModeUser.AutoSize = true;
            this.lblModeUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblModeUser.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeUser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblModeUser.Location = new System.Drawing.Point(300, 36);
            this.lblModeUser.Name = "lblModeUser";
            this.lblModeUser.Size = new System.Drawing.Size(189, 30);
            this.lblModeUser.TabIndex = 57;
            this.lblModeUser.Text = "Add New User";
            // 
            // btnUserSaveInfo
            // 
            this.btnUserSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSaveInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSaveInfo.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnUserSaveInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSaveInfo.Location = new System.Drawing.Point(686, 592);
            this.btnUserSaveInfo.Name = "btnUserSaveInfo";
            this.btnUserSaveInfo.Size = new System.Drawing.Size(122, 36);
            this.btnUserSaveInfo.TabIndex = 4;
            this.btnUserSaveInfo.Text = "Save";
            this.btnUserSaveInfo.UseVisualStyleBackColor = true;
            this.btnUserSaveInfo.Click += new System.EventHandler(this.btnUserSaveInfo_Click);
            // 
            // btnUserCloseInfo
            // 
            this.btnUserCloseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCloseInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCloseInfo.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnUserCloseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCloseInfo.Location = new System.Drawing.Point(558, 592);
            this.btnUserCloseInfo.Name = "btnUserCloseInfo";
            this.btnUserCloseInfo.Size = new System.Drawing.Size(122, 36);
            this.btnUserCloseInfo.TabIndex = 5;
            this.btnUserCloseInfo.Text = "Close";
            this.btnUserCloseInfo.UseVisualStyleBackColor = true;
            this.btnUserCloseInfo.Click += new System.EventHandler(this.btnUserCloseInfo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 637);
            this.Controls.Add(this.lblModeUser);
            this.Controls.Add(this.btnUserSaveInfo);
            this.Controls.Add(this.btnUserCloseInfo);
            this.Controls.Add(this.tcAddNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.FrmAddNewUser_Load);
            this.tcAddNewUser.ResumeLayout(false);
            this.tbPersonalInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddNewUser;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Button btnPeopleClose;
        private System.Windows.Forms.Button btnUserSaveInfo;
        private System.Windows.Forms.Button btnUserCloseInfo;
        private System.Windows.Forms.Label lblUserNameInfo;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.Label lblConfirmPasswordInfo;
        private System.Windows.Forms.Label lblUserIDInfo;
        private System.Windows.Forms.CheckBox chBIsActiveInfo;
        private System.Windows.Forms.TextBox txtPasswordInfo;
        private System.Windows.Forms.TextBox txtConfirmPasswordInfo;
        private System.Windows.Forms.TextBox txtUserNameInfo;
        private System.Windows.Forms.Label lblUserIDInfoK;
        private System.Windows.Forms.Label lblModeUser;
        private UCPersonefo ucUserInfoWithFilter1;
        private UCFilters ucUserFilter1;
        private UCFilters ucFilters1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}