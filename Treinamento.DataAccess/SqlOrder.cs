using System;
using System.Collections.Generic;
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

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        IList<Order> IOrder.ListOrder()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT ORDERS.ORD_ID, ORDERS.ORD_NUMBER, ORDERS.ORD_DESCRIPTION, ORDERS.ORD_DATE, ORDER_TYPES.ORT_DESCRIPTION");
            stringBuilder.AppendLine("FROM ORDERS INNER JOIN ORDER_TYPES ON ORDERS.ORD_ORT_ID = ORDER_TYPES.ORT_ID");

            using (var connection = new SqlConnection(GetConnectionString))
            using (var command = new SqlCommand(stringBuilder.ToString(), connection))
            {
                connection.Open();

                var lista = command.ExecuteReader().OfType<Order>().ToList;
            }

        }

        void IOrder.NewOrder(Order order)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("INSERT INTO ORDERS (ORD_DESCRIPTION, ORD_NUMBER, ORD_DATE, ORD_ORT_ID)");
            stringBuilder.AppendLine("VALUES (@ord_description, @ord_number, @ord_date, @ord_ort_id)");

            using (var connection = new SqlConnection(GetConnectionString))
            using (var command = new SqlCommand(stringBuilder.ToString(), connection))
            {
                IList<SqlParameter> listOfParameters = new List<SqlParameter>
                {
                    new SqlParameter()
                    {
                        ParameterName = "@ord_description",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.Description
                    },

                    new SqlParameter()
                    {
                        ParameterName = "@ord_number",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderNumber
                    },

                    new SqlParameter()
                    {
                        ParameterName = "@ord_date",
                        SqlDbType = System.Data.SqlDbType.DateTime,
                        Value = order.OrderDate
                    }
                };

                command.Parameters.AddRange(listOfParameters.ToArray());

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        void IOrder.UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
