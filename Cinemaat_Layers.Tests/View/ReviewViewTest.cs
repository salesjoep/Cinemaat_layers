using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Context_Classes;
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
    public class ReviewViewTest
    {
        public static IReviewContext context = new ReviewContext(MockConnection.connection);
        public static IReviewLogic logic = new ReviewLogic(context);
        public ReviewController sut = new ReviewController(logic);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllReviews()
        {
            var result = sut.Index(1);
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
