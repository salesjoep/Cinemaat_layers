using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class OrderLogic
    {
        public OrderLogic(IOrderContext context)
        {
            Repository = new OrderRepository(context);
        }

        private OrderRepository Repository { get; }

        public void AddOrder(int movieId, int userId, int seatId, int movieHallId, string movieName, double moviePrice, double totalPrice)
        {
            var order = new Order
            {
                MovieId = movieId,
                UserId = userId,
                SeatId = seatId,
                MovieHallId = movieHallId,
                MovieName = movieName,
                MoviePrice = moviePrice,
                TotalPrice = totalPrice
            };
            Repository.Add(order);
        }

        public IEnumerable<IOrder> GetAllOrders()
        {
            return Repository.GetAll();
        }
    }
}
