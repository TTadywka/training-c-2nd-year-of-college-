using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_лба_Оаип
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] m_p = new int[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Рисуем Круг";
            button1.Text = "Рисовать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_p[1] = Convert.ToInt32(textBox1.Text);
            m_p[2] = Convert.ToInt32(textBox2.Text);
            m_p[3] = Convert.ToInt32(textBox3.Text);
            m_p[4] = Convert.ToInt32(textBox4.Text);
            pictureBox1.Refresh();

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(System.Drawing.Pens.Fuchsia, m_p[1], m_p[2], m_p[3], m_p[4]);
        }

    }
}
