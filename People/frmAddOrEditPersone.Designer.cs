namespace DVLD_Project
{
    partial class frmAddOrEditPersone
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
            this.lblAddNewPersone = new System.Windows.Forms.Label();
            this.lblPersoneIDNo = new System.Windows.Forms.Label();
            this.lblPersoneID = new System.Windows.Forms.Label();
            this.btnPersoneSave = new System.Windows.Forms.Button();
            this.btnPersoneClose = new System.Windows.Forms.Button();
            this.pbPersoneID = new System.Windows.Forms.PictureBox();
            this.ucAddOrEditPersone1 = new DVLD_Project.UCAddOrEditPersone();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewPersone
            // 
            this.lblAddNewPersone.AutoSize = true;
            this.lblAddNewPersone.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddNewPersone.Font = new System.Drawing.Font("Tahoma", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPersone.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAddNewPersone.Location = new System.Drawing.Point(299, 9);
            this.lblAddNewPersone.Name = "lblAddNewPersone";
            this.lblAddNewPersone.Size = new System.Drawing.Size(254, 33);
            this.lblAddNewPersone.TabIndex = 20;
            this.lblAddNewPersone.Text = "Add New Persone";
            // 
            // lblPersoneIDNo
            // 
            this.lblPersoneIDNo.AutoSize = true;
            this.lblPersoneIDNo.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoneIDNo.Location = new System.Drawing.Point(175, 57);
            this.lblPersoneIDNo.Name = "lblPersoneIDNo";
            this.lblPersoneIDNo.Size = new System.Drawing.Size(45, 21);
            this.lblPersoneIDNo.TabIndex = 19;
            this.lblPersoneIDNo.Text = "N/A";
            // 
            // lblPersoneID
            // 
            this.lblPersoneID.AutoSize = true;
            this.lblPersoneID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoneID.Location = new System.Drawing.Point(13, 57);
            this.lblPersoneID.Name = "lblPersoneID";
            this.lblPersoneID.Size = new System.Drawing.Size(106, 21);
            this.lblPersoneID.TabIndex = 18;
            this.lblPersoneID.Text = "PersoneID:";
            // 
            // btnPersoneSave
            // 
            this.btnPersoneSave.Enabled = false;
            this.btnPersoneSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneSave.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoneSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnPersoneSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersoneSave.Location = new System.Drawing.Point(491, 475);
            this.btnPersoneSave.Name = "btnPersoneSave";
            this.btnPersoneSave.Size = new System.Drawing.Size(130, 36);
            this.btnPersoneSave.TabIndex = 55;
            this.btnPersoneSave.Text = "Save";
            this.btnPersoneSave.UseVisualStyleBackColor = true;
            this.btnPersoneSave.Click += new System.EventHandler(this.btnPersoneSave_Click);
            // 
            // btnPersoneClose
            // 
            this.btnPersoneClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPersoneClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoneClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnPersoneClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersoneClose.Location = new System.Drawing.Point(363, 475);
            this.btnPersoneClose.Name = "btnPersoneClose";
            this.btnPersoneClose.Size = new System.Drawing.Size(122, 36);
            this.btnPersoneClose.TabIndex = 54;
            this.btnPersoneClose.Text = "Close";
            this.btnPersoneClose.UseVisualStyleBackColor = true;
            this.btnPersoneClose.Click += new System.EventHandler(this.btnPersoneClose_Click);
            // 
            // pbPersoneID
            // 
            this.pbPersoneID.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbPersoneID.Location = new System.Drawing.Point(125, 57);
            this.pbPersoneID.Name = "pbPersoneID";
            this.pbPersoneID.Size = new System.Drawing.Size(30, 21);
            this.pbPersoneID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneID.TabIndex = 59;
            this.pbPersoneID.TabStop = false;
            // 
            // ucAddOrEditPersone1
            // 
            this.ucAddOrEditPersone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAddOrEditPersone1.Location = new System.Drawing.Point(17, 95);
            this.ucAddOrEditPersone1.Name = "ucAddOrEditPersone1";
            this.ucAddOrEditPersone1.Size = new System.Drawing.Size(825, 445);
            this.ucAddOrEditPersone1.TabIndex = 21;
            this.ucAddOrEditPersone1.PersoneSaved += new System.Action<int>(this.ucAddOrEditPersone1_PersoneSaved);
            this.ucAddOrEditPersone1.btnSave += new System.Action<bool>(this.ucAddOrEditPersone1_btnSave);
            // 
            // frmAddOrEditPersone
            // 
            this.AcceptButton = this.btnPersoneSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPersoneClose;
            this.ClientSize = new System.Drawing.Size(861, 552);
            this.Controls.Add(this.pbPersoneID);
            this.Controls.Add(this.btnPersoneSave);
            this.Controls.Add(this.btnPersoneClose);
            this.Controls.Add(this.ucAddOrEditPersone1);
            this.Controls.Add(this.lblAddNewPersone);
            this.Controls.Add(this.lblPersoneIDNo);
            this.Controls.Add(this.lblPersoneID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditPersone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrEditPersone";
            this.Load += new System.EventHandler(this.frmAddOrEditPersone_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewPersone;
        private System.Windows.Forms.Label lblPersoneIDNo;
        private System.Windows.Forms.Label lblPersoneID;
        private UCAddOrEditPersone ucAddOrEditPersone1;
        private System.Windows.Forms.Button btnPersoneClose;
        private System.Windows.Forms.Button btnPersoneSave;
        private System.Windows.Forms.PictureBox pbPersoneID;
    }
}