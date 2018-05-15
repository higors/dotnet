using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Entities
{
    public class Order
    {
        public UInt32 Id { get; set; }
        public String Description { get; set; }
        public String OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
