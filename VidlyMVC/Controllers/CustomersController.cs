using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using VidlyMVC.Data;
using VidlyMVC.Models.ViewModels;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly VidlyMVCContext _context;

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
            var customer = _context.Customer.Include(c => c.MembershipType).FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        public IActionResult Create()
        {
            var membershipTypes = _context.MembershipType.ToList();

            var viewModel = new CustomerViewModel
            {
                MembershipType = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int? id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                MembershipType = _context.MembershipType.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _context.Customer.Update(customer);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var customer = _context.Customer.Include(c => c.MembershipType).FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Customer customer)
        {
            _context.Customer.Remove(customer);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
