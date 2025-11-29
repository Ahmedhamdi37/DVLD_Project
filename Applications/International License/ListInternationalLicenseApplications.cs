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
    public partial class ListInternationalLicenseApplications : Form
    {

        enum enApplicationStatus { CancellApplication = 2, CompleteApplication = 3 }

        enApplicationStatus _ApplicationStatus = enApplicationStatus.CompleteApplication;
        DataTable _AllInternationalLicenseApplication;
        int _LDLAppID = -1;
        int _PersonID = -1;
        string _NationalNo = "";

        public ListInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        private void _FillComboBoxInternationalLicense()
        {
            cbInternationalLicenseFilterBy.Items.Add("None");
            cbInternationalLicenseFilterBy.Items.Add("Int.License ID");
            cbInternationalLicenseFilterBy.Items.Add("Application ID");
            cbInternationalLicenseFilterBy.Items.Add("Driver ID");
            cbInternationalLicenseFilterBy.Items.Add("L.License ID");
            cbInternationalLicenseFilterBy.Items.Add("Is Active");
            cbInternationalLicenseFilterBy.SelectedIndex = 0;
        }
        private void _Refresh()
        {
            
            dgvInternationalLicenseApplications.DataSource = clsInternationalLicenses.ListInternationalLicense();
            _AllInternationalLicenseApplication = (DataTable)dgvInternationalLicenseApplications.DataSource;
            dgvInternationalLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInternationalLicenseApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lblInternationalLicenseApplicationsNumbers.Text = dgvInternationalLicenseApplications.RowCount.ToString();
        }
        private void ListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            _Refresh();
            _FillComboBoxInternationalLicense();
        }
        private void showApplicatiionsDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form FrmApplicationDetails = new frmPersoneDetails(_PersonID);
            FrmApplicationDetails.ShowDialog();
        }

        private void sToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form FrmShowLicense = new FrmLicenseInfo(_LDLAppID);
            FrmShowLicense.ShowDialog();
        }

        private void showPersoneLicenseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form FrmLicenseHistory = new FrmLicensesHistory(_NationalNo);
            FrmLicenseHistory.ShowDialog();
        }

        private void btnInternationalLicenseApplicatonsClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddInternationalLicenseApplication_Click_1(object sender, EventArgs e)
        {
            Form frm = new FrmNewInternationalLicenseApplication();
            frm.ShowDialog();
            _Refresh();
        }
        private void cbInternationalLicenseFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterInternationalLicense.Text = "";

            if (cbInternationalLicenseFilterBy.SelectedIndex == 0)
            {
                txtFilterInternationalLicense.Enabled = false;
                dgvInternationalLicenseApplications.DataSource = _AllInternationalLicenseApplication;
                return;
            }
            txtFilterInternationalLicense.Enabled = true;
            _FilterProccess();
        }
        private void txtFilterInternationalLicense_TextChanged(object sender, EventArgs e)
        {
            _FilterProccess();
        }
        private void _FilterProccess()
        {
            DataView dv = new DataView(_AllInternationalLicenseApplication);
            if (dv != null && txtFilterInternationalLicense.Text != "")
            {
                string FilterType = cbInternationalLicenseFilterBy.SelectedItem.ToString().Replace(" ", "");

                dv.RowFilter = $"{FilterType}='{txtFilterInternationalLicense.Text}'";
                if (dv.Count > 0)
                {
                    dgvInternationalLicenseApplications.DataSource = dv.ToTable();
                    lblInternationalLicenseApplicationsNumbers.Text = dgvInternationalLicenseApplications.RowCount.ToString();
                    return;
                }
                dgvInternationalLicenseApplications.DataSource = _AllInternationalLicenseApplication;
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

        private void dgvInternationalLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int LLicenseID = (int)dgvInternationalLicenseApplications.CurrentRow.Cells[3].Value;
            clsInternationalLicenses ILicense = clsInternationalLicenses.Find(LLicenseID, true);
            if(ILicense !=null)
            {
                _LDLAppID = ILicense.LDLAppID;
                _PersonID = ILicense.PersonID;
                _NationalNo = clsPerson.Find(_PersonID).NationalNo;
            }
        }
    }
}
