using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.LOGIC
{
    public class ShoppingCartLogic : IShoppingCartLogic
    {
        private readonly IShoppingCartContext shoppingCartContext;
        public ShoppingCartLogic(IShoppingCartContext context)
        {
            shoppingCartContext = context;
        }

        public void AddShoppingCart(int userId, int orderId, DateTime date, int quanitity)
        {
            var shoppingCart = new ShoppingCart
            {
                UserId = userId,
                OrderId = orderId,
                Date = date,
                Quantity = quanitity
            };
            shoppingCartContext.Add(shoppingCart);
        }

        public IEnumerable<IShoppingCart> GetShoppingCarts()
        {
            return shoppingCartContext.GetAll();
        }
    }
}
