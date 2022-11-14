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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            string s1 = "";
            string s2 = "";
            if (checkBox2.Checked == true) 
                s1 = "Разговор длится: " + Convert.ToString((a - 8)/3) + " минут " + "\n";
            if (checkBox1.Checked == true)
                if ((a - ((a - 8) + (a - 8))) >= 0)
                        {
                        s2 = "Маше не надо ложить денег на счет";
                        }
                else
                    s2 = "Маше надо положить " + Convert.ToString(((a - ((a - 8)+(a - 8)))) * (-1)) + " рублей " + "\n";
                    
            MessageBox.Show(s1 + s2);
        }
    }
}
