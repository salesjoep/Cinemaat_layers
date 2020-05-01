using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaat_layers.VIEW.Models
{
    public class ShoppingCartViewModel : IShoppingCart
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
