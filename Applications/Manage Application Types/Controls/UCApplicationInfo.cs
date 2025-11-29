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
    public partial class UCApplicationInfo: UserControl
    {
        int _LDLAppID;
        clsLocalDrivingLicenseApplication _LDLApp;

        public UCApplicationInfo()
        {
            InitializeComponent();
        }
        private void _LoaD_Data()
        {
            lblDLAIDInfoK.Text = _LDLApp.LDLAppID.ToString();
            lblAppliedForLicenseK.Text = _LDLApp.ClassName;
            lblPassedTestsK.Text = _LDLApp.PassedTest.ToString();
            ucApplicationBasicInfo1.RecieveData(_LDLAppID);
        }
        public void RecieveData(int LDLAppID)
        {
            _LDLAppID = LDLAppID;   
            _LDLApp =clsLocalDrivingLicenseApplication.FoundLocalLicenseApplication(_LDLAppID);
            _LoaD_Data();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FrmLicenseInfo = new FrmLicenseInfo(_LDLAppID);
            FrmLicenseInfo.ShowDialog();
        }
    }
}
