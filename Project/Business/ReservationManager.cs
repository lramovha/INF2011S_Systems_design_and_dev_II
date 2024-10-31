using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Project.Data;

namespace Project.Business
{
    public class ReservationManager
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // Add a new reservation
        public void AddReservation(Reservation reservation)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Reservations (RoomID, GuestID, CheckInDate, CheckOutDate, TotalPrice) VALUES (@RoomID, @GuestID, @CheckInDate, @CheckOutDate, @TotalPrice)", connection);
                command.Parameters.AddWithValue("@RoomID", reservation.RoomID);
                command.Parameters.AddWithValue("@GuestID", reservation.GuestID);
                command.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                command.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
               // command.Parameters.AddWithValue("@TotalPrice", reservation.TotalPrice);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get all reservations
        public List<Reservation> GetAllReservations()
        {
            var reservations = new List<Reservation>();

            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Reservations", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservations.Add(new Reservation
                        {
                            ReservationID = reader.GetInt32(0),
                            RoomID = reader.GetInt32(1),
                            GuestID = reader.GetInt32(2),
                            CheckInDate = reader.GetDateTime(3),
                            CheckOutDate = reader.GetDateTime(4),
                            //TotalPrice = reader.GetDecimal(5)
                        });
                    }
                }
            }

            return reservations;
        }

        // Get reservation by ID
        public Reservation GetReservationById(int reservationID)
        {
            Reservation reservation = null;

            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Reservations WHERE ReservationID = @ReservationID", connection);
                command.Parameters.AddWithValue("@ReservationID", reservationID);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reservation = new Reservation
                        {
                            ReservationID = reader.GetInt32(0),
                            RoomID = reader.GetInt32(1),
                            GuestID = reader.GetInt32(2),
                            CheckInDate = reader.GetDateTime(3),
                            CheckOutDate = reader.GetDateTime(4),
                           // TotalPrice = reader.GetDecimal(5)
                        };
                    }
                }
            }

            return reservation;
        }

        // Update reservation details
        public void UpdateReservation(Reservation reservation)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("UPDATE Reservations SET RoomID = @RoomID, GuestID = @GuestID, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, TotalPrice = @TotalPrice WHERE ReservationID = @ReservationID", connection);
                command.Parameters.AddWithValue("@RoomID", reservation.RoomID);
                command.Parameters.AddWithValue("@GuestID", reservation.GuestID);
                command.Parameters.AddWithValue("@CheckInDate", reservation.CheckInDate);
                command.Parameters.AddWithValue("@CheckOutDate", reservation.CheckOutDate);
                //command.Parameters.AddWithValue("@TotalPrice", reservation.TotalPrice);
                command.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete a reservation
        public void DeleteReservation(int reservationID)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Reservations WHERE ReservationID = @ReservationID", connection);
                command.Parameters.AddWithValue("@ReservationID", reservationID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
