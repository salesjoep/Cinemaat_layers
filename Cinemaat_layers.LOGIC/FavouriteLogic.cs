using Cinemaat_layers.DAL.Repository_Classes;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class FavouriteLogic : IFavouriteLogic
    {
        private FavouriteRepository Repository { get; }
        public FavouriteLogic(IFavouriteContext context)
        {
            Repository = new FavouriteRepository(context);
        }

        public void CreateFavourite(IFavourite _favourite)
        {
            var favourite = new Favourite
            {
                favouriteId = _favourite.favouriteId,
                MovieId = _favourite.MovieId,
                UserId = _favourite.UserId,
                MovieName = _favourite.MovieName
            };
            Repository.CreateFavourite(favourite);
        }

        public IEnumerable<IFavourite> GetAll(int favouriteId)
        {
            return Repository.GetAll(favouriteId);
        }
    }
}
