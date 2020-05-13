using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hopTropOnlineShop.Models;
using hopTropOnlineShop.Helpers;
using hopTropOnlineShop.DAL;

namespace hopTropOnlineShop.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private IRepository _repository;

        public LoginController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("[action]")]
            public IActionResult Login()
            {
                return View();
            }

        
        [HttpPost("[action]")]
        public IActionResult Login([FromForm] User loginUser)
        {
            List<User> users = _repository.GetUserByUsername(loginUser.Username);

            if (users.Count == 0)
            {
                ModelState.AddModelError("", "Invalid username and/or password");
            }
            else
            {
                foreach(User u in users)
                {
                    if (u.Password == loginUser.Password)
                    {
                        return RedirectToActionPermanent("Index", "Home", null);
                    }
                }
                return Ok();
            }
            return View();
        }
    }
}

