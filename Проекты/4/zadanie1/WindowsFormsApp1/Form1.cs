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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пункт меню Объект", "pee pee poo poo");
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 sotrudnik = new Form2();
            sotrudnik.MdiParent = this;
            sotrudnik.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();

        }
    }
}
