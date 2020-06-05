using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult WriteReview()
        {
            var reviewViewModel = new ReviewViewModel();
            return View(reviewViewModel);
        }

        [HttpPost]
        public ActionResult WriteReview(ReviewViewModel _review)
        {
            _reviewLogic.CreateReview(_review);
            return View();
        }
    }
}
