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
    public partial class FrmNewInternationalLicenseApplication : Form
    {
        string _NationalNo = "";
        int _LDLAppID = -1;
        int _LLicenseID = -1;
        int _PersonID = -1;
        short _ApplicationType = 6;

        clsInternationalLicenses _ILicense;

        public FrmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void _LoaD()
        {
            if (_LDLAppID <1)
            {
                ucInternationalApplicationInfo1.RecieveData(_LLicenseID, -1, -1);
                return;
            }
            _ILicense = clsInternationalLicenses.Find(_LLicenseID);

            ucDriverLicenseInfo1.RecieveData(_LDLAppID);
            ucInternationalApplicationInfo1.RecieveData(_LLicenseID, _ILicense.ILicenseID, _ILicense.ApplicationID);
            LLblShowLicenseHistory.Enabled = true;
        }
     
        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_NationalNo != "")
            {
                Form FrmShowLicenseHistory = new FrmLicensesHistory(_NationalNo);
                FrmShowLicenseHistory.ShowDialog();
            }
        }
        private void ucDriverLicenseInfo1_evPersonNationalNo(string obj)
        {
            _NationalNo = obj;
        }
        private void FrmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            ucLicenseFilter1.AllLicense = clsLicenses.ListLicense();
            _LoaD();
        }
        private void _CheckILicenseIsExist(int _LLicenseID)
        {
            if (_ILicense.IsExist(_LLicenseID))
            {
                clsUtilities.SendMessage($"This Licenses already exist with ID {_LLicenseID}");
           //     ucInternationalApplicationInfo1.RecieveData(_LLicenseID, _ILicense.ILicenseID, _ILicense.ApplicationID);
                btnIssue.Enabled = false;
                LLblShowLicenseInfo.Enabled = true;
                LLblShowLicenseInfo.Enabled = true;
                return;
            }
        }
        private void _FillILicense()
        {
            _PersonID = clsPerson.Find(_NationalNo).PersonID;
            _ILicense.PersonID = _PersonID;
            _ILicense.ApplicationTypeID = _ApplicationType;
            _ILicense.ApplicationFees = clsApplicationTypes.FoundApplicationByID(_ApplicationType).ApplicationFees;
            _ILicense.CreatedByUserID = clsUtilities.User.UserID;
            _ILicense.DriverID = clsDrivers.Find(_PersonID).DriverID;
            _ILicense.LLicenseID = _LLicenseID;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            _CheckILicenseIsExist(_LLicenseID);
            _ILicense = new clsInternationalLicenses();
            _FillILicense();
            if (_ILicense.Save())
            {
                clsUtilities.SendMessage("International License Issued Successfully", "Successeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucInternationalApplicationInfo1.RecieveData(_LLicenseID, _ILicense.ILicenseID, _ILicense.ApplicationID);
                LLblShowLicenseInfo.Enabled = true;
                LLblShowLicenseInfo.Enabled = true;
            }
            else
            {
                clsUtilities.SendMessage("Not Issued Successfully");
            }
        }
        private bool _IsILicenseIxist(int LLicenseID)
        {
            return _ILicense.IsExist(LLicenseID);
        }
        private void ucLicenseFilter1_evLicenseID(int arg1, int arg2, bool arg3)
        {
            if (_IsILicenseIxist(arg2))
            {
                clsUtilities.SendMessage($"Person already have an Active International License with ID = {_ILicense.ILicenseID} ", "Not Allowed");
                return;
            }

                _LDLAppID = arg1;
                _LLicenseID = arg2;
                _LoaD();
                btnIssue.Enabled = !arg3;
                LLblShowLicenseInfo.Enabled = arg3;
        }
        private void LLblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FrmShowLicense = new FrmLicenseInfo(_LDLAppID);
            FrmShowLicense.ShowDialog();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
