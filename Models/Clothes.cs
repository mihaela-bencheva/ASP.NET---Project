using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hopTropOnlineShop.Models
{
    public class Clothes
    {
        public int IDCloth { get; set; }
        public string TypeOfCloth { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
    }
}
