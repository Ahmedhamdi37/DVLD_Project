using ClsDVLDBusinessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FrmLoginScreen : Form
    {
        private bool IsSignOut = false;

        string RegistryPath = @"Software\DVLD\RememberMe";

        public FrmLoginScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void FrmLoginScreen_Load(object sender, EventArgs e)
        {
            _LoadUserInfoFromRememberMe();
        }
        private void btnCloseLoginScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private bool IsNullOrEmpityTextBoxesForLogin(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                text.Focus();
                errorProvider1.SetError(text, $"Fill {text.Name} Please!");
                return false;
            }
            else
            {
                errorProvider1.SetError(text, "");
                return true;
            }
        }
        private bool CheckBoxes()
        {
            return (IsNullOrEmpityTextBoxesForLogin(txtUserName) && IsNullOrEmpityTextBoxesForLogin(txtPassword));
        }
        private void _DeleteUserInfoFromRememberMe()
        {
            using (var Key = Registry.CurrentUser.OpenSubKey(RegistryPath, true))
            {
                if (Key == null) return;
                Key.DeleteValue("username", false);
                Key.DeleteValue("password",false);
            }
        }
        private void _LoadUserInfoFromRememberMe()
        {
            using (var Key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (Key == null) return;
                txtUserName.Text = Key.GetValue("username") as string ?? string.Empty;
                txtPassword.Text = Key.GetValue("password") as string ?? string.Empty ;
            }
            if(!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                CBRememberMe.CheckState = CheckState.Checked;
            }
        }
        private bool _SendUserInfoToRememberMe(string UserName, string Password)
        {
            try
            {
                if(!string.IsNullOrEmpty(UserName) &&!string.IsNullOrEmpty( Password))
                {
                    using (var Key =Registry.CurrentUser.CreateSubKey(RegistryPath,true))
                    {
                        Key.SetValue("username", UserName);
                        Key.SetValue("password", Password);
                    }
                }
            }
            catch(Exception ex)
            {
                clsUtilities.SendMessage("An Error occured: " + ex.Message);
                return false;
            }
            return true;
        }
        private bool _CheckMatchesPasswords()
        {
            return (DVLD.Utilities.clsSecurity.ComputeHash(txtPassword.Text) == clsUtilities.User.Password);
        }
        private bool _CheckIsActive()
        {
            return (clsUsers.IsUserActive(clsUtilities.User.UserID));
        }
        private bool _RememberMeProccess()
        {
            _DeleteUserInfoFromRememberMe();
            if (CBRememberMe.CheckState == CheckState.Checked)
            {
               return  _SendUserInfoToRememberMe(txtUserName.Text, txtPassword.Text);
            }
            return false;
        }
        private void _LoadMainFormProccess()
        {
            MainFrm.DataBack += IsSignOut_Click;
            Form frm = new MainFrm();
            this.Hide();
            frm.ShowDialog();
            MainFrm.DataBack -= IsSignOut_Click;
        }
        private void _SignOutProccess()
        {
            if (IsSignOut != true)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        private void _MainFormProccess()
        {
            _LoadMainFormProccess();
            _SignOutProccess();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckBoxes())
            {
                clsUtilities.User = clsUsers.FoundUserByUserName(txtUserName.Text);

                if (clsUtilities.User != null)
                {
                    if (_CheckMatchesPasswords())
                    {
                        if (_CheckIsActive())
                        {
                           if( _RememberMeProccess())
                            {
                                _MainFormProccess();
                            }
                        }
                        else clsUtilities.SendMessage("This User Not Active!");
                    }
                    else clsUtilities.SendMessage("Password InCorrect!,Please Fill Password Correct");
                }
                else clsUtilities.SendMessage("This User Not Exist!");
            }
        }
        private void IsSignOut_Click(object sender, bool IssignOut)
        {
            IsSignOut = IssignOut;
        }
    }
}


