using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartContext _shoppingCartContext;

        public ShoppingCartController(IShoppingCartContext shoppingCartContext)
        {
            _shoppingCartContext = shoppingCartContext;
        }
        public ActionResult Index()
        {
            var shoppingCartLogic = new ShoppingCartLogic(_shoppingCartContext);
            var shoppingCarts = new List<ShoppingCartViewModel>();

            foreach (var shoppingCart in shoppingCartLogic.GetShoppingCarts())
            {
                shoppingCarts.Add(new ShoppingCartViewModel
                {
                    UserId = shoppingCart.UserId,
                    OrderId = shoppingCart.OrderId,
                    Date = shoppingCart.Date,
                    Quantity = shoppingCart.Quantity
                });
            }
            return View(shoppingCarts);
        }
    }
}