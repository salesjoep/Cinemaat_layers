using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewLogic _reviewLogic;
        public ReviewController(IReviewLogic reviewLogic)
        {
            _reviewLogic = reviewLogic;
        }
        public ActionResult Index(int movieId)
        {
            var allReviews = _reviewLogic.GetAllReviews(movieId);
            var reviews = new List<ReviewViewModel>();

            foreach (var review in allReviews)
            {
                reviews.Add(new ReviewViewModel
                {
                    ReviewId = review.ReviewId,
                    Review = review.Review,
                    Rating = review.Rating,
                    MovieId = movieId
                });
            }

            return View(reviews);
        }

        [HttpGet]
        public ActionResult WriteReview(int movieId)
        {
            var reviewViewModel = new ReviewViewModel()
            {
                MovieId = movieId,
                UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"))
            };
            return View(reviewViewModel);
        }

        [HttpPost]
        public ActionResult WriteReview(ReviewViewModel _review)
        {
            _reviewLogic.CreateReview(_review);
            return Redirect("https://localhost:44384/Movie/AllMovies");
        }
    }
}
