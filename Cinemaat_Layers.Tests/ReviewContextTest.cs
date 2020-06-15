using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_Layers.Tests.MockData;
using FakeItEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class ReviewContextTest
    {
        public IReviewContext sut = new ReviewContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GetAllReviewsFromMovieId()
        {
            var result = sut.GetAll(1);
            Assert.IsNotNull(result);
        }

    }
}
