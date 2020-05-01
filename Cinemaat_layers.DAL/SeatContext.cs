using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class SeatContext : ISeatContext
    {
        private readonly DatabaseConnection _connection;

        public SeatContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(ISeat seat)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ISeat> ISeatContext.GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM Seat", _connection.SqlConnection);
            var reader = cmd.ExecuteReader();

            var seatRecords = new List<ISeat>();

            while (reader.Read())
            {
                var seat = new SeatDto
                {
                    SeatNr = (int)reader["SeatNr"],
                    IsReserved = (bool)reader["IsReserved"]
                };

                seatRecords.Add(seat);
            }
            return seatRecords;
        }

        public ISeat GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
