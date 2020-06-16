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
    public class SeatLogicTest
    {
        public static ISeatContext context = new SeatContext(MockConnection.connection);
        public ISeatLogic sut = new SeatLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllSeats()
        {
            var result = sut.GetAllSeats();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
