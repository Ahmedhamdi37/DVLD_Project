using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    class clsFormate
    {
        public static  string  FormateDate(DateTime Date)
        {
            return Date.ToString("dd/MM/yyyy");
        }
        public static void FormateDataGirdView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    }
}
