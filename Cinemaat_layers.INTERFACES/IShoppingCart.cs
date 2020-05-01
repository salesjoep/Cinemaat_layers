using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.INTERFACES
{
    public interface IShoppingCart
    {
        int UserId { get; set; }
        int OrderId { get; set; }
        DateTime Date { get; set; }
        int Quantity { get; set; }
    }
}
