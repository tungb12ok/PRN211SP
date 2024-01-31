using System.Collections.Generic;
using BussinessLogic.Repository;
using DataAccess.Models;

namespace BussinessLogic
{
    public class RoomsDAO : IRoomsRepository
    {
        private readonly HotelManagementContext _context;
        private static readonly object instanceLock = new object();
        private static RoomsDAO instance = null;

        // Private constructor for Singleton
        private RoomsDAO(HotelManagementContext dbContext)
        {
            _context = dbContext;
        }

        // Singleton Instance property
        public static RoomsDAO Instance(HotelManagementContext dbContext)
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new RoomsDAO(dbContext);
                }
                return instance;
            }
        }

        public void Add(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges(); // Saving changes to the database
        }

        public Room Get(int id)
        {
            return _context.Rooms.Find(id); // Retrieve a room by ID
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms.ToList(); // Retrieve all rooms
        }

        public void Update(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges(); // Saving changes to the database
        }

        public void Delete(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges(); // Saving changes to the database
            }
        }

      
    }
}
