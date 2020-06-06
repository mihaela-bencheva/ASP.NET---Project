using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hopTropOnlineShop.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult PrintInfoCardShevitsa()
        {
            return View();
        }

        public IActionResult PrintInfoCardSymbol()
        {
            return View();
        }

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