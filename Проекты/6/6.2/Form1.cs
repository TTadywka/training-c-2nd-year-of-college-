using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите данные";
            button1.Text = "Рисование";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Pen MyPen;
            MyPen = new Pen(Color.Green, 3);
            g.DrawRectangle(MyPen, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

        }
    }
}
