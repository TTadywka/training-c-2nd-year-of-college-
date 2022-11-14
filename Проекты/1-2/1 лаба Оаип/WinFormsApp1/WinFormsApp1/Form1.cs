using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Работу выполнил студент группы ИП3-20", "Справка");

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form f2 = new Form3();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form f2 = new Form5();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИП3-20", "Справка");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
