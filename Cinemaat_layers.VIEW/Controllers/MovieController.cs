using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieLogic  _movieLogic;

        public MovieController(IMovieLogic movieLogic)
        {
          
            _movieLogic = movieLogic;
        }

        //Read in CRUD
        
        public ActionResult Index()
        {
            //var allMovies = _movieContext.GetAllMovies();
            
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            
            return View(movies);
        }

        public ActionResult Avengers_Endgame()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Movie_1917()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Thor_Ragnarok()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Spiderman_Far_From_Home()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Captain_Marvel()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Antman_And_The_Wasp()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Black_Panther()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Doctor_Strange()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }
        public ActionResult Captain_America_Winter_Soldier()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Antman()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult Spiderman_Homecoming()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }

        public ActionResult No_Time_To_Die()
        {
            //var allMovies = _movieContext.GetAllMovies();
            var allMovies = _movieLogic.GetAllMovies();
            var movies = new List<MovieViewModel>();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating,
                    Price = movie.Price
                });
            }
            return View(movies);
        }


        public ActionResult Delete(int MovieId)
        {

            _movieLogic.DeleteMovie(MovieId);
            return RedirectToAction("Index");

        
        }

        //Create in CRUD

        [HttpGet]
        public ActionResult Create()
        {
            var movieViewModel = new MovieViewModel();
            return View(movieViewModel);
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel movie)
        {
            _movieLogic.CreateMovie(movie);

            return RedirectToAction("Index");
            //return View(new MovieViewModel());
        }
        
        [HttpGet]
        public ActionResult Edit()
        {
            MovieViewModel movieViewModel = new MovieViewModel();
            _movieLogic.GetById(movieViewModel);
            return View(movieViewModel);
        }

        [HttpPost]
        public ActionResult Edit(MovieViewModel movie)
        {
            _movieLogic.UpdateMovie(movie);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
        
    }
}