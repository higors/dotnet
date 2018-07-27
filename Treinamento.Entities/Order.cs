using System;
using Dapper;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int? OrderId { get; set; }
        public String Salesman { get; set; }
        public String OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }

        public int IdItem { get; set; }
        public virtual Item ItemOrder { get; set; }
    }
}
