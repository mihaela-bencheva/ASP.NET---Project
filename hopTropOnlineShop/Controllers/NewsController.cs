using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class NewsController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult PrintInfoCardShevitsa()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IActionResult PrintInfoCardSymbol()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IActionResult PrintInfoCardOrnaments()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}