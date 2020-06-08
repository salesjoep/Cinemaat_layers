using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class FavouriteViewModel : IFavourite
    {
        public int favouriteId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public string MovieName { get; set; }
    }
}
