using Cinemaat_layers.DAL;
using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests
{
    public class AgendaContextTest
    {
        public IAgendaContext sut = new AgendaContext(MockConnection.connection);
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AgendaContextGetAllTest()
        {
            var result = sut.GetAll(1);
            Assert.IsNotNull(result);
            MockConnection.CloseConnection();
        }
    }
}
