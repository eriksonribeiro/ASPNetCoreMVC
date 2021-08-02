using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customers = GetCustomers().FirstOrDefault(c => c.Id == id);

            return View(customers);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
              new Customer(1,"John Smith"),
              new Customer(2, "Marry Willians")
            };
        }
    }
}
