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
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public string Password { get; set; }

        public int IDCustomer { get; set; }
        public bool IsAdministrator { get; set; }
    }
}
