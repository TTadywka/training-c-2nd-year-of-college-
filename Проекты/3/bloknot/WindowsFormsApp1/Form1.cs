using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.GetEncoding("UTF-8"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("tags.txt"))
            {
            sw.WriteLine (listBox1.Items.Count.ToString ());
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sw.WriteLine(listBox1.Items[i]);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text+= listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            { MessageBox.Show("нет выделенной строки", "вы ошибка"); }
            else
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader reader = new StreamReader("tags.txt"))
            {
                string z = reader.ReadLine();
                for (int i = 0; i < Convert.ToDouble(z); i++)
                {
                    listBox1.Items.Add(reader.ReadLine());
                }
            }
        }
    }
}
