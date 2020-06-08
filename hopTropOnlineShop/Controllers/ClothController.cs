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
using Microsoft.AspNetCore.Http;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class ClothController : Controller
    {
        private readonly OnlineShopContext _context;
        private IRepository _repository;

        public ClothController(OnlineShopContext context, IRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        
        [HttpGet("[action]")]
        public IActionResult Shop()
             { 
                 List<Cloth> clothes = _repository.GetAllClothes();
                 User user = _repository.GetUserByID(Convert.ToInt32(HttpContext.Session.GetString("identity")));
                 ClothesDetailsViewModel clothesDetailsViewModel = new ClothesDetailsViewModel()
                 {
                   Clothes = clothes,
                   User = user
                 }; 

                 return View(clothesDetailsViewModel);
             }

        [HttpGet("[action]")]
        public IActionResult CreateCloth()
        {
            int UserId = Convert.ToInt32(HttpContext.Session.GetString("identity"));
            if (UserId > 0)
            {
                User user = _repository.GetUserByID(UserId);
                if (user.IsAdministrator)
                {
                    return View();
                }
                return RedirectToActionPermanent("Login", "Login", null);
            }
            return RedirectToActionPermanent("Login", "Login", null);
        }

        [HttpPost("[action]")]
        public IActionResult CreateCloth([FromForm] Cloth cloth)
        {
            if (ModelState.IsValid)
            {
                _repository.CreateCloth(cloth);
                return RedirectToActionPermanent("Shop", "Cloth", null);
            }
            return View(cloth);
        }

       [HttpGet("[action]")]
       public IActionResult SearchCloth(string searchString)
        {
            List<Cloth> clothes = _repository.GetClothesByPattern(searchString);
            return RedirectToActionPermanent("Shop", "Cloth", clothes);
        }

        [HttpGet("[action]")]
        public IActionResult Search(string searchString)
        {
            List<Cloth> clothes = _repository.GetClothesByPattern(searchString);
            User user = _repository.GetUserByID(Convert.ToInt32(HttpContext.Session.GetString("identity")));
            ClothesDetailsViewModel clothesDetailsViewModel = new ClothesDetailsViewModel()
            {
                Clothes = clothes,
                User = user
            };
            return View(clothesDetailsViewModel);
        }
    }
}
//Add Data Validation