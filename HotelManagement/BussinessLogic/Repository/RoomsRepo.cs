using System.Collections.Generic;
using BussinessLogic.Repository;
using DataAccess.Models;

namespace BussinessLogic
{
    public class RoomsRepo : IRoomsRepository
    {
        private readonly HotelManagementContext _dbContext;

        public RoomsRepo(HotelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Room room)
        {
            RoomsDAO.Instance(_dbContext).Add(room);
        }

        public Room Get(int id)
        {
            return RoomsDAO.Instance(_dbContext).Get(id);
        }

        public IEnumerable<Room> GetAll()
        {
            return RoomsDAO.Instance(_dbContext).GetAll();
        }

        public void Update(Room room)
        {
            RoomsDAO.Instance(_dbContext).Update(room);
        }

        public void Delete(int id)
        {
            RoomsDAO.Instance(_dbContext).Delete(id);
        }
    }
}
