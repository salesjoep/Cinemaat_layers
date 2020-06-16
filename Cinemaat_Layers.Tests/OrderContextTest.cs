using Cinemaat_layers.DAL;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class OrderContextTest
    {
        public IOrderContext sut = new OrderContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void OrderContextTest1()
        {
            var result = sut.GetAll();
            Assert.IsNotNull(result);
            MockConnection.CloseConnection();
        }
    }
}
