using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hopTropOnlineShop.Models
{
    public class Cloth
    {
        [Key]
        public int IDCloth { get; set; }
        public string Gender { get; set; }
        public string TypeOfCloth { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public virtual ICollection<WishListCloth> WishListClothes { get; set; }
    }
}
