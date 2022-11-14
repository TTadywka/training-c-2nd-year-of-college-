using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._4
{
    public partial class Form1 : Form
    {
        Bitmap mbit;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mbit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(mbit);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Pen MyPen;
            MyPen = new Pen(Color.Red);
            g.DrawEllipse(MyPen, 55, 55, 100, 50);
            MyPen = new Pen(Color.Blue);
            g.DrawLine(MyPen, 30, 55, 300, 55);
            g.FillRectangle(Brushes.Yellow, 90, 100, 300, 100);
            g.DrawString("Иванов Артем", new Font("Arial", 22), new SolidBrush(Color.Green), 10, 10);
            pictureBox1.Image = mbit;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Графика";
            button1.Text = "Рисование";

        }
    }
}
