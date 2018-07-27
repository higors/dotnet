using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Interfaces;
using Treinamento.Entities;

namespace Treinamento.Business
{
    public class Order : IOrder
    {
        private IOrder order = DataAccess.Factory.OrderFactory.NewOrder;
        public void DeleteOrder(uint Id)
        {
            throw new NotImplementedException();
        }

        public IList<object> ListOrder()
        {
            return order.ListOrder();
        }

        public void NewOrder(Entities.Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Entities.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
