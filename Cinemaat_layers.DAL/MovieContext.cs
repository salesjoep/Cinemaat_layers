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

        //Create in CRUD
        public void CreateMovie(IMovie movie)
        {
            throw new NotImplementedException();
        }

        //Read in CRUD
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
        //Delete in CRUD
        public void DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        //Update in CRUD
        public void UpdateMovie(IMovie movie)
        {
            throw new NotImplementedException();
        }
    }
}
