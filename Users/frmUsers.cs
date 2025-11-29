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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        private void _Fill_lbl_UserNumber()
        {
            lblUserNumbers.Text = dgvUsers.RowCount.ToString();
        }
        private void _FillIsActiveComboBox()
        {
            cbUserIsActive.Items.Add("All");
            cbUserIsActive.Items.Add("Yes");
            cbUserIsActive.Items.Add("No");
            cbUserIsActive.SelectedIndex= 0;
        }
        private void _FillComboBoxFilter()
        {
            cbUsersFilterBy.Items.Add("None");
            cbUsersFilterBy.Items.Add("User ID");
            cbUsersFilterBy.Items.Add("UserName");
            cbUsersFilterBy.Items.Add("Person ID");
            cbUsersFilterBy.Items.Add("Full Name");
            cbUsersFilterBy.Items.Add("Is Active");
        }
        private void _RefreshUsers()
        {
            dgvUsers.DataSource = clsUsers.GetAllUsers();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _Fill_lbl_UserNumber();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frmAddNewUserK = new FrmAddNewUser(-1);
            frmAddNewUserK.ShowDialog();
            _RefreshUsers();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            _FillComboBoxFilter();
            _RefreshUsers();
        }
        private void btnUsersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbUsersFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsersFilterBy.SelectedIndex > 0 && cbUsersFilterBy.SelectedIndex < 5)
            {
                cbUserIsActive.Visible = false;
                txtFilterUsers.Visible = true;
                txtFilterUsers.Enabled = true;
                _FilterProcess();
            }
            else if (cbUsersFilterBy.SelectedIndex == 5)
            {
                txtFilterUsers.Visible = false;
                cbUserIsActive.Visible = true;
                _FillIsActiveComboBox();
                _FilterProcess();
            }
            else
            {
                cbUserIsActive.Visible = false;
                txtFilterUsers.Visible = false;
                txtFilterUsers.Enabled = false;
                txtFilterUsers.Text = "";
            }
        }
        private void txtFilterUsers_TextChanged(object sender, EventArgs e)
        {
            _FilterProcess();
        }
        private void cbUserIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterProcess();
        }
        private void _FilterIsActive(DataView dv, string FilterType)
        {
            if (cbUserIsActive.SelectedItem != null && cbUserIsActive.SelectedItem.ToString() == "Yes")
            {
                dv.RowFilter = $"{FilterType} = true";
            }
            else if (cbUserIsActive.SelectedItem != null && cbUserIsActive.SelectedItem.ToString() == "No")
            {
                dv.RowFilter = $"{FilterType} = false";
            }
        }
        private void _FilterProcess()
        {
            if (cbUsersFilterBy.SelectedIndex > 0 && (txtFilterUsers.Text != ""||cbUserIsActive.Visible!=false))
            {
                try
                {
                    DataView dv = new DataView(clsUsers.GetAllUsers());
                    string FilterType = cbUsersFilterBy.SelectedItem.ToString().Replace(" ", "");
                    if (txtFilterUsers.Visible == true)
                    {
                        dv.RowFilter = $"{FilterType}= '{txtFilterUsers.Text}'";
                    }
                    else
                    {
                        _FilterIsActive(dv, FilterType);
                    }
                    if (dv.Count > 0 )
                    {
                        dgvUsers.DataSource = dv.ToTable();   
                    }
                    else if(cbUserIsActive.Visible==true&&(cbUserIsActive.SelectedItem.ToString()=="No"||cbUserIsActive.SelectedItem.ToString()=="Yes"))
                    {
                        dv.Table.Rows.Clear();
                        dgvUsers.DataSource = dv.ToTable();
                    }
                    _Fill_lbl_UserNumber();
                }
                catch { }
            }
            else
            {
                _RefreshUsers();
            }
        }
        private void showDetiailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            //_RefreshUsers();
        }
        private void addNewPersoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddNewUserK = new FrmAddNewUser(-1);
            frmAddNewUserK.ShowDialog();
            _RefreshUsers();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddNewUserK = new FrmAddNewUser((int)dgvUsers.CurrentRow.Cells[1].Value);
            frmAddNewUserK.ShowDialog();
            _RefreshUsers();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = clsUtilities.SendMessageToDialoge("Are you sure to delete this User!", "Caution Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (clsUsers.DeleteuserByID((int)dgvUsers.CurrentRow.Cells[0].Value))
                {

                    clsUtilities.SendMessage("Deleted Successfuly", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsUtilities.SendMessage("Not Delete User Successfuly", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _RefreshUsers();
            }
        }
        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form from = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[1].Value);
            from.ShowDialog();
        }
        private void txtFilterUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbUsersFilterBy.SelectedIndex == 1 || cbUsersFilterBy.SelectedIndex == 3)
            {
                if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            } 
            else if (cbUsersFilterBy.SelectedIndex == 2 || cbUsersFilterBy.SelectedIndex == 4)
            {
                if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                { e.Handled = true; }
            }
        }
    }
}
