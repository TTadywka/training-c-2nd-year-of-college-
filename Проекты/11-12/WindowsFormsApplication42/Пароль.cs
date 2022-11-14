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
    public partial class Пароль : Form
    {
        public Пароль()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            О_себе f2 = new О_себе();
            
            string s = textBox1.Text;
            if (s == "1111")
            {
                this.Hide();
                f2.Visible = true;
                
            }
            
            if ((s != "1111"))
            {
                f2.Visible = false;
                MessageBox.Show("Неверно введен пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Главная f1 = new Главная();
            this.Hide();
            f1.Visible = true;
        }
    }
}

