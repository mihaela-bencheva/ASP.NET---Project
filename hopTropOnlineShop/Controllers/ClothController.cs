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
                 ClothesDetailsViewModel clothesDetailsViewModel = new ClothesDetailsViewModel()
                 {
                   Clothes = clothes,
                 }; 

                 return base.View(clothesDetailsViewModel);
             }


       
        //public async Task<IActionResult> Shop()
        //{
        //    return View(await _context.Clothes.ToListAsync());
        //}
    }
}
