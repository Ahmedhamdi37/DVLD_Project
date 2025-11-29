using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FrmRenewLicenseApplication : Form
    {
        int _LDLAppID = -1;
        int _OldLLicenseID = -1;
        int _LLicenseID = -1;
        clsLicenses _LLicense;
        clsApplicatations _Application;

        public FrmRenewLicenseApplication()
        {
            InitializeComponent();
        }
        private void _LoaD()
        {
            ucApplicationNewLicenseInfo1.ReciveData(_OldLLicenseID, _LLicenseID,_LDLAppID);
           
            if (_LDLAppID > -1)
            {
                ucDriverLicenseInfo1.RecieveData(_LDLAppID);
            }
        }
        private void FrmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            ucLicenseFilter1.AllLicense = clsLicenses.ListLicense();
            _LoaD();
        }
        private bool _CheKAllowRenewOrNot()
        {
            _LLicense = clsLicenses.FindLocalLicenseID(_OldLLicenseID);
            _LLicense = clsLicenses.Find(clsApplicatations.FoundApplication(_LLicense.LDLAppID).ApplicationID);

            if (_LLicense != null&&_LLicense.ExpirationDate>DateTime.Now)
            {
                clsUtilities.SendMessage($"Selected License is Not yet Expired, it will Expire on:" +
                    $"{clsFormate.FormateDate(_LLicense.ExpirationDate)}","Not Allowed");

                //LLblShowNewLicenseInfo.Enabled = false;
            }
            return _LLicense.ExpirationDate < DateTime.Now;
        }
        private bool _IsLicenseActive(int LLicenseID)
        {
            return clsLicenses.LicenseIsActive(LLicenseID);
        }
        private void ucLicenseFilter1_evLicenseID(int arg1, int arg2, bool arg3)
        {
         
            if (!_IsLicenseActive(arg2))
            {
                clsUtilities.SendMessage("Selected License Is Not Active, Choose an active license.","Not allowed");
                return;
            }

            _LDLAppID = arg1;
            _OldLLicenseID = arg2;
            //LLblShowNewLicenseInfo.Enabled = arg3;
            LLblShowLicenseHistory.Enabled = arg3;

            if (_CheKAllowRenewOrNot())
            {
                btnIssue.Enabled = true;
            }
            _LoaD();
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to Renew The License",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (Result==DialogResult.OK)
            {
                _Application = clsApplicatations.FoundApplication(_LDLAppID);
                ucApplicationNewLicenseInfo1.RenewLicense(_Application);
            }
        }
        private void ucApplicationNewLicenseInfo1_evLocked(bool obj)
        {
            btnIssue.Enabled = !obj;
            LLblShowNewLicenseInfo.Enabled = true;
            ucLicenseFilter1.Enabled = false;
        }
        private void LLblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Application = clsApplicatations.FoundApplication(_LDLAppID);

            Form FrmShowLicenseHistory = new FrmLicensesHistory(clsPerson.Find(_Application.PersonID).NationalNo);
            FrmShowLicenseHistory.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LLblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FrmShowLicense = new FrmLicenseInfo(_LDLAppID);
            FrmShowLicense.ShowDialog();
        }
    }
}
