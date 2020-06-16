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
    public class OrderLogicTest
    {
        public static IOrderContext context = new OrderContext(MockConnection.connection);
        public IOrderLogic sut = new OrderLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllOrders()
        {
            var result = sut.GetAllOrders();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
