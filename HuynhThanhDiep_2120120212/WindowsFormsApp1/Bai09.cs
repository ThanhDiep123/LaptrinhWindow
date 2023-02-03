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

namespace WindowsFormsApp1
{
    public partial class Bai09 : Form
    {
        public Bai09()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSox.Text);
            int y = int.Parse(txtSoy.Text);
            int kq = x + y;
            tbKetqua.Text = tbKetqua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSox.Text);
            int y = int.Parse(txtSoy.Text);
            int kq = x * y;
            tbKetqua.Text = tbKetqua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKetqua.Text);
            sw.Close();
        }

        private void btThaot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
