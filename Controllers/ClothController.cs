using hopTropOnlineShop.Models;
using hopTropOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using hopTropOnlineShop.DAL;



namespace hopTropOnlineShop.Controllers
{
    public class ClothController : Controller
    {
        private readonly OnlineShopContext _context;

        public ClothController(OnlineShopContext context)
        {
            _context = context;
            /*public ActionResult Shop()
             {
                 List<Cloth> clothes = new List<Cloth>(); 
                 clothes.Add(new Cloth
                 {
                     IDCloth = 1,
                     Gender = "Дамска",
                     TypeOfCloth = "Кенарена риза",
                     Size = "XS, S, M, L, XL",
                     Color = "Бяла",
                     Price = 39.90,
                     Currency = "лв."
                 });

                 clothes.Add(new Cloth
                 {
                     IDCloth = 2,
                     Gender = "Мъжка",
                     TypeOfCloth = "Кенарена риза",
                     Size = "XS, S, M, L, XL",
                     Color = "Синя",
                     Price = 49.90,
                     Currency = "лв."
                 });
                 //Creating the View model
                 ClothesDetailsViewModel clothesDetailsViewModel = new ClothesDetailsViewModel()
                 {
                   Clothes = clothes,
                 }; 

                 //Pass the studentDetailsViewModel to the view
                 return View(clothesDetailsViewModel);
             }

            private ViewResult View(ClothesDetailsViewModel clothesDetailsViewModel)
             {
                 throw new NotImplementedException();
             }*/

        }
        public async Task<IActionResult> Shop()
        {
            return View(await _context.Clothes.ToListAsync());
        }
    }
}
