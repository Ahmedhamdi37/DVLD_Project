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
    public partial class FrmLocalDrivingLicenseApplicationInfo: Form
    {
        int _LDLAppID = -1;
        public FrmLocalDrivingLicenseApplicationInfo(int LDLAppID)
        {
            _LDLAppID = LDLAppID;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ucApplicationInfo1.RecieveData(_LDLAppID);
        }
    }
}
