using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class MovieLogic : IMovieLogic
    {
        private readonly IMovieContext movieContext;
        
        public MovieLogic(IMovieContext context)
        {
            movieContext = context;

        }

        public void CreateMovie(IMovie _movie)
        {
            var movie = new Movie
            {
                MovieName = _movie.MovieName,
                Description = _movie.Description,
                DateCreated = _movie.DateCreated,
                Genre = _movie.Genre,
                Review = _movie.Review,
                Rating = _movie.Rating,
                Price = _movie.Price
            };
            movieContext.CreateMovie(movie);
        }

        public IEnumerable<IMovie> GetAllMovies()
        {
            return movieContext.GetAll();
        }

        public IMovie UpdateMovie(IMovie movie)
        {
            //Movie _movie = new Movie();
            //movie = _movie;
            movieContext.UpdateMovie(movie);
            return movie;
        }

        public void DeleteMovie(int movieId)
        {
            movieContext.DeleteMovie(movieId);
        }

        public IMovie GetById(IMovie movie)
        {
            return movieContext.GetById(movie);
        }

        public void CreateReview(IMovie _movie)
        {
            var movie = new Movie
            {
                Review = _movie.Review,
                Rating = _movie.Rating
            };
            movieContext.CreateReview(movie);
        }
    }
}
