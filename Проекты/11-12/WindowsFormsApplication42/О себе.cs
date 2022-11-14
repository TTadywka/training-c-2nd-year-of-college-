using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication42
{
    public partial class О_себе : Form
    {
        public О_себе()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главная f1 = new Главная();
            this.Hide();
            f1.Visible = true;
        }


        private void О_себе_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Application.Exit();
            }
        }
    }
}
