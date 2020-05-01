using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class SeatController : Controller
    {
        private readonly ISeatContext _seatContext;

        public SeatController(ISeatContext seatContext)
        {
            _seatContext = seatContext;
        }

        //Read
        public ActionResult Index()
        {
            var seatLogic = new SeatLogic(_seatContext);
            var seats = new List<SeatViewModel>();

            foreach (var seat in seatLogic.GetAllSeats())
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