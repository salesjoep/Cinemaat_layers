using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class SeatViewModel : ISeat
    {
        public int SeatNr { get; set; }
        public bool IsReserved { get; set; }
    }
}
