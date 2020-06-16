using Cinemaat_layers.DAL;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{
    public class MovieLogicTest
    {
        public static IMovieContext context = new MovieContext(MockConnection.connection);
        public IMovieLogic sut = new MovieLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllMovies()
        {
            var result = sut.GetAllMovies();
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }

        [Test]
        public void GetMovieById()
        {
            var result = sut.GetById(MockMovie.movieTest);
            Assert.AreEqual(MockMovie.movieTest, result);

            MockConnection.CloseConnection();
        }
    }
}
