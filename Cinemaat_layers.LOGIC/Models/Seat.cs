using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    internal class Seat : ISeat
    {
        public int SeatNr { get; set; }
        public bool IsReserved { get; set; }
    }
}
