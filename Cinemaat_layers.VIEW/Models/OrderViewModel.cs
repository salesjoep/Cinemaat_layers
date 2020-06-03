using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class OrderViewModel : IOrder
    {
        public int OrderId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int SeatId { get; set; }
        public int MovieHallId { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public int AgendaId { get; set; }
        public DateTime Time { get; set; }
    }
}
