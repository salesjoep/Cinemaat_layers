using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class MovieRepository
    {
        private readonly IMovieContext _context;

        public MovieRepository(IMovieContext context)
        {
            _context = context;
        }

        public void Add(IMovie movie)
        {
            _context.Add(movie);
        }

        public IEnumerable<IMovie> GetAll()
        {
            return _context.GetAll();
        }

        public IEnumerable<IMovie> Select1917Movie()
        {
            return _context.Select1917Movie();
        }
    }
}
