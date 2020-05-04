﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IOrder
    {
        int MovieId { get; set; }
        int UserId { get; set; }
        int SeatId { get; set; }
        int MovieHallId { get; set; }
        string MovieName { get; set; }
        double MoviePrice { get; set; }
        double TotalPrice { get; set; }
    }
}