using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginLogic _loginLogic;

        public LoginController(ILoginLogic loginLogic)
        {
            _loginLogic = loginLogic;
        }

        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel user)
        {
            bool login = _loginLogic.Login(user);
            if (login)
            {
                HttpContext.Session.SetString("Email", user.Email);
                HttpContext.Session.SetInt32("UserId", user.UserId);
                System.Threading.Thread.Sleep(3500);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Logout()
        {
            try
            {
                if (HttpContext.Session.GetInt32("UserId") != null)
                {
                    HttpContext.Session.Clear();
                }
                return RedirectToAction("Index", "Login");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Welcome()
        {
            return View();
        }

        
    }
}