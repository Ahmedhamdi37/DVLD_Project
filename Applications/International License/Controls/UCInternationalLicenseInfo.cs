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
    public partial class UCInternationalLicenseInfo : UserControl
    {
        int _PersonID = -1;
        int _LLicenseID = -1;
        clsInternationalLicenses _ILicense;
        clsPerson _Person ;

        public UCInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        private void _FillPersonData()
        {
            if(_PersonID>-1)
            {
                _Person = clsPerson.Find(_PersonID);
                lblDriverNameK.Text = _Person.FullName;
                lblNationalNoK.Text = _Person.NationalNo;
                lblDateOfBirthK.Text = clsFormate.FormateDate(_Person.DateOfBirth);
                if(_Person.Gendor==0)
                {
                    pbGendor.Image = Properties.Resources.Man_32;
                    lblGendorK.Text = "Male";
                }
                else
                {
                    pbGendor.Image = Properties.Resources.Woman_32;
                    lblGendorK.Text = "Female";
                }
            }
        }
        private void _FillILicenseData()
        {
            if(_LLicenseID>-1)
            {
                _ILicense = clsInternationalLicenses.Find(_LLicenseID);
                //FillILicense
                lblInternationalIiceIDK.Text = _ILicense.ILicenseID.ToString();
                lblLLicenseIDK.Text = _ILicense.LLicenseID.ToString();
                lblIssueDateK.Text = clsFormate.FormateDate(_ILicense.IssueDate);
                lblExpirationDateK.Text = clsFormate.FormateDate(_ILicense.ExpirationDate);
                lblApplicationIDK.Text = _ILicense.ApplicationID.ToString();
                lblDriverIDK.Text = _ILicense.DriverID.ToString();
                if (_ILicense.IsActive == true)
                {
                    lblIsActiveK.Text = "Yes";
                }
                else
                {
                    lblIsActiveK.Text = "No";
                }
            }
        }
        private void _LoaD()
        {
            _FillPersonData();
            _FillILicenseData();
        }
        public void RecieveData(int PersonID,int LLicenseID)
        {
            _PersonID = PersonID;
            _LLicenseID = LLicenseID;
            _LoaD();
        }
    }
}
