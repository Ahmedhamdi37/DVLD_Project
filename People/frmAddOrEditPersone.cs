using ClsDVLDBusinessLayer;
using DVLD_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmAddOrEditPersone : Form
    {
        enum Mode { AddMode = 0, UpdateMode = 1 }
        Mode _Mode = Mode.AddMode;
        int _PersonID = -1;
        DataTable _AllPeople = new DataTable();

        public delegate void DataBackEventHandler(object sender, int PersoneID, DataTable AllPeople);
        public static  event DataBackEventHandler DataBack;

        public frmAddOrEditPersone()
        {
            InitializeComponent();
            _Mode = Mode.AddMode;
        }

        public frmAddOrEditPersone(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
                _Mode = Mode.UpdateMode;
        }
        private void _AddModeLoad()
        {
            lblAddNewPersone.Text = "Add New Persone";
            btnPersoneSave.Enabled = false;
        }
        private void _UpdateModeLoad()
        {
            lblAddNewPersone.Text = "Update Persone ";
              lblPersoneIDNo.Text = _PersonID.ToString();
        }
        private void _LoaD()
        {
            if (_Mode == Mode.AddMode)
            {
                _AddModeLoad();
                ucAddOrEditPersone1.LoadPersone(_PersonID);
            }
            else
            {
                _UpdateModeLoad();
                ucAddOrEditPersone1.LoadPersone(_PersonID);
            }
        }
        private void frmAddOrEditPersone_Load_1(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void btnPersoneClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _PersonID,_AllPeople);
            this.Close();
        }
        private void btnPersoneSave_Click(object sender, EventArgs e)
        {
            ucAddOrEditPersone1.PersoneSave();
            _AllPeople = clsPerson.GetAllPeople(); 
        }
        private void ucAddOrEditPersone1_PersoneSaved(int obj)
        {
            _PersonID = obj;
            if(_PersonID == -1)
            {
                _Mode = Mode.AddMode;
            }
            else
            {
                _Mode = Mode.UpdateMode;
            }
            _LoaD();
        }
        private void ucAddOrEditPersone1_btnSave(bool obj)
        {
            btnPersoneSave.Enabled = obj;
        }
    }
}
