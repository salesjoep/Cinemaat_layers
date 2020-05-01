using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface ISeat
    {
        int SeatNr { get; set; }
        bool IsReserved { get; set; }
    }
}
