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
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }
        private void _FillComboBoxFilter()
        {
            cbPeopleFilterBy.Items.Add("None");
            cbPeopleFilterBy.Items.Add("Person ID");
            cbPeopleFilterBy.Items.Add("National No");
            cbPeopleFilterBy.Items.Add("First Name");
            cbPeopleFilterBy.Items.Add("Second Name");
            cbPeopleFilterBy.Items.Add("Third Name");
            cbPeopleFilterBy.Items.Add("Last Name");
            cbPeopleFilterBy.Items.Add("Nationality");
            cbPeopleFilterBy.Items.Add("Gendor");
            cbPeopleFilterBy.Items.Add("Phone");
            cbPeopleFilterBy.Items.Add("Email");

        }
        private void _FillPeopleNumbers()
        {
            lblPeopleNumbers.Text = dgvPeople.RowCount.ToString();
        }
        private  void _RefreshPeople()
        {
          
            dgvPeople.DataSource = clsPerson.GetAllPeople();
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            _FillPeopleNumbers();
        }
        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddOrEditPersone(-1);
            frm.ShowDialog();
            _RefreshPeople();
        }
        private void btnPeopleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showDetiailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersoneDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeople();
        }
        private void addNewPersoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddOrEditPersone(-1);
            frm.ShowDialog();
            _RefreshPeople();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddOrEditPersone((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeople();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult result = clsUtilities.SendMessageToDialoge("Are you sure to delete this Persone!", "Caution Delete", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    clsUtilities.SendMessage("Deleted Successfuly", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsUtilities.SendMessage("Not Delete Person Successfuly", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _RefreshPeople();
            }
        }
        private void btnAddPeople_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmAddOrEditPersone(-1);
            frm.ShowDialog();
            _RefreshPeople();
        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
            _FillComboBoxFilter();
            _RefreshPeople();  
        }
        private void cbPeopleFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeopleFilterBy.SelectedIndex > 0)
            {
                txtFilterPeople.Enabled = true;
                _FilterProcess();
            }
            else
            {
                txtFilterPeople.Enabled = false;
                txtFilterPeople.Text = "";
            }
        }
        private void txtFilterPeople_TextChanged(object sender, EventArgs e)
        {
            _FilterProcess();
        }
        private void _FilterProcess()
        {
            if (cbPeopleFilterBy.SelectedIndex > 0 && (txtFilterPeople.Text != ""))
            {
                try
                {
                    DataView dv = new DataView(clsPerson.GetAllPeople());
                    string FilterType = cbPeopleFilterBy.SelectedItem.ToString().Replace(" ", "");
                  
                    dv.RowFilter = $"{FilterType}= '{txtFilterPeople.Text}'";

                    if (dv.Count > 0)
                    {
                        dgvPeople.DataSource = dv.ToTable();
                        _FillPeopleNumbers();
                    }
                }
                catch { }
            }
            else
            {
              _RefreshPeople();
            }
            
        }
        private void txtFilterPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbPeopleFilterBy.SelectedIndex == 1 || cbPeopleFilterBy.SelectedIndex == 8) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if ((cbPeopleFilterBy.SelectedIndex > 2 && cbPeopleFilterBy.SelectedIndex < 8) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
