namespace DVLD_Project
{
    partial class frmIssueDriveLicenseForTheFirstTime
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
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotesResult = new System.Windows.Forms.TextBox();
            this.btnStreetScheduleTestClose = new System.Windows.Forms.Button();
            this.btnStreetScheduleTestSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(20, 459);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 21);
            this.lblNotes.TabIndex = 105;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotesResult
            // 
            this.txtNotesResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotesResult.Location = new System.Drawing.Point(125, 462);
            this.txtNotesResult.Multiline = true;
            this.txtNotesResult.Name = "txtNotesResult";
            this.txtNotesResult.Size = new System.Drawing.Size(709, 140);
            this.txtNotesResult.TabIndex = 104;
            // 
            // btnStreetScheduleTestClose
            // 
            this.btnStreetScheduleTestClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreetScheduleTestClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreetScheduleTestClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnStreetScheduleTestClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStreetScheduleTestClose.Location = new System.Drawing.Point(585, 609);
            this.btnStreetScheduleTestClose.Name = "btnStreetScheduleTestClose";
            this.btnStreetScheduleTestClose.Size = new System.Drawing.Size(116, 36);
            this.btnStreetScheduleTestClose.TabIndex = 107;
            this.btnStreetScheduleTestClose.Text = "Close";
            this.btnStreetScheduleTestClose.UseVisualStyleBackColor = true;
            // 
            // btnStreetScheduleTestSave
            // 
            this.btnStreetScheduleTestSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreetScheduleTestSave.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreetScheduleTestSave.Image = global::DVLD_Project.Properties.Resources.New_Driving_License_321;
            this.btnStreetScheduleTestSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStreetScheduleTestSave.Location = new System.Drawing.Point(705, 608);
            this.btnStreetScheduleTestSave.Name = "btnStreetScheduleTestSave";
            this.btnStreetScheduleTestSave.Size = new System.Drawing.Size(129, 36);
            this.btnStreetScheduleTestSave.TabIndex = 106;
            this.btnStreetScheduleTestSave.Text = "Issue";
            this.btnStreetScheduleTestSave.UseVisualStyleBackColor = true;
            // 
            // frmIssueDriveLicenseForTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 654);
            this.Controls.Add(this.btnStreetScheduleTestClose);
            this.Controls.Add(this.btnStreetScheduleTestSave);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotesResult);
            this.Name = "frmIssueDriveLicenseForTheFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Drive License For The First Time";
            this.Load += new System.EventHandler(this.frmIssueDriveLicenseForTheFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
      
        private System.Windows.Forms.Button btnStreetScheduleTestClose;
        private System.Windows.Forms.Button btnStreetScheduleTestSave;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotesResult;
    }
}