using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    internal class MovieHall : IMovieHall
    {
        public int MovieId { get; set; }
        public int NrOfSeats { get; set; }
    }
}
