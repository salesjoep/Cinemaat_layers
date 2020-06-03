using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Renci.SshNet;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderLogic _orderLogic;

        public OrderController(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public ActionResult Index()
        {
            var allOrders = _orderLogic.GetAllOrders();
            var orders = new List<OrderViewModel>();

            foreach (var order in allOrders)
            {
                orders.Add(new OrderViewModel
                {
                    OrderId = order.OrderId,
                    MovieId = order.MovieId,
                    UserId = order.UserId,
                    SeatId = order.SeatId,
                    AgendaId = order.AgendaId,
                    Time = order.Time,
                    MovieHallId = order.MovieHallId,
                    MovieName = order.MovieName,
                    Price = order.Price,
                    TotalPrice = order.TotalPrice
                });
            }
            return View(orders);
        }
        
        public ActionResult Order()
        {
            var allOrders = _orderLogic.GetAllOrders();
            var orders = new List<OrderViewModel>();

            foreach (var order in allOrders)
            {
                orders.Add(new OrderViewModel
                {
                    OrderId = order.OrderId,
                    MovieId = order.MovieId,
                    UserId = order.UserId,
                    SeatId = order.SeatId,
                    AgendaId = order.AgendaId,
                    Time = order.Time,
                    MovieHallId = order.MovieHallId,
                    MovieName = order.MovieName,
                    Price = order.Price,
                    TotalPrice = order.TotalPrice
                });
            }
            return View(orders);
        }

        [HttpGet]
        public ActionResult CreateOrder(int movieId, int userId, int seatId, int agendaId, DateTime time, int movieHallId, string movieName, double price, double totalPrice)
        {

            var orderViewModel = new OrderViewModel()
            {
                MovieId = movieId,
                UserId = 12,
                SeatId = 1,
                AgendaId = agendaId,
                Time = time,
                MovieHallId = movieHallId,
                MovieName = movieName,
                Price = price,
                TotalPrice = price
            };
            return View(orderViewModel);
        }

        [HttpPost]
        public ActionResult CreateOrder(OrderViewModel order)
        {
            _orderLogic.CreateOrder(order);
            return View("Success");
        }
    }
}