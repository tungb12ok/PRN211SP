using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Repository
{
    public class BookingRepo : IBookingRepository
    {
        private readonly HotelManagementContext _dbContext;

        public BookingRepo(HotelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Booking booking)
        {
            BookingDAO.Instance(_dbContext).Add(booking);
        }

        public void Delete(int id)
        {
           BookingDAO.Instance(_dbContext).Delete(id);
        }

        public Booking Get(int id)
        {
            return BookingDAO.Instance(_dbContext).Get(id);
        }

        public IEnumerable<Booking> GetAll()
        {
            return BookingDAO.Instance(_dbContext).GetAll();
        }

        public void Update(Booking booking)
        {
            BookingDAO.Instance(_dbContext).Update(booking);
        }
    }
}
