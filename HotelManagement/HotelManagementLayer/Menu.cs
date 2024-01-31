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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManagement a = new CustomerManagement();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingManagement a = new BookingManagement();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomsManagement a = new RoomsManagement();
            a.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            HotelManagementContext context = new HotelManagementContext();
            BookingRepo bookingRepo = new BookingRepo(context);
            var price = bookingRepo.GetAll().Sum(x => x.TotalPrice);

            lbTotal.Text += price.ToString() + " $";
        }
    }
}
