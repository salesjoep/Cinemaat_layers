using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
            string query = "INSERT INTO `review` (`ReviewId`, `Review`, `Rating`, `MovieId`, `UserId`) VALUES (@ReviewId, @Review, @Rating, @MovieId, @UserId); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@ReviewId", review.ReviewId);
                command.Parameters.AddWithValue("@Review", review.Review);
                command.Parameters.AddWithValue("@Rating", review.Rating);
                command.Parameters.AddWithValue("@MovieId", review.MovieId);
                command.Parameters.AddWithValue("@UserId", review.UserId);

                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }

        public IEnumerable<IReview> GetAll(int movieId)
        {
            _connection.SqlConnection.Open();
            var cmd = new MySqlCommand("SELECT * FROM review WHERE `MovieId` = @MovieId", _connection.SqlConnection);
            cmd.Parameters.AddWithValue("@MovieId", movieId);
            var reader = cmd.ExecuteReader();

            var reviewRecords = new List<IReview>();

            while (reader.Read())
            {
                var review = new ReviewDto
                {
                    ReviewId = (int)reader["ReviewId"],
                    Review = reader["Review"]?.ToString(),
                    Rating = (int)reader["Rating"],
                    MovieId = (int)reader["MovieId"]
                };
                reviewRecords.Add(review);

            }

            _connection.SqlConnection.Close();
            return reviewRecords;
        }
    }
}
