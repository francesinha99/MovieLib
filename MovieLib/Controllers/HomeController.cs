using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieLib.Models;

namespace MovieLib.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext maContext { get; set; }

        public HomeController(MovieApplicationContext someName)
        {
            maContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = maContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            //Validation

            if (ModelState.IsValid)
            {
                maContext.Add(ar);
                maContext.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = maContext.Categories.ToList();
                return View();
            }
          
        }

        public IActionResult MovieList()
        {
            var movies = maContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = maContext.Categories.ToList();

            var movie = maContext.Responses.Single(x => x.MovieID == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse ar)
        {
            maContext.Update(ar);
            maContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = maContext.Responses.Single(x => x.MovieID == movieid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            maContext.Responses.Remove(ar);
            maContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
