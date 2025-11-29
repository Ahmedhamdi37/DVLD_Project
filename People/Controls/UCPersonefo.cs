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
    public partial class UCPersonefo : UserControl
    {
        int _PersoneID = -1;
        clsPerson _Persone;

        public UCPersonefo()
        {
            InitializeComponent();
        }
        private void _FillAndHandlePictureImage()
        {
            if (_Persone.ImagePath != "" && File.Exists(_Persone.ImagePath))
            {
                pbPersoneImageInfo.Image = Image.FromFile(_Persone.ImagePath);
            }
            else
            {
                if (_Persone.Gendor == 1)
                {
                    pbPersoneImageInfo.Image = Properties.Resources.Male_512;
                }
                else
                {
                    pbPersoneImageInfo.Image = Properties.Resources.Female_512;
                }
            }
        }
        private void _FillPersoneCountry()
        {
            lblPersoneCountryInfoK.Text = _Persone.CountryInfo.CountryName ;
        }
        private void _FillGendorPeropty()
        {
            if (_Persone.Gendor == 1)
            {
                lblPersoneGendorInfoK.Text = "Male";
            }
            else
            {
                lblPersoneGendorInfoK.Text = "Female";
            }
        }
        private void _FillPersoneTextBoxs()
        {
            _FillGendorPeropty();
            _FillPersoneCountry();
            _FillAndHandlePictureImage();
            lblPersoneIDInfok.Text = _PersoneID.ToString();
            lblPersoneNameInfoK.Text = _Persone.FirstName + " " + _Persone.SecondName + " " + _Persone.ThirdName + " " + _Persone.LastName;
            lblPersoenNationalNoInfoK.Text = _Persone.NationalNo;
            lblPersoneDateOfBirthInfoK.Text = _Persone.DateOfBirth.ToString();
            lblPersonePhoneiInfoK.Text = _Persone.Phone;
            lblPersoneEmailInfoK.Text = _Persone.Email;
            lblPersoneAddressInfoK.Text = _Persone.Address;
        }
        private void _LoaD(int PersoneID)
        {
            _PersoneID = PersoneID;
            _Persone = clsPerson.Find(_PersoneID);
            _FillPersoneTextBoxs();
        }
        public void LoadPersoneDetails(int PersoneID)
        {
            _LoaD(PersoneID);
        }
        private void llblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddOrEditPersone(_PersoneID);
            frm.ShowDialog();
            LoadPersoneDetails(_PersoneID);
        }
    }
}
