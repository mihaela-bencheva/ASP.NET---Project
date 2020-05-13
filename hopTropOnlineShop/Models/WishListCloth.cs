using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hopTropOnlineShop.Models
{
    public class WishListCloth
    {
        [Key]
        public int IDCloth { get; set; }
        public int IDBasket { get; set; }
    }
}
