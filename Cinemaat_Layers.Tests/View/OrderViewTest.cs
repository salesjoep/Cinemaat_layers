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
    public class OrderViewTest
    {
        public static IOrderContext context = new OrderContext(MockConnection.connection);
        public static IOrderLogic logic = new OrderLogic(context);
        public OrderController sut = new OrderController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllOrders()
        {
            var result = sut.Order();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
