using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CreateMovie(IMovie movie)
        {
            _context.CreateMovie(movie);
        }
        
        public IEnumerable<IMovie> GetAll()
        {
            return _context.GetAll();
        }

        public void UpdateMovie(IMovie movie)
        {
            _context.UpdateMovie(movie);
        }

        public void DeleteMovie(int movieId)
        {
            _context.DeleteMovie(movieId);
        }

        public void GetById(int MovieId)
        {
            _context.GetById(MovieId);
        }

        
    }
}
