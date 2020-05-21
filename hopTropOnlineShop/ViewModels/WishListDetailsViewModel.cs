using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hopTropOnlineShop.Models;

namespace hopTropOnlineShop.ViewModels
{
    public class WishListDetailsViewModel
    {
        public List<Cloth> Clothes { get; set; }
        public double Sum { get; set; }
        public int IDUser { get; set; }
    }
}
