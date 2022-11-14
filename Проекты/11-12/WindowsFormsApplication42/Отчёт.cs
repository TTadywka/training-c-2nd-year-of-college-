using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication42
{
    public partial class Отчёт : Form
    {
        public Отчёт()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Главная f = new Главная();
            this.Hide();
            f.Visible = true;
        }



        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
           Process.Start(@"E:\Оаип\Лабы по Оаип\9-10");
        }

        private void FormOtchet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\1-2");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\4");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\6");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\5");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\7");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\8");
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Отчёт по ЛР Иванов Артем.doc");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\Оаип\Лабы по Оаип\3");
        }
    }
}
