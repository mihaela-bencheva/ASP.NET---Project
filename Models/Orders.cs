using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace hopTropOnlineShop.Models
{
    public class Orders
    {
        public int IDOrder { get; set; }
        [ForeignKey("Customers")]
        public string Address { get; set; }
        public double Sum { get; set; }
        [ForeignKey("Basket")]
        public int IdBasket { get; set; }
    }
}
