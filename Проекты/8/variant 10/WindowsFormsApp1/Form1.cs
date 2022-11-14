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
        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        private void DrawTriangle(int level, PointF top, PointF left, PointF right)
        {
            if (level == 0)
            {
                PointF[] points = new PointF[3]
                {
                    top, right, left
                };
                _graph.FillPolygon(Brushes.Black, points);
            }
            else
            {
                var leftMid = MidPoint(top, left);
                var rightMid = MidPoint(top, right);
                var topMid = MidPoint(left, right);
                DrawTriangle(level - 1, top, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, left, topMid);
                DrawTriangle(level - 1, rightMid, topMid, right);
            }
        }

        private int _width;
        private int _height;
        private Bitmap _fractal;
        private Graphics _graph;
        public Form1()
        {
            InitializeComponent();
            _width = pictureBox1.Width;
            _height = pictureBox1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _fractal = new Bitmap(_width, _height);
            _graph = Graphics.FromImage(_fractal);
            PointF topPoint = new PointF(_width / 2f, 0);
            PointF leftPoint = new PointF(0, _height);
            PointF rightPoint = new PointF(_width, _height);
            DrawTriangle(5, topPoint, leftPoint, rightPoint);
            pictureBox1.BackgroundImage = _fractal;
        }
    }
}
