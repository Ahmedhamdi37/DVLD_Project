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
    public partial class UCApplicationNewLicenseInfo : UserControl
    {
        int _ApplicationTypeID = 2;
        int _OldLLicenseID = -1;
        int _LLicenseID = -1;
        int _LDLAppID = -1;
        clsLicenses _LLicense;
        clsApplicationTypes _ApplicationType;
        clsLicenses _RLicense;
        clsApplicatations _Application;
        public event Action< bool> evLocked;


        public UCApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        private void _DataForRLicense()
        {
            if (_OldLLicenseID > -1)
            {
                int ApplicationID = clsLocalDrivingLicenseApplication.FoundLocalLicenseApplication(_LDLAppID).ApplicationID;

                _LLicense = clsLicenses.Find(ApplicationID);

                int LicensePeriod = _LLicense.ExpirationDate.Year - _LLicense.IssueDate.Year;
                lblOldLicenseIDK.Text = _LLicense.LicenseID.ToString();
                lblExpirationDateK.Text = clsFormate.FormateDate(DateTime.Now.AddYears(LicensePeriod));
                lblLicenseFeesK.Text = Convert.ToInt32(_LLicense.PaidFees).ToString();
                lblTotalFeesK.Text = (Convert.ToInt32(lblApplicationFeesK.Text) +
                    Convert.ToInt32(lblLicenseFeesK.Text)).ToString();
                return;
            }
        }
        
        private void _LoadBasicRenewApplicationInfo()
        {
            _DataForRLicense();
            lblApplicationDateK.Text = clsFormate.FormateDate(DateTime.Now);
            lblIssueDateK.Text = clsFormate.FormateDate(DateTime.Now);
            lblCreatedByUserIDK.Text = clsUtilities.User.UserID.ToString();
            lblApplicationFeesK.Text = Convert.ToInt32(_ApplicationType.ApplicationFees).ToString();
        }
        private void _LoadRenewApplicationInfo(int LLicenseID)
        {
            //هنا


            lblRenewLApplicationIDK.Text = _Application.ApplicationID.ToString();
            txtNotes.Text = _LLicense.Notes.ToString();
            lblRLLicenseIDK.Text = _RLicense.LicenseID.ToString();
            evLocked(true);
        }
        private void _LoaD()
        {
            _ApplicationType = clsApplicationTypes.FoundApplicationByID(_ApplicationTypeID);
 
            _LoadBasicRenewApplicationInfo();
        }

        private bool _UpdateLocalDrivingLicense()
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicense = clsLocalDrivingLicenseApplication.FoundLocalLicenseApplication(_LDLAppID);

            if (LocalDrivingLicense != null)
            {
                LocalDrivingLicense.ApplicationID = _Application.ApplicationID;
            }
             return    LocalDrivingLicense.Save();
        }

        private void _FillApplicationInfo(clsApplicatations Application)
        {
            int AppPeriod = Application.LastDate.Year - Application.ApplicationDate.Year;
            _Application = new clsApplicatations();

            _Application.PersonID = Application.PersonID;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationTypeID = Application.ApplicationTypeID;
            _Application.ApplicationStatus = Application.ApplicationStatus;
            _Application.LastDate = DateTime.Now.AddYears(AppPeriod);
            _Application.ApplicationFees = Convert.ToInt32(lblApplicationFeesK.Text);
            _Application.CreatedByUserID = Convert.ToInt32(lblCreatedByUserIDK.Text);
        }

        private bool _RenewApplication(clsApplicatations Application)
        {
            _FillApplicationInfo(Application);

            if(_Application.Save())
            {

              return  _UpdateLocalDrivingLicense();
            }
            return false;
        }

        private void _FillRLiecenseInfo()
        {
                if(_Application !=null)
            {
                int DatePeriod = _LLicense.ExpirationDate.Year - _LLicense.IssueDate.Year;

                _RLicense.ApplicationID = _Application.ApplicationID;
                _RLicense.DriverID = _LLicense.DriverID;
                _RLicense.LicenseClass = _LLicense.LicenseClass;
                _RLicense.IssueDate = DateTime.Now;
                _RLicense.ExpirationDate = DateTime.Now.AddYears(DatePeriod);
                _RLicense.Notes = txtNotes.Text;
                _RLicense.PaidFees = Convert.ToInt32(lblTotalFeesK.Text);
                _RLicense.IssueReason = 2;
                _RLicense.CreatedByUserID =Convert.ToInt32(lblCreatedByUserIDK.Text);
            }
        }

        private bool _DeActivateOldLicense(int LLicenseID, bool Active = false)
        {
            return clsLicenses.UpdateActivateLicense(LLicenseID, Active);
        }

        public void RenewLicense(clsApplicatations Application)
        {


            if(_RenewApplication(Application))
            {
                _RLicense = new clsLicenses();
                _FillRLiecenseInfo();

                if (_RLicense.Save())
                {
                    _DeActivateOldLicense(_OldLLicenseID);

                    clsUtilities.SendMessage($"License Renew Successfully With License ID ={_RLicense.LicenseID}",
                        "Succeeded",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadRenewApplicationInfo(_RLicense.LicenseID);
                    return;
                }
                clsUtilities.SendMessage("Not Renew License Successfully", "Not Renewing!");
            }

        }

        public void ReciveData(int OldLLicenseID,int LLicenseID,int LDLAppID)
        {
            _OldLLicenseID = OldLLicenseID;
            _LLicenseID = LLicenseID;
            _LDLAppID = LDLAppID;
            _LoaD();
        }
    }
}
