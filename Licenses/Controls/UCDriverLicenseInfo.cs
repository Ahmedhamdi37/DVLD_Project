using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class UCDriverLicenseInfo : UserControl
    {
        int _LDLAppID = -1;
        clsApplicatations _Application;
        clsPerson _Person;
        clsLicenses _License;
        clsLicenseClasses _LicenseClass;
        public event Action<string> evPersonNationalNo;

        public UCDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadPerson()
        {
            _Person = clsPerson.Find(_Application.PersonID);
            if (_Person != null)
            {
                lblNameK.Text = _Person.FullName;
                lblNationalNoK.Text = _Person.NationalNo;
                if (_Person.Gendor != 1)
                {
                    pbGendor.Image = Properties.Resources.Man_32;
                    lblGendorK.Text = "Male";
                }
                else
                {
                    pbGendor.Image = Properties.Resources.Woman_32;
                    lblGendorK.Text = "Female";
                }
                lblDateOfBirthK.Text = clsFormate.FormateDate(_Person.DateOfBirth);
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    pbDriver.ImageLocation = _Person.ImagePath;
                }
            }
        }
        private void _HandleIssueReason()
        {
            switch (_License.IssueReason)
            {
                case 1:
                    lblIssueReasonK.Text = "First Time";
                    break;
                case 2:
                    lblIssueReasonK.Text = "Renew";
                    break;
                case 3:
                    lblIssueReasonK.Text = "Replacement For Damaged";
                    break;
                case 4:
                    lblIssueReasonK.Text = "Replacement For Lost";
                    break;
            }
        }
        private void _LoadLicense()
        {
            _License = clsLicenses.Find(_Application.ApplicationID);
            if (_License != null)
            {
                lblLicenseIDK.Text = _License.LicenseID.ToString();
                lblIssueDateK.Text = clsFormate.FormateDate(_License.IssueDate);
                lblExpirationDateK.Text = clsFormate.FormateDate(_License.ExpirationDate);
                lblDriverIDK.Text = _License.DriverID.ToString();

                _HandleIssueReason();

                if (string.IsNullOrEmpty(_License.Notes))
                {
                    lblNotesK.Text = "No Notes";
                }
                else
                {
                    lblNotesK.Text = _License.Notes;
                }
                if (_License.IsActive != true)
                {
                    lblIsActiveK.Text = "No";
                }
                else
                {
                    lblIsActiveK.Text = "Yes";
                }
                if (clsDetainedLicenses.LicenseIsDetained(_License.LicenseID))
                {
                    lblIsDetainedK.Text = "Yes";
                }
                else
                {
                    lblIsDetainedK.Text = "No";
                }
            }
        }
        private void _LoadLicenseClass()
        {
            if (_License != null)
            {
                _LicenseClass = clsLicenseClasses.Find(_License.LicenseClass);
                if (_LicenseClass != null)
                {
                    lblClassK.Text = _LicenseClass.ClassName;
                }
            }
        }
        private void _LoadAllData()
        {
            _Application = clsApplicatations.FoundApplication(_LDLAppID);
            if (_Application != null)
            {
                _LoadPerson();
                _LoadLicense();
                _LoadLicenseClass();
            }
            if(evPersonNationalNo!=null)
            {
                evPersonNationalNo(_Person.NationalNo);
            }
        }
        public void RecieveData(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            if (_LDLAppID > -1)
            {
                _LoadAllData();
            }
        }
    }
}
