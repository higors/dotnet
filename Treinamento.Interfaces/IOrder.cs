using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Entities;

namespace Treinamento.Interfaces
{
    public interface IOrder
    {
        void NewOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(UInt32 Id);
        IList<Order> ListOrder();
    }
}
