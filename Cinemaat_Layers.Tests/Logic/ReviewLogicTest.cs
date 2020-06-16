using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{
    public class ReviewLogicTest
    {
        public static IReviewContext context = new ReviewContext(MockConnection.connection);
        public IReviewLogic sut = new ReviewLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllReviews()
        {
            var result = sut.GetAllReviews(1);
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
