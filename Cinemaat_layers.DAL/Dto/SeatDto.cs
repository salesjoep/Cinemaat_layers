using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    internal class SeatDto : ISeat
    {
        public int SeatId { get; set; }
        public int SeatNr { get; set; }
        public bool IsReserved { get; set; }
    }
}
