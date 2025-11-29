using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FrmManageApplicationTypes: Form
    {
        public FrmManageApplicationTypes()
        {
            InitializeComponent();
        }
        private void _FillApplicationNumbers()
        {
            lblApplicationsTypesNumbers.Text = dgvApplicationTypes.RowCount.ToString();
        }
        private void _Refresh ()
        {
            dgvApplicationTypes.DataSource = clsApplicationTypes.ListApplicationTypes();
            dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ;
            dgvApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
         
        }
        private void _LoaD()
        {
            _Refresh();
            _FillApplicationNumbers();
        }

        private void btnApplicationTypes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmShowEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
