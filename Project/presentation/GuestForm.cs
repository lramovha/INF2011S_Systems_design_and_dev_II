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
    public partial class GuestForm : Form
    {
        private GuestManager guestManager = new GuestManager();

        public GuestForm()
        {
            InitializeComponent();
            LoadGuests();  // Load guests when the form loads
        }

        // Load all guests and display them in the DataGridView
        private void LoadGuests()
        {
            List<Guest> guests = guestManager.GetAllGuests();
            GuestsDataGridView.DataSource = guests;
        }

        // Add a new guest to the database
        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Email = EmailTextBox.Text,
                Address = AddressTextBox.Text
            };

            guestManager.AddGuest(guest);
            MessageBox.Show("Guest added successfully!");
            LoadGuests();  // Refresh guest list
            ClearFields();
        }

        // Update an existing guest's information
        private void UpdateGuestButton_Click(object sender, EventArgs e)
        {
            if (GuestsDataGridView.SelectedRows.Count > 0)
            {
                Guest selectedGuest = (Guest)GuestsDataGridView.SelectedRows[0].DataBoundItem;
                selectedGuest.Name = NameTextBox.Text;
                selectedGuest.Phone = PhoneTextBox.Text;
                selectedGuest.Email = EmailTextBox.Text;
                selectedGuest.Address = AddressTextBox.Text;

                guestManager.UpdateGuest(selectedGuest);
                MessageBox.Show("Guest updated successfully!");
                LoadGuests();  // Refresh guest list
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a guest to update.");
            }
        }

        // Delete a guest from the database
        private void DeleteGuestButton_Click(object sender, EventArgs e)
        {
            if (GuestsDataGridView.SelectedRows.Count > 0)
            {
                Guest selectedGuest = (Guest)GuestsDataGridView.SelectedRows[0].DataBoundItem;
                guestManager.DeleteGuest(selectedGuest.GuestID);
                MessageBox.Show("Guest deleted successfully!");
                LoadGuests();  // Refresh guest list
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a guest to delete.");
            }
        }

        // Populate the TextBoxes with selected guest details
        private void GuestsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (GuestsDataGridView.SelectedRows.Count > 0)
            {
                Guest selectedGuest = (Guest)GuestsDataGridView.SelectedRows[0].DataBoundItem;
                NameTextBox.Text = selectedGuest.Name;
                PhoneTextBox.Text = selectedGuest.Phone;
                EmailTextBox.Text = selectedGuest.Email;
                AddressTextBox.Text = selectedGuest.Address;
            }
        }

        // Helper method to clear TextBox fields
        private void ClearFields()
        {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
