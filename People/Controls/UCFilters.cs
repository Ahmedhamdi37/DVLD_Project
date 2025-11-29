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
    public partial class UCFilters : UserControl
    {
        public  DataTable AllIndividualInDB;
        private int _PersonID =-1;
        private DataTable _FilteredOnly;
        public event Action<int> evResultPersonAdded;

        private void _FilComboBoxFilter()
        {
            cbFilterBy.Items.Add("National No");
            cbFilterBy.Items.Add("Person ID");
            cbFilterBy.SelectedIndex = 0;   
        }
        public UCFilters()
        {
            InitializeComponent();
            _FilComboBoxFilter();
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            _FilterProcess();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _FilterProcess();
        }
        private void _FilterProcess()
        {
            _PersonID = -1;
            if (txtFilter.Text != "")
            {
                DataView dv = new DataView(AllIndividualInDB);
                string FilterType = cbFilterBy.SelectedItem.ToString().Replace(" ", "");

                dv.RowFilter = $"{FilterType}='{txtFilter.Text}'";

                if (dv.Count > 0)
                {
                    _FilteredOnly = dv.ToTable();
                    int.TryParse(_FilteredOnly.Rows[0]["PersonID"].ToString(), out _PersonID);
                }
            }
        }
        private void _SendPersonIDToForm()
        {
            if (evResultPersonAdded != null)
            {
                Action<int> handler = evResultPersonAdded;
                handler(_PersonID);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(_PersonID>-1)
            {
                _SendPersonIDToForm();
            }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddOrEditPersone.DataBack += frmAddOrEditPersone_DataBack;
            Form frm = new frmAddOrEditPersone(-1);
            frm.ShowDialog();
            frmAddOrEditPersone.DataBack -= frmAddOrEditPersone_DataBack;
        }
        private void frmAddOrEditPersone_DataBack(object sender ,int PersoneID,DataTable AllPeople)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilter.Text= PersoneID.ToString();
            AllIndividualInDB = AllPeople;
            _FilterProcess();
            _SendPersonIDToForm();
        }
        public  void FilltxtFilterWithPersonID(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
            _SendPersonIDToForm();
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 1)
            {
                if(!char.IsDigit(e.KeyChar)&&(!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}







