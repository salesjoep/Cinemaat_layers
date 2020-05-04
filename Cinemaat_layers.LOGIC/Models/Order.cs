﻿using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    internal class Order : IOrder
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int SeatId { get; set; }
        public int MovieHallId { get; set; }
        public string MovieName { get; set; }
        public double MoviePrice { get; set; }
        public double TotalPrice { get; set; }
    }
}