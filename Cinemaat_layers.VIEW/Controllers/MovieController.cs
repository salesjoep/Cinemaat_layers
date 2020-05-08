﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieContext _movieContext;

        public MovieController(IMovieContext movieContext)
        {
            _movieContext = movieContext;
        }
        public ActionResult Index()
        {
            var movieLogic = new MovieLogic(_movieContext);
            var movies = new List<MovieViewModel>();

            foreach (var movie in movieLogic.GetAllMovies())
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating
                });
            }
            return View(movies);
        }

        public ActionResult Avengers_Endgame()
        {
            var movieLogic = new MovieLogic(_movieContext);
            var movies = new List<MovieViewModel>();

            foreach (var movie in movieLogic.GetAllMovies())
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating
                });
            }
            return View(movies);
        }

        public ActionResult Movie_1917()
        {
            var movieLogic = new MovieLogic(_movieContext);
            var movies = new List<MovieViewModel>();

            foreach (var movie in movieLogic.GetAllMovies())
            {
                movies.Add(new MovieViewModel
                {
                    MovieName = movie.MovieName,
                    Description = movie.Description,
                    DateCreated = movie.DateCreated,
                    Genre = movie.Genre,
                    Review = movie.Review,
                    Rating = movie.Rating
                });
            }
            return View(movies);
        }

        public ActionResult Delete(int MovieId)
        {
            var movieLogic = new MovieLogic(_movieContext);
            var movies = new List<MovieViewModel>();

            foreach (var movie in movieLogic.GetAllMovies())
            {
                movieLogic.DeleteMovie(MovieId);
            }
            return View(movies);
        }



        //GET: Customer/Details/5

    }
}