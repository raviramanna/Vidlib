using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlib.Models;
using Vidlib.ViewModel;

namespace Vidlib.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name="Shreak"};

            var customer1 = new Customer {Name = "Ravi"};
            var customer2 = new Customer {Name = "Ramanna"};
            var customers = new List<Customer> {customer1, customer2};

            RandomViewModel viewModel = new RandomViewModel {Movie = movie, Customers = customers};
            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Mission Impossible"},
                new Movie{Name = "Minnions"}
            };
            return movies;
        }
    }
}