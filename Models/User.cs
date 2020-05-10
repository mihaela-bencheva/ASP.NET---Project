using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hopTropOnlineShop.Models
{
    public class User
    {
        [Key]
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IDCustomer { get; set; }
    }
}
