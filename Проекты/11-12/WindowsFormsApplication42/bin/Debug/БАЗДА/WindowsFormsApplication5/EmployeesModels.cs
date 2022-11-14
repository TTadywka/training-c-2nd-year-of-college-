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
    public partial class EmployeesModels : Form
    {
        public EmployeesModels()
        {
            InitializeComponent();
        }

        private void EmployeesModels_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet3.Сотрудники_и_заказанные_модели". При необходимости она может быть перемещена или удалена.
            this.сотрудники_и_заказанные_моделиTableAdapter.Fill(this.zakazyDataSet3.Сотрудники_и_заказанные_модели);

        }
    }
}
