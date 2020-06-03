using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IMovie
    {
        int MovieId { get; set; }
        string MovieName { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
        string Genre { get; set; }
        string Review { get; set; }
        double Rating { get; set; }
        double Price { get; set; }

    }
}
