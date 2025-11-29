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
    public partial class frmUserInfo : Form
    {
        int _PersonID = -1;


        public frmUserInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

        }
        private void _LoaD()
        {
            if (clsUsers.IsUserExist(_PersonID))
            {
                UCUserInfoC.LoadPersoneDetails(_PersonID);
                ucLoginInfo1._LoaDLoginInfo(_PersonID);
            }
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            _LoaD();
        }

        private void btnUsersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
