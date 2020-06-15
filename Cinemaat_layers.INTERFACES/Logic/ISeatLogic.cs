using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface ISeatLogic
    {
        void AddSeat(int seatNr, bool isReserved);
        IEnumerable<ISeat> GetAllSeats();
    }
}
