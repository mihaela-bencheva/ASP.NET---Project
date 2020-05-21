using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hopTropOnlineShop.DAL;
using hopTropOnlineShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace hopTropOnlineShop.Controllers
{
    public class RegisterController : Controller
    {
        private IRepository _repository;

        public RegisterController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("[action]")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("[action]")]
        public IActionResult Register([FromForm] User user)
        {
            List<User> checkUser = _repository.GetUserByUsername(user.Username);
            if (checkUser.Count > 0)
            {
                ModelState.AddModelError("", "Invalid username and/or password");
            }
            else
            {
                _repository.CreateUser(user);
                return RedirectToActionPermanent("Login", "Login", null);
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}