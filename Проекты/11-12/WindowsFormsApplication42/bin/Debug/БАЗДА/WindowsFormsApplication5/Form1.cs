using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers f = new Customers();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models f = new Models();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeesModels f = new EmployeesModels();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Goods f = new Goods();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
