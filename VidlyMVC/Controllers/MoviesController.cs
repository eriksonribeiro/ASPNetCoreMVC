using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VidlyMVC.Data;
using VidlyMVC.Models;
using VidlyMVC.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

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
            var movies = _context.Movie.Include(g => g.Genre).ToList();
            return View(movies);
        }

        public IActionResult Details(int? id)
        {
            var movie = _context.Movie.Include(g => g.Genre).FirstOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);
        }

        public IActionResult Create()
        {
            var genres = _context.Genre.ToList();
            var viewModel = new MovieViewModel
            {
                Genre = genres
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            movie.DateAdded = DateTime.Now;
            _context.Movie.Add(movie);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            var movie = _context.Movie.Include(g => g.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            var viewModel = new MovieViewModel
            {
                Genre = _context.Genre.ToList(),
                Movie = movie
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _context.Movie.Update(movie);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var movie = _context.Movie.Include(g => g.Genre).FirstOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);
        }


        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(Movie movie)
        {
            _context.Movie.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
