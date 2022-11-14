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
            label1.Text = "ну попросил же....";
            label1.ForeColor= Color.Red;
            MessageBox.Show("ну потрогал ты и че дальше", "бездарь");
        }
    }
}
