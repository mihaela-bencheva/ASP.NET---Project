using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hopTropOnlineShop.Models;
using Microsoft.EntityFrameworkCore;

namespace hopTropOnlineShop.DAL
{
    public static class OnlineShopInitializer 
    {
        public static void Initialize(OnlineShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Clothes.Any())
            {
                return;  
            }

            var clothes = new List<Cloth>
            {
            new Cloth{IDCloth = 1, Gender = "Дамска", TypeOfCloth = "Кенарена риза", Size = "XS, S, M, L, XL", Color = "Бяла", Price = 49.90, Currency = "лв." },
            new Cloth{IDCloth = 2, Gender = "Мъжка", TypeOfCloth = "Кенарена риза", Size = "XS, S, M, L, XL", Color = "Бяла", Price = 59.90, Currency = "лв." }
            };

            foreach (Cloth c in clothes)
            {
                context.Clothes.Add(c);
            }
            context.SaveChanges();
            
            var customers = new List<Customer>
            {
            new Customer{IDCustomer = 1, FirstName = "Андрей", LastName = "Върбанов", TelephoneNumber = "0981122344", Email = "andigold@gmail.com", Address = "Хагенбер, Австрия, SoftwarePark, стая 5206"}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();
            var baskets = new List<Basket>
            {
            new Basket{IDBasket = 1, Size = "XS", Color = "Бяла", IDCustomer = 1}
            };
            foreach (Basket b in baskets)
            {
                context.Baskets.Add(b);
            }
            context.SaveChanges();
        }
    }
}
