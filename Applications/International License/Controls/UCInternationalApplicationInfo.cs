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
    public partial class UCInternationalApplicationInfo : UserControl
    {
        int _ApplicationTypeID = 6;
        int _LLicenseID = -1;
        int _ILicenseID = -1;
        int _IApplicationID = -1;

        public UCInternationalApplicationInfo()
        {
            InitializeComponent();
        }
        private void _FillData()
        {
            lblApplicationDateK.Text = clsFormate.FormateDate(DateTime.Now);
            lblIssueDateK.Text = lblApplicationDateK.Text;
            lblExpirationDateK.Text = clsFormate.FormateDate(DateTime.Now.AddYears(1));
            lblCreatedByUserIDK.Text = clsUtilities.User.UserName;
            lblFeesK.Text = clsApplicationTypes.FoundApplicationByID(_ApplicationTypeID).ApplicationFees.ToString();
            if (_LLicenseID > -1)
            {
                lblLocalLicenseIDK.Text = _LLicenseID.ToString();
            }
            if (_ILicenseID > -1 && _IApplicationID > -1)
            {
                lblInternationalLicenseIDK.Text = _ILicenseID.ToString();
                lblInternationalApplicationIDK.Text = _IApplicationID.ToString();
            }

        }
        public void RecieveData(int LLicenseID,int ILicenseID,int IApplicationID)
        {
            _LLicenseID = LLicenseID;
            _ILicenseID = ILicenseID;
            _IApplicationID = IApplicationID;
            _FillData();
        }


    }
}
