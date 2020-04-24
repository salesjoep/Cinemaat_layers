using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    internal class MovieDto : IMovie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Genre { get; set; }
        public string Review { get; set; }
        public double Rating { get; set; }
    }
}
