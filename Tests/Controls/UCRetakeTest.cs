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
using System.Runtime.InteropServices;

namespace DVLD_Project
{

    public partial class UCRetakeTest : UserControl
    {
        public event Action<int> OnRetakeApplicationID;
        enum enMode { AddMode = 1, ShowMode = 2 };

        enMode _Mode = enMode.AddMode;
        int _LDLAppID = -1;
        int RAppID = 7;
        int _ScheduleType = -1;
        int _ScheduleFees = -1;
        int _TestAppointmentID = -1;
        clsApplicatations _Application;
        clsLocalDrivingLicenseApplication _LocalApplication;
        //Retake App for AddMode
        clsApplicationTypes _RetakeAppType;
        //Retake App for Show
        clsScheduleTestAppointments _RetakeApp;

        public UCRetakeTest()
        {
            InitializeComponent();
        }

        private void _LoadOriginalDataFor_RetakeApplication()
        {
            _RetakeAppType = clsApplicationTypes.FoundApplicationByID(RAppID);
            if (_RetakeAppType != null)
            {
                lblRetakeAppFeesK.Text = _RetakeAppType.ApplicationFees.ToString();
                lblTotalFeesK.Text = (_RetakeAppType.ApplicationFees + _ScheduleFees).ToString();
            }
        }
        private void _LoadData()
        {
            _RetakeApp = clsScheduleTestAppointments.FindRetakeApplicationInfo(_LDLAppID);
            if (_RetakeApp != null)
            {
                lblRetakeAppFeesK.Text = _RetakeApp.ApplicationFees.ToString();
                lblRetakeTestAppIDK.Text = _RetakeApp.ApplicationID.ToString();
                lblTotalFeesK.Text = (_RetakeApp.ApplicationFees + _ScheduleFees).ToString();
            }
            else
            {
                clsUtilities.SendMessage("No Retake Application Info Found");
            }
        }
        private void _ChooseMode(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;

            if (_TestAppointmentID > -1)
            {
                _Mode = enMode.ShowMode;
                return;
            }
            _Mode = enMode.AddMode;
        }
        public void LoadRetakeInfo(int TestAppointmentID,int LDlAppID, int ScheduleType)
        {
            _ChooseMode(TestAppointmentID);

            _LDLAppID = LDlAppID;
            _ScheduleType = ScheduleType;
            _ScheduleFees = clsTestTypes.FindTestTypeByID(_ScheduleType).TestTypeFees;

            if (_Mode == enMode.ShowMode)
            {
                _LoadData();
            }
            else { _LoadOriginalDataFor_RetakeApplication(); }
        }
        private void _FillRApplicationInfo()
        {
            _Application = clsApplicatations.FoundApplication(_LDLAppID);
            _LocalApplication = new clsLocalDrivingLicenseApplication();
            _LocalApplication.PersonID = _Application.PersonID;
            _LocalApplication.LastDate = DateTime.Now.AddYears(_Application.LastDate.Year - _Application.ApplicationDate.Year);
            _LocalApplication.ApplicationTypeID = RAppID;
            _LocalApplication.ApplicationFees = Convert.ToInt32(lblRetakeAppFeesK.Text);
            _LocalApplication.createdByUserID = clsUtilities.User.UserID;
        }
        private void _SaveRetakeApplication()
        {
            _FillRApplicationInfo();

            if (_LocalApplication != null)
            {
                if (_LocalApplication.Save())
                {
                    if(OnRetakeApplicationID!=null)
                    {
                        OnRetakeApplicationID.Invoke(_LocalApplication.ApplicationID);
                    }
                }
            }
        }
        public void SaveRetakeApp(int LDLAppID )
        {
            _LDLAppID = LDLAppID;
            _SaveRetakeApplication();
        }
    }
}
