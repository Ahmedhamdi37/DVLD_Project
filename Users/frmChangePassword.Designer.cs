namespace DVLD_Project
{
    partial class frmChangePassword
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
            this.btnCloseChangePassword = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSaveChangePassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucLoginInfo1 = new DVLD_Project.UCLoginInfo();
            this.UCUserInfoforChangePassword = new DVLD_Project.UCPersonefo();
            this.pbPersoneNationalNo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseChangePassword
            // 
            this.btnCloseChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChangePassword.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChangePassword.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnCloseChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChangePassword.Location = new System.Drawing.Point(549, 567);
            this.btnCloseChangePassword.Name = "btnCloseChangePassword";
            this.btnCloseChangePassword.Size = new System.Drawing.Size(116, 36);
            this.btnCloseChangePassword.TabIndex = 4;
            this.btnCloseChangePassword.Text = "Close";
            this.btnCloseChangePassword.UseVisualStyleBackColor = true;
            this.btnCloseChangePassword.Click += new System.EventHandler(this.btnCloseChangePassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(49, 485);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(115, 17);
            this.lblNewPassword.TabIndex = 35;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(27, 522);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(139, 17);
            this.lblConfirmPassword.TabIndex = 34;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentPassword.Location = new System.Drawing.Point(29, 447);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(138, 17);
            this.lblCurrentPassword.TabIndex = 33;
            this.lblCurrentPassword.Text = "Current Password:";
            this.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(223, 515);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(128, 21);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(223, 447);
            this.txtCurrentPassword.Multiline = true;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(128, 21);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPassword_KeyPress);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(223, 481);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(128, 21);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPassword_KeyPress);
            // 
            // btnSaveChangePassword
            // 
            this.btnSaveChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChangePassword.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChangePassword.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnSaveChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChangePassword.Location = new System.Drawing.Point(678, 567);
            this.btnSaveChangePassword.Name = "btnSaveChangePassword";
            this.btnSaveChangePassword.Size = new System.Drawing.Size(116, 36);
            this.btnSaveChangePassword.TabIndex = 3;
            this.btnSaveChangePassword.Text = "Save";
            this.btnSaveChangePassword.UseVisualStyleBackColor = true;
            this.btnSaveChangePassword.Click += new System.EventHandler(this.btnSaveChangePassword_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucLoginInfo1
            // 
            this.ucLoginInfo1.Location = new System.Drawing.Point(10, 320);
            this.ucLoginInfo1.Name = "ucLoginInfo1";
            this.ucLoginInfo1.Size = new System.Drawing.Size(802, 97);
            this.ucLoginInfo1.TabIndex = 57;
            // 
            // UCUserInfoforChangePassword
            // 
            this.UCUserInfoforChangePassword.Location = new System.Drawing.Point(10, 11);
            this.UCUserInfoforChangePassword.Name = "UCUserInfoforChangePassword";
            this.UCUserInfoforChangePassword.Size = new System.Drawing.Size(802, 303);
            this.UCUserInfoforChangePassword.TabIndex = 23;
            // 
            // pbPersoneNationalNo
            // 
            this.pbPersoneNationalNo.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbPersoneNationalNo.Location = new System.Drawing.Point(187, 447);
            this.pbPersoneNationalNo.Name = "pbPersoneNationalNo";
            this.pbPersoneNationalNo.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneNationalNo.TabIndex = 59;
            this.pbPersoneNationalNo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(187, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(187, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPersoneNationalNo);
            this.Controls.Add(this.ucLoginInfo1);
            this.Controls.Add(this.btnSaveChangePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.btnCloseChangePassword);
            this.Controls.Add(this.UCUserInfoforChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseChangePassword;
        private UCPersonefo UCUserInfoforChangePassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSaveChangePassword;
        private UCLoginInfo ucLoginInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPersoneNationalNo;
    }
}