using Cinemaat_layers.INTERFACES;
using Cinemaat_layers.INTERFACES.Context;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Context_Classes
{
    public class FavouriteContext : IFavouriteContext
    {
        private readonly DatabaseConnection _connection;
        public FavouriteContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        //Create in CRUD
        public void CreateFavourite(IFavourite favourite)
        {
            _connection.SqlConnection.Open();
            string query = "INSERT INTO `favourite` (`FavouriteId`, `MovieId`, `UserId`, `MovieName`) VALUES(@FavouriteId, @MovieId, @UserId, @MovieName); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@FavouriteId", favourite.favouriteId);
                command.Parameters.AddWithValue("@MovieId", favourite.MovieId);
                command.Parameters.AddWithValue("@UserId", favourite.UserId);
                command.Parameters.AddWithValue("@MovieName", favourite.MovieName);

                command.ExecuteNonQuery();

            }
            _connection.SqlConnection.Close();
        }
    }
}
