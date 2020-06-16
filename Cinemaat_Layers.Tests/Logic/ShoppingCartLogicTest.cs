using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{
    public class ShoppingCartLogicTest
    {
        public static IShoppingCartContext context = new ShoppingCartContext(MockConnection.connection);
        public IShoppingCartLogic sut = new ShoppingCartLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllShoppingCarts()
        {
            var result = sut.GetShoppingCarts();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
