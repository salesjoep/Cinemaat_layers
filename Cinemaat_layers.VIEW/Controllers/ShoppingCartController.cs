using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaat_layers.VIEW.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartLogic _shoppingCartLogic;

        public ShoppingCartController(IShoppingCartLogic shoppingCartLogic)
        {
            _shoppingCartLogic = shoppingCartLogic;
        }
        public ActionResult Index()
        {
            var shoppingCartLogic = _shoppingCartLogic.GetShoppingCarts();
            var shoppingCarts = new List<ShoppingCartViewModel>();

            foreach (var shoppingCart in shoppingCartLogic)
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