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
    public partial class FrmUpdateTestType: Form
    {
        int _TestTypeTypeID = -1;
        clsTestTypes _TestType;

        public FrmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeTypeID= TestTypeID;    
            if(_TestTypeTypeID>-1)
            {
                _TestType=clsTestTypes.FindTestTypeByID(_TestTypeTypeID);
            }
        }
        private void _LoaD()
        {
            lblTestTypeIDK.Text = _TestType.TestTypeID.ToString();
            txtTestTypeTitle.Text = _TestType.TestTypeTitle;
            txtTestTypeDescription.Text = _TestType.TestTypeDescription;
            txtTestTypeFees.Text =_TestType.TestTypeFees.ToString();
        }
        private void FrmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnTestTypeTypeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTestTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtTestTypeDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtTestTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void btnTestypeSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTestTypeTitle.Text) && (!string.IsNullOrEmpty(txtTestTypeDescription.Text)&&!string.IsNullOrEmpty(txtTestTypeFees.Text)))
            {
                _TestType.TestTypeTitle=txtTestTypeTitle.Text;
                _TestType.TestTypeDescription=txtTestTypeDescription.Text;
                _TestType.TestTypeFees= Convert.ToInt32(txtTestTypeFees.Text);

                if (_TestType.Update())
                {
                    clsUtilities.SendMessage("Updated Successfuly", "Updated");
                }
                else
                {
                    clsUtilities.SendMessage("Not Updated Successfuly!", "Wrong!");
                }
            }
        }
    }
}






