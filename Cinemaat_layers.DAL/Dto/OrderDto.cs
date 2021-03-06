﻿using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    public class OrderDto : IOrder
    {
        public int OrderId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int SeatId { get; set; }
        public int AgendaId { get; set; }
        public int MovieHallId { get; set; }
        public DateTime Time { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}
