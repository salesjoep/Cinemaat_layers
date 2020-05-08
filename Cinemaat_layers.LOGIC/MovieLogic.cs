using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class MovieLogic
    {
        private readonly MovieRepository _repository;
        public MovieLogic(IMovieContext context)
        {
            Repository = new MovieRepository(context);
            
        }

        private MovieRepository Repository { get; }

        public void CreateMovie(string movieName, string description, DateTime dateCreated, string genre, string review, double rating)
        {
            var movie = new Movie
            {
                MovieName = movieName,
                Description = description,
                DateCreated = dateCreated,
                Genre = genre,
                Review = review,
                Rating = rating
            };
            Repository.CreateMovie(movie);
        }

        public IEnumerable<IMovie> GetAllMovies()
        {
            return Repository.GetAll();
        }

        public IMovie UpdateMovie(int MovieId, string movieName, string description, DateTime dateCreated, string genre, string review, double rating)
        {
            var movie = new Movie
            {
                MovieName = movieName,
                Description = description,
                DateCreated = dateCreated,
                Genre = genre,
                Review = review,
                Rating = rating
            };
            _repository.UpdateMovie(movie, MovieId);
            return movie;
        }

        public void DeleteMovie(int movieId)
        {
            Repository.DeleteMovie(movieId);
        }
    }
}
