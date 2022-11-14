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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("white #FFFFFF", "белый");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("black #000000", "черный");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("gray #808080", "серый");
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("red #FF0000", "красный");
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("crimson #DC143C", "темно-красный");
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("maroon #8000000", "темно-бордовый");
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("yellow #FFFF00", "желтый");
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("lime #00FF00", "известь");
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("fuchsia #FF00FF", "фуксия");
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("mediumvioletred #C71585", "фиолетово-красный");
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("blue #0000FF", "синий");
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("darkolivegreen #556B2F", "темно-оливковый");
        }
    }
}
