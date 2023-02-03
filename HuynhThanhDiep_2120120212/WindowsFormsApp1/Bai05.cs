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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void Bai05_Load(object sender, EventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {

        }
        private void Bai05_KeyUp(object sender,KeyEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\kwy_Logger.txt", true);
            sw.Write(e.KeyCode);
            sw.Close();
        }

        
    }
}
