using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Repository_Classes
{
    public class FavouriteRepository
    {
        private readonly IFavouriteContext _context;

        public FavouriteRepository(IFavouriteContext context)
        {
            _context = context;
        }

        public void CreateFavourite(IFavourite favourite)
        {
            _context.CreateFavourite(favourite);
        }
        public IEnumerable<IFavourite> GetAll(int favouriteId)
        {
            return _context.GetAll(favouriteId);
        }
    }
}
