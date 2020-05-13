using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hopTropOnlineShop.Models;
using hopTropOnlineShop.DAL;

namespace hopTropOnlineShop.Controllers
{
    public class CustomerController : Controller
    {
        private IRepository _repository;

        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("[action]")]
        public IActionResult CreateCustomerOrder([FromForm] Customer customer)
        {
            _repository.addCustomer(customer);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}