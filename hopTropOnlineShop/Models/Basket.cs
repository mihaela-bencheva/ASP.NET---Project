using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hopTropOnlineShop.Models
{
    public class Basket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IDBasket { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        //[ForeignKey("Customer")]
        public int IDCustomer { get; set; }
        public virtual ICollection<WishListCloth> WishListClothes { get; set; }
    }
}
