using ClsDVLDBusinessLayer;
using DVLD_Project;
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
    public partial class frmShowEditApplicationType: Form
    {
        int _ApplicationTypeID = -1;
        clsApplicationTypes _ApplicationType;

        public frmShowEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
            if (_ApplicationTypeID > -1)
            {
                _ApplicationType = clsApplicationTypes.FoundApplicationByID(_ApplicationTypeID);
            }
        }
        private void _LoaD()
        {
            lblApplicationTypeIDK.Text = _ApplicationType.ApplicationTypeID.ToString();
            txtApplicationTypeTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtApplicatinTypeFees.Text = _ApplicationType.ApplicationFees.ToString();
        }
        private void frmShowEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnApplicationTypeSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApplicationTypeTitle.Text) && !string.IsNullOrEmpty(txtApplicatinTypeFees.Text))
            {
                _ApplicationType.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
                _ApplicationType.ApplicationFees = Convert.ToInt32(txtApplicatinTypeFees.Text);

                if (_ApplicationType.Update())
                {
                    clsUtilities.SendMessage("Updated Successfuly", "Updated", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    clsUtilities.SendMessage("Not Updated Successfuly!", "Wrong!");
                }
            }
        }
        private void txtApplicationTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtApplicatinTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void btnApplicationTypeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
