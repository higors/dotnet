using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Treinamento.Entities;

namespace Treinamento.Presentation.FormApp
{
    public partial class Form1 : Form
    {
        private enum EnumAction
        {
            Nothing,
            NewItem,
            UpdateItem,
            DeleteItem
        }

        private Interfaces.IOrder Order;

        private Entities.Order rowOrder;

        private EnumAction Action;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Order = Treinamento.Business.Factory.Order.NewOrder();
            Action = EnumAction.Nothing;
            LoadComponents();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dataGridView1.DataSource = Order.ListOrder(); 
        }

        private void LoadComponents()
        {
            ComboTypeOrder.DataSource = Order.ListOrderTypes();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Action = EnumAction.NewItem; 
            ClearFields();
            TextBoxOrderNumber.Focus();
        }

        private void ClearFields()
        {
            TextBoxOrderNumber.Text = String.Empty;
            TextBoxDescription.Text = String.Empty;
            DateOrder.Value = DateTime.Now;
            ComboTypeOrder.SelectedIndex = -1;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Action = EnumAction.UpdateItem;
            rowOrder = dataGridView1.CurrentRow.DataBoundItem as Entities.Order;

            TextBoxOrderNumber.Text = rowOrder.OrderNumber;
            TextBoxDescription.Text = rowOrder.Description;
            DateOrder.Value = rowOrder.OrderDate;
            ComboTypeOrder.SelectedIndex = ComboTypeOrder.FindStringExact(rowOrder.OrderType.ToString());
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            Action = EnumAction.DeleteItem;
            rowOrder = dataGridView1.CurrentRow.DataBoundItem as Entities.Order;

            Order.DeleteOrder(rowOrder.Id);

            rowOrder = null;
            Action = EnumAction.Nothing;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            switch (Action)
            {
                case EnumAction.NewItem:
                    rowOrder = FieldsToOrder();
                    Order.NewOrder(rowOrder);
                    break;
                case EnumAction.UpdateItem:
                    rowOrder = FieldsToOrder();
                    Order.UpdateOrder(rowOrder);
                    break;
            }
            Action = EnumAction.Nothing;
        }

        private Order FieldsToOrder()
        {
            return new Entities.Order()
            {
                OrderNumber = TextBoxOrderNumber.Text,
                Description = TextBoxDescription.Text,
                OrderType = new OrderType() { Description = ComboTypeOrder.SelectedText },
                OrderDate = DateOrder.Value
            };
        }
    }
}
