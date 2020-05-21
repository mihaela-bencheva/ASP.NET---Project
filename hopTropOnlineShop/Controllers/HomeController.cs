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
using Microsoft.AspNetCore.Http;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IRepository _repository;
        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Index()
        {
            User currentUser = _repository.GetUserByID(Convert.ToInt32(HttpContext.Session.GetString("identity")));
            return View(currentUser);
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
