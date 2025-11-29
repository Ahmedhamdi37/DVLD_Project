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
    public partial class frmTestAppointments : Form
    {
        enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        enTestType _enTestType = enTestType.VisionTest;

        int _LDLAppID;
        int _TestTypeID = 1;
        int _AppointmentID = -1;
        int RAppointment = -1;

        public frmTestAppointments(int LDLAppID, short TestType)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            if (TestType == 1)
            {
                _enTestType = enTestType.VisionTest;
                _TestTypeID = (int)enTestType.VisionTest;
            }
            else if (TestType == 2)
            {
                _enTestType = enTestType.WrittenTest;
                _TestTypeID = (int)enTestType.WrittenTest;
            }
            else if (TestType == 3)
            {
                _enTestType = enTestType.StreetTest;
                _TestTypeID = (int)enTestType.StreetTest;
            }
        }
        private void _Refresh()
        {
            dgvVisionTestAppointments.DataSource = clsTestAppointments.ListTestAppointment(_LDLAppID, _TestTypeID);
            dgvVisionTestAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisionTestAppointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lblVisionTestAppointmentsNumbers.Text = dgvVisionTestAppointments.RowCount.ToString();
        }
        private void _LoadUcApplicationInfo()
        {
            ucApplicationInfo1.RecieveData(_LDLAppID);
        }
        private void _FillModeMainData(string FormTitle, string Address, Image ModeImage)
        {
            this.Text = FormTitle;
            lblTestAppointments.Text = Address;
            pbTestAppointments.Image = ModeImage;
        }
        private void _ChoseTestType()
        {
            if (_enTestType == enTestType.VisionTest)
            {
                _FillModeMainData("Vision Test Appointments", "Vision Test Appointments", Properties.Resources.Vision_512);
            }
            else if (_enTestType == enTestType.WrittenTest)
            {
                _FillModeMainData("Written Test Appointments", "Written Test Appointments", Properties.Resources.Written_Test_512);
            }
            else if (_enTestType == enTestType.StreetTest)
            {
                _FillModeMainData("Street Test Appointments", "Street Test Appointments", Properties.Resources.Street_Test_32);
            }
        }
        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            _ChoseTestType();
            _LoadUcApplicationInfo();
            _Refresh();
        }
        private void btnLocalLicenseApplicatonsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            //Check Is Not Pass
            if (!clsTests.TestAppointmentIsPassed(clsTestAppointments.FoundTestAppointmentBasicInfo(_LDLAppID, _TestTypeID).AppointmentID))
            {
                //Check Is Valid Means AppointmentTest Valid Not Locked
                if (clsTestAppointments.TestAppointmentIsValid(_LDLAppID, _TestTypeID))
                {
                    clsUtilities.SendMessage("Person Already have an active appointment for this test, You cannot add new appointment");
                    return;
                }
                Form frmAddVisionAppointment = new frmScheduleTest(_LDLAppID, _TestTypeID, _AppointmentID);
                frmAddVisionAppointment.ShowDialog();
                _Refresh();
            }
            else
            {
                clsUtilities.SendMessage("This Person already passed this test before, you can only retake faild test", "Not Allowed");
            }
        }
        private void _EditSchedule()
        {
            if ((int)dgvVisionTestAppointments.CurrentRow.Cells[0].Value > 0)
            {
                _AppointmentID = Convert.ToInt32(dgvVisionTestAppointments.CurrentRow.Cells[0].Value);
                Form frmAddVisionAppointment = new frmScheduleTest(_LDLAppID, _TestTypeID, _AppointmentID);
                frmAddVisionAppointment.ShowDialog();
                _Refresh();
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditSchedule();
        }
        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)dgvVisionTestAppointments.CurrentRow.Cells[0].Value > 0)
            {
                _AppointmentID = Convert.ToInt32(dgvVisionTestAppointments.CurrentRow.Cells[0].Value);
                Form frmTakeTest = new frmTakeTest(_LDLAppID, _TestTypeID, _AppointmentID);
                frmTakeTest.ShowDialog();
                _Refresh();
            }
            else
            {
                MessageBox.Show("Please select an appointment to Take Test.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



