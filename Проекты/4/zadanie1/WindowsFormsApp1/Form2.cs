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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undo");
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create");
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удалить данные?", "Предупреждение",MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (DialogResult)
            {
                case DialogResult.Yes: { MessageBox.Show("Удаление данных");
                        break;
                    }
                case DialogResult.No: {MessageBox.Show("Отмена удаления данных");
                        break;
                    }
            }
        }
    }
}
