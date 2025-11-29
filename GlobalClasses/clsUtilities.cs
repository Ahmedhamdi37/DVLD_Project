using ClsDVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    internal class clsUtilities
    {
     public static clsUsers User;

        public static void SendMessage(string Message, string Caption="Error", MessageBoxButtons Buton = MessageBoxButtons.OK, MessageBoxIcon Icon = MessageBoxIcon.Error)
        {
            MessageBox.Show(Message, Caption, Buton, Icon);
        }
        public static DialogResult SendMessageToDialoge(string Message, string Caption, MessageBoxButtons Buton, MessageBoxIcon Icon)
        {
            return MessageBox.Show(Message, Caption, Buton, Icon);
        }


    }
}
