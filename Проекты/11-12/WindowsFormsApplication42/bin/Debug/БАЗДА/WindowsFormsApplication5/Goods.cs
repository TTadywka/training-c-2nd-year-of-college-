﻿using System;
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
    public partial class Goods : Form
    {
        public Goods()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakazyDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.zakazyDataSet.Товары);

        }
    }
}
