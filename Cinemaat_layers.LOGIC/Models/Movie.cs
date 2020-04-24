using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC.Models
{
    internal class Movie : IMovie
    {
        public string MovieName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Genre { get; set; }
        public string Review { get; set; }
        public double Rating { get; set; }
    }
}
