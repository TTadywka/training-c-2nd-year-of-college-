using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + comboBox1.Text);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                button4_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button5.Visible = false;
            textBox2.Text = comboBox1.Text;
            listBox1.Items.Clear();
            using (StreamReader reader = new StreamReader("cons.config"))
            {
                string z = reader.ReadLine();
                for (int j = 0; j < Convert.ToDouble(z); j++)
                    listBox1.Items.Add(reader.ReadLine());
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button5.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "" + textBox2.Text);
            using (StreamWriter sw = new StreamWriter("cons.config"))
            {
                sw.WriteLine(listBox1.Items.Count.ToString());
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string newstr = "";
            int flag = 0;
            char c;
            int k = str.Length;
            for (int j = 0; j< k;j++)
            {
                c = str[j];
                if (flag != 0) newstr += c;
                if (c == '|') flag = 1;

            }
            comboBox1.Text = newstr;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Выдели строку");
            else
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            using (StreamWriter sw = new StreamWriter("cons.config"))
            {
                sw.WriteLine(listBox1.Items.Count.ToString());
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);

            }
        }
    }
}
