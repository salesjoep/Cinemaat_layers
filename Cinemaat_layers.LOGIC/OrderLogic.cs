using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class OrderLogic : IOrderLogic
    {
        public OrderLogic(IOrderContext context)
        {
            Repository = new OrderRepository(context);
        }

        private OrderRepository Repository { get; }

        public void CreateOrder(IOrder _order)
        {
            var order = new Order
            {
                OrderId = _order.OrderId,
                MovieId = _order.MovieId,
                UserId = _order.UserId,
                SeatId = _order.SeatId,
                MovieHallId = _order.MovieHallId,
                MovieName = _order.MovieName,
                MoviePrice = _order.MoviePrice,
                TotalPrice = _order.TotalPrice
            };
            Repository.CreateOrder(order);
        }

        public IEnumerable<IOrder> GetAllOrders()
        {
            return Repository.GetAll();
        }
    }
}
