namespace DVLD_Project
{
    partial class UCLoginInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblUserIsActiveInfoK = new System.Windows.Forms.Label();
            this.lblUserIDInfoK = new System.Windows.Forms.Label();
            this.lblUserNameInfoK = new System.Windows.Forms.Label();
            this.lblUserIsActiveInfo = new System.Windows.Forms.Label();
            this.lblUserNameInfo = new System.Windows.Forms.Label();
            this.lblUserIDInfo = new System.Windows.Forms.Label();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Controls.Add(this.lblUserIsActiveInfoK);
            this.gbLoginInfo.Controls.Add(this.lblUserIDInfoK);
            this.gbLoginInfo.Controls.Add(this.lblUserNameInfoK);
            this.gbLoginInfo.Controls.Add(this.lblUserIsActiveInfo);
            this.gbLoginInfo.Controls.Add(this.lblUserNameInfo);
            this.gbLoginInfo.Controls.Add(this.lblUserIDInfo);
            this.gbLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLoginInfo.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginInfo.Location = new System.Drawing.Point(0, 0);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(809, 97);
            this.gbLoginInfo.TabIndex = 9;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Login Information";
          
            // 
            // lblUserIsActiveInfoK
            // 
            this.lblUserIsActiveInfoK.AutoSize = true;
            this.lblUserIsActiveInfoK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIsActiveInfoK.Location = new System.Drawing.Point(632, 46);
            this.lblUserIsActiveInfoK.Name = "lblUserIsActiveInfoK";
            this.lblUserIsActiveInfoK.Size = new System.Drawing.Size(34, 21);
            this.lblUserIsActiveInfoK.TabIndex = 13;
            this.lblUserIsActiveInfoK.Text = "???";
            // 
            // lblUserIDInfoK
            // 
            this.lblUserIDInfoK.AutoSize = true;
            this.lblUserIDInfoK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDInfoK.Location = new System.Drawing.Point(197, 46);
            this.lblUserIDInfoK.Name = "lblUserIDInfoK";
            this.lblUserIDInfoK.Size = new System.Drawing.Size(34, 21);
            this.lblUserIDInfoK.TabIndex = 12;
            this.lblUserIDInfoK.Text = "???";
            // 
            // lblUserNameInfoK
            // 
            this.lblUserNameInfoK.AutoSize = true;
            this.lblUserNameInfoK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameInfoK.Location = new System.Drawing.Point(402, 46);
            this.lblUserNameInfoK.Name = "lblUserNameInfoK";
            this.lblUserNameInfoK.Size = new System.Drawing.Size(34, 21);
            this.lblUserNameInfoK.TabIndex = 11;
            this.lblUserNameInfoK.Text = "???";
            // 
            // lblUserIsActiveInfo
            // 
            this.lblUserIsActiveInfo.AutoSize = true;
            this.lblUserIsActiveInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIsActiveInfo.Location = new System.Drawing.Point(552, 46);
            this.lblUserIsActiveInfo.Name = "lblUserIsActiveInfo";
            this.lblUserIsActiveInfo.Size = new System.Drawing.Size(81, 21);
            this.lblUserIsActiveInfo.TabIndex = 10;
            this.lblUserIsActiveInfo.Text = "Is Active:";
            // 
            // lblUserNameInfo
            // 
            this.lblUserNameInfo.AutoSize = true;
            this.lblUserNameInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameInfo.Location = new System.Drawing.Point(309, 46);
            this.lblUserNameInfo.Name = "lblUserNameInfo";
            this.lblUserNameInfo.Size = new System.Drawing.Size(93, 21);
            this.lblUserNameInfo.TabIndex = 9;
            this.lblUserNameInfo.Text = "UserName:";
            // 
            // lblUserIDInfo
            // 
            this.lblUserIDInfo.AutoSize = true;
            this.lblUserIDInfo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDInfo.Location = new System.Drawing.Point(129, 46);
            this.lblUserIDInfo.Name = "lblUserIDInfo";
            this.lblUserIDInfo.Size = new System.Drawing.Size(68, 21);
            this.lblUserIDInfo.TabIndex = 8;
            this.lblUserIDInfo.Text = "UserID:";
            // 
            // UCLoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbLoginInfo);
            this.Name = "UCLoginInfo";
            this.Size = new System.Drawing.Size(809, 97);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label lblUserIsActiveInfoK;
        private System.Windows.Forms.Label lblUserIDInfoK;
        private System.Windows.Forms.Label lblUserNameInfoK;
        private System.Windows.Forms.Label lblUserIsActiveInfo;
        private System.Windows.Forms.Label lblUserNameInfo;
        private System.Windows.Forms.Label lblUserIDInfo;
    }
}
