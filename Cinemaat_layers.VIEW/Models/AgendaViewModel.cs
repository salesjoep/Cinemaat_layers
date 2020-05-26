using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class AgendaViewModel : IAgenda
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MovieHallId { get; set; }
        public bool IsValid { get; set; }
        public DateTime Time { get; set; }
    }
}
