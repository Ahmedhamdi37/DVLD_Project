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
    public partial class FrmLicenseInfo : Form
    {
        int _LDLAppID = -1;

        public FrmLicenseInfo(int LDLAppID)
        {
            _LDLAppID = LDLAppID;

            InitializeComponent();
        }
        private void FrmLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_LDLAppID > -1)
            {
                ucDriverLicenseInfo1.RecieveData(_LDLAppID);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
