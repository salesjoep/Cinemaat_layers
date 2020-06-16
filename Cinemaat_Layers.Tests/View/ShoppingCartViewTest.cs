using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Controllers;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.View
{
    public class ShoppingCartViewTest
    {
        public static IShoppingCartContext context = new ShoppingCartContext(MockConnection.connection);
        public static IShoppingCartLogic logic = new ShoppingCartLogic(context);
        public ShoppingCartController sut = new ShoppingCartController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllShoppingCarts()
        {
            var result = sut.Index();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
