using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento.Presentation.FormApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private enum Pedido
        {
            Código,
            Item,
            Quantidade,
            Valor,
            Data
        };

        private FormVenda venda = new FormVenda();

        public Form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            venda.Show();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
