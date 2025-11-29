namespace DVLD_Project
{
    partial class FrmLoginScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescrition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbLogoLoginScreen = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.CBRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnCloseLoginScreen = new System.Windows.Forms.Button();
            this.lblLoginInyourAccount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLoginScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblDescrition);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pbLogoLoginScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 433);
            this.panel1.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(100, 298);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 16);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblDescrition
            // 
            this.lblDescrition.AutoSize = true;
            this.lblDescrition.BackColor = System.Drawing.Color.Black;
            this.lblDescrition.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrition.ForeColor = System.Drawing.Color.White;
            this.lblDescrition.Location = new System.Drawing.Point(39, 222);
            this.lblDescrition.Name = "lblDescrition";
            this.lblDescrition.Size = new System.Drawing.Size(210, 23);
            this.lblDescrition.TabIndex = 4;
            this.lblDescrition.Text = "DRIVING && VEHICLE";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Black;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(28, 251);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(233, 23);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "LICENSE DEPARTMENT";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(73, 193);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(143, 23);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME TO";
            // 
            // pbLogoLoginScreen
            // 
            this.pbLogoLoginScreen.Image = global::DVLD_Project.Properties.Resources.IconLogo;
            this.pbLogoLoginScreen.Location = new System.Drawing.Point(62, 46);
            this.pbLogoLoginScreen.Name = "pbLogoLoginScreen";
            this.pbLogoLoginScreen.Size = new System.Drawing.Size(164, 117);
            this.pbLogoLoginScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoLoginScreen.TabIndex = 0;
            this.pbLogoLoginScreen.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(342, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 18);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(342, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 18);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(535, 112);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(213, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Symbol", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(535, 82);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(213, 24);
            this.txtUserName.TabIndex = 0;
            // 
            // CBRememberMe
            // 
            this.CBRememberMe.AutoSize = true;
            this.CBRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRememberMe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRememberMe.Location = new System.Drawing.Point(535, 165);
            this.CBRememberMe.Name = "CBRememberMe";
            this.CBRememberMe.Size = new System.Drawing.Size(111, 20);
            this.CBRememberMe.TabIndex = 2;
            this.CBRememberMe.Text = "Remember Me.";
            this.CBRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::DVLD_Project.Properties.Resources.sign_in_32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(620, 208);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbUserName
            // 
            this.pbUserName.Image = global::DVLD_Project.Properties.Resources.Person_32;
            this.pbUserName.Location = new System.Drawing.Point(485, 82);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(30, 24);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserName.TabIndex = 61;
            this.pbUserName.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pbPassword.Location = new System.Drawing.Point(485, 112);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 24);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 60;
            this.pbPassword.TabStop = false;
            // 
            // btnCloseLoginScreen
            // 
            this.btnCloseLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLoginScreen.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoginScreen.Image = global::DVLD_Project.Properties.Resources.closeBlack32;
            this.btnCloseLoginScreen.Location = new System.Drawing.Point(750, 12);
            this.btnCloseLoginScreen.Name = "btnCloseLoginScreen";
            this.btnCloseLoginScreen.Size = new System.Drawing.Size(43, 36);
            this.btnCloseLoginScreen.TabIndex = 67;
            this.btnCloseLoginScreen.UseVisualStyleBackColor = true;
            this.btnCloseLoginScreen.Click += new System.EventHandler(this.btnCloseLoginScreen_Click);
            // 
            // lblLoginInyourAccount
            // 
            this.lblLoginInyourAccount.AutoSize = true;
            this.lblLoginInyourAccount.BackColor = System.Drawing.Color.White;
            this.lblLoginInyourAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInyourAccount.ForeColor = System.Drawing.Color.Black;
            this.lblLoginInyourAccount.Location = new System.Drawing.Point(451, 30);
            this.lblLoginInyourAccount.Name = "lblLoginInyourAccount";
            this.lblLoginInyourAccount.Size = new System.Drawing.Size(184, 19);
            this.lblLoginInyourAccount.TabIndex = 68;
            this.lblLoginInyourAccount.Text = "Login to your account";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 433);
            this.Controls.Add(this.lblLoginInyourAccount);
            this.Controls.Add(this.btnCloseLoginScreen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.CBRememberMe);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pbUserName);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginScreen";
            this.Load += new System.EventHandler(this.FrmLoginScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLoginScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbLogoLoginScreen;
        private System.Windows.Forms.Label lblDescrition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox CBRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCloseLoginScreen;
        private System.Windows.Forms.Label lblLoginInyourAccount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}