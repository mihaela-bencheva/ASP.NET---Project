using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hopTropOnlineShop.Models;
using hopTropOnlineShop.DAL;
using Microsoft.AspNetCore.Http;

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
                 
                    if (u.Password == loginUser.Password && u.Username == loginUser.Username)
                    {
                        HttpContext.Session.SetString("identity", u.IDUser.ToString());
                        //HttpContext.Session.GetString("identity");
                        return RedirectToActionPermanent("Index", "Home", null);
                    }
                }
                return RedirectToActionPermanent("Login", "Login", null);
            }
            return View();
        }

        [HttpGet("[action]")]
        public IActionResult CurrentUser()
        {
           int UserId = Convert.ToInt32(HttpContext.Session.GetString("identity"));
            if (UserId > 0)
            {
                User user = _repository.GetUserByID(UserId);
                return View(user);
            }
            return RedirectToActionPermanent("Login", "Login", null);
        }

        [HttpGet("[action]")]
        public IActionResult LogOut()
        {
            HttpContext.Session.SetString("identity", (0).ToString());
            return RedirectToActionPermanent("Shop", "Cloth", null);
        }

        [HttpGet("[action]")]
        public IActionResult ShowAllUsersToAdmin()
        {
            if (_repository.GetUserByID(Convert.ToInt32(HttpContext.Session.GetString("identity"))).IsAdministrator == true)
            {
                List<User> users = _repository.GetAllUsers();
                return View(users);
            }
            return RedirectToActionPermanent("Login", "Login", null);
        }

        [HttpPost("[action]")]
        public IActionResult DeleteUserByID(int id)
        {
            _repository.DeleteUserByID(id);
            return RedirectToActionPermanent("ShowAllUsersToAdmin", "Login");
        }

        [HttpPost("[action]")]
        public IActionResult SetUserToAdmin(int id)
        {
            _repository.SetUserToAdminByID(id);
            return RedirectToActionPermanent("ShowAllUsersToAdmin", "Login");
        }
    }
}

