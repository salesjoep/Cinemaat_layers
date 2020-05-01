using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    internal class MovieHallDto : IMovieHall
    {
        public int MovieHallId { get; set; }
        public int MovieId { get; set; }
        public int NrOfSeats { get; set; }
    }
}
