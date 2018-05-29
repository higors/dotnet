using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.DataAccess.Factory
{
    public class Order
    {
        public static Interfaces.IOrder NewOrder()
        {
            return new SqlOrder();
        }
    }
}
