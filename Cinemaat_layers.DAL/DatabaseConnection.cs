using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Cinemaat_layers.DAL
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string connectionString)
        {
            SqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlConnection SqlConnection { get; set; }
    }
}
