using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Repository_Classes
{
    public class ReviewRepository
    {
        private readonly IReviewContext _context;

        public ReviewRepository(IReviewContext context)
        {
            _context = context;
        }

        public void CreateReview(IReview review)
        {
            _context.CreateReview(review);
        }

        public IEnumerable<IReview> GetAll(int movieId)
        {
            return _context.GetAll(movieId);
        }
    }
}
