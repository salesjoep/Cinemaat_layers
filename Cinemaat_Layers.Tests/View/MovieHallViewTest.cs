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
    public class MovieHallViewTest
    {
        public static IMovieHallContext context = new MovieHallContext(MockConnection.connection);
        public static IMovieHallLogic logic = new MovieHallLogic(context);
        public MovieHallController sut = new MovieHallController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllMovieHalls()
        {
            var result = sut.Index();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
