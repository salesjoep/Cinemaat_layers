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
    public class SeatViewTest
    {
        public static ISeatContext context = new SeatContext(MockConnection.connection);
        public static ISeatLogic logic = new SeatLogic(context);
        public SeatController sut = new SeatController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllSeats()
        {
            var result = sut.Index();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
