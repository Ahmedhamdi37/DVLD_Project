using ClsDVLDBusinessLayer;
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
    public partial class FrmIssueDriverLicense : Form
    {
        int _LDLAppID = -1;
        string _NationalNo = "";
        clsLocalDrivingLicenseApplication _LDLApp;
        clsLicenses _License;
        clsPerson _Person;
        clsLicenseClasses _LicenseClass;
        clsDrivers _Driver;

        public FrmIssueDriverLicense(int LDLAppID,string NationalNo)
        {
            _LDLAppID = LDLAppID;
            _NationalNo = NationalNo;

            InitializeComponent();
            _Person = clsPerson.Find(_NationalNo);
            _LDLApp = clsLocalDrivingLicenseApplication.FoundLocalLicenseApplication(_LDLAppID);
            _LicenseClass = clsLicenseClasses.Find(_LDLApp.LicenseClassID);
        }

        private void _HandleDriver()
        {
            _Driver = clsDrivers.Find(_Person.PersonID);
            if (_Driver == null)
            {
                _Driver = new clsDrivers();
                _Driver.PersonID = _Person.PersonID;
                _Driver.CreatedDate = DateTime.Now;
                _Driver.CratedByUserID = clsUtilities.User.UserID;
                _Driver.Save();
            }
        }

        private void FrmIssueDriverLicense_Load(object sender, EventArgs e)
        {
            ucApplicationInfo1.RecieveData(_LDLAppID);
            _HandleDriver();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillLiecenseInfo()
        {
            DateTime ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
            if (_Driver != null)
            {
                _License.DriverID = _Driver.DriverID;
            }

            _License.LicenseID = _LDLApp.LicenseClassID;
                _License.ApplicationID = _LDLApp.ApplicationID;
            _License.PersonID = _Person.PersonID;
            _License.LicenseClass = _LDLApp.LicenseClassID;
            _License.ExpirationDate = ExpirationDate;
            _License.Notes = txtNotes.Text;
            _License.PaidFees = _LicenseClass.ClassFees;
            _License.IssueReason = _LDLApp.ApplicationTypeID;
            _License.CreatedByUserID = clsUtilities.User.UserID;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _License = new clsLicenses();
            _FillLiecenseInfo();

            if (_License.Save())
            {
                clsUtilities.SendMessage($"License Issue Successfully With License ID ={_License.LicenseID}",
                    "Succeeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsUtilities.SendMessage("Not Issuing License Successfully", "Not Issuing!");
        }

    }

}




