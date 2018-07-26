using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Entities
{
    [Table("ORDERS")]
    public class Order
    {
        [Column("ORD_ID")]
        public int? Id { get; set; }
        [Column("ORD_SALESMAN")]
        public String Salesman { get; set; }
        [Column("ORD_QUANTITY")]
        public String OrderQuantity { get; set; }
        [Column("ORD_DATE")]
        public DateTime OrderDate { get; set; }

        [Column("ORD_ITM_ID")]
        public int IdItem { get; set; }
        public virtual Item ItemOrder { get; set; }
    }
}
