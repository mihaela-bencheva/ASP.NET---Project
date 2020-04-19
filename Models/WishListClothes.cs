using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace hopTropOnlineShop.Models
{
    public class WishListClothes
    {
        [ForeignKey("Clothes")]
        public int IDCloth { get; set; }
        [ForeignKey("Basket")]
        public int IdBasket { get; set; }
    }
}
