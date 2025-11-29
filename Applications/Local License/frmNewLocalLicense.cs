using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmNewLocalLicense : Form
    {
        enum enMode { AddMode=1,UpdateMode=2}
        enMode _Mode = enMode.AddMode;

        DataTable _AllLicenseClasses;
        DataTable _LicenseClasses;
        int _PersonID = -1;
        int _LicenseClassID = -1;
        int _ClassFees = 0;
        clsLocalDrivingLicenseApplication _LocalApplication;

        public frmNewLocalLicense()
        {
            InitializeComponent();
            _AllLicenseClasses = clsLicenseClasses.ListLicenseClasses();
            _LocalApplication = new clsLocalDrivingLicenseApplication();
        }
        private void _FillComboBoxLicenseClasses()
        {
            cbLocalLicenseClass.Items.Add("Class 1 - Small Motorcycle");
            cbLocalLicenseClass.Items.Add("Class 2 - Heavy Motorcycle License");
            cbLocalLicenseClass.Items.Add("Class 3 - Ordinary driving license");
            cbLocalLicenseClass.Items.Add("Class 4 - Commercial");
            cbLocalLicenseClass.Items.Add("Class 5 - Agricultural");
            cbLocalLicenseClass.Items.Add("Class 6 - Small and medium bus");
            cbLocalLicenseClass.Items.Add("Class 7 - Truck and heavy vehicle");
            cbLocalLicenseClass.SelectedIndex = 2;
        }
        private void _AddMode()
        {
            ucPersonFilterAddNewLocalLicenseApplication.AllIndividualInDB = clsPerson.GetAllPeople();
            _FillComboBoxLicenseClasses();

            lblNewLocalLicenseApplicationDateK.Text = DateTime.Today.ToString("yyyy/MM/dd");
            lblLocalLicenseCreatedByK.Text = clsUtilities.User.UserName;
            _FilterProccess();
        }
        private void _UpdateMode()
        {
            lblDLApplicationIDK.Text = _LocalApplication.ApplicationID.ToString();
        }
        private void _LoaD()
        {
            if(_Mode==enMode.AddMode)
            {
                _AddMode();
            }
            else
            {
                _UpdateMode();  
            }
          
        }
        private void cbLocalLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterProccess();
        }
        private void frmNewLocalLicense_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
        private void _FilterProccess()
        {
            DataView dv = new DataView(_AllLicenseClasses);

            string FilterString = cbLocalLicenseClass.SelectedItem.ToString();

            dv.RowFilter = $"ClassName='{FilterString}'";
            if (dv.Count > 0)
            {
                _LicenseClasses = dv.ToTable();
                _LicenseClassID = Convert.ToInt32(_LicenseClasses.Rows[0][0]);
                _ClassFees = Convert.ToInt32(_LicenseClasses.Rows[0].Field<decimal?>(5) ?? 0m);
                lblLocalLicenseApplicationFeesK.Text = _ClassFees.ToString();
            }
        }
        private void btnNewLocalLicenseApplicationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _FillApplication()
        {
            _LocalApplication.PersonID = _PersonID;
            _LocalApplication.ApplicationTypeID = 1;
            _LocalApplication.LastDate = DateTime.Today.AddYears(Convert.ToInt32(_LicenseClasses.Rows[0][4]));
            _LocalApplication.ApplicationFees = _ClassFees;
            _LocalApplication.createdByUserID = clsUtilities.User.UserID;
            _LocalApplication.LicenseClassID = _LicenseClassID;
        }
        private void btnNewLocalLicenseApplicationSave_Click(object sender, EventArgs e)
        {
            int ApplicationID = clsLocalDrivingLicenseApplication.IsApplicationExist(_PersonID, _LicenseClassID);
            if (ApplicationID>-1)
            {
                clsUtilities.SendMessage($"Choese another License Class, the selected Person Already have an Active Application for the selected class with id={ApplicationID}");
            }
            else
            {
               _FillApplication();
                if (_LocalApplication.Save())
                {
                    clsUtilities.SendMessage("Saved Data Successfuly", "Saved Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.UpdateMode;
                    _LoaD();
                }
                else { clsUtilities.SendMessage("Not Saved Data Successfuly"); }
            }
        }

        private void ucPersonFilterAddNewLocalLicenseApplication_evResultPersonAdded(int obj)
        {
            _PersonID = obj;
            ucPersonInfoLocalLicenseApplicationWithFilter1.LoadPersoneDetails(obj);
        }
        private void btnNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            if (_PersonID > -1)
            {
                tcAddNewLocalLicenseApplication.SelectedIndex = 1;
            }
            else { clsUtilities.SendMessage("Please Select Any Person Before Add New Local License!"); }
        }
        private void tcAddNewLocalLicenseApplication_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tcAddNewLocalLicenseApplication.SelectedIndex == 1 && _PersonID == -1)
            {
                e.Cancel = true;
                clsUtilities.SendMessage("Please Select Any Person Before Add New Local License!");

            }
            else if (tcAddNewLocalLicenseApplication.SelectedIndex == 0)
            {
                tcAddNewLocalLicenseApplication.SelectedIndex = 0;
            }
            else
            {
                tcAddNewLocalLicenseApplication.SelectedIndex = 1;
            }
        }
    }
}


