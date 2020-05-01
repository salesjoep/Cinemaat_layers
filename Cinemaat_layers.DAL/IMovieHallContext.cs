using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IMovieHallContext
    {
        void Add(IMovieHall movieHall);

        IEnumerable<IMovieHall> GetAll();

        IMovieHall GetById(int id);
    }
}
