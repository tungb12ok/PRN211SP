using BussinessLogic;
using BussinessLogic.Repository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagementLayer
{
    public partial class RoomsManagement : Form
    {
        HotelManagementContext _context;
        RoomsRepo _roomsRepository;
        public RoomsManagement()
        {
            _context = new HotelManagementContext();
            _roomsRepository = new RoomsRepo(_context);
            InitializeComponent();
        }

        private void RoomsManagement_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Clear();

            cbStatus.Items.Add("Already");
            cbStatus.Items.Add("Booked");

            cbStatus.SelectedIndex = 0; 

            loadUI();
        }
        private void loadUI()
        {
            var listRoom = _roomsRepository.GetAll()
                .Select(x => new
                {
                    x.RoomId,
                    x.Status,
                    x.RoomType,
                    x.Price
                })
                .ToList();
            dataGridView1.DataSource = listRoom;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var r = new Room
            {
                RoomType = txtRoomType.Text,
                Status = cbStatus.SelectedItem.ToString(),
                Price = float.Parse(numPrice.Value + "")
            };

            _roomsRepository.Add(r);
            loadUI();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string id = selectedRow.Cells["RoomID"].Value.ToString();

                Room r = GetRoom(id);

                txtRoomID.Text = r.RoomId + "";
                txtRoomType.Text = r.RoomType;
                cbStatus.SelectedItem = r.Status;
                numPrice.Text = r.Price + "";
            }
        }
        private Room GetRoom(string roomId)
        {
            return _roomsRepository.Get(int.Parse(roomId));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room roomUpdate = GetRoom(txtRoomID.Text);
            if (roomUpdate != null)
            {
                roomUpdate.RoomId = roomUpdate.RoomId;
                roomUpdate.RoomType = txtRoomType.Text;
                roomUpdate.Status = cbStatus.SelectedItem.ToString();
                roomUpdate.Price = float.Parse(numPrice.Value + "");
                _roomsRepository.Update(roomUpdate);
                loadUI();
            }
            else
            {
                MessageBox.Show("ID does not exits!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room roomUpdate = GetRoom(txtRoomID.Text);
            if (roomUpdate != null)
            {
                _roomsRepository.Delete(roomUpdate.RoomId);
                loadUI();
            }
            else
            {
                MessageBox.Show("ID does not exits!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Fetch all rooms from _roomsRepository
            var allRooms = _roomsRepository.GetAll();

            // Filter and project the data
            var filteredRooms = allRooms
                .Where(r => r.RoomType.Contains(txtSearch.Text) ||
                            r.Status.Contains(txtSearch.Text) ||
                            r.Price.ToString().Contains(txtSearch.Text))
                .Select(x => new
                {
                    x.RoomId,
                    x.Status,
                    x.RoomType,
                    x.Price
                })
                .ToList();

            // Set the filtered data as the DataSource for dataGridView1
            dataGridView1.DataSource = filteredRooms;

        }
    }
}
