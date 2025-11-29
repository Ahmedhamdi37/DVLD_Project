using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class UCLicenseFilter : UserControl
    {
        bool _IsExixt = false;

        public  DataTable AllLicense;
        int _LLicenseID = -1;
        int _LDLAppID = -1;
        clsLicenses _License;
        clsInternationalLicenses _ILicense;

        public event Action<int,int,bool> evLicenseID;


        public UCLicenseFilter()
        {
            InitializeComponent();
            _ILicense = new clsInternationalLicenses();
        }

        private void _FilterProcess()
        {
            if (AllLicense != null)
            {
                DataView dv = new DataView(AllLicense);


                string FilterType = "LicenseID";

                if (txtLicenseID.Text != "")
                {
                    dv.RowFilter = $"{FilterType}= '{txtLicenseID.Text}'";

                    if (dv.Count > 0)
                    {
                        int.TryParse(dv.ToTable().Rows[0]["LicenseID"].ToString(), out _LLicenseID);
                    }
                }
            }
        }
        private void _FindLocalLicense()
        {
            _License = clsLicenses.FindLocalLicenseID(_LLicenseID);
            if (_License != null)
            {
                _LDLAppID = _License.LDLAppID;
            }
        }
        private bool _IsILicenseIxist(int LLicenseID)
        {
            return _ILicense.IsExist(LLicenseID);
        }
        private void btnLicenseSearch_Click(object sender, EventArgs e)
        {
            _FilterProcess();
            _FindLocalLicense();
            _IsExixt = true;
            if (evLicenseID != null)
            {
                evLicenseID(_LDLAppID, _LLicenseID,_IsExixt);
            }
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
