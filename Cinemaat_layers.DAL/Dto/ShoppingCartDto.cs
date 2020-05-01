using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Dto
{
    public class ShoppingCartDto : IShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
