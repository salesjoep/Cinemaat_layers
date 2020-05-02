using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}