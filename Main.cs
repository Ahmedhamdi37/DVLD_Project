using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class MainFrm : Form
    {
        public delegate void DataBackEventHandler(object sender,bool IsSignOut);
        public static event DataBackEventHandler DataBack;

        public MainFrm()
        {
            InitializeComponent();

            //Configration to Logg Event
            DVLD.Utilities.clsLogger.Configure();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPeople = new frmPeople();

            frmPeople.ShowDialog();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUsers = new frmUsers();  
            frmUsers.ShowDialog();
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDrivers = new frmDrivers();
            frmDrivers.ShowDialog();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUserInfoK = new frmUserInfo(clsUtilities.User.PersonID);
            frmUserInfoK.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmChangePasswordK = new frmChangePassword(clsUtilities.User.PersonID);
            frmChangePasswordK.ShowDialog();
        }
        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmDetainLicenseK = new frmDetainLicense();
            frmDetainLicenseK.ShowDialog();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmNewLocalLicenseApplicationK = new frmNewLocalLicense();
            frmNewLocalLicenseApplicationK.ShowDialog();
        }
        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLocalLicenseApplicatonsK = new frmLocalDrivinglicenseApplications();
            frmLocalLicenseApplicatonsK.ShowDialog();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = clsUtilities.SendMessageToDialoge("Are you sure SignOut!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result ==DialogResult.OK)
            {
                this.Close();
                DataBack?.Invoke(this,true);
                this.Close();
            }
        }
        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmManageApplicationTypes();
            frm.ShowDialog();
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmManageTestTypes();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmNewInternationalLicenseApplication = new FrmNewInternationalLicenseApplication();
            FrmNewInternationalLicenseApplication.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmListInternationalLicense = new ListInternationalLicenseApplications();
            FrmListInternationalLicense.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmRenewLicenseApplication = new FrmRenewLicenseApplication();
            FrmRenewLicenseApplication.ShowDialog();
        }
    }
}
