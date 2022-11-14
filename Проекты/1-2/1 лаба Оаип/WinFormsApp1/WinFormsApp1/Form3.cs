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
    public partial class Form3 : Form
    {
        public Form3()
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
            
            if (radioButton1.Checked == true)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double d = a;
                if (checkBox1.Checked == true)
                {
                    double b = Math.Sin(a);
                    MessageBox.Show("sin а = " + b);
                    a = d; 
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Cos(a);
                    MessageBox.Show("cos а = " + b);
                    a = d;
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Cos(a);
                    MessageBox.Show("sin а = " + b);
                    a = d;
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Tanh(a);
                    MessageBox.Show("ctg а = " + b);
                    a = d;
                }
            }
            else
            {
                double c = 0;
                double с = Convert.ToDouble(textBox1.Text);
                double a = (c * 180) / Math.PI;
                double d = a;
                if (checkBox1.Checked == true)
                {
                    double b = Math.Sin(a);
                    MessageBox.Show("sin а = " + b);
                    a = d;
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Cos(a);
                    MessageBox.Show("cos а = " + b);
                    a = d;
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Cos(a);
                    MessageBox.Show("sin а = " + b);
                    a = d;
                }
                if (checkBox2.Checked == true)
                {
                    double b = Math.Tanh(a);
                    MessageBox.Show("ctg а = " + b);
                    a = d;
                }
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
