using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet4.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.zakazyDataSet4.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet5.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.zakazyDataSet5.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet2.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.zakazyDataSet2.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.заказыTableAdapter.Update(this.zakazyDataSet2.Заказы);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            заказыBindingSource.Filter = "КодСотрудника=" + dataGridView1[2, bb].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            заказыBindingSource.Filter = "КодКлиента=" +dataGridView1[3, bb].Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            заказыBindingSource.Filter = "СерийныйНомер=" + dataGridView1[4, bb].Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            заказыBindingSource.Filter = "СтавкаНалога=" + dataGridView1[6, bb].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказыBindingSource.Filter = "";
        }
    }
}
