using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Repository
{
    public class CustomerRepo : ICustomersRepository
    {
        private readonly HotelManagementContext _dbContext;

        public CustomerRepo(HotelManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Customer customer) => CustomersDAO.Instance(_dbContext).Add(customer);

        public void Delete(int id) => CustomersDAO.Instance(_dbContext).Delete(id);

        public Customer Get(int id) => CustomersDAO.Instance(_dbContext).Get(id);

        public IEnumerable<Customer> GetAll() => CustomersDAO.Instance(_dbContext).GetAll();

        public void Update(Customer customer) => CustomersDAO.Instance(_dbContext).Update(customer);
    }
}
