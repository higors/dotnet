using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treinamento.Interfaces;

namespace Treinamento.Presentation.FormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private IOrder order = Business.Factory.OrderFactory.NewOrder;

        private FormVenda venda = new FormVenda();

        public Form()
        {
            InitializeComponent();

            FillGrid();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            venda.Show();
            FillGrid();
        }

        private void DgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FillGrid()
        {
            dgvPedidos.DataSource = order.ListOrder();
            dgvPedidos.Update();
            dgvPedidos.Refresh();
        }
    }
}
