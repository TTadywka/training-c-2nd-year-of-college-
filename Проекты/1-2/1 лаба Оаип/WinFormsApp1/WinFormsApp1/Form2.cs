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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form f2 = new Form1();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            switch (Convert.ToString(label1.Text))
            {
                case "+":
                    MessageBox.Show((a + "+" + b + "=" + (a + b)) , "Пи пи пу пу"); break;
                case "-":
                    MessageBox.Show((a + "-" + b + "=" + (a - b)) , "Пи пи пу пу"); break;
                case "*":
                    MessageBox.Show((a + "*" + b + "=" + (a * b)) , "Пи пи пу пу"); break;
                case "/":
                    MessageBox.Show((a + "/" + b + "=" + (a / b)) , "Пи пи пу пу"); break;
                case "%":
                    MessageBox.Show((a + "%" + b + "=" + (a % b)) , "Пи пи пу пу"); break;

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            this.BackColor = Color.Pink;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            this.BackColor = Color.DeepPink;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            this.BackColor = Color.HotPink;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            this.BackColor = Color.LightPink;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "%";
            this.BackColor = Color.MediumPurple;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
