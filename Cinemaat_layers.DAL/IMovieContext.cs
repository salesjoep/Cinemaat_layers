using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IMovieContext
    {
        void CreateMovie(IMovie movie);

        IEnumerable<IMovie> GetAll();

        void UpdateMovie(IMovie movie, int MovieId);

        IMovie GetById(int id);

        void DeleteMovie(int movieId);
    }
}
