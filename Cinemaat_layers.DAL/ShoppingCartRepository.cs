using Cinemaat_layers.INTERFACES;
using Renci.SshNet.Security.Cryptography.Ciphers.Modes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class ShoppingCartRepository
    {
        private readonly IShoppingCartContext _context;

        public ShoppingCartRepository(IShoppingCartContext context)
        {
            _context = context;
        }

        public void Add(IShoppingCart shoppingCart)
        {
            _context.Add(shoppingCart);
        }

        public IEnumerable<IShoppingCart> GetAll()
        {
            return _context.GetAll();
        }
    }
}
