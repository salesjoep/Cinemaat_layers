using Cinemaat_layers.DAL;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class ShoppingCartContextTest
    {
        public IShoppingCartContext sut = new ShoppingCartContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void SeatContextGetAll()
        {
            var result = sut.GetAll();
            CollectionAssert.IsEmpty(result);
            MockConnection.CloseConnection();
        }
    }
}
