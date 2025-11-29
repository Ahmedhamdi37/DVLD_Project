using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FrmLicensesHistory: Form
    {

      //  int _LDLAppID = -1;
        string _NationalNo = "";
        clsPerson _Person;

        public FrmLicensesHistory(string  NationalNo)
        {
       //     _LDLAppID = LDLAppID;
            _NationalNo = NationalNo;

            InitializeComponent();
        }
        private void _LoadPerson()
        {
            if (!string.IsNullOrEmpty(_NationalNo))
            {
                _Person = clsPerson.Find(_NationalNo);
            }
        }
        private void _LoadPersonInfo()
        {
            _LoadPerson();
            if (_Person!=null)
            {
                ucFilters1.AllIndividualInDB = clsPerson.GetAllPeople();
                ucFilters1.FilltxtFilterWithPersonID(_Person.PersonID);
                ucFilters1.Enabled = false;
            }
        }
        private void _LoadDriverLicenses()
        {
            if(_Person!=null)
            {
                ucDriverLicenses1._RecieveData(_Person.PersonID);
            }
        }
        private void _LoaD()
        {
            _LoadPersonInfo();
            _LoadDriverLicenses();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ucFilters1_evResultPersonAdded(int obj)
        {
            ucPersonefo1.LoadPersoneDetails(obj);
        }
        private void FrmLicensesHistory_Load(object sender, EventArgs e)
        {
            _LoaD();
        }
    }
}
