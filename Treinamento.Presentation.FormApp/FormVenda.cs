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
    public partial class FormVenda : System.Windows.Forms.Form
    {
        Interfaces.IOrder order = Business.Factory.OrderFactory.NewOrder;

        public FormVenda()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            order.NewOrder(new Entities.Order()
            {
                ItemOrder = new Entities.Item()
                {
                    Description = txtPedidoItem.Text,
                    Cost = Convert.ToDecimal(mtbValorItem.Text)
                },
                OrderQuantity = Convert.ToInt32(mtbQuantidade.Text),
                Salesman = txtVendedor.Text,
                OrderDate = dtpData.Value
            });
            Close();
        }
    }
}
