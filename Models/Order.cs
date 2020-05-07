using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hopTropOnlineShop.Models
{
    public class Order
    {
        [Key]
        public int IDOrder { get; set; }
        //[ForeignKey("Customer")]
        public string Address { get; set; }
        public double Sum { get; set; }
       // [ForeignKey("Basket")]
        public int IdBasket { get; set; }
    }
}
