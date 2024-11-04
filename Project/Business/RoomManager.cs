using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Project.Data;

namespace Project.Business
{
    public class RoomManager
    {
        private readonly DatabaseConnection db = new DatabaseConnection();

        // Add a new room
        public void AddRoom(Room room)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Rooms (RoomNumber, Type, Price, IsAvailable) VALUES (@RoomNumber, @Type, @Price, @IsAvailable)", connection);
                command.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                command.Parameters.AddWithValue("@Type", room.Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@IsAvailable", room.IsAvailable);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get all rooms
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Rooms", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomNumber = reader.GetString(1),
                            Type = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            IsAvailable = reader.GetBoolean(4)
                        });
                    }
                }
            }

            return rooms;
        }

        // Update room details (e.g., availability, type, price)
        public void UpdateRoom(Room room)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("UPDATE Rooms SET RoomNumber = @RoomNumber, Type = @Type, Price = @Price, IsAvailable = @IsAvailable WHERE RoomID = @RoomID", connection);
                command.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                command.Parameters.AddWithValue("@Type", room.Type);
                command.Parameters.AddWithValue("@Price", room.Price);
                command.Parameters.AddWithValue("@IsAvailable", room.IsAvailable);
                command.Parameters.AddWithValue("@RoomID", room.RoomID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete a room
        public void DeleteRoom(int roomID)
        {
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", connection);
                command.Parameters.AddWithValue("@RoomID", roomID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get available rooms only
        public List<Room> GetAvailableRooms()
        {
            var availableRooms = new List<Room>();

            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Rooms WHERE IsAvailable = 1", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        availableRooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomNumber = reader.GetString(1),
                            Type = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            IsAvailable = reader.GetBoolean(4)
                        });
                    }
                }
            }

            return availableRooms;
        }

        public Room GetRoomById(int roomId)
        {
            Room room = null;
            using (var connection = db.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Rooms WHERE RoomID = @RoomID", connection);
                command.Parameters.AddWithValue("@RoomID", roomId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomNumber = reader.GetString(1),
                            Type = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            IsAvailable = reader.GetBoolean(4)
                        };
                    }
                }
            }
            return room;
        }

    }
}
