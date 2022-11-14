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
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
        }

        private void Models_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet1.Модели". При необходимости она может быть перемещена или удалена.
            this.моделиTableAdapter.Fill(this.zakazyDataSet1.Модели);

        }
    }
}
