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
    public class OrderController : Controller
    {
        private readonly IOrderContext _orderContext;

        public OrderController(IOrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        public ActionResult Index()
        {
            var orderLogic = new OrderLogic(_orderContext);
            var orders = new List<OrderViewModel>();

            foreach (var order in orderLogic.GetAllOrders())
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
    }
}