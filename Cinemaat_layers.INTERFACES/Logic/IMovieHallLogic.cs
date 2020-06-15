using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface IMovieHallLogic
    {
        void AddMovieHall(int movieId, int nrOfSeats);
        IEnumerable<IMovieHall> GetAllMovieHalls();
    }
}
