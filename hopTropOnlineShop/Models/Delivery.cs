using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hopTropOnlineShop.Models
{
    public class Delivery
    {
        [Key]
        public int IdDelivery { get; set; }
        //[ForeignKey("Order")]
        public int IDOrder { get; set; }
        public string DeliveryDate { get; set; }
    }
}
