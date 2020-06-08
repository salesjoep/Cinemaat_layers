using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class FavouriteController : Controller
    {
        private readonly IFavouriteLogic _favouriteLogic;
        public FavouriteController(IFavouriteLogic favouriteLogic)
        {
            _favouriteLogic = favouriteLogic;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var favouriteViewModel = new FavouriteViewModel();
            return View(favouriteViewModel);
        }

        [HttpPost]
        public ActionResult Create(FavouriteViewModel favourite)
        {
            _favouriteLogic.CreateFavourite(favourite);
            return View();
        }
    }
}
