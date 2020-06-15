using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class FavouriteContextTest
    {
        public IFavouriteContext sut = new FavouriteContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void MovieContextGetAllTest()
        {
            var result = sut.GetAll(12);
            Assert.IsNotNull(result);
        }
    }
}
