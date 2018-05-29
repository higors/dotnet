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
                return System.Configuration.ConfigurationManager.ConnectionStrings["MY_DB"].ToString();
            }
        }

        public IList<OrderType> ListOrderTypes()
        {
            List<OrderType> list = new List<OrderType>();
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT ORT_ID ID, ORT_DESCRIPTION DESCRIPTION FROM ORDER_TYPES");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            {
                using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
                {
                    connection.Open();

                    var dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        list.Add(new OrderType()
                        {
                            Id = UInt32.Parse(dataReader["ID"].ToString()),
                            Description = dataReader["DESCRIPTION"].ToString()
                        });
                    }
                    return list; 
                }
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
            List<Order> list = new List<Order>();
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT ORDERS.ORD_ID ID_PEDIDO");
            stringBuilder.AppendLine(", ORDERS.ORD_NUMBER NUMERO_PEDIDO");
            stringBuilder.AppendLine(", ORDERS.ORD_DESCRIPTION DESCRICAO");
            stringBuilder.AppendLine(", ORDERS.ORD_DATE");
            stringBuilder.AppendLine(", ORDER_TYPES.ORT_ID");
            stringBuilder.AppendLine(", ORDER_TYPES.ORT_DESCRIPTION");
            stringBuilder.AppendLine("FROM ORDERS");
            stringBuilder.AppendLine("INNER JOIN ORDER_TYPES ON ORDERS.ORD_ORT_ID = ORDER_TYPES.ORT_ID");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
            {
                connection.Open();

                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(new Order()
                    {
                        Id = UInt32.Parse(dataReader["ID_PEDIDO"].ToString()),
                        Description = dataReader["NUMERO_PEDIDO"].ToString(),
                        OrderNumber = dataReader["DESCRICAO"].ToString(),
                        OrderDate = DateTime.Parse(dataReader["ORD_DATE"].ToString()),
                        OrderType = new OrderType() { Id = UInt32.Parse(dataReader["ORT_ID"].ToString()), Description = dataReader["ORT_DESCRIPTION"].ToString() }
                    });
                }
                return list;
            }
        }

        void IOrder.NewOrder(Order order)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("INSERT INTO ORDERS (ORD_DESCRIPTION, ORD_NUMBER, ORD_DATE, ORD_ORT_ID)");
            stringBuilder.AppendLine("VALUES (@ord_description, @ord_number, @ord_date, @ord_ort_id)");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
            {
                IList<SqlParameter> parameterList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@ord_description",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.Description
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_number",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderNumber
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_date",
                        SqlDbType = System.Data.SqlDbType.Date,
                        Value = order.OrderDate
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_ort_id",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderType.Id
                    }
                };

                command.Parameters.AddRange(parameterList.ToArray());

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        void IOrder.UpdateOrder(Order order)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("UPDATE ORDERS");
            stringBuilder.AppendLine("SET ORD_DESCRIPTION = @ord_description");
            stringBuilder.AppendLine(", ORD_NUMBER = @ord_number");
            stringBuilder.AppendLine(", ORD_DATE = @ord_date");
            stringBuilder.AppendLine(", ORD_ORT_ID = @ord_ord_id");
            stringBuilder.AppendLine("WHERE ORD_ID = @ord_id");

            using (SqlConnection connection = new SqlConnection(GetConnectionString))
            using (SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection))
            {
                IList<SqlParameter> parameterList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@ord_description",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.Description
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_number",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderNumber
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_date",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderDate
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_ord_id",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = order.OrderType.Id
                    },

                    new SqlParameter
                    {
                        ParameterName = "@ord_id",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Value = order.Id
                    }
                };

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
