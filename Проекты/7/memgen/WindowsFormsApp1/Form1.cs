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

        private Bitmap bmp_for_draw;
        private string full_name_of_image;
        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|**.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    bmp_for_draw = new Bitmap(open_dialog.FileName);
                    pictureBox1.Image = bmp_for_draw;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("невозможно открыть выбранный файл", "мда",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawString(textBox3.Text, new Font("arial", 16), Brushes.Black, 30, 15);
            g.DrawString(textBox4.Text, new Font("arial", 16), Brushes.Black, 30, 450);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|**.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(save_dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
