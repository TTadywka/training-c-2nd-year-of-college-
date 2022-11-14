using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen a, b;
            a = new Pen(Color.Black, 3);
            g.Clear(Color.White);
            g.DrawRectangle(a, 200, 10, 10, 220);
            g.DrawLine(a, 210, 15, 340, 210);
            g.DrawLine(a, 347, 210, 210, 210);
            g.DrawLine(a, 200, 20, 70, 210);
            g.DrawLine(a, 67, 210, 200, 210);
            g.DrawLine(a, 73, 230, 345, 230);
            g.DrawArc(a, 73, 180, 30, 100, -180, -90);
            g.DrawLine(a, 345, 230, 333, 258);
            g.DrawLine(a, 74, 248, 337, 248);
            g.DrawLine(a, 333, 258, 300, 305);
            g.DrawEllipse(a, 70, 25, 40, 40);
            g.DrawArc(a, -40, 260, 130, 30, 0, 40);
            g.DrawArc(a, 90, 260, 150, 30, -180, -70);
            g.DrawArc(a, 120, 147, 150, 150, -240, -60);
            g.DrawArc(a, 232, 273, 150, 30, -180, -50);
            g.DrawArc(a, 232, 273, 150, 30, -180, -50);
            g.DrawArc(a, 250, 160, 150, 150, -240, -60);
            b = new Pen(Color.Black, 1);
            g.DrawArc(b, 75, 193, 37, 37, -180, -90);
            g.DrawArc(b, 325, 193, 37, 37, -180, -90);

        }
    }
}
