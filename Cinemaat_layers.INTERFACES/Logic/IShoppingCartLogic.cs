using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES.Logic
{
    public interface IShoppingCartLogic
    {
        void AddShoppingCart(int userId, int orderId, DateTime date, int quanitity);
        IEnumerable<IShoppingCart> GetShoppingCarts();
    }
}
