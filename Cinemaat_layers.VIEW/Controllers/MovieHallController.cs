using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class MovieHallController : Controller
    {
        private readonly IMovieHallLogic _movieHallLogic;

        public MovieHallController(IMovieHallLogic movieHallLogic)
        {
            _movieHallLogic = movieHallLogic;
        }
        public ActionResult Index()
        {
            var movieHallLogic = _movieHallLogic.GetAllMovieHalls();
            var movieHalls = new List<MovieHallViewModel>();

            foreach (var movieHall in movieHallLogic)
            {
                movieHalls.Add(new MovieHallViewModel
                {
                    MovieId = movieHall.MovieId,
                    NrOfSeats = movieHall.NrOfSeats
                });
            }
            return View(movieHalls);
        }
    }
}