using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IMovieContext
    {
        void Add(IMovie movie);

        IEnumerable<IMovie> GetAll();
        IEnumerable<IMovie> SelectSpecificMovie();

        IMovie GetById(int id);
    }
}
