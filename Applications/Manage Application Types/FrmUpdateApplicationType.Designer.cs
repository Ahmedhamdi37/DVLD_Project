namespace DVLD_Project
{
    partial class FrmUpdateApplicationType
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
            this.lblUpdateApplicationTypeType = new System.Windows.Forms.Label();
            this.txtApplicationTypeTitle = new System.Windows.Forms.TextBox();
            this.txtApplicatinTypeFees = new System.Windows.Forms.TextBox();
            this.lblApplicationTypeIDK = new System.Windows.Forms.Label();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.lblApplicationTypeTitle = new System.Windows.Forms.Label();
            this.lblApplicationTypeFees = new System.Windows.Forms.Label();
            this.btnApplicationTypeSave = new System.Windows.Forms.Button();
            this.btnApplicationTypeClose = new System.Windows.Forms.Button();
            this.pbApplicationTypeTitle = new System.Windows.Forms.PictureBox();
            this.pbApplicationTypeFees = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypeFees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateApplicationTypeType
            // 
            this.lblUpdateApplicationTypeType.AutoSize = true;
            this.lblUpdateApplicationTypeType.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateApplicationTypeType.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateApplicationTypeType.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUpdateApplicationTypeType.Location = new System.Drawing.Point(33, 27);
            this.lblUpdateApplicationTypeType.Name = "lblUpdateApplicationTypeType";
            this.lblUpdateApplicationTypeType.Size = new System.Drawing.Size(352, 35);
            this.lblUpdateApplicationTypeType.TabIndex = 23;
            this.lblUpdateApplicationTypeType.Text = "Update Applicatin Type";
            // 
            // txtApplicationTypeTitle
            // 
            this.txtApplicationTypeTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicationTypeTitle.Location = new System.Drawing.Point(138, 127);
            this.txtApplicationTypeTitle.Multiline = true;
            this.txtApplicationTypeTitle.Name = "txtApplicationTypeTitle";
            this.txtApplicationTypeTitle.Size = new System.Drawing.Size(247, 24);
            this.txtApplicationTypeTitle.TabIndex = 62;
            this.txtApplicationTypeTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApplicationTitle_KeyPress);
            // 
            // txtApplicatinTypeFees
            // 
            this.txtApplicatinTypeFees.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicatinTypeFees.Location = new System.Drawing.Point(138, 160);
            this.txtApplicatinTypeFees.Multiline = true;
            this.txtApplicatinTypeFees.Name = "txtApplicatinTypeFees";
            this.txtApplicatinTypeFees.Size = new System.Drawing.Size(247, 24);
            this.txtApplicatinTypeFees.TabIndex = 63;
            this.txtApplicatinTypeFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApplicatinFees_KeyPress);
            // 
            // lblApplicationTypeIDK
            // 
            this.lblApplicationTypeIDK.AutoSize = true;
            this.lblApplicationTypeIDK.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypeIDK.Location = new System.Drawing.Point(138, 92);
            this.lblApplicationTypeIDK.Name = "lblApplicationTypeIDK";
            this.lblApplicationTypeIDK.Size = new System.Drawing.Size(34, 21);
            this.lblApplicationTypeIDK.TabIndex = 69;
            this.lblApplicationTypeIDK.Text = "???";
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypeID.Location = new System.Drawing.Point(40, 92);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(34, 21);
            this.lblApplicationTypeID.TabIndex = 68;
            this.lblApplicationTypeID.Text = "ID:";
            // 
            // lblApplicationTypeTitle
            // 
            this.lblApplicationTypeTitle.AutoSize = true;
            this.lblApplicationTypeTitle.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypeTitle.Location = new System.Drawing.Point(25, 127);
            this.lblApplicationTypeTitle.Name = "lblApplicationTypeTitle";
            this.lblApplicationTypeTitle.Size = new System.Drawing.Size(49, 21);
            this.lblApplicationTypeTitle.TabIndex = 70;
            this.lblApplicationTypeTitle.Text = "Title:";
            // 
            // lblApplicationTypeFees
            // 
            this.lblApplicationTypeFees.AutoSize = true;
            this.lblApplicationTypeFees.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTypeFees.Location = new System.Drawing.Point(23, 160);
            this.lblApplicationTypeFees.Name = "lblApplicationTypeFees";
            this.lblApplicationTypeFees.Size = new System.Drawing.Size(51, 21);
            this.lblApplicationTypeFees.TabIndex = 71;
            this.lblApplicationTypeFees.Text = "Fees:";
            // 
            // btnApplicationTypeSave
            // 
            this.btnApplicationTypeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationTypeSave.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationTypeSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnApplicationTypeSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationTypeSave.Location = new System.Drawing.Point(266, 206);
            this.btnApplicationTypeSave.Name = "btnApplicationTypeSave";
            this.btnApplicationTypeSave.Size = new System.Drawing.Size(119, 36);
            this.btnApplicationTypeSave.TabIndex = 72;
            this.btnApplicationTypeSave.Text = "Save";
            this.btnApplicationTypeSave.UseVisualStyleBackColor = true;
            this.btnApplicationTypeSave.Click += new System.EventHandler(this.btnApplicationTypeSave_Click);
            // 
            // btnApplicationTypeClose
            // 
            this.btnApplicationTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationTypeClose.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationTypeClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnApplicationTypeClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationTypeClose.Location = new System.Drawing.Point(141, 206);
            this.btnApplicationTypeClose.Name = "btnApplicationTypeClose";
            this.btnApplicationTypeClose.Size = new System.Drawing.Size(119, 36);
            this.btnApplicationTypeClose.TabIndex = 73;
            this.btnApplicationTypeClose.Text = "Close";
            this.btnApplicationTypeClose.UseVisualStyleBackColor = true;
            this.btnApplicationTypeClose.Click += new System.EventHandler(this.btnApplicationTypeClose_Click);
            // 
            // pbApplicationTypeTitle
            // 
            this.pbApplicationTypeTitle.Image = global::DVLD_Project.Properties.Resources.ApplicationTitle;
            this.pbApplicationTypeTitle.Location = new System.Drawing.Point(92, 127);
            this.pbApplicationTypeTitle.Name = "pbApplicationTypeTitle";
            this.pbApplicationTypeTitle.Size = new System.Drawing.Size(30, 24);
            this.pbApplicationTypeTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationTypeTitle.TabIndex = 67;
            this.pbApplicationTypeTitle.TabStop = false;
            // 
            // pbApplicationTypeFees
            // 
            this.pbApplicationTypeFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbApplicationTypeFees.Location = new System.Drawing.Point(92, 160);
            this.pbApplicationTypeFees.Name = "pbApplicationTypeFees";
            this.pbApplicationTypeFees.Size = new System.Drawing.Size(30, 24);
            this.pbApplicationTypeFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationTypeFees.TabIndex = 66;
            this.pbApplicationTypeFees.TabStop = false;
            // 
            // FrmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 254);
            this.Controls.Add(this.btnApplicationTypeSave);
            this.Controls.Add(this.btnApplicationTypeClose);
            this.Controls.Add(this.lblApplicationTypeFees);
            this.Controls.Add(this.lblApplicationTypeTitle);
            this.Controls.Add(this.lblApplicationTypeIDK);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.txtApplicationTypeTitle);
            this.Controls.Add(this.txtApplicatinTypeFees);
            this.Controls.Add(this.pbApplicationTypeTitle);
            this.Controls.Add(this.pbApplicationTypeFees);
            this.Controls.Add(this.lblUpdateApplicationTypeType);
            this.Name = "FrmUpdateApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateApplicationType";
            this.Load += new System.EventHandler(this.FrmUpdateApplicationType_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypeFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateApplicationTypeType;
        private System.Windows.Forms.TextBox txtApplicationTypeTitle;
        private System.Windows.Forms.TextBox txtApplicatinTypeFees;
        private System.Windows.Forms.PictureBox pbApplicationTypeTitle;
        private System.Windows.Forms.PictureBox pbApplicationTypeFees;
        private System.Windows.Forms.Label lblApplicationTypeIDK;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Label lblApplicationTypeTitle;
        private System.Windows.Forms.Label lblApplicationTypeFees;
        private System.Windows.Forms.Button btnApplicationTypeSave;
        private System.Windows.Forms.Button btnApplicationTypeClose;
    }
}