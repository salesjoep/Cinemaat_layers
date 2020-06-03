using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    public class Agenda : IAgenda
    {
        public int AgendaId { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MovieHallId { get; set; }
        public bool IsValid { get; set; }
        public DateTime Time { get; set; }
    }
}
