using Cinemaat_layers.DAL;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class MovieHallContextTest
    {
        public IMovieHallContext sut = new MovieHallContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AgendaContextGetAllTest()
        {
            var result = sut.GetAll();
            Assert.IsNotNull(result);
            MockConnection.CloseConnection();
        }
    }
}
