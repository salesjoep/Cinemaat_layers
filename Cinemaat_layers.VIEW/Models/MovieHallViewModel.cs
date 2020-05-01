using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class MovieHallViewModel : IMovieHall
    {
        public int MovieId { get; set; }
        public int NrOfSeats { get; set; }
    }
}
