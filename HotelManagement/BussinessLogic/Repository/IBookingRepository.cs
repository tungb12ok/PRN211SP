using DataAccess.Models;
using System.Collections.Generic;

namespace BussinessLogic.Repository
{
    public interface IBookingRepository
    {
        void Add(Booking booking);
        Booking Get(int id);
        IEnumerable<Booking> GetAll();
        void Update(Booking booking);
        void Delete(int id);
    }
}
