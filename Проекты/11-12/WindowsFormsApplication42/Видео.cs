using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication42
{
    public partial class Видео : Form
    {
        public Видео()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Ева.mp4");
            Thread.Sleep(14000);
            int i = comboBox1.SelectedIndex;
            switch(i)
            {
                case (0):
                    Process.Start("zxc.mp4");
                    Thread.Sleep(1200);break;
                case (1):
                    Process.Start("zxc.mp4");
                    Thread.Sleep(1200); break;
                case (2):
                    Process.Start("zxc.mp4");
                    Thread.Sleep(1200);   break;
                case (3):
                    Process.Start("zxc.mp4");
                    Thread.Sleep(1200); break;
            }

            int t = comboBox3.SelectedIndex;
            switch (t) {
                case (0):
                    Process.Start("кот.jpg");
                    MessageBox.Show("Поздравляю, "+textBox1.Text,"Поздравление!!!");
                    break;
                case (1):
                    Process.Start("кот.jpg");
                    MessageBox.Show("Поздравляю, " + textBox1.Text, "Поздравление!!!");
                    break;
                case (2):
                    Process.Start("кот.jpg");
                    MessageBox.Show("Поздравляю, " + textBox1.Text, "Поздравление!!!");
                    break;
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
                Главная g = new Главная();
                this.Hide();
                g.Show();
            }

        private void Видео_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Application.Exit();
            }
        }
    }


    }
