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
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void _FillDriversComboBox()
        {
            cbDriversFilterBy.Items.Add("None");
            cbDriversFilterBy.Items.Add("Driver ID");
            cbDriversFilterBy.Items.Add("Person ID");
            cbDriversFilterBy.Items.Add("National No");
            cbDriversFilterBy.Items.Add("Full Name");
            cbDriversFilterBy.SelectedIndex = 0;
        }
        private void _FillDriverNumbers()
        {
            lblDriverNumbers.Text = dgvDrivers.RowCount.ToString();
        }
        private void _Refresh()
        {
            dgvDrivers.DataSource = clsDrivers.ListDrivers();
            clsFormate.FormateDataGirdView(dgvDrivers);
            _FillDriverNumbers();
        }
        private void _LoaD()
        {
            _FillDriversComboBox();
            _Refresh();
        }
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbDriversFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDriversFilterBy.SelectedIndex > 0)
            {
                txtFilterDrivers.Enabled = true;
                _FilterProcess();
            }
            else
            {
                txtFilterDrivers.Enabled = false;
                txtFilterDrivers.Text = "";
            }
        }
        private void txtFilterDrivers_TextChanged(object sender, EventArgs e)
        {
            _FilterProcess();
        }
        private void _FilterProcess()
        {
            if (cbDriversFilterBy.SelectedIndex > 0 && (txtFilterDrivers.Text != ""))
            {
                try
                {
                    DataView dv = new DataView(clsDrivers.ListDrivers());
                    string FilterType = cbDriversFilterBy.SelectedItem.ToString().Replace(" ", "");

                    dv.RowFilter = $"{FilterType}= '{txtFilterDrivers.Text}'";

                    if (dv.Count > 0)
                    {
                        dgvDrivers.DataSource = dv.ToTable();
                        _FillDriverNumbers();
                    }
                }
                catch { }
            }
            else
            {
                _Refresh();
            }
        }
        private void txtFilterDrivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cbDriversFilterBy.SelectedIndex == 1 || cbDriversFilterBy.SelectedIndex == 2) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (cbDriversFilterBy.SelectedIndex == 4 && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
