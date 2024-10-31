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
        }

        private void LoadGuests()
        {
            var guests = guestManager.GetAllGuests();
            guestComboBox.DataSource = guests;
            guestComboBox.DisplayMember = "Name";
            guestComboBox.ValueMember = "GuestID";
        }

        private void LoadRooms()
        {
            var rooms = roomManager.GetAvailableRooms();
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
            var reservation = new Reservation
            {
                GuestID = (int)guestComboBox.SelectedValue,
                RoomID = (int)roomComboBox.SelectedValue,
                CheckInDate = checkInDatePicker.Value,
                CheckOutDate = checkOutDatePicker.Value,
                Status = statusComboBox.SelectedItem.ToString()
            };

            reservationManager.AddReservation(reservation);
            LoadReservationData();
        }

        private void UpdateReservationButton_Click(object sender, EventArgs e)
        {
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
        }

        private void DeleteReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationDataGridView.SelectedRows.Count > 0)
            {
                var reservationID = (int)reservationDataGridView.SelectedRows[0].Cells["ReservationID"].Value;
                reservationManager.DeleteReservation(reservationID);
                LoadReservationData();
            }
        }
    }
}
