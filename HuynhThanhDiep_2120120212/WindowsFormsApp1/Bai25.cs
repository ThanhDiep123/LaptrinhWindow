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
    public partial class Bai25 : Form
    {
        PictureBox pbImage = new PictureBox();
        Timer tmGame = new Timer();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;
        public Bai25()
        {
            InitializeComponent();
        }

        private void Bai25_Load(object sender, EventArgs e)
        {
            tmGame.Interval = 3;
            tmGame.Tick += tmGame_Tick;
            tmGame.Start();

            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Size = new Size(100, 100);
            pbImage.Location = new Point(xBall, yBall);
            this.Controls.Add(pbImage);
            pbImage.ImageLocation = @"D:\ball.png";
        }
     
        private void tmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDelta;
            yBall += yDelta;
            if (xBall > this.ClientSize.Width - pbImage.Width || xBall <= 0)
                xDelta = -xDelta;
            if (yBall > this.ClientSize.Height - pbImage.Height || yBall <= 0)
                yDelta = -yDelta;
            pbImage.Location = new Point(xBall, yBall);
        }
    }
}
