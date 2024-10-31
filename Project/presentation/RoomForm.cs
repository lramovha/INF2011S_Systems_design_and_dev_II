using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Business;
using Project.Data;

namespace Project.presentation
{
    public partial class RoomForm : Form
    {
        private RoomManager roomManager = new RoomManager();

        public RoomForm()
        {
            InitializeComponent();
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            var rooms = roomManager.GetAllRooms();
            roomDataGridView.DataSource = rooms;
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                RoomNumber = roomNumberTextBox.Text,
                Type = typeComboBox.SelectedItem.ToString(),
                Price = decimal.Parse(priceTextBox.Text),
                IsAvailable = isAvailableCheckBox.Checked
            };

            roomManager.AddRoom(room);
            LoadRoomData();
        }

        private void UpdateRoomButton_Click(object sender, EventArgs e)
        {
            if (roomDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = roomDataGridView.SelectedRows[0];
                var room = new Room
                {
                    RoomID = (int)selectedRow.Cells["RoomID"].Value,
                    RoomNumber = roomNumberTextBox.Text,
                    Type = typeComboBox.SelectedItem.ToString(),
                    Price = decimal.Parse(priceTextBox.Text),
                    IsAvailable = isAvailableCheckBox.Checked
                };

                roomManager.UpdateRoom(room);
                LoadRoomData();
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (roomDataGridView.SelectedRows.Count > 0)
            {
                var roomID = (int)roomDataGridView.SelectedRows[0].Cells["RoomID"].Value;
                roomManager.DeleteRoom(roomID);
                LoadRoomData();
            }
        }
        
    }
}
