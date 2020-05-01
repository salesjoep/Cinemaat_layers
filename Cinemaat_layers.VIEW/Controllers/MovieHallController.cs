using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class MovieHallController : Controller
    {
        private readonly IMovieHallContext _movieHallContext;

        public MovieHallController(IMovieHallContext movieHallContext)
        {
            _movieHallContext = movieHallContext;
        }
        public ActionResult Index()
        {
            var movieHallLogic = new MovieHallLogic(_movieHallContext);
            var movieHalls = new List<MovieHallViewModel>();

            foreach (var movieHall in movieHallLogic.GetAllMovieHalls())
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