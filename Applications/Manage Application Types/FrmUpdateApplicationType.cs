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
    public partial class FrmUpdateApplicationType: Form
    {
        int _ApplicationTypeID = -1;
        clsApplicationTypesBusinessLayer _ApplicationType;

        public FrmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
            if (_ApplicationTypeID > -1)
            {
                _ApplicationType = clsApplicationTypesBusinessLayer.FindApplicationByID(_ApplicationTypeID);
            }
        }
        private void _LoaD()
        {
            lblApplicationTypeIDK.Text = _ApplicationType.ApplicationTypeID.ToString();
            txtApplicationTypeTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtApplicatinTypeFees.Text = ((int)_ApplicationType.ApplicationFees).ToString();
        }

        private void btnApplicationTypeSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtApplicationTypeTitle.Text)&&!string.IsNullOrEmpty(txtApplicatinTypeFees.Text))
            {
                decimal ApplicationFees=default;
                decimal.TryParse(txtApplicatinTypeFees.Text, out ApplicationFees);
                _ApplicationType.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
                _ApplicationType.ApplicationFees = ApplicationFees;
                if(_ApplicationType.Update())
                {
                    clsUtilities.SendMessage("Updated Successfuly","Updated");
                }
                else
                {
                    clsUtilities.SendMessage("Not Updated Successfuly!", "Wrong!");
                }
            }
        }
        private void txtApplicationTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&&(!char.IsControl(e.KeyChar)))
                {
                e.Handled = true;
            }
        }
        private void txtApplicatinFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void FrmUpdateApplicationType_Load_1(object sender, EventArgs e)
        {
            _LoaD();
        }

        private void btnApplicationTypeClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
