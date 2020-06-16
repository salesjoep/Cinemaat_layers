using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_layers.VIEW.Controllers;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.View
{
    public class MovieViewTest
    {
        public static IMovieContext context = new MovieContext(MockConnection.connection);
        public static IMovieLogic logic = new MovieLogic(context);
        public MovieController sut = new MovieController(logic);


        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllMovies()
        {
            var result = sut.Movie();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }

}
