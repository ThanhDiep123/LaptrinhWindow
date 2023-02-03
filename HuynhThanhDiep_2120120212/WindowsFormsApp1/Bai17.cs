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
    public partial class Bai17 : Form
    {
        public Bai17()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string song = lbSong.SelectedItem.ToString();
            lbFavorite.Items.Add(song);
            lbSong.Items.RemoveAt(lbSong.SelectedIndex);
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
       
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSong.Items.Count; i++)
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }
    }
}
