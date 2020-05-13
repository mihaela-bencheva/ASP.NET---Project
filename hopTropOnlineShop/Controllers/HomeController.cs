using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hopTropOnlineShop.Models;
using Eco.ViewModel.Runtime;
using hopTropOnlineShop.DAL;
using hopTropOnlineShop.Helpers;
using Microsoft.AspNetCore.Http;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       // public IRepository _repository;
        public HomeController(ILogger<HomeController> logger) //IRepository repository)
        {
            _logger = logger;
            //_repository = repository;
        }

        //[Route("Login")]
        //[HttpPost]
        //public IActionResult Login([FromForm] User loginUser)
        //{
        //    return View();
        //}

        //[Route("Login")]
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        [Route("[action]")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult News()
        {
            return View();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Basket()
        {
            return View();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Shop()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Testing()
        {
            Cloth testing = new Cloth
            {
                Gender = "dfhs",
                Color = "yellow",
                Price = 1243
            };
            SessionHelper.SetObjectAsJson(HttpContext.Session, "test", testing);
            testing.Price = 456;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "test", testing);
           var json = HttpContext.Session.GetString("test");
            return Ok(json);
        }

        [Route("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
