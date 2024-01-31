using DataAccess.Models;
using System.Collections.Generic;

namespace BussinessLogic.Repository
{
    public interface ICustomersRepository
    {
        void Add(Customer customer);
        Customer Get(int id);
        IEnumerable<Customer> GetAll();
        void Update(Customer customer);
        void Delete(int id);
    }
}
