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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("{0} ({1})", DateTime.Now.ToString("dd.MM.yyyy - hh:mm"), DateTime.Now.DayOfWeek);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Пароль fp = new Пароль();
            this.Hide();
            fp.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            progressBar2.PerformStep();
            progressBar3.PerformStep();
            progressBar4.PerformStep();
            progressBar5.PerformStep();
            progressBar6.PerformStep();
            progressBar7.PerformStep();
            progressBar8.PerformStep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Отчёт fp = new Отчёт();
            this.Hide();
            fp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Это итоговая лабораторная работа для допуска к экзаменам", "Поставьте автомат");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Видео g = new Видео();
            this.Hide();
            g.Visible = true;
        }
    }
}
