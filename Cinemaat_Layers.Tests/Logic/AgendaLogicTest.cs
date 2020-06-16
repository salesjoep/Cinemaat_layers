using Cinemaat_layers.DAL;
using Cinemaat_layers.INTERFACES.Logic;
using Cinemaat_layers.LOGIC;
using Cinemaat_Layers.Tests.MockData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.Logic
{
    
    public class AgendaLogicTest
    {
        public static IAgendaContext context = new AgendaContext(MockConnection.connection);
        public IAgendaLogic sut = new AgendaLogic(context);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllAgendasTest()
        {
            var result = sut.GetAllAgendas(1);
            Assert.IsNotNull(result);

            MockConnection.CloseConnection();
        }
    }
}
