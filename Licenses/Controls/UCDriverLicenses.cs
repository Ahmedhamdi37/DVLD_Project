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
    public partial class UCDriverLicenses : UserControl
    {
        enum enLicenceType { Local = 0, International = 1 }

        enLicenceType _LicenseType = enLicenceType.Local;
        int _PersonID = -1;
        clsDrivers _Driver;

        public UCDriverLicenses()
        {
            InitializeComponent();
        }
        
        private void _RefreshLocalLicense()
        {
            dgvLocalLicensesHistory.DataSource = clsLicenses.ListLicense(_Driver.DriverID);
            clsFormate.FormateDataGirdView(dgvLocalLicensesHistory);
            lblDriverLicensesNumbers.Text = dgvLocalLicensesHistory.RowCount.ToString();
        }
        private void _RefreshInternationalLicense()
        {
            dtvInternationalLicenses.DataSource = clsInternationalLicenses.ListInternationalLicense(_Driver.DriverID);
            clsFormate.FormateDataGirdView(dtvInternationalLicenses);
            lblInternationalLicensesRecordK.Text = dtvInternationalLicenses.RowCount.ToString();
        }
        private void _LoadData()
        {
            _Driver = clsDrivers.Find(_PersonID);
        }
        private void _Choose_Any_LicenseType()
        {
            if (tcDriverLicnese.SelectedIndex != (int)enLicenceType.International)
            {
                _LicenseType = enLicenceType.Local;
                _RefreshLocalLicense();
            }
            else
            {
                _LicenseType = enLicenceType.International;
                _RefreshInternationalLicense();
            }
        }
        public void _RecieveData(int PersonID)
        {
            if (PersonID > -1)
            {
                _PersonID = PersonID;

                _LoadData();
                if (_Driver != null)
                {
                    _Choose_Any_LicenseType();
                }
            }
        }

        private void tcDriverLicnese_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Choose_Any_LicenseType();
        }
    }
}
