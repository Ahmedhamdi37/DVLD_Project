namespace DVLD_Project
{
    partial class UCAddOrEditPersone
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddOrEditPersone));
            this.llPersoneSetImage = new System.Windows.Forms.LinkLabel();
            this.cbPersoneCountry = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblThirdName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.llPersoneRemoveImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbPersoneCountry = new System.Windows.Forms.PictureBox();
            this.pbPersonePhone = new System.Windows.Forms.PictureBox();
            this.pbPersoneDateOfBirth = new System.Windows.Forms.PictureBox();
            this.pbGendorWoman = new System.Windows.Forms.PictureBox();
            this.pbPersoneAddress = new System.Windows.Forms.PictureBox();
            this.pbPersoneEmail = new System.Windows.Forms.PictureBox();
            this.pbGendorMan = new System.Windows.Forms.PictureBox();
            this.pbPersoneNationalNo = new System.Windows.Forms.PictureBox();
            this.pbPersoneName = new System.Windows.Forms.PictureBox();
            this.pbPersoneImage = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendorWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendorMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // llPersoneSetImage
            // 
            this.llPersoneSetImage.AutoSize = true;
            this.llPersoneSetImage.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPersoneSetImage.Location = new System.Drawing.Point(670, 308);
            this.llPersoneSetImage.Name = "llPersoneSetImage";
            this.llPersoneSetImage.Size = new System.Drawing.Size(95, 21);
            this.llPersoneSetImage.TabIndex = 13;
            this.llPersoneSetImage.TabStop = true;
            this.llPersoneSetImage.Text = "Set Imagee";
            this.llPersoneSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPersoneSetImage_LinkClicked);
            // 
            // cbPersoneCountry
            // 
            this.cbPersoneCountry.BackColor = System.Drawing.Color.DarkGray;
            this.cbPersoneCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPersoneCountry.FormattingEnabled = true;
            this.cbPersoneCountry.Location = new System.Drawing.Point(476, 202);
            this.cbPersoneCountry.Name = "cbPersoneCountry";
            this.cbPersoneCountry.Size = new System.Drawing.Size(128, 21);
            this.cbPersoneCountry.TabIndex = 11;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(476, 128);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(128, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            this.dtpDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateOfBirth_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(476, 163);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 21);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateOfBirth.Location = new System.Drawing.Point(346, 132);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(103, 17);
            this.lblDateOfBirth.TabIndex = 49;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhone.Location = new System.Drawing.Point(391, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 17);
            this.lblPhone.TabIndex = 48;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCountry.Location = new System.Drawing.Point(380, 206);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(70, 17);
            this.lblCountry.TabIndex = 47;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(250, 165);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(68, 21);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(161, 168);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(52, 21);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(161, 254);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(443, 120);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(161, 201);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 42);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalNumber.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNumber.Location = new System.Drawing.Point(161, 128);
            this.txtNationalNumber.Multiline = true;
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(128, 21);
            this.txtNationalNumber.TabIndex = 5;
            this.txtNationalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNumber_Validating);
            this.txtNationalNumber.Validated += new System.EventHandler(this.txtNationalNumber_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(645, 85);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(128, 21);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtThirdName
            // 
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.Location = new System.Drawing.Point(483, 88);
            this.txtThirdName.Multiline = true;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(128, 21);
            this.txtThirdName.TabIndex = 3;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThirdName_KeyPress);
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtThirdName_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(322, 88);
            this.txtSecondName.Multiline = true;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(128, 21);
            this.txtSecondName.TabIndex = 1;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondName_KeyPress);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(161, 88);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(128, 21);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(345, 54);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(66, 23);
            this.lblSecondName.TabIndex = 36;
            this.lblSecondName.Text = "Second";
            // 
            // lblThirdName
            // 
            this.lblThirdName.AutoSize = true;
            this.lblThirdName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdName.Location = new System.Drawing.Point(515, 54);
            this.lblThirdName.Name = "lblThirdName";
            this.lblThirdName.Size = new System.Drawing.Size(49, 23);
            this.lblThirdName.TabIndex = 35;
            this.lblThirdName.Text = "Third";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(669, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(40, 23);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "Last";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(197, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(41, 23);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.Location = new System.Drawing.Point(40, 128);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(94, 17);
            this.lblNationalNo.TabIndex = 32;
            this.lblNationalNo.Text = "National No:";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.Location = new System.Drawing.Point(40, 167);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(64, 17);
            this.lblGendor.TabIndex = 31;
            this.lblGendor.Text = "Gendor:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(40, 245);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 17);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(40, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Person 32.png");
            this.imageList1.Images.SetKeyName(1, "Number 32.png");
            this.imageList1.Images.SetKeyName(2, "Man 32.png");
            this.imageList1.Images.SetKeyName(3, "Woman 32.png");
            this.imageList1.Images.SetKeyName(4, "Email 32.png");
            this.imageList1.Images.SetKeyName(5, "Address 32.png");
            this.imageList1.Images.SetKeyName(6, "Calendar 32.png");
            this.imageList1.Images.SetKeyName(7, "Country 32.png");
            // 
            // llPersoneRemoveImage
            // 
            this.llPersoneRemoveImage.AutoSize = true;
            this.llPersoneRemoveImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPersoneRemoveImage.Location = new System.Drawing.Point(680, 343);
            this.llPersoneRemoveImage.Name = "llPersoneRemoveImage";
            this.llPersoneRemoveImage.Size = new System.Drawing.Size(53, 16);
            this.llPersoneRemoveImage.TabIndex = 56;
            this.llPersoneRemoveImage.TabStop = true;
            this.llPersoneRemoveImage.Text = "Remove";
            this.llPersoneRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPersoneRemoveImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbPersoneCountry
            // 
            this.pbPersoneCountry.Image = global::DVLD_Project.Properties.Resources.Country_32;
            this.pbPersoneCountry.Location = new System.Drawing.Point(440, 199);
            this.pbPersoneCountry.Name = "pbPersoneCountry";
            this.pbPersoneCountry.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneCountry.TabIndex = 65;
            this.pbPersoneCountry.TabStop = false;
            // 
            // pbPersonePhone
            // 
            this.pbPersonePhone.Image = global::DVLD_Project.Properties.Resources.Phone_32;
            this.pbPersonePhone.Location = new System.Drawing.Point(440, 160);
            this.pbPersonePhone.Name = "pbPersonePhone";
            this.pbPersonePhone.Size = new System.Drawing.Size(30, 24);
            this.pbPersonePhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonePhone.TabIndex = 64;
            this.pbPersonePhone.TabStop = false;
            // 
            // pbPersoneDateOfBirth
            // 
            this.pbPersoneDateOfBirth.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbPersoneDateOfBirth.Location = new System.Drawing.Point(440, 124);
            this.pbPersoneDateOfBirth.Name = "pbPersoneDateOfBirth";
            this.pbPersoneDateOfBirth.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneDateOfBirth.TabIndex = 63;
            this.pbPersoneDateOfBirth.TabStop = false;
            // 
            // pbGendorWoman
            // 
            this.pbGendorWoman.Image = global::DVLD_Project.Properties.Resources.Woman_32;
            this.pbGendorWoman.Location = new System.Drawing.Point(219, 160);
            this.pbGendorWoman.Name = "pbGendorWoman";
            this.pbGendorWoman.Size = new System.Drawing.Size(30, 24);
            this.pbGendorWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGendorWoman.TabIndex = 62;
            this.pbGendorWoman.TabStop = false;
            // 
            // pbPersoneAddress
            // 
            this.pbPersoneAddress.Image = global::DVLD_Project.Properties.Resources.Address_32;
            this.pbPersoneAddress.Location = new System.Drawing.Point(125, 254);
            this.pbPersoneAddress.Name = "pbPersoneAddress";
            this.pbPersoneAddress.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneAddress.TabIndex = 61;
            this.pbPersoneAddress.TabStop = false;
            // 
            // pbPersoneEmail
            // 
            this.pbPersoneEmail.Image = global::DVLD_Project.Properties.Resources.Email_32;
            this.pbPersoneEmail.Location = new System.Drawing.Point(125, 199);
            this.pbPersoneEmail.Name = "pbPersoneEmail";
            this.pbPersoneEmail.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneEmail.TabIndex = 60;
            this.pbPersoneEmail.TabStop = false;
            // 
            // pbGendorMan
            // 
            this.pbGendorMan.Image = global::DVLD_Project.Properties.Resources.Man_32;
            this.pbGendorMan.Location = new System.Drawing.Point(125, 160);
            this.pbGendorMan.Name = "pbGendorMan";
            this.pbGendorMan.Size = new System.Drawing.Size(30, 24);
            this.pbGendorMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGendorMan.TabIndex = 59;
            this.pbGendorMan.TabStop = false;
            // 
            // pbPersoneNationalNo
            // 
            this.pbPersoneNationalNo.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbPersoneNationalNo.Location = new System.Drawing.Point(125, 124);
            this.pbPersoneNationalNo.Name = "pbPersoneNationalNo";
            this.pbPersoneNationalNo.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneNationalNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneNationalNo.TabIndex = 58;
            this.pbPersoneNationalNo.TabStop = false;
            // 
            // pbPersoneName
            // 
            this.pbPersoneName.Image = global::DVLD_Project.Properties.Resources.Person_32;
            this.pbPersoneName.Location = new System.Drawing.Point(125, 85);
            this.pbPersoneName.Name = "pbPersoneName";
            this.pbPersoneName.Size = new System.Drawing.Size(30, 24);
            this.pbPersoneName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneName.TabIndex = 57;
            this.pbPersoneName.TabStop = false;
            // 
            // pbPersoneImage
            // 
            this.pbPersoneImage.Location = new System.Drawing.Point(627, 128);
            this.pbPersoneImage.Name = "pbPersoneImage";
            this.pbPersoneImage.Size = new System.Drawing.Size(147, 160);
            this.pbPersoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersoneImage.TabIndex = 41;
            this.pbPersoneImage.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCAddOrEditPersone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbPersoneCountry);
            this.Controls.Add(this.pbPersonePhone);
            this.Controls.Add(this.pbPersoneDateOfBirth);
            this.Controls.Add(this.pbGendorWoman);
            this.Controls.Add(this.pbPersoneAddress);
            this.Controls.Add(this.pbPersoneEmail);
            this.Controls.Add(this.pbGendorMan);
            this.Controls.Add(this.pbPersoneNationalNo);
            this.Controls.Add(this.pbPersoneName);
            this.Controls.Add(this.llPersoneRemoveImage);
            this.Controls.Add(this.llPersoneSetImage);
            this.Controls.Add(this.cbPersoneCountry);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNationalNumber);
            this.Controls.Add(this.pbPersoneImage);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblThirdName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNationalNo);
            this.Controls.Add(this.lblGendor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "UCAddOrEditPersone";
            this.Size = new System.Drawing.Size(820, 445);
            this.Load += new System.EventHandler(this.UCAddOrEditPersone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendorWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendorMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersoneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llPersoneSetImage;
        private System.Windows.Forms.ComboBox cbPersoneCountry;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.PictureBox pbPersoneImage;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblThirdName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel llPersoneRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbPersoneName;
        private System.Windows.Forms.PictureBox pbPersoneNationalNo;
        private System.Windows.Forms.PictureBox pbGendorMan;
        private System.Windows.Forms.PictureBox pbPersoneEmail;
        private System.Windows.Forms.PictureBox pbPersoneAddress;
        private System.Windows.Forms.PictureBox pbGendorWoman;
        private System.Windows.Forms.PictureBox pbPersoneDateOfBirth;
        private System.Windows.Forms.PictureBox pbPersonePhone;
        private System.Windows.Forms.PictureBox pbPersoneCountry;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
