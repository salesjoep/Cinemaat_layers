using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public interface IShoppingCartContext
    {
        void Add(IShoppingCart shoppingCart);

        IEnumerable<IShoppingCart> GetAll();

        IShoppingCart GetById(int id);
    }
}
