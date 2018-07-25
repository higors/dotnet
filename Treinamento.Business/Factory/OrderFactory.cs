using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Interfaces;

namespace Treinamento.Business.Factory
{
    public static class OrderFactory
    {
        public static IOrder NewOrder => new Order();
    }
}
