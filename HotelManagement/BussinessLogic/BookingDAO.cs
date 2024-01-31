using BussinessLogic.Repository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogic
{
    public class BookingDAO : IBookingRepository
    {
        private readonly HotelManagementContext _context;
        private static readonly object instanceLock = new object();
        private static BookingDAO instance = null;

        // Private constructor for Singleton
        private BookingDAO(HotelManagementContext dbContext)
        {
            _context = dbContext;
        }

        // Singleton Instance property
        public static BookingDAO Instance(HotelManagementContext dbContext)
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new BookingDAO(dbContext);
                }
                return instance;
            }
        }

        public void Add(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public Booking Get(int id)
        {
            return _context.Bookings.Find(id);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _context.Bookings.ToList();
        }

        public void Update(Booking booking)
        {
            _context.Bookings.Update(booking);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }
    }
}
