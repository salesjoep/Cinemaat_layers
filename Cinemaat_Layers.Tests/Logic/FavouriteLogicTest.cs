using Cinemaat_layers.DAL.Context_Classes;
using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{

    public class FavouriteLogicTest
    {
        public static IFavouriteContext context = new FavouriteContext(MockConnection.connection);
        public IFavouriteLogic sut = new FavouriteLogic(context);

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetAllfavourites()
        {
            var result = sut.GetAll(12);
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
