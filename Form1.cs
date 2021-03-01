using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_OOP_Prototype1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zagruzka(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 30, 50, 150, 200);
            graph.DrawLine(pen, 150, 200, 250, 50);

            Rectangle elipse = new Rectangle(250, 50, 200, 170);
            graph.DrawEllipse(pen, elipse);

            graph.DrawLine(pen, 450, 50, 600, 200);
            graph.DrawLine(pen, 600, 200, 750, 50);

            Rectangle Pryam = new Rectangle(250, 50, 200, 170);
            graph.DrawRectangle(pen, Pryam);

            pictureBox1.Image = bmp;
        }
    }
}
