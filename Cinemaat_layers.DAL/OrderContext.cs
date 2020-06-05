using Cinemaat_layers.DAL.Dto;
using Cinemaat_layers.INTERFACES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaat_layers.DAL
{
    public class OrderContext : IOrderContext
    {
        private readonly DatabaseConnection _connection;

        public OrderContext(DatabaseConnection connection)
        {
            _connection = connection;
        }
        public void Add(IOrder order)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IOrder> IOrderContext.GetAll()
        {
            _connection.SqlConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM Order", _connection.SqlConnection);
            var reader = cmd.ExecuteReader();

            var orderRecords = new List<IOrder>();

            while (reader.Read())
            {
                var order = new OrderDto
                {
                    OrderId = (int)reader["OrderId"],
                    MovieId = (int)reader["MovieId"],
                    UserId = (int)reader["UserId"],
                    SeatId = (int)reader["SeatId"],
                    AgendaId = (int)reader["AgendaId"],
                    Time = DateTime.Parse(reader["Time"]?.ToString() ?? ""),
                    MovieHallId = (int)reader["MovieHallId"],
                    MovieName = reader["MovieName"]?.ToString(),
                    Price = (double)reader["Price"],
                    TotalPrice = (double)reader["TotalPrice"],
                    Quantity = (int)reader["Quantity"]
                };
                orderRecords.Add(order);
            }
            return orderRecords;
        }

        public IOrder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(IOrder order)
        {
            _connection.SqlConnection.Open();
            string query = "INSERT INTO `order` (`OrderId`, `MovieId`, `UserId`, `SeatId`, `AgendaId`, `Time`, `MovieHallId`, `MovieName`, `Price`, `TotalPrice`, `Quantity`) VALUES (@OrderId, @MovieId, @UserId, @SeatId, @AgendaId, @Time, @MovieHallId, @MovieName, @Price, @TotalPrice, @Quantity); ";
            using (MySqlCommand command = new MySqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@OrderId", order.OrderId);
                command.Parameters.AddWithValue("@MovieId", order.MovieId);
                command.Parameters.AddWithValue("@UserId", order.UserId);
                command.Parameters.AddWithValue("@SeatId", order.SeatId);
                command.Parameters.AddWithValue("@AgendaId", order.AgendaId);
                command.Parameters.AddWithValue("@Time", order.Time);
                command.Parameters.AddWithValue("@MovieHallId", order.MovieHallId);
                command.Parameters.AddWithValue("@MovieName", order.MovieName);
                command.Parameters.AddWithValue("@Price", order.Price);
                command.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                command.Parameters.AddWithValue("@Quantity", order.Quantity);

                command.ExecuteNonQuery();
            }
            _connection.SqlConnection.Close();
        }
    }
}
