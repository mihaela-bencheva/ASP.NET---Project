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
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int IDCustomer { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
