using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bai14 : Form
    {
        public Bai14()
        {
            InitializeComponent();
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTinhtien_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (rbNam.Checked == true)
                msg += "ông ";
            if (rbNu.Checked == true)
                msg += "Bà ";
            if (ckDiscount.Checked == true)
                disc = 5;
            tbketqua.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }
    }
}
