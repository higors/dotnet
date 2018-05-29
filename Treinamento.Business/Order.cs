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
        private Treinamento.Interfaces.IOrder order = DataAccess.Factory.Order.NewOrder();
        public IList<Entities.Order> ListOrder()
        {
            return order.ListOrder();
        }

        void IOrder.DeleteOrder(uint Id)
        {
            order.DeleteOrder(Id);
        }

        IList<OrderType> IOrder.ListOrderTypes()
        {
            return order.ListOrderTypes();
        }

        void IOrder.NewOrder(Entities.Order order)
        {
            this.order.NewOrder(order);
        }

        void IOrder.UpdateOrder(Entities.Order order)
        {
            this.order.UpdateOrder(order);
        }
    }
}
