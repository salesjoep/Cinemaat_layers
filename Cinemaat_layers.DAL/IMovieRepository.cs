using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IMovieRepository
    {
        void Add(IMovie movie);
        IEnumerable<IMovie> GetAll();
        IEnumerable<IMovie> Select1917Movie();

        IMovie Update(IMovie movieChanges);
        IMovie Delete(string movieName);
    }
}
