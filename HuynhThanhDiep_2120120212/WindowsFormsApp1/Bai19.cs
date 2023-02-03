﻿using System;
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
    public partial class Bai19 : Form
    {
        private void BtFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.ImageLocation = @"D:\abc.jpg";
        }
        public Bai19()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}
