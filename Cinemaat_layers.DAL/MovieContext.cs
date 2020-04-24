using Cinemaat_layers.INTERFACES;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Cinemaat_layers.DAL.Dto;

namespace Cinemaat_layers.DAL
{
    public class MovieContext : IMovieContext
    {
        private readonly DatabaseConnection _connection;

        public MovieContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(IMovie movie)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IMovie> IMovieContext.GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM Movie", _connection.SqlConnection);
            var reader = cmd.ExecuteReader();

            var movieRecords = new List<IMovie>();

            while (reader.Read())
            {
                var movie = new MovieDto
                {
                    MovieId = (int)reader["MovieId"],
                    MovieName = reader["MovieName"]?.ToString(),
                    Description = reader["Description"]?.ToString(),
                    DateCreated = DateTime.Parse(reader["DateCreated"]?.ToString() ?? ""),
                    Genre = reader["Genre"]?.ToString(),
                    Review = reader["Review"]?.ToString(),
                    Rating = (double)reader["Rating"]
                };

                movieRecords.Add(movie);
            }
            return movieRecords;
        }

        public IMovie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
