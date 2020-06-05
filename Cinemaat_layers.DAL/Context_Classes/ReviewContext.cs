﻿using Cinemaat_layers.DAL.Dto;
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

        public IEnumerable<IReview> GetAll()
        {
            _connection.SqlConnection.Open();
            var cmd = new MySqlCommand("SELECT * FROM review", _connection.SqlConnection);
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
