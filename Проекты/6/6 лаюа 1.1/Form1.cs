using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_лаюа_1._1
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
            Pen MyPen;
            MyPen = new Pen(Color.GreenYellow, 3);
            g.Clear(Color.White);
            g.DrawArc(MyPen, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            g.DrawPie(MyPen, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Графика";
            button1.Text = "Рисование";

        }
    }
}
