using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Project.Data;

namespace Project.Business
{
    public class GuestManager
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Create a new guest
        public void AddGuest(Guest guest)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "INSERT INTO Guests (Name, Phone, Email, Address) VALUES (@Name, @Phone, @Email, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", guest.Name);
                cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                cmd.Parameters.AddWithValue("@Email", guest.Email);
                cmd.Parameters.AddWithValue("@Address", guest.Address);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Retrieve all guests
        public List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM Guests";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        GuestID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Phone = reader.GetString(2),
                        Email = reader.GetString(3),
                        Address = reader.GetString(4)
                    };
                    guests.Add(guest);
                }
            }
            return guests;
        }

        // Update a guest's information
        public void UpdateGuest(Guest guest)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "UPDATE Guests SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address WHERE GuestID=@GuestID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
                cmd.Parameters.AddWithValue("@Name", guest.Name);
                cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                cmd.Parameters.AddWithValue("@Email", guest.Email);
                cmd.Parameters.AddWithValue("@Address", guest.Address);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Delete a guest
        public void DeleteGuest(int guestID)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "DELETE FROM Guests WHERE GuestID=@GuestID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GuestID", guestID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
