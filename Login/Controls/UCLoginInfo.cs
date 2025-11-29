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
    public partial class UCLoginInfo : UserControl
    {
        int _PersonID = -1;
        clsUsers _User;

        public UCLoginInfo()
        {
            InitializeComponent();
        }
        private void _FillLoginInfo()
        {
            lblUserIDInfoK.Text = _User.UserID.ToString();
            lblUserNameInfoK.Text = _User.UserName;
            if(_User.IsActive == true )
            {
                lblUserIsActiveInfoK.Text = "Yes";
            }
            else
            {
                lblUserIsActiveInfoK.Text = "No";
            }
        }
        public void _LoaDLoginInfo(int PersonID)
        {
            _PersonID = PersonID;
            _User = clsUsers.FoundUserByPersonID(PersonID);
            if (_User != null)
            {
                _FillLoginInfo();
            }
        }

    }
}
