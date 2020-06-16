using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Linq;

namespace Cinemaat_Layers.Tests
{
    public class Tests
    {
        public IMovieContext sut = new MovieContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MovieContextGetByIdTest()
        {
            IMovie movie = new MovieDto()
            {
                MovieId = 500,
                MovieName = "testName",
                Description = "testDescription",
                DateCreated = DateTime.Now,
                Genre = "action",
                Review = "testReview",
                Rating = 3,
                Price = 10
            };

            var result = sut.GetById(movie);
            Assert.AreEqual(movie.MovieId, result.MovieId);
            MockConnection.CloseConnection();
        }
    }
}