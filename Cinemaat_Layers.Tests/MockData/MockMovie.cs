using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.MockData
{
    public static class MockMovie
    {
        public static IMovie movieTest = new Movie()
        {
            MovieId = 500,
            MovieName = "testName",
            Description = "testDescription",
            DateCreated = new DateTime(2020, 06, 15),
            Genre = "action",
            Review = "testReview",
            Rating = 3,
            Price = 10
        };
    }
}
