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
                    MovieId = order.MovieId,
                    UserId = order.UserId,
                    SeatId = order.SeatId,
                    MovieHallId = order.MovieHallId,
                    MovieName = order.MovieName,
                    MoviePrice = order.MoviePrice,
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
                    MovieHallId = order.MovieHallId,
                    MovieName = order.MovieName,
                    MoviePrice = order.MoviePrice,
                    TotalPrice = order.TotalPrice
                });
            }
            return View(orders);
        }

        [HttpGet]
        public ActionResult CreateOrder()
        {
            var orderViewModel = new OrderViewModel();
            return View(orderViewModel);
        }

        [HttpPost]
        public ActionResult CreateOrder(OrderViewModel order)
        {
            _orderLogic.CreateOrder(order);
            return View();
        }
    }
}