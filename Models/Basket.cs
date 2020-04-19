using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hopTropOnlineShop.Models
{
    public class Basket
    {
        public int IdBasket { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [ForeignKey("Customers")]
        public int IDCustomer { get; set; } 
        
    }
}
