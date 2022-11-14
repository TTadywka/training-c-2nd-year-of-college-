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

        private void panel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void panel1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
        }

        private void panel2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
