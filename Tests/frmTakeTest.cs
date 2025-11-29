using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDVLDBusinessLayer.clsPerson;

namespace DVLD_Project
{
    public partial class frmTakeTest : Form
    {
        enum enScheduleType { VisionSchedule = 1, WrittenSchedule = 2, StreetSchedule = 3 };
        enum enMode { TakeTest = 1, ShowTest=2 }
        enMode _Mode = enMode.TakeTest;

        enScheduleType _enSchedule = enScheduleType.VisionSchedule;
        int _ScheduleType = -1;
        int _LDLAppID = -1;
        int _TestAppointmentID = -1;
        clsScheduleTestAppointments _ApplicationInfo;
        clsTests _TestInfo;

        public frmTakeTest(int LDLAppID, int ScheduleType, int TestAppointmentID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _TestAppointmentID = TestAppointmentID;

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
        }

        private void _FillModeMainData( string gbTitle, string Address, Image ModeImage)
        {
            gbTakeTest.Text = gbTitle;
            lblTakeTest.Text = Address;
            pbTakeTest.Image = ModeImage;
        }
        private void _ChoseScheduleType()
        {
            switch (_enSchedule)
            {
                case enScheduleType.VisionSchedule:
                    {
                        _FillModeMainData( "Vision Test", "Schedule Vision Test", Properties.Resources.Vision_512);
                        break;
                    }
                case enScheduleType.WrittenSchedule:
                    {
                        _FillModeMainData( "Written Test", "Schedule Written Test", Properties.Resources.Written_Test_512);
                        break;
                    }
                case enScheduleType.StreetSchedule:
                    {
                        _FillModeMainData( "Street Test", "Schedule Street Test", Properties.Resources.Street_Test_32);
                        break;
                    }
            }
        }
        private void _ChooseAnyMode()
        {
            if (!clsTestAppointments.TestAppointmentIsValid(_LDLAppID, _ScheduleType))
            {
                _Mode = enMode.ShowTest;
            }
            else
            {
                _Mode = enMode.TakeTest;
            }
        }
        private void _FillShowScreen()
        {
            lblLDlAppIDK.Text = _LDLAppID.ToString();
            lblDClassNameK.Text = _ApplicationInfo.ClassName;
            lblApplicantNameK.Text = _ApplicationInfo.ApplicantName;
            lblTrialNumberK.Text = _ApplicationInfo.trialTestNumber.ToString();
            lblDateK.Text = _ApplicationInfo.AppointmentDate.ToString();
            lblFeesK.Text = _ApplicationInfo.TestAppointmentFees.ToString();
        }
        private void _LockTakeTest()
        {
            rbTestFail.Checked = !clsTests.TestAppointmentIsPassed(clsTestAppointments.FoundTestAppointmentBasicInfo(_LDLAppID, _ScheduleType).AppointmentID);
            rbTestFail.Enabled = false;
            rbTestPass.Enabled = false;
            btnSave.Enabled = false;
            lblLockedTakeTest.Visible = true;

        }
        private void _LoadApplicationInfo()
        {
            _ApplicationInfo = clsScheduleTestAppointments.FindApplicationInfo(_LDLAppID, _ScheduleType, _TestAppointmentID);
            if (_ApplicationInfo != null)
            {
                _FillShowScreen();
                if(_Mode==enMode.ShowTest)
                {
                    _LockTakeTest();
                }
                return;
            }
            clsUtilities.SendMessage("No Application Found");
        }
        private void _LoaD()
        {
            _ChoseScheduleType();
            _ChooseAnyMode();
            _LoadApplicationInfo();
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadDataToTestInfo()
        {
            _TestInfo = new clsTests();
            _TestInfo.TestAppointmentID = _TestAppointmentID;
            _TestInfo.TestTypeID = _ScheduleType;

            if (rbTestPass.Checked)
            {
                _TestInfo.TestResult = true;
            }
            else { _TestInfo.TestResult = false; }

            _TestInfo.Notes = txtTestNotes.Text;
            _TestInfo.CreatedByUserID = clsUtilities.User.UserID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = clsUtilities.SendMessageToDialoge("Are you sure want to save?" +
                " after that you cannot change the Pass/Fail results after you save?.","Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _LoadDataToTestInfo();

                if (_TestInfo.Save())
                {
                    clsUtilities.SendMessage("Test Taken Successfully", "Test Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsUtilities.SendMessage("Test Not Taken Successfully");
                }
                this.Close();
            }
        }
    }
}
