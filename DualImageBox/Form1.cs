using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualImageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create both bitmaps

            //Left
            Bitmap left = new Bitmap(3000,3000); 
            Bitmap right = new Bitmap(3000, 3000);
            
            Graphics g = Graphics.FromImage(left);
            //Make light blue / blue pattern
            for (int x = 0; x < 3000; x += 500)
            {
                for (int y = 0; y < 3000; y += 500)
                {
                    g.FillRectangle(Brushes.LightBlue, x, y, 500, 500);
                    g.FillRectangle(Brushes.Blue, x + 250, y, 250, 250);
                    g.FillRectangle(Brushes.Blue, x, y + 250, 250, 250);
                }
            }

            //Make light green / green pattern
            g = Graphics.FromImage(right);
            for (int x = 0; x < 3000; x += 500)
            {
                for (int y = 0; y < 3000; y += 500)
                {
                    g.FillRectangle(Brushes.LightGreen, x, y, 500, 500);
                    g.FillRectangle(Brushes.Green, x + 250, y, 250, 250);
                    g.FillRectangle(Brushes.Green, x, y + 250, 250, 250);
                }
            }

            g.Dispose();

            imgBoxLeft.Image = left;
            imgBoxRight.Image = right;
        }

        private void imgBoxLeft_Scroll(object sender, ScrollEventArgs e)
        {
            imgBoxRight.ScrollTo(imgBoxLeft.HorizontalScroll.Value, imgBoxLeft.VerticalScroll.Value);
        }

        private void imgBoxLeft_ZoomChanged(object sender, EventArgs e)
        {
            imgBoxRight.Zoom = imgBoxLeft.Zoom;
        }

        private void imgBoxRight_Scroll(object sender, ScrollEventArgs e)
        {
            imgBoxLeft.ScrollTo(imgBoxRight.HorizontalScroll.Value, imgBoxRight.VerticalScroll.Value);
        }

        private void imgBoxRight_ZoomChanged(object sender, EventArgs e)
        {
            imgBoxLeft.Zoom = imgBoxRight.Zoom;
        }
    }
}
