using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;

namespace Cinemaat_layers.LOGIC
{
    public interface IMovieLogic
    {
        void CreateMovie(IMovie _movie);
        void DeleteMovie(int movieId);
        IEnumerable<IMovie> GetAllMovies();
        IMovie UpdateMovie(IMovie movie);
        IMovie GetById(IMovie movie);
        void CreateReview(IMovie _movie);
    }
}