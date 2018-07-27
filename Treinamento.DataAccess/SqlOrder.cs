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

            stringBuilder.AppendLine("DELETE ORDERS WHERE ORD_ID = @ordId");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    var parameter = new SqlParameter()
                    {
                        ParameterName = "@ordId",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Value = Id
                    };

                    command.Parameters.Add(parameter);

                    command.ExecuteNonQuery();
                }
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
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("INSERT INTO ORDERS (ORD_DESCRIPTION, ORD_NUMBER, ORD_DATE)");
            stringBuilder.AppendLine("VALUES (@ord_description, @ord_number, )");
        }

        void IOrder.UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
