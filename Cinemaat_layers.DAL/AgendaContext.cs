using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class AgendaContext : IAgendaContext
    {
        private readonly DatabaseConnection _connection;

        public AgendaContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(IAgenda agenda)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IAgenda> IAgendaContext.GetAll(int movieId)
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM agenda WHERE MovieId=@MovieId", _connection.SqlConnection);
            cmd.Parameters.AddWithValue("@MovieId", movieId);
            var reader = cmd.ExecuteReader();

            var agendaRecords = new List<IAgenda>();

            while (reader.Read())
            {
                var agenda = new AgendaDto
                {
                    AgendaId = (int)reader["AgendaId"],
                    MovieId = (int)reader["MovieId"],
                    MovieName = reader["MovieName"]?.ToString(),
                    MovieHallId = (int)reader["MovieHallId"],
                    IsValid = (bool)reader["IsValid"],
                    Time = DateTime.Parse(reader["Time"]?.ToString() ?? ""),
                    Price = (double)reader["Price"]
                };

                agendaRecords.Add(agenda);
            }
            return agendaRecords;
        }

        public IAgenda GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
