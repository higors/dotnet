using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Business.Factory
{
    public class Order
    {
        public static Treinamento.Interfaces.IOrder NewOrder()
        {
            return new Treinamento.DataAccess.SqlOrder();
        }
    }
}
