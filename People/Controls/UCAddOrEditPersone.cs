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
    public partial class UCAddOrEditPersone : UserControl
    {
         int _PersoneID = -1;
        clsPerson _Persone;
        public event Action<int> PersoneSaved;
        public event Action<bool> btnSave;
        
        public UCAddOrEditPersone()
        {
            InitializeComponent();
        }
        private void _FillComboBoxCountry()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                cbPersoneCountry.Items.Add(row["CountryName"]);
            }
            cbPersoneCountry.SelectedIndex = cbPersoneCountry.FindString("Egypt");
        }
        private void _AddModeLoad()
        {
            _FillComboBoxCountry();
            _Persone = new clsPerson();
            llPersoneSetImage.Visible = true ;
            llPersoneRemoveImage.Visible = false;
          //  rbMale.Checked = true;
        }
        private void _EditMode(int PersoneID)
        {
            _FillComboBoxCountry();
            _Persone = clsPerson.Find(PersoneID);
        
            txtFirstName.Text = _Persone.FirstName;
            txtSecondName.Text = _Persone.SecondName;
            txtThirdName.Text = _Persone.ThirdName;
            txtLastName.Text = _Persone.LastName;
            txtNationalNumber.Text = _Persone.NationalNo;
            txtAddress.Text = _Persone.Address;
            txtPhone.Text = _Persone.Phone;
            txtEmail.Text = _Persone.Email;
            dtpDateOfBirth.Value = _Persone.DateOfBirth ;
            cbPersoneCountry.SelectedIndex = cbPersoneCountry.FindString(_Persone.CountryInfo.CountryName);
            if (_Persone.ImagePath != "" &&File.Exists(_Persone.ImagePath))
            {
                // openFileDialog1.FileName = _Persone.ImagePath;
                //pbPersoneImage.Image = Image.FromFile(openFileDialog1.FileName);
                pbPersoneImage.ImageLocation = _Persone.ImagePath;
                llPersoneSetImage.Visible = true;
                llPersoneRemoveImage.Visible = true;
            }
            else
            {
                if (_Persone.Gendor == 1)
                {
                    pbPersoneImage.Image = Properties.Resources.Male_512;
                }
                else
                {
                    pbPersoneImage.Image = Properties.Resources.Female_512;
                }
                llPersoneSetImage.Visible = true;
                llPersoneRemoveImage.Visible = false;
            }
            if(_Persone.Gendor== 0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
        }
        private void _LoaD(int PersoneID)
        {
            _PersoneID = PersoneID;
            if(_PersoneID == -1)
            {
                _AddModeLoad();
            }
            else
            {
                if(clsPerson.IsPersonExist(_PersoneID))
                {
                    _EditMode(_PersoneID);
                }
                else
                {
                    clsUtilities.SendMessage("Person Not Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public void LoadPersone(int PersoneID)
        {
          _LoaD(PersoneID);
        }
        private OpenFileDialog _SetOpenFileDialoge(OpenFileDialog openFileDialog1)
        {
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = "Image Files (*.jpg)|*.jpg |All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            return openFileDialog1;
        }
        private void _DestroyImage()
        {
            pbPersoneImage.Image.Dispose();
        }
        private void _SetMaleOrFemaleImage()
        {
            if (_Persone.Gendor == 0)
            {
                pbPersoneImage.Image = Properties.Resources.Male_512;
            }

            else
            {
                pbPersoneImage.Image = Properties.Resources.Female_512;
            }
        }
        private void llPersoneSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {
            _DestroyImage();
            openFileDialog1 = _SetOpenFileDialoge(openFileDialog1);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersoneImage.Load(openFileDialog1.FileName);
                llPersoneRemoveImage.Enabled = true;
            }
        }
        private void llPersoneRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _DestroyImage();
           _SetMaleOrFemaleImage();
            openFileDialog1.FileName ="";
            llPersoneRemoveImage.Visible = false;
        }
        private void _ValidateFormChilds()
        {
            if (!this.ValidateChildren())
            {
                clsUtilities.SendMessage("Please Fill all Required Fields!", "Cautions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void _FillPersonDetailFromTextBox()
        {
            _Persone.FirstName = txtFirstName.Text.Trim();
            _Persone.SecondName = txtSecondName.Text.Trim();
            _Persone.ThirdName = txtThirdName.Text.Trim();
            _Persone.LastName = txtLastName.Text.Trim();
            _Persone.NationalNo = txtNationalNumber.Text.Trim();
            _Persone.Address = txtAddress.Text.Trim();
            _Persone.Phone = txtPhone.Text.Trim();
            _Persone.Email = txtEmail.Text.Trim();
        }
        private void _FillDateOfBirth()
        {
            _Persone.DateOfBirth = dtpDateOfBirth.Value;
        }
        private void _FillNationalityCountryID()
        {
            int CountryID = clsCountry.Find(cbPersoneCountry.Text).ID;
            _Persone.NationalityCountryID = CountryID;
        }
        private void _FillGendorPeropty()
        {
            if (rbMale.Checked)
            {
                _Persone.Gendor = 1;
            }
            else
            {
                _Persone.Gendor = 0;
            }
        }
        private void _FillAndHandleImage()
        {
            if (openFileDialog1.FileName == ""&&(pbPersoneImage.Image != Properties.Resources.Male_512 || pbPersoneImage.Image != Properties.Resources.Female_512))
            {
                if ((openFileDialog1.FileName != "") && (openFileDialog1.FileName != _Persone.ImagePath))
                {
                    string OriginalPath = openFileDialog1.FileName;
                    string CopyImagePath = @"E:\DVLD_Images\";
                    string destinationFileName = Path.Combine(CopyImagePath, Guid.NewGuid() + Path.GetExtension(OriginalPath));

                    if (destinationFileName != _Persone.ImagePath && _Persone.ImagePath != "")
                    {
                        if (_Persone != null && !string.IsNullOrEmpty(_Persone.ImagePath) && File.Exists(_Persone.ImagePath))
                        {
                            try
                            {
                                pbPersoneImage.Image?.Dispose();
                                File.Delete(_Persone.ImagePath);
                            }
                            catch (Exception ex)
                            {
                                clsUtilities.SendMessage("Error deleting old image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    File.Copy(OriginalPath, destinationFileName, true);
                    pbPersoneImage.Image = Image.FromFile(destinationFileName);
                    _Persone.ImagePath = destinationFileName;
                }
                else if (_Persone.ImagePath != "" && openFileDialog1.FileName != _Persone.ImagePath)
                {
                    if (File.Exists(_Persone.ImagePath))
                    {
                        File.Delete(_Persone.ImagePath);
                    }
                    _Persone.ImagePath = "";
                }
            }
            else
            {
                _Persone.ImagePath = "";
            }
        }
        private void _FillAllPersoneDetails()
        {
            _FillPersonDetailFromTextBox();
            _FillDateOfBirth();
            _FillNationalityCountryID();
            _FillGendorPeropty();
            _FillAndHandleImage();
        }
        public void PersoneSave()
        {
            _ValidateFormChilds();
            _FillAllPersoneDetails();
            if (_Persone.Save())
            {
                clsUtilities.SendMessage("Person Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsUtilities.SendMessage("Person Not Saved!", "Error");
            }
            _PersoneID = _Persone.PersonID;
            LoadPersone(_PersoneID);
            if (PersoneSaved != null)
            {
                PersoneSaved(_PersoneID);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel=true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "FirstName should have a value");
            }
           else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtSecondName.Text))
            {
                e.Cancel = true;
                txtSecondName.Focus();
                errorProvider1.SetError(txtSecondName, "SecondName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecondName, "");
            }
        }
        private void txtThirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
            {
                e.Cancel = true;
                txtThirdName.Focus();
                errorProvider1.SetError(txtThirdName, "ThirdName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtThirdName, "");
            }
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "LastName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }
        private void txtNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNumber.Text))
            {
                e.Cancel = true;
                txtNationalNumber.Focus();
                errorProvider1.SetError(txtNationalNumber, "NationalNo should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNumber, "");
            }
        }
        private void txtNationalNumber_Validated(object sender, EventArgs e)
        {
            if(clsPerson.IsPersonExist(txtNationalNumber.Text))
            {
             
                txtNationalNumber.Focus();
                errorProvider1.SetError(txtNationalNumber, "This NationalNumber is already exist");
            }
            else
            {
             
                errorProvider1.SetError(txtNationalNumber, "");
            }
        }
        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (clsPerson.IsEmailExist(txtEmail.Text))
            {

                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "This Email is already exist");
            }
            else
            {

                errorProvider1.SetError(txtEmail, "");
            }
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Address should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
                btnSave(true);
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if(dtpDateOfBirth.Value == DateTime.Now)
            {
                e.Cancel = true;
                dtpDateOfBirth.Focus();
                errorProvider1.SetError(dtpDateOfBirth, "DateOfBirth should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpDateOfBirth, "");
            }
        }
        private void UCAddOrEditPersone_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MaxDate = currentDate;
        }
        private void rbMale_Click(object sender, EventArgs e)
        {
                pbPersoneImage.Image = Properties.Resources.Male_512;
                openFileDialog1.FileName = "";
        }
        private void rbFemale_Click(object sender, EventArgs e)
        {
                pbPersoneImage.Image = Properties.Resources.Female_512;
                openFileDialog1.FileName = "";   
        }
    }
}
