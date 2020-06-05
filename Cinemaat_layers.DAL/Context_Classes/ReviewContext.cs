using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Context_Classes
{
    public class ReviewContext : IReviewContext
    {
        private readonly DatabaseConnection _connection;

        public ReviewContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        //Create in CRUD
        public void CreateReview(IReview review)
        {
            _connection.SqlConnection.Open();
            string query = "INSERT INTO `review` (`ReviewId`, `Review`, `Rating`, `MovieId`) VALUES (@ReviewId, @Review, @Rating, @MovieId); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@ReviewId", review.ReviewId);
                command.Parameters.AddWithValue("@Review", review.Review);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@MovieId", review.MovieId);

                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }
    }
}
