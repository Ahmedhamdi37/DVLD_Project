namespace DVLD_Project
{
    partial class frmUserInfo
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
            this.btnUsersClose = new System.Windows.Forms.Button();
            this.UCUserInfoC = new DVLD_Project.UCPersonefo();
            this.ucLoginInfo1 = new DVLD_Project.UCLoginInfo();
            this.SuspendLayout();
            // 
            // btnUsersClose
            // 
            this.btnUsersClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnUsersClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersClose.Location = new System.Drawing.Point(688, 427);
            this.btnUsersClose.Name = "btnUsersClose";
            this.btnUsersClose.Size = new System.Drawing.Size(124, 36);
            this.btnUsersClose.TabIndex = 22;
            this.btnUsersClose.Text = "Close";
            this.btnUsersClose.UseVisualStyleBackColor = true;
            this.btnUsersClose.Click += new System.EventHandler(this.btnUsersClose_Click);
            // 
            // UCUserInfoC
            // 
            this.UCUserInfoC.Location = new System.Drawing.Point(10, 12);
            this.UCUserInfoC.Name = "UCUserInfoC";
            this.UCUserInfoC.Size = new System.Drawing.Size(802, 313);
            this.UCUserInfoC.TabIndex = 0;
            // 
            // ucLoginInfo1
            // 
            this.ucLoginInfo1.Location = new System.Drawing.Point(10, 331);
            this.ucLoginInfo1.Name = "ucLoginInfo1";
            this.ucLoginInfo1.Size = new System.Drawing.Size(802, 90);
            this.ucLoginInfo1.TabIndex = 23;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 476);
            this.Controls.Add(this.ucLoginInfo1);
            this.Controls.Add(this.btnUsersClose);
            this.Controls.Add(this.UCUserInfoC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPersonefo UCUserInfoC;
        private System.Windows.Forms.Button btnUsersClose;
        private UCLoginInfo ucLoginInfo1;
    }
}