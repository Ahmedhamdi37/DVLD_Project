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
    public partial class FrmAddNewUser : Form
    {
        enum enMode { AddMode=1,EditMode=2}
        enMode _Mode = enMode.AddMode;

        int _PersonID = -1;
        clsUsers _User;
     
        public FrmAddNewUser(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            if(_PersonID==-1)
            {
                _User = new clsUsers();
                _Mode = enMode.AddMode;
            }
            else
            {
                _Mode = enMode.EditMode;
            }
        }
        private void _FillPersonCardInfo()
        {
           ucUserInfoWithFilter1.LoadPersoneDetails(_PersonID);
        }
        private void _FillucFilterListAllPeople()
        {
            ucFilters1.AllIndividualInDB = clsPerson.GetAllPeople();
        }
        private void _FillUserDetails()
        {
            lblUserIDInfoK.Text = _User.UserID.ToString();
            txtUserNameInfo.Text = _User.UserName;
            txtPasswordInfo.Text = _User.Password.ToString();
            txtConfirmPasswordInfo.Text = _User.Password.ToString();
            if (_User.IsActive != false)
            {
                chBIsActiveInfo.CheckState = CheckState.Checked;
            }
        }
        private void ucFilters1_evResultPersonAdded(int obj)
        {
            if (clsPerson.IsPersonExist(obj))
            {
                _PersonID = obj;
                _FillPersonCardInfo();
            }
            else
            {
                MessageBox.Show("No Person with  " + obj.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _AddUserLoad()
        {
            lblModeUser.Text = "Add New User";
            _FillucFilterListAllPeople();
        }
        private void _EditUserLoad()
        {
            lblModeUser.Text = "Update User";
            _FillucFilterListAllPeople();
            ucFilters1.FilltxtFilterWithPersonID(_PersonID);
            _FillPersonCardInfo();
            ucFilters1.Enabled = false;
            _User = clsUsers.FoundUserByPersonID(_PersonID);
            if (_User != null)
            {
                _FillUserDetails();
            }
        }
        private void _LoaD()
        {
            if (_Mode == enMode.AddMode)
            {
                _AddUserLoad();
            }
            else
            {
                _EditUserLoad();
            }
        }
        private void FrmAddNewUser_Load(object sender, EventArgs e)
        {
            _LoaD();
          
        }
        private void btnUserCloseInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPeopleClose_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1 && !clsUsers.IsUserExist(_PersonID))
            {
                tcAddNewUser.SelectedIndex = 1;
            }
            else
            {
                if (clsUsers.IsUserExist(_PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No Person with ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtUserNameInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtUserNameInfo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserNameInfo.Text))
            {
                e.Cancel = true;
                txtUserNameInfo.Focus();
                errorProvider1.SetError(txtUserNameInfo, "UserName cannot blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserNameInfo, "");
            }
        }
        private void txtPasswordInfo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordInfo.Text))
            {
                e.Cancel = true;
                txtPasswordInfo.Focus();
                // Set Error
                errorProvider1.SetError(txtPasswordInfo, "Fill Password");
            }
            else
            {
                e.Cancel = false;
                // closing Error
                errorProvider1.SetError(txtPasswordInfo, "");
            }
        }
        private void txtConfirmPasswordInfo_Validated(object sender, EventArgs e)
        {
            if (txtConfirmPasswordInfo.Text != txtPasswordInfo.Text)
            {
                txtConfirmPasswordInfo.Focus();
                errorProvider1.SetError(txtConfirmPasswordInfo, "Pasword Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPasswordInfo, "");
            }
        }
        private void txtConfirmPasswordInfo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPasswordInfo.Text))
            {
                e.Cancel = true;
                txtConfirmPasswordInfo.Focus();
                errorProvider1.SetError(txtConfirmPasswordInfo, "Fill Confirm Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPasswordInfo, "");
            }
        }
        private void btnUserSaveInfo_Click(object sender, EventArgs e)
        {

            _User.PersonID = _PersonID;
            _User.UserName= txtUserNameInfo.Text;

            _User.Password = DVLD.Utilities.clsSecurity.ComputeHash(txtPasswordInfo.Text);
            if (chBIsActiveInfo.CheckState == CheckState.Checked)
            {
                _User.IsActive = true;
            }else
            {
                _User.IsActive= false;
            }
           if(_User.Save())
            {
                MessageBox.Show("Saved Successfuly");

            }
           else
            {
                MessageBox.Show("Dont Saves Succesfuly");
            }
           _Mode=enMode.EditMode;
            _LoaD();
        }

        private void ucUserInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ucFilters1_Load(object sender, EventArgs e)
        {

        }
    }
}

