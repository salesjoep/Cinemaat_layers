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
        public ReviewLogic(IReviewContext context)
        {
            Repository = new ReviewRepository(context);
        }
        private ReviewRepository Repository { get; }

        public void CreateReview(IReview _review)
        {
            var review = new ReviewModel
            {
                ReviewId = _review.ReviewId,
                Review = _review.Review,
                Rating = _review.Rating,
                MovieId = _review.MovieId
            };
            Repository.CreateReview(review);
        }

        public IEnumerable<IReview> GetAllReviews()
        {
            return Repository.GetAll();
        }
    }
}
