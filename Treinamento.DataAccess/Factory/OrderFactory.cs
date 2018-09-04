using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Interfaces;

namespace Treinamento.DataAccess.Factory
{
    public static class OrderFactory
    {
        public static IOrder NewOrder => new SqlOrder();

        /*
        public static IOrder NewOrder => new SqlOrder();

        public static IOrder NewOrder { 
            get
            {
                return new SqlOrder();
            }}

        public static IOrder NewOrder()
        {
            return new SqlOrder();
        }
        */
    }
}
