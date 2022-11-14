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
    public partial class Form1 : Form
    {
        bool drow;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drow = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drow = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            if (drow == true)
            {
            g.FillEllipse(Brushes.Black, e.X, e.Y, 3, 3);
            }
        }
    }
}
