﻿using Cinemaat_layers.INTERFACES.Context;
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

        public bool Login(ILogin user)
        {
            bool login = false;            
            _connection.SqlConnection.Open();
            using (MySqlCommand query = new MySqlCommand("SELECT * FROM userregistration WHERE Email = @Email AND Password = SHA1(@Password); ", _connection.SqlConnection))
            {
                query.Parameters.AddWithValue("@Email", user.Email);
                query.Parameters.AddWithValue("@Password", user.Password);
                var reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.UserId = reader.GetInt32(0);
                        user.Email = reader.GetString(1);
                    }
                    login = true;
                }
            }
            return login;
        }
    }
}
