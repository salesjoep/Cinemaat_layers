using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL.Testing_Classes
{
    public class MovieContextTest : IMovieContext
    {
        private static string _connectionString = "";
        private readonly DatabaseConnection _connection;

        public static void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MovieContextTest(DatabaseConnection connection)
        {
            _connection = connection;
        }

        //Read in CRUD
        public List<IMovie> GetAllMovies()
        {
            List<IMovie> movies = new List<IMovie>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "SELECT * FROM movie";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MovieDto movie = new MovieDto();
                        movie.MovieId = reader.GetInt32(0);
                        movie.MovieName = reader.GetString(1);
                        movie.Description = reader.GetString(2);
                        movie.DateCreated = reader.GetDateTime(3);
                        movie.Genre = reader.GetString(4);
                        movie.Review = reader.GetString(5);
                        movie.Rating = reader.GetDouble(6);

                        movies.Add(movie);

                    }
                }
            }
            return movies;
        }

        //Create in CRUD
        public void CreateMovie(IMovie movie)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "INSERT INTO movie VALUES(@MovieName, @Description, @DateCreated, @Genre, @Review, @Rating; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                    command.Parameters.AddWithValue("@Description", movie.Description);
                    command.Parameters.AddWithValue("@DateCreated", movie.DateCreated);
                    command.Parameters.AddWithValue("@Genre", movie.Genre);
                    command.Parameters.AddWithValue("@Review", movie.Review);
                    command.Parameters.AddWithValue("@Rating", movie.Rating);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Update in CRUD
        public void UpdateMovie(IMovie movie)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE movie SET MovieName = @MovieName, Description = @Description, DateCreated = @DateCreated, Genre = @Genre, Review = @Review, Rating = @Rating WHERE MovieId=@MovieId; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MovieName", movie.MovieName);
                    command.Parameters.AddWithValue("@Description", movie.Description);
                    command.Parameters.AddWithValue("@DateCreated", movie.DateCreated);
                    command.Parameters.AddWithValue("@Genre", movie.Genre);
                    command.Parameters.AddWithValue("@Review", movie.Review);
                    command.Parameters.AddWithValue("@Rating", movie.Rating);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete in CRUD
        public void DeleteMovie(int MovieId)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                string query = "DELETE FROM movie WHERE MovieId=@MovieId; ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MovieId", MovieId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Add(IMovie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMovie> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMovie> SelectSpecificMovie()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMovie> Select1917Movie()
        {
            throw new NotImplementedException();
        }

        public IMovie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
