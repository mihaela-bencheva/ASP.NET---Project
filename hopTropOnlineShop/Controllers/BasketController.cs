using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hopTropOnlineShop.Models;
using hopTropOnlineShop.ViewModels;

namespace hopTropOnlineShop.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Details()
        {
            Basket basket = new Basket
            {
                IDBasket = 1
            };


            Cloth cloth = new Cloth 
            {
                Gender = "Мъжка",
                TypeOfCloth = "Кенарена риза",
                Price = 59.99,
                Currency = "лв."
            };
            

            WishListDetailsViewModel wishListDetailsViewModel = new WishListDetailsViewModel()
            {
                Basket = basket,
                Cloth = cloth
            };

            return View(wishListDetailsViewModel);
        }
    }
}