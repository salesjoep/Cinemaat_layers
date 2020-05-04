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
        public MovieLogic(IMovieContext context)
        {
            Repository = new MovieRepository(context);
        }

        private MovieRepository Repository { get; }

        public void AddMovie(string movieName, string description, DateTime dateCreated, string genre, string review, double rating)
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
            Repository.Add(movie);
        }

        public IEnumerable<IMovie> GetAllMovies()
        {
            return Repository.GetAll();
        }
        public IEnumerable<IMovie> SelectSpecificMovie()
        {
            return Repository.GetAll();
        }

        public IEnumerable<IMovie> Select1917Movie()
        {
            return Repository.GetAll();
        }
    }
}
