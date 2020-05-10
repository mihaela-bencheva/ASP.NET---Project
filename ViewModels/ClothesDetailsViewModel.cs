using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hopTropOnlineShop.Models;

namespace hopTropOnlineShop.ViewModels
{
    public class ClothesDetailsViewModel
    {
        public string Gender { get; set; }
        public string TypeOfCloth { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public List<Cloth> Clothes { get; internal set; } 
    }
}
