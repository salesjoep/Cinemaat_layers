using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class SeatLogic : ISeatLogic
    {
        private readonly ISeatContext seatContext;
        public SeatLogic(ISeatContext context)
        {
            seatContext = context;
        }

        public void AddSeat(int seatNr, bool isReserved)
        {
            var seat = new Seat
            {
                SeatNr = seatNr,
                IsReserved = isReserved
            };
            seatContext.Add(seat);
        }

        public IEnumerable<ISeat> GetAllSeats()
        {
            return seatContext.GetAll();
        }
    }
}
