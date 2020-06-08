using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IFavourite
    {
        int favouriteId { get; set; }
        int MovieId { get; set; }
        int UserId { get; set; }
        string MovieName { get; set; }
    }
}
