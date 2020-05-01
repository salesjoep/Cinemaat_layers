using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class ShoppingCartContext : IShoppingCartContext
    {
        private readonly DatabaseConnection _connection;

        public ShoppingCartContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(IShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IShoppingCart> GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM ShoppingCart", _connection.SqlConnection);
            var reader = cmd.ExecuteReader();

            var shoppingCartRecords = new List<IShoppingCart>();

            while (reader.Read())
            {
                var shoppingCart = new ShoppingCartDto
                {
                    ShoppingCartId = (int)reader["ShoppingCartId"],
                    UserId = (int)reader["UserId"],
                    OrderId = (int)reader["OrderId"],
                    Date = DateTime.Parse(reader["Date"]?.ToString() ?? ""),
                    Quantity = (int)reader["Quantity"]
                };

                shoppingCartRecords.Add(shoppingCart);
            }
            return shoppingCartRecords;
        }

        public IShoppingCart GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
