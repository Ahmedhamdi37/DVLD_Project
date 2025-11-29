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
    public partial class frmPersoneDetails : Form
    {
        int _PersoneID = -1;
      
        public frmPersoneDetails(int personeID)
        {
            InitializeComponent();
            _PersoneID = personeID;
        }

        private void _LoaDPersoneDetails(int PersoneID)
        {
            if (PersoneID != -1)
            {
                if (clsPerson.IsPersonExist(PersoneID))
                {
                    UCUserInfoC1.LoadPersoneDetails(PersoneID);
                }
                else
                {
                    clsUtilities.SendMessage($"Persone for this ID ={PersoneID} Not Found","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clsUtilities.SendMessage("PersonID is not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPersoneDetails_Load(object sender, EventArgs e)
        {
            _LoaDPersoneDetails(_PersoneID);
        }
        private void btnUsersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
