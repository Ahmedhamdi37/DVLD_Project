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
    public partial class FrmManageTestTypes: Form
    {
        public FrmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _FillTestTypesNumbers()
        {
            lblTestTypesNumbers.Text = dgvTestTypes.RowCount.ToString();
        }
        private void _Refresh()
        {
            dgvTestTypes.DataSource = clsTestTypes.ListTestTypes();
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
           
        }
        private void _LoaD()
        {
            _Refresh();
            _FillTestTypesNumbers();
        }

        private void FrmManageTestTypes_Load(object sender, EventArgs e)
        {
          _LoaD();
        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmUpdateTestType ((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoaD();
        }
    }
}
