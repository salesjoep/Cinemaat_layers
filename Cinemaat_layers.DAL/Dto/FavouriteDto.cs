using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    public class FavouriteDto : IFavourite
    {
        public int favouriteId { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public string MovieName { get; set; }
    }
}
