using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using System.Diagnostics;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext context) { this.context = context; }

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(movies => movies.Name).ToList();
            return View(movies);
        }

    }
}