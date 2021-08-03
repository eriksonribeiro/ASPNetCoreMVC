using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyMVC.Data;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        private VidlyMVCContext _context;

        public CustomersController(VidlyMVCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customer.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customers = _context.Customer.FirstOrDefault(c => c.Id == id);

            return View(customers);
        }
    }
}
