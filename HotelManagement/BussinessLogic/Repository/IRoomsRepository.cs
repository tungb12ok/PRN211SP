using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Repository
{
    public interface IRoomsRepository
    {
        void Add(Room room);
        Room Get(int id);
        IEnumerable<Room> GetAll();
        void Update(Room room);
        void Delete(int id);
    }
}
