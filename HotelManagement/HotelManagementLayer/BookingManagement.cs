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

namespace HotelManagementLayer
{
    public partial class BookingManagement : Form
    {

        private HotelManagementContext context;
        private CustomerRepo customerRepo;
        private BookingRepo bookingRepo;
        private RoomsRepo roomsRepo;
        public BookingManagement()
        {
            context = new HotelManagementContext();
            customerRepo = new CustomerRepo(context);
            bookingRepo = new BookingRepo(context);
            roomsRepo = new RoomsRepo(context);
            InitializeComponent();
        }

        private void BookingManagement_Load(object sender, EventArgs e)
        {
            numPrice.DecimalPlaces = 2;
            loadUI();
        }
        private void loadUI()
        {
            IEnumerable<Customer> cus = customerRepo.GetAll();

            dgvCus.DataSource = cus
                                        .Select(x => new
                                        {
                                            x.CustomerId,
                                            x.Name,
                                            x.PhoneNumber,
                                            x.Email,
                                            x.Address
                                        })
                                        .ToList();

            var listRoom = roomsRepo.GetAll()
                .Select(x => new
                {
                    x.RoomId,
                    x.Status,
                    x.RoomType,
                    x.Price
                })
                .ToList();
            dgvRooms.DataSource = listRoom;

            dgvBooking.DataSource = bookingRepo.GetAll()
                                               .Select(x => new
                                               {
                                                   x.BookingId,
                                                   x.RoomId,
                                                   x.CustomerId,
                                                   x.CheckInDate,
                                                   x.CheckOutDate,
                                                   x.TotalPrice
                                               })
                                               .ToList();
        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCus.Rows[e.RowIndex];

                string id = selectedRow.Cells["CustomerID"].Value.ToString();

                Customer c = customerRepo.Get(int.Parse(id));

                txtCustomerID.Text = id;
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvRooms.Rows[e.RowIndex];

                string id = selectedRow.Cells["RoomID"].Value.ToString();

                Room r = roomsRepo.Get(int.Parse(id));

                txtRoomID.Text = r.RoomId + "";
                numPrice.Text = r.Price.ToString();

            }
        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBooking.Rows[e.RowIndex];

                string id = selectedRow.Cells[0].Value.ToString();

                Booking a = bookingRepo.Get(int.Parse(id));
                txtBookingID.Text = a.BookingId.ToString();
                txtCustomerID.Text = a.CustomerId + "";
                txtRoomID.Text = a.RoomId.ToString();
                dateIn.Text = a.CheckInDate.ToString();
                dateOut.Text = a.CheckOutDate.ToString();
                numPrice.Text = a.TotalPrice.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = new Booking
            {
                CustomerId = int.Parse(txtCustomerID.Text),
                RoomId = int.Parse(txtRoomID.Text),
                CheckInDate = dateIn.Value,
                CheckOutDate = dateOut.Value,
                TotalPrice = float.Parse(numPrice.Value.ToString())
            };

            bookingRepo.Add(a);
            loadUI();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Booking b = bookingRepo.Get(int.Parse(txtBookingID.Text));
            if (b != null)
            {
                b.CustomerId = int.Parse(txtCustomerID.Text);
                b.RoomId = int.Parse(txtRoomID.Text);
                b.CheckInDate = dateIn.Value;
                b.CheckOutDate = dateOut.Value;
                b.TotalPrice = float.Parse(numPrice.Value + "");

                bookingRepo.Update(b);
                loadUI();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Booking b = bookingRepo.Get(int.Parse(txtBookingID.Text));
            if(b != null)
            {
                bookingRepo.Delete(b.BookingId);
                loadUI();
            }
        }
    }
}
