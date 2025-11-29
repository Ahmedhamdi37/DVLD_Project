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
    public partial class frmLocalDrivinglicenseApplications : Form
    {
        enum enApplicationStatus { CancellApplication = 2, CompleteApplication = 3 }

        enApplicationStatus _ApplicationStatus = enApplicationStatus.CompleteApplication;
        DataTable _AllLocalLicenseApplication;
        int _LDLAppID = -1;
        string _NationalNo = "";

        public frmLocalDrivinglicenseApplications()
        {
            InitializeComponent();
        }
        private void _FillComboBoxLocalLicense()
        {
            cbLocalLicenseFilterBy.Items.Add("None");
            cbLocalLicenseFilterBy.Items.Add("L.D.AppID");
            cbLocalLicenseFilterBy.Items.Add("National No");
            cbLocalLicenseFilterBy.Items.Add("Full Name");
            cbLocalLicenseFilterBy.Items.Add("Status");
            cbLocalLicenseFilterBy.SelectedIndex = 0;
        }
        private void _Refresh()
        {
            dgvLocalLicenseApplications.DataSource = clsLocalDrivingLicenseApplication.ListLocalLicenseApplications();
            _AllLocalLicenseApplication = (DataTable)dgvLocalLicenseApplications.DataSource;
            dgvLocalLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocalLicenseApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lblLocalLicenseApplicationsNumbers.Text = dgvLocalLicenseApplications.RowCount.ToString();
        }
        private void frmLocalDrivinglicenseApplications_Load(object sender, EventArgs e)
        {
            _Refresh();
            _FillComboBoxLocalLicense();
        }
        private void showApplicatiionsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmLocalDrivingLicenseApplicationInfo = new FrmLocalDrivingLicenseApplicationInfo(_LDLAppID);
            FrmLocalDrivingLicenseApplicationInfo.ShowDialog();
            _Refresh();
        }
        private void schduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTestAppointments((int)dgvLocalLicenseApplications.CurrentRow.Cells[0].Value, 1);
            frm.ShowDialog();
            _Refresh();
        }
        private void showPersoneLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmLicenseHistory = new FrmLicensesHistory(_NationalNo);
            FrmLicenseHistory.ShowDialog();
        }
        private void scheduleWrittenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTestAppointments((int)dgvLocalLicenseApplications.CurrentRow.Cells[0].Value, 2);
            frm.ShowDialog();
            _Refresh();
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTestAppointments((int)dgvLocalLicenseApplications.CurrentRow.Cells[0].Value, 3);
            frm.ShowDialog();
            _Refresh();
        }
        private void btnLocalLicenseApplicatonsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewLocalLicense();
            frm.ShowDialog();
            _Refresh();
        }
        private void cbPeopleFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterLocalLicense.Text = "";

            if (cbLocalLicenseFilterBy.SelectedIndex == 0)
            {
                txtFilterLocalLicense.Enabled = false;
                dgvLocalLicenseApplications.DataSource = _AllLocalLicenseApplication;
                return;
            }
            txtFilterLocalLicense.Enabled = true;
            _FilterProccess();
        }
        private void txtFilterPeople_TextChanged(object sender, EventArgs e)
        {
            _FilterProccess();
        }
        private void _FilterProccess()
        {
            DataView dv = new DataView(_AllLocalLicenseApplication);
            if (dv != null && txtFilterLocalLicense.Text != "")
            {
                string FilterType = cbLocalLicenseFilterBy.SelectedItem.ToString().Replace(" ", "");

                dv.RowFilter = $"{FilterType}='{txtFilterLocalLicense.Text}'";
                if (dv.Count > 0)
                {
                    dgvLocalLicenseApplications.DataSource = dv.ToTable();
                    lblLocalLicenseApplicationsNumbers.Text = dgvLocalLicenseApplications.RowCount.ToString();
                    return;
                }
                dgvLocalLicenseApplications.DataSource = _AllLocalLicenseApplication;
            }
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUtilities.SendMessageToDialoge("Are you sure to Cancell this Application now", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _ApplicationStatus = enApplicationStatus.CancellApplication;

                if (clsLocalDrivingLicenseApplication.UpdateLocalApplicationStatus((int)dgvLocalLicenseApplications.CurrentRow.Cells[0].Value, (int)_ApplicationStatus))
                {
                    clsUtilities.SendMessage("Application Canceld Successfuly", "Cancel Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Refresh();
                }
            }
        }
        private void SetMenuItemsState(Dictionary<string, bool> state)
        {
            foreach (var kvp in state)
            {
                if (contextMenuStrip1.Items.ContainsKey(kvp.Key))
                {
                    contextMenuStrip1.Items[kvp.Key].Enabled = kvp.Value;
                }
            }
        }
        private void SetTestScheduleSubMenu(int passedTests)
        {
            ToolStripMenuItem schduleTests = contextMenuStrip1.Items["schduleTestsToolStripMenuItem"] as ToolStripMenuItem;

            switch (passedTests)
            {
                case 0:
                    schduleTests.DropDownItems["schduleVisionTestToolStripMenuItem"].Enabled = true;
                    schduleTests.DropDownItems["scheduleWrittenToolStripMenuItem"].Enabled = false;
                    schduleTests.DropDownItems["scheduleStreetTestToolStripMenuItem"].Enabled = false;
                    break;
                case 1:
                    schduleTests.DropDownItems["schduleVisionTestToolStripMenuItem"].Enabled = false;
                    schduleTests.DropDownItems["scheduleWrittenToolStripMenuItem"].Enabled = true;
                    schduleTests.DropDownItems["scheduleStreetTestToolStripMenuItem"].Enabled = false;
                    break;
                case 2:
                    schduleTests.DropDownItems["schduleVisionTestToolStripMenuItem"].Enabled = false;
                    schduleTests.DropDownItems["scheduleWrittenToolStripMenuItem"].Enabled = false;
                    schduleTests.DropDownItems["scheduleStreetTestToolStripMenuItem"].Enabled = true;
                    break;
            }
        }
        private void dgvLocalLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _LDLAppID = (int)dgvLocalLicenseApplications.CurrentRow.Cells[0].Value;
            _NationalNo = (string)dgvLocalLicenseApplications.CurrentRow.Cells[2].Value;

            if (clsLicenses.LicenseIsExist(_LDLAppID))
            {
                SetMenuItemsState(new Dictionary<string, bool>
        {
            { "showApplicatiionsDetailsToolStripMenuItem", true },
            { "editApplicationsToolStripMenuItem", false },
            { "deleteToolStripMenuItem", false },
            { "cancelApplicationToolStripMenuItem", false },
            { "schduleTestsToolStripMenuItem", false },
            { "issueDrivingLicenseToolStripMenuItem", false },
            { "sToolStripMenuItem", true },
            { "showPersoneLicenseHistoryToolStripMenuItem", true }
        });
            }
            else if (clsLocalDrivingLicenseApplication.LocalApplicationIsCancel(_LDLAppID))
            {
                SetMenuItemsState(new Dictionary<string, bool>
        {
            { "showApplicatiionsDetailsToolStripMenuItem", true },
            { "editApplicationsToolStripMenuItem", false },
            { "deleteToolStripMenuItem", false },
            { "cancelApplicationToolStripMenuItem", false },
            { "schduleTestsToolStripMenuItem", false },
            { "issueDrivingLicenseToolStripMenuItem", false },
            { "sToolStripMenuItem", false },
            { "showPersoneLicenseHistoryToolStripMenuItem", true }
        });
            }
            else
            {
                int PassedTests = (int)dgvLocalLicenseApplications.CurrentRow.Cells[5].Value;

                if (PassedTests < 3)
                {
                    SetMenuItemsState(new Dictionary<string, bool>
            {
                { "showApplicatiionsDetailsToolStripMenuItem", true },
                { "editApplicationsToolStripMenuItem", true },
                { "deleteToolStripMenuItem", true },
                { "cancelApplicationToolStripMenuItem", true },
                { "schduleTestsToolStripMenuItem", true },
                { "issueDrivingLicenseToolStripMenuItem", false },
                { "sToolStripMenuItem", false },
                { "showPersoneLicenseHistoryToolStripMenuItem", true }
            });
                    SetTestScheduleSubMenu(PassedTests);
                    return;
                }
                else
                {
                    SetMenuItemsState(new Dictionary<string, bool>
            {
                { "showApplicatiionsDetailsToolStripMenuItem", true },
                { "editApplicationsToolStripMenuItem", true },
                { "deleteToolStripMenuItem", true },
                { "cancelApplicationToolStripMenuItem", true },
                { "schduleTestsToolStripMenuItem", false },
                { "issueDrivingLicenseToolStripMenuItem", true },
                { "sToolStripMenuItem", false },
                { "showPersoneLicenseHistoryToolStripMenuItem", true }
            });
                }
            }
        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)dgvLocalLicenseApplications.CurrentRow.Cells[2].Value;

            Form FrmIssueLicense = new FrmIssueDriverLicense(_LDLAppID, NationalNo);
            FrmIssueLicense.ShowDialog();
            _Refresh();
        }
        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmShowLicense = new FrmLicenseInfo(_LDLAppID);
            FrmShowLicense.ShowDialog();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUtilities.SendMessageToDialoge("Are you sure do want to delete this application?",
                "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(clsLocalDrivingLicenseApplication.DeleteApplication(_LDLAppID))
                {
                    clsUtilities.SendMessage("Application Deleted Successfully", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Refresh();
                    return;
                }
                clsUtilities.SendMessage("Wrong to Delete this Application");
            }
        }
    }
}
