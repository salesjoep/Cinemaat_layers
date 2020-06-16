using Cinemaat_layers.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Cinemaat_Layers.Tests.MockData
{
    public static class MockConnection
    {
        public static DatabaseConnection connection = new DatabaseConnection("server=meelsnet.nl;user id=mmuller;database=mmuller_cinemaat;password=Hoi123;");

        public static void CloseConnection()
        {
            connection.SqlConnection.Close();
        }
    }
}
