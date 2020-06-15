using Cinemaat_layers.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_Layers.Tests.MockData
{
    public static class MockConnection
    {
        public static DatabaseConnection connection = new DatabaseConnection("server=meelsnet.nl;user id=mmuller;database=mmuller_cinemaat;password=Hoi123;");
    }
}
