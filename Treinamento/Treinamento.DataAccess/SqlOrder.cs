using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Entities;
using Treinamento.Interfaces;

namespace Treinamento.DataAccess
{
    public class SqlOrder : IOrder
    {
        public String connectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["MY_DB"].ConnectionString;
            }
        }
        void IOrder.DeleteOrder(uint Id)
        {
            throw new NotImplementedException();
        }

        IList<Order> IOrder.ListOrder()
        {
            throw new NotImplementedException();
        }

        void IOrder.NewOrder(Order order)
        {
            throw new NotImplementedException();
        }

        void IOrder.UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
