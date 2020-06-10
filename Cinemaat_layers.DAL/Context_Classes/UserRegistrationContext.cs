using Cinemaat_layers.INTERFACES.Context;
using Cinemaat_layers.INTERFACES.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Context_Classes
{
    public class UserRegistrationContext : IUserRegistrationContext
    {
        private readonly DatabaseConnection _connection;

        public UserRegistrationContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        //Create User
        public void CreateUser(IUserRegistration user)
        {
            _connection.SqlConnection.Open();
            string query = "INSERT INTO userregistration VALUES (@UserId, @Username, @Email, SHA1(@Password)); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);

                command.ExecuteNonQuery();                
            }
            _connection.SqlConnection.Close();
        }
    }
    
}
