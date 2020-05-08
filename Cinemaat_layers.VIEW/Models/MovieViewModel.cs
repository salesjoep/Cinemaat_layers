﻿using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class MovieViewModel : IMovie
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
