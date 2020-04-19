using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace hopTropOnlineShop.Models
{
    public class Delivery
    {
        public int IdDelivery { get; set; }
        [ForeignKey("Orders")]
        public int IDOrder { get; set; }
        public string DeliveryDate { get; set; }
    }
}
