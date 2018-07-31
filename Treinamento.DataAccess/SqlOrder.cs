using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Entities;
using Treinamento.Interfaces;

namespace Treinamento.DataAccess
{
    public class SqlOrder : IOrder
    {
        public String GetConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["MY_DB"].ConnectionString;
            }
        }

        void IOrder.DeleteOrder(uint Id)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("DELETE ORDERS WHERE ORDERID = @ordId");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                connection.Open();
                connection.Execute(stringBuilder.ToString(), new { ord_id = Id }, commandType: CommandType.Text);
            }
        }

        IList<object> IOrder.ListOrder()
        {
            var stringBuilder = new StringBuilder();
            List<object> listObject;

            stringBuilder.AppendLine("SELECT *");
            stringBuilder.AppendLine("FROM ORDERS O");
            stringBuilder.AppendLine("LEFT JOIN ITEMS I ON O.IDITEM = I.ITEMID");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                connection.Open();
                listObject = connection.Query<Order, Item, object>(stringBuilder.ToString(), (ord, itm) =>
                 {
                     ord.ItemOrder = itm;

                     return new
                     {
                         Venda = ord.OrderId,
                         Item = ord.ItemOrder.Description,
                         ValorUnitario = ord.ItemOrder.Cost,
                         Quantidade = ord.OrderQuantity,
                         Vendedor = ord.Salesman,
                         Data = ord.OrderDate
                     };
                 }, splitOn: "ITEMID").ToList();
            }
            return listObject;
        }

        void IOrder.NewOrder(Order order)
        {
            var stringBuilderItem = new StringBuilder();
            var stringBuilderOrder = new StringBuilder();

            stringBuilderItem.AppendLine("INSERT INTO ITEMS(DESCRIPTION, COST)");
            stringBuilderItem.AppendLine("OUTPUT INSERTED.ITEMID ");
            stringBuilderItem.AppendLine("VALUES (@description, @cost)");
            stringBuilderOrder.AppendLine("INSERT INTO ORDERS(IDITEM, ORDERQUANTITY, SALESMAN, ORDERDATE)");
            stringBuilderOrder.AppendLine("VALUES (@idItem, @orderQuantity, @salesman, @orderDate )");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                connection.Open();
                var idItem = Convert.ToInt32(connection.ExecuteScalar(stringBuilderItem.ToString(),
                    new
                    {
                        description = order.ItemOrder.Description,
                        cost = order.ItemOrder.Cost
                    }, commandType: CommandType.Text));
                connection.Execute(stringBuilderOrder.ToString(),
                    new
                    {
                        idItem = idItem,
                        orderQuantity = order.OrderQuantity,
                        salesman = order.Salesman,
                        orderDate = order.OrderDate
                    }, commandType: CommandType.Text);
            }
        }

        void IOrder.UpdateOrder(Order order)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("UPDATE ORDERS");
            stringBuilder.AppendLine("SET IDITEM = @idItem,");
            stringBuilder.AppendLine("ORDERQUANTITY = @orderQuantity,");
            stringBuilder.AppendLine("SALESMAN = @salesman,");
            stringBuilder.AppendLine("ORDERDATE = @orderDate");
            stringBuilder.AppendLine("WHERE ORDERID = @orderId");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                connection.Open();
                connection.Execute(stringBuilder.ToString(),
                    new
                    {
                        idItem = order.IdItem,
                        orderQuantity = order.OrderQuantity,
                        salesman = order.Salesman,
                        orderDate = order.OrderDate,
                        orderId = order.OrderId
                    }, commandType: CommandType.Text);
            }
        }
    }
}
