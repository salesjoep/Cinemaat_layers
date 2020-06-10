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
            _connection.SqlConnection.Open();
            string query = "INSERT INTO movie VALUES (@MovieId, @MovieName, @Description, @DateCreated, @Genre, @Review, @Rating @Price); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@MovieId", movie.MovieId);
                command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                command.Parameters.AddWithValue("@Description", movie.Description);
                command.Parameters.AddWithValue("@DateCreated", movie.DateCreated);
                command.Parameters.AddWithValue("@Genre", movie.Genre);
                command.Parameters.AddWithValue("@Review", movie.Review);
                command.Parameters.AddWithValue("@Rating", movie.Rating);
                command.Parameters.AddWithValue("@Price", movie.Price);

                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }

        //Read in CRUD
        IEnumerable<IMovie> IMovieContext.GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM movie", _connection.SqlConnection);
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
                    Rating = (double)reader["Rating"],
                    Price = (double)reader["Price"]
                };

                movieRecords.Add(movie);
            }
            _connection.SqlConnection.Close();
            return movieRecords;
        }

        public IMovie GetById(IMovie movie)
        {
            _connection.SqlConnection.Open();
            string query = "SELECT * FROM movie WHERE MovieId = @MovieId; ";

            
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@MovieId", movie.MovieId);
                command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                command.Parameters.AddWithValue("@Description", movie.Description);
                command.Parameters.AddWithValue("@DateCreated", movie.DateCreated);
                command.Parameters.AddWithValue("@Genre", movie.Genre);
                command.Parameters.AddWithValue("@Review", movie.Review);
                command.Parameters.AddWithValue("@Rating", movie.Rating);
                command.Parameters.AddWithValue("@Price", movie.Price);
            }
            _connection.SqlConnection.Close();
            return movie;
            
        }
        //Delete in CRUD
        public void DeleteMovie(int movieId)
        {
            _connection.SqlConnection.Open();
            string query = "DELETE FROM movie WHERE MovieId=@MovieId; ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@MovieId", movieId);
                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }

        //Update in CRUD
        public void UpdateMovie(IMovie movie)
        {
            _connection.SqlConnection.Open();
            string query = "UPDATE movie SET MovieName = @MovieName, Description = @Description, DateCreated = @DateCreated, Genre = @Genre, Review = @Review, Rating = @Rating, Price = @Price WHERE MovieId=@MovieId; ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@MovieId", movie.MovieId);
                command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                command.Parameters.AddWithValue("@Description", movie.Description);
                command.Parameters.AddWithValue("@DateCreated", movie.DateCreated);
                command.Parameters.AddWithValue("@Genre", movie.Genre);
                command.Parameters.AddWithValue("@Review", movie.Review);
                command.Parameters.AddWithValue("@Rating", movie.Rating);
                command.Parameters.AddWithValue("@Price", movie.Price);

                command.ExecuteNonQuery();
                _connection.SqlConnection.Close();
            }
        }

        public void CreateReview(IMovie movie)
        {
            _connection.SqlConnection.Open();
            string query = "INSERT INTO review (Review, Rating) VALUES (@Review, @Rating); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@ReviewId", movie.Review);
                command.Parameters.AddWithValue("@Rating", movie.Rating);

                command.ExecuteNonQuery();
                _connection.SqlConnection.Close();
            }
        }
    }
}
