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

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Brush bruh = new SolidBrush(Color.Black);
            Graphics g = pictureBox1.CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(text, Font, bruh, 150, 50);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);
        }
    }
}
