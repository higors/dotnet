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

                    command.ExecuteNonQuery();
                }
            }
        }

        IList<Order> IOrder.ListOrder()
        {
            throw new NotImplementedException();
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
