using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;

namespace Cinemaat_layers.LOGIC
{
    public interface IMovieLogic
    {
        void CreateMovie(string movieName, string description, DateTime dateCreated, string genre, string review, double rating);
        void DeleteMovie(int movieId);
        IEnumerable<IMovie> GetAllMovies();
        IMovie UpdateMovie(int MovieId, string movieName, string description, DateTime dateCreated, string genre, string review, double rating);
    }
}