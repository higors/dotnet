using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Entities
{
    public class Item
    {
        [Column("ITM_ID")]
        public UInt32 Id { get; set; }
        [Column("ITM_DESCRIPTION")]
        public String Description { get; set; }
        [Column("ITM_COST")]
        public decimal Cost { get; set; }
    }
}
