using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eco.Ocl.Support;
using hopTropOnlineShop.DAL;
using hopTropOnlineShop.Models;
using hopTropOnlineShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class WishListController : Controller
    {
        private IRepository _repository;

        public WishListController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("[action]")]
        public IActionResult AddToBasket(int id)
        {
            string cookie = HttpContext.Session.GetString("cart") ?? string.Empty;
            HttpContext.Session.SetString("cart", cookie + id + ',');
            return RedirectToActionPermanent("Shop", "Cloth", null);
        }

        [HttpGet("[action]")]
        public IActionResult PrintFromBasket()
        {
            string[] clothesIds = (HttpContext.Session.GetString("cart") ?? string.Empty).Split(',', StringSplitOptions.RemoveEmptyEntries);

            List<Cloth> clothes = new List<Cloth>();
            double sum = 0;
            for (int i = 0; i < clothesIds.Length; i++)
            {
                Cloth cloth = _repository.GetClothById(Convert.ToInt32(clothesIds[i]));
                clothes.Add(cloth);
                sum += cloth.Price;
            }

            WishListDetailsViewModel wishListDetailsViewModel = new WishListDetailsViewModel()
            {
                IDUser = Convert.ToInt32(HttpContext.Session.GetString("identity")),
                Clothes = clothes,
                Sum = Math.Round(sum, 2)
            };

            return View(wishListDetailsViewModel);
        }
    }
}