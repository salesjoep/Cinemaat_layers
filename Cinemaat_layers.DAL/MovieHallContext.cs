using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class MovieHallContext : IMovieHallContext
    {
        private readonly DatabaseConnection _connection;

        public MovieHallContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(IMovieHall movieHall)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IMovieHall> IMovieHallContext.GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM MovieHall", _connection.SqlConnection);
            var reader = cmd.ExecuteReader();

            var movieHallRecords = new List<IMovieHall>();

            while (reader.Read())
            {
                var movieHall = new MovieHallDto
                {
                    MovieHallId = (int)reader["MovieHallId"],
                    MovieId = (int)reader["MovieId"],
                    NrOfSeats = (int)reader["NrOfSeats"]
                };
                movieHallRecords.Add(movieHall);
            }
            return movieHallRecords;
        }

        public IMovieHall GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
