using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Context_Classes
{
    public class LoginContext : ILoginContext
    {
        private readonly DatabaseConnection _connection;
        public LoginContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public void Login(ILogin user)
        {
            
            _connection.SqlConnection.Open();
            string query = "SELECT Email, Password FROM userregistration where Email=@Email and Password=@Password; ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);                

                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }
    }
}
