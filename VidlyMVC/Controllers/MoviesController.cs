using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customers = GetMovies().FirstOrDefault(c => c.Id == id);

            return View(customers);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
              new Movie(1,"Skrek 2"),
              new Movie(2, "Wall-E")
            };
        }
    }
}
