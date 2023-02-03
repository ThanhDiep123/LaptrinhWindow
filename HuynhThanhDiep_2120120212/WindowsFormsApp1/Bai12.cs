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
    public partial class Bai12 : Form
    {

        public Bai12()
        {
            InitializeComponent();
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void Bai12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedIndex.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
    }
}
