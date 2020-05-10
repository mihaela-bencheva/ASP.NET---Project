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

namespace hopTropOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       // public IRepository _repository;
        public HomeController(ILogger<HomeController> logger) //IRepository repository)
        {
            _logger = logger;
            //_repository = repository;
        }

        public IActionResult LoginCheck([FromForm] User loginUser)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Basket()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
