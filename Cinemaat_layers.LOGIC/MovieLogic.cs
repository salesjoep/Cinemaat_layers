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
        private readonly MovieRepository _repository;
        public MovieLogic(IMovieContext context)
        {
            Repository = new MovieRepository(context);

        }

        private MovieRepository Repository { get; }

        public void CreateMovie(IMovie _movie)
        {
            var movie = new Movie
            {
                MovieName = _movie.MovieName,
                Description = _movie.Description,
                DateCreated = _movie.DateCreated,
                Genre = _movie.Genre,
                Review = _movie.Review,
                Rating = _movie.Rating
            };
            Repository.CreateMovie(movie);
        }

        public IEnumerable<IMovie> GetAllMovies()
        {
            return Repository.GetAll();
        }

        public IMovie UpdateMovie(IMovie movie)
        {
            //Movie _movie = new Movie();
            //movie = _movie;
            Repository.UpdateMovie(movie);
            return movie;
        }

        public void DeleteMovie(int movieId)
        {
            Repository.DeleteMovie(movieId);
        }

        public void GetById(int MovieId)
        {
            Repository.GetById(MovieId);
        }
    }
}
