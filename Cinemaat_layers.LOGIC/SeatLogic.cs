using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class SeatLogic
    {
        public SeatLogic(ISeatContext context)
        {
            Repository = new SeatRepository(context);
        }
        private SeatRepository Repository { get; }

        public void AddSeat(int seatNr, bool isReserved)
        {
            var seat = new Seat
            {
                SeatNr = seatNr,
                IsReserved = isReserved
            };
            Repository.Add(seat);
        }

        public IEnumerable<ISeat> GetAllSeats()
        {
            return Repository.GetAll();
        }
    }
}
