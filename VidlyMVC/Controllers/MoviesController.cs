using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VidlyMVC.Data;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly VidlyMVCContext _context;

        public MoviesController(VidlyMVCContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var movies = _context.Movie.ToList();
            return View(movies);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customers = _context.Movie.FirstOrDefault(c => c.Id == id);

            return View(customers);
        }

    }
}
