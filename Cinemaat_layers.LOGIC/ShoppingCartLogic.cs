using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class ShoppingCartLogic
    {
        public ShoppingCartLogic(IShoppingCartContext context)
        {
            Repository = new ShoppingCartRepository(context);
        }
        private ShoppingCartRepository Repository { get; set; }

        public void AddShoppingCart(int userId, int orderId, DateTime date, int quanitity)
        {
            var shoppingCart = new ShoppingCart
            {
                UserId = userId,
                OrderId = orderId,
                Date = date,
                Quantity = quanitity
            };
            Repository.Add(shoppingCart);
        }

        public IEnumerable<IShoppingCart> GetShoppingCarts()
        {
            return Repository.GetAll();
        }
    }
}
