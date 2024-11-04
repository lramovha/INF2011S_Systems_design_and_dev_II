using Project.Business;
using Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.presentation
{
    public partial class ReservationForm : Form
    {
        private ReservationManager reservationManager = new ReservationManager();
        private GuestManager guestManager = new GuestManager();
        private RoomManager roomManager = new RoomManager();

        public ReservationForm()
        {
            InitializeComponent();
            LoadGuests();
            LoadRooms();
            LoadReservationData();
            LoadStatusOptions();
        }


        private void LoadStatusOptions()
        {
            statusComboBox.Items.Add("Pending");
            statusComboBox.Items.Add("Confirmed");
            statusComboBox.Items.Add("Cancelled");
            statusComboBox.SelectedIndex = 0; // Set a default value
        }

        private void LoadGuests()
        {
            var guests = guestManager.GetAllGuests();
            if (guests.Count == 0)
            {
                MessageBox.Show("No guests available. Please add a guest first.");
            }
            guestComboBox.DataSource = guests;
            guestComboBox.DisplayMember = "Name";
            guestComboBox.ValueMember = "GuestID";
        }


        private bool ValidateInputs()
        {
            if (guestComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a guest.");
                return false;
            }
            if (roomComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.");
                return false;
            }
            if (checkInDatePicker.Value.Date >= checkOutDatePicker.Value.Date)
            {
                MessageBox.Show("Check-out date must be after check-in date.");
                return false;
            }
            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation status.");
                return false;
            }
            return true;
        }


        private void LoadRooms()
        {
            var rooms = roomManager.GetAvailableRooms();
            if (rooms.Count == 0)
            {
                MessageBox.Show("No available rooms. Please ensure rooms are available.");
            }
            roomComboBox.DataSource = rooms;
            roomComboBox.DisplayMember = "RoomNumber";
            roomComboBox.ValueMember = "RoomID";
        }

        private void LoadReservationData()
        {
            var reservations = reservationManager.GetAllReservations();
            reservationDataGridView.DataSource = reservations;
        }

        private void AddReservationButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                // Retrieve selected RoomID
                int roomID = (int)roomComboBox.SelectedValue;

                // Fetch the room details to get the price per night
                var room = roomManager.GetRoomById(roomID); // Make sure GetRoomById exists and returns room details
                if (room == null)
                {
                    MessageBox.Show("Selected room could not be found.");
                    return;
                }

                // Calculate the number of days between Check-In and Check-Out dates
                int numberOfDays = (checkOutDatePicker.Value - checkInDatePicker.Value).Days;

                // Calculate the total price
                decimal totalPrice = room.Price * numberOfDays;

                // Create and populate the reservation object
                var reservation = new Reservation
                {
                    GuestID = (int)guestComboBox.SelectedValue,
                    RoomID = roomID,
                    CheckInDate = checkInDatePicker.Value,
                    CheckOutDate = checkOutDatePicker.Value,
                    Status = statusComboBox.SelectedItem.ToString(),
                    TotalPrice = totalPrice // Set calculated total price
                };

                // Add reservation to the database
                reservationManager.AddReservation(reservation);

                // Reload the reservations data and show success message
                LoadReservationData();
                MessageBox.Show("Reservation added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void UpdateReservationButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (reservationDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = reservationDataGridView.SelectedRows[0];
                var reservation = new Reservation
                {
                    ReservationID = (int)selectedRow.Cells["ReservationID"].Value,
                    GuestID = (int)guestComboBox.SelectedValue,
                    RoomID = (int)roomComboBox.SelectedValue,
                    CheckInDate = checkInDatePicker.Value,
                    CheckOutDate = checkOutDatePicker.Value,
                    Status = statusComboBox.SelectedItem.ToString()
                };

                reservationManager.UpdateReservation(reservation);
                LoadReservationData();
            }
            else
            {
                MessageBox.Show("Please select a reservation to update.");
            }
        }


        private void DeleteReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this reservation?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var reservationID = (int)reservationDataGridView.SelectedRows[0].Cells["ReservationID"].Value;
                    reservationManager.DeleteReservation(reservationID);
                    LoadReservationData();
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
        }


    }
}
