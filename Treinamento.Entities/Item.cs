using System;
using Dapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Entities
{
    [Table("Items")]
    public class Item
    {
        public int? ItemId { get; set; }
        public String Description { get; set; }
        public decimal Cost { get; set; }
    }
}
