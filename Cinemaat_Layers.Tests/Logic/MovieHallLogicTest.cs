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
    public class MovieHallLogicTest
    {
        public static IMovieHallContext context = new MovieHallContext(MockConnection.connection);
        public IMovieHallLogic sut = new MovieHallLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllMovieHalls()
        {

            var result = sut.GetAllMovieHalls();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
