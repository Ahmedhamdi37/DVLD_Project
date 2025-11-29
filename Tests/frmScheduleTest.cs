using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD_Project
{
    public partial class frmScheduleTest : Form
    {
        enum enScheduleType { VisionSchedule = 1, WrittenSchedule = 2, StreetSchedule = 3 };
        enum enMode { AddMode = 1, UpdateMode = 2 };

        enMode _Mode = enMode.AddMode;
        enScheduleType _enSchedule = enScheduleType.VisionSchedule;

        int _LDLAppID = -1;
        int _ScheduleType = 1;
        int _TestAppointmentID = -1;
        int _RApplicationID = -1;
        clsScheduleTestAppointments _ApplicationInfo;
        clsTestAppointments _TestAppointment;

        public frmScheduleTest(int LDLAppID, int ScheduleType, int TestAppointmentID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _TestAppointmentID = TestAppointmentID;

            _TestAppointment = new clsTestAppointments();

            if (ScheduleType == 1)
            {
                _enSchedule = enScheduleType.VisionSchedule;
                _ScheduleType = (int)enScheduleType.VisionSchedule;
            }
            else if (ScheduleType == 2)
            {
                _enSchedule = enScheduleType.WrittenSchedule;
                _ScheduleType = (int)enScheduleType.WrittenSchedule;
            }
            else if (ScheduleType == 3)
            {
                _enSchedule = enScheduleType.StreetSchedule;
                _ScheduleType = (int)enScheduleType.StreetSchedule;
            }
            if (_TestAppointmentID > -1)
            {
                _Mode = enMode.UpdateMode;
                _TestAppointment = clsTestAppointments.FoundTestAppointmentBasicInfo(_LDLAppID, _ScheduleType);
            }
        }
        private void _FillModeMainData(string FormTitle,string gbTitle,string Address,Image ModeImage )
        {
            this.Text = FormTitle;
            gbScheduleTest.Text = gbTitle;
            lblScheduleTest.Text = Address;
            pbScheduleTest.Image = ModeImage;
        }
        private void _ChoseScheduleType()
        {
            switch (_enSchedule)
            {
                case enScheduleType.VisionSchedule:
                    {
                        _FillModeMainData("Vision Test", "Vision Test", "Schedule Vision Test", Properties.Resources.Vision_512);
                        break;
                    }
                case enScheduleType.WrittenSchedule:
                    {
                        _FillModeMainData("Written Test", "Written Test", "Schedule Written Test", Properties.Resources.Written_Test_512);
                        break;
                    }
                case enScheduleType.StreetSchedule:
                    {
                        _FillModeMainData("Street Test", "Street Test", "Schedule Street Test", Properties.Resources.Street_Test_32);
                        break;
                    }
            }
        }
        private void _LockScedhuleTest()
        {
                lblScheduleTest.Text = "Schedule Retake Test";
                lblLockedMessage.Visible = true;
                dtpScheduleTest.Enabled = false;
                btnScheduleTestSave.Enabled = false;
        }
        private void _FillShowScreen()
        {
            lblDlAppIDk.Text = _LDLAppID.ToString();
            lblDClassNameK.Text = _ApplicationInfo.ClassName;
            lblApplicantNameK.Text = _ApplicationInfo.ApplicantName;
            lblTrialK.Text = _ApplicationInfo.trialTestNumber.ToString();
            dtpScheduleTest.Value = _ApplicationInfo.AppointmentDate;
            lblApplicationFeesK.Text = _ApplicationInfo.TestAppointmentFees.ToString();
        }
        private void _LoadApplicationInfo()
        {
            _ApplicationInfo = clsScheduleTestAppointments.FindApplicationInfo(_LDLAppID, _ScheduleType, _TestAppointmentID);
            if (_ApplicationInfo != null)
            {
                _FillShowScreen();
                ucRetakeTest1.LoadRetakeInfo(_TestAppointmentID,_LDLAppID, _ScheduleType);

                if (_ApplicationInfo.trialTestNumber <= 0)
                {
                    ucRetakeTest1.Enabled = false;
                }
                if (_Mode == enMode.UpdateMode && !clsTestAppointments.TestAppointmentIsValid(_LDLAppID, _ScheduleType))
                {
                 
                    _LockScedhuleTest();
                }

                return;
            }
            clsUtilities.SendMessage("No Application Found");
        }
        private void _LoaD()
        {
            _ChoseScheduleType();
            _LoadApplicationInfo();
        }
        private void frmAddVisionAppointmen_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnVisionScheduleTestClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _SaveTestScheduleTest()
        {
            _FillTestAppointment(_RApplicationID);
            if (_TestAppointment.Save() && _Mode == enMode.AddMode)
            {
                if (_Mode == enMode.UpdateMode)
                {
                    clsUtilities.SendMessage("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                clsUtilities.SendMessage("Saved ScheduleTest Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                clsUtilities.SendMessage("Not Saved Successfully");   
        }
        private void btnVisionScheduleTestSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddMode && ucRetakeTest1.Enabled == true)
            {
                ucRetakeTest1.SaveRetakeApp(_LDLAppID);
            }
            _SaveTestScheduleTest();
        }
        private void _FillTestAppointment(int RApplicationID)
        {
            _TestAppointment.TestTypeID = _ScheduleType;
            _TestAppointment.LDLAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpScheduleTest.Value;
            _TestAppointment.TestAppointmentFees = Convert.ToInt32(lblApplicationFeesK.Text);
            _TestAppointment.CreatedBy = clsUtilities.User.UserID;
            _TestAppointment.AppointmentID = _TestAppointmentID;
            _TestAppointment.RApplicationID = RApplicationID;
        }
        private void ucRetakeTest1_OnRetakeApplicationID(int obj)
        {
            if(obj>-1)
            {
                _RApplicationID = obj;
            }
        }
    }
}
