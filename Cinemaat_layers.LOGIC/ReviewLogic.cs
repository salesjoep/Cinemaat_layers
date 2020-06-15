using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Repository_Classes;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class ReviewLogic : IReviewLogic
    {
        private readonly IReviewContext reviewContext;
        public ReviewLogic(IReviewContext context)
        {
            reviewContext = context;
        }

        public void CreateReview(IReview _review)
        {
            var review = new ReviewModel
            {
                ReviewId = _review.ReviewId,
                Review = _review.Review,
                Rating = _review.Rating,
                MovieId = _review.MovieId,
                UserId = _review.UserId
            };
            reviewContext.CreateReview(review);
        }

        public IEnumerable<IReview> GetAllReviews(int movieId)
        {
            return reviewContext.GetAll(movieId);
        }
    }
}
