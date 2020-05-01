using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class MovieHallRepository
    {
        private readonly IMovieHallContext _context;

        public MovieHallRepository(IMovieHallContext context)
        {
            _context = context;
        }

        public void Add(IMovieHall movieHall)
        {
            _context.Add(movieHall);
        }

        public IEnumerable<IMovieHall> GetAll()
        {
            return _context.GetAll();
        }
    }
}
