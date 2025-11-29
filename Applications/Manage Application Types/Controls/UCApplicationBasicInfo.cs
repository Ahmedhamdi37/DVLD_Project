using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsDVLDBusinessLayer;

namespace DVLD_Project
{
    public partial class UCApplicationBasicInfo: UserControl
    {
        int _LDLAppID = -1;
        clsApplicatations _ApplicationInfo;

        public UCApplicationBasicInfo()
        {
            InitializeComponent();
        }

      public void RecieveData(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            _ApplicationInfo = clsApplicatations.FoundApplication(_LDLAppID);
            _LoaD_Data();
        }
        private void _LoaD_Data()
        {
            lblApplicationIDK.Text = _ApplicationInfo.ApplicationID.ToString();
            lblApplicationsFeesK.Text = _ApplicationInfo.ApplicationFees.ToString();
            lblApplicationDateK.Text = clsFormate.FormateDate(_ApplicationInfo.ApplicationDate);
            lblApplicationStatusDateK.Text = clsFormate.FormateDate(_ApplicationInfo.LastDate);
            lblApplicationStatusK.Text = _ApplicationInfo.LocalLicenseApplication.ApplicationStatus;
            lblApplicantK.Text = _ApplicationInfo.LocalLicenseApplication.ApplicantName;
            lblApplicationTypeK.Text = _ApplicationInfo.ApplicationTypeInfo.ApplicationTypeTitle;
            lblCreatedByK.Text = _ApplicationInfo.UserInfo.UserName;
         
        }

        private void llViewPersoneInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Frm = new frmPersoneDetails(_ApplicationInfo.PersonID);
            Frm.ShowDialog();
        }
    }
}
