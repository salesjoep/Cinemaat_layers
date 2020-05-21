using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly IUserRegistrationLogic _userRegistrationLogic;
        public UserRegistrationController(IUserRegistrationLogic userRegistrationLogic)
        {
            _userRegistrationLogic = userRegistrationLogic;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            var userRegistrationViewModel = new UserRegistrationViewModel();
            return View(userRegistrationViewModel);
        }

        [HttpPost]
        public ActionResult CreateUser(UserRegistrationViewModel user)
        {
            _userRegistrationLogic.CreateUser(user);
            return View();
        }
    }
}