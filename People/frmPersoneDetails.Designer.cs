namespace DVLD_Project
{
    partial class frmPersoneDetails
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
            this.lblPersoneDetailsTitle = new System.Windows.Forms.Label();
            this.btnUsersClose = new System.Windows.Forms.Button();
            this.UCUserInfoC1 = new DVLD_Project.UCPersonefo();
            this.SuspendLayout();
            // 
            // lblPersoneDetailsTitle
            // 
            this.lblPersoneDetailsTitle.AutoSize = true;
            this.lblPersoneDetailsTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblPersoneDetailsTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoneDetailsTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPersoneDetailsTitle.Location = new System.Drawing.Point(286, 58);
            this.lblPersoneDetailsTitle.Name = "lblPersoneDetailsTitle";
            this.lblPersoneDetailsTitle.Size = new System.Drawing.Size(198, 29);
            this.lblPersoneDetailsTitle.TabIndex = 26;
            this.lblPersoneDetailsTitle.Text = "Persone Details";
            // 
            // btnUsersClose
            // 
            this.btnUsersClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnUsersClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersClose.Location = new System.Drawing.Point(660, 380);
            this.btnUsersClose.Name = "btnUsersClose";
            this.btnUsersClose.Size = new System.Drawing.Size(116, 36);
            this.btnUsersClose.TabIndex = 25;
            this.btnUsersClose.Text = "Close";
            this.btnUsersClose.UseVisualStyleBackColor = true;
            this.btnUsersClose.Click += new System.EventHandler(this.btnUsersClose_Click);
            // 
            // UCUserInfoC1
            // 
            this.UCUserInfoC1.Location = new System.Drawing.Point(15, 90);
            this.UCUserInfoC1.Name = "UCUserInfoC1";
            this.UCUserInfoC1.Size = new System.Drawing.Size(777, 284);
            this.UCUserInfoC1.TabIndex = 23;
            // 
            // frmPersoneDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 429);
            this.Controls.Add(this.lblPersoneDetailsTitle);
            this.Controls.Add(this.btnUsersClose);
            this.Controls.Add(this.UCUserInfoC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersoneDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.frmPersoneDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsersClose;
        private UCPersonefo UCUserInfoC1;
        private System.Windows.Forms.Label lblPersoneDetailsTitle;
    }
}