using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class MovieHallLogic
    {
        private readonly IMovieHallContext movieHallContext;
        public MovieHallLogic(IMovieHallContext context)
        {
            //Repository = new MovieHallRepository(context);
            movieHallContext = context;
        }

        public void AddMovieHall(int movieId, int nrOfSeats)
        {
            var movieHall = new MovieHall
            {
                MovieId = movieId,
                NrOfSeats = nrOfSeats
            };
            movieHallContext.Add(movieHall);
        }

        public IEnumerable<IMovieHall> GetAllMovieHalls()
        {
            return movieHallContext.GetAll();
        }
    }
}
