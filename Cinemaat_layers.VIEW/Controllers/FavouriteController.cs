using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class FavouriteController : Controller
    {
        private readonly IFavouriteLogic _favouriteLogic;
        public FavouriteController(IFavouriteLogic favouriteLogic)
        {
            _favouriteLogic = favouriteLogic;
        }
        public ActionResult Index(/*int userId*/)
        {
            var allFavourites = _favouriteLogic.GetAll(Convert.ToInt32(HttpContext.Session.GetInt32("UserId")));
            var favourites = new List<FavouriteViewModel>();

            foreach (var favourite in allFavourites)
            {
                favourites.Add(new FavouriteViewModel
                {
                    favouriteId = favourite.favouriteId,
                    MovieId = favourite.MovieId,
                    UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId")),
                    MovieName = favourite.MovieName
                });
            }

            return View(favourites);
        }

        [HttpGet]
        public ActionResult Create(int movieId, string movieName)
        {
            var favouriteViewModel = new FavouriteViewModel()
            {
                MovieId = movieId,
                UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId")),
                MovieName = movieName
            };
            return View(favouriteViewModel);
        }

        [HttpPost]
        public ActionResult Create(FavouriteViewModel favourite)
        {
            _favouriteLogic.CreateFavourite(favourite);
            return View();
        }
    }
}
