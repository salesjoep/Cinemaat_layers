using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class SeatController : Controller
    {
        private readonly ISeatLogic _seatLogic;

        public SeatController(ISeatLogic seatLogic)
        {
            _seatLogic = seatLogic;
        }

        //Read
        public ActionResult Index()
        {
            var seatLogic = _seatLogic.GetAllSeats();
            var seats = new List<SeatViewModel>();

            foreach (var seat in seatLogic)
            {
                seats.Add(new SeatViewModel
                {
                    SeatNr = seat.SeatNr,
                    IsReserved = seat.IsReserved
                });
            }
            return View(seats);
        }
    }
}