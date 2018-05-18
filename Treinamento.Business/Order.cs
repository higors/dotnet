using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Entities;
using Treinamento.Interfaces;

namespace Treinamento.Business
{
    public class Order : IOrder
    {
        public IList<Entities.Order> ListOrder()
        {
            throw new NotImplementedException();
        }

        void IOrder.DeleteOrder(uint Id)
        {
            throw new NotImplementedException();
        }

        void IOrder.NewOrder(Entities.Order order)
        {
            throw new NotImplementedException();
        }

        void IOrder.UpdateOrder(Entities.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
