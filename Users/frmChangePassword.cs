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
    public partial class frmChangePassword : Form
    {
        int _PersonID = -1;
        clsUsers _User;

        public frmChangePassword(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void _LoaD()
        {
            if (_PersonID > -1)
            {
                _User=clsUsers.FoundUserByPersonID(_PersonID);
                UCUserInfoforChangePassword.LoadPersoneDetails(_PersonID);
                ucLoginInfo1._LoaDLoginInfo(_PersonID);
            }
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoaD();    
        }

        private void txtCurrentPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "shoud equls NewPassword");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnCloseChangePassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChangePassword_Click(object sender, EventArgs e)
        {
            
             if (DVLD.Utilities.clsSecurity.ComputeHash(txtCurrentPassword.Text) == _User.Password && txtNewPassword.Text != "")
            {
                _User.Password = DVLD.Utilities.clsSecurity.ComputeHash(txtNewPassword.Text);
                if (_User.Save())
                {
                    clsUtilities.SendMessage("Updated Current Password Successfuly", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsUtilities.SendMessage("What's Wrong! Not Updated Succesfully",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
