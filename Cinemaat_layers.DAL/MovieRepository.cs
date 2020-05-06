using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMovieContext _context;
        private List<IMovie> movieList;

        public MovieRepository(IMovieContext context)
        {
            _context = context;
        }
        //CREATE - RUD
        public void Add(IMovie movie)
        {
            _context.Add(movie);
        }
        //CRU - DELETE
        public IMovie Delete(string movieName)
        {
            IMovie movie = movieList.FirstOrDefault(e => e.MovieName == movieName);
            if (movie != null)
            {
                movieList.Remove(movie);
            }
            return movie;


        }

        //C - READ - UD
        public IEnumerable<IMovie> GetAll()
        {
            return _context.GetAll();
        }

        public IEnumerable<IMovie> Select1917Movie()
        {
            return _context.Select1917Movie();
        }

        //CR - UPDATE - D
        public IMovie Update(IMovie movieChanges)
        {
            IMovie movie = movieList.FirstOrDefault(e => e == movieChanges);
            if (movie != null)
            {
                movie.MovieName = movieChanges.MovieName;
                movie.Description = movieChanges.Description;
                movie.DateCreated = movieChanges.DateCreated;
                movie.Genre = movieChanges.Genre;
                movie.Review = movieChanges.Review;
                movie.Rating = movieChanges.Rating;
            }
            return movie;
        }
    }
}
