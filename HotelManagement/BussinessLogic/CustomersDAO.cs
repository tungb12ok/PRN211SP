using BussinessLogic.Repository;
using DataAccess.Models;
using System.Collections.Generic;

namespace BussinessLogic
{
    public class CustomersDAO : ICustomersRepository
    {
        private readonly HotelManagementContext _context;
        private static readonly object instanceLock = new object();
        private static CustomersDAO instance = null;

        // Private constructor for Singleton
        private CustomersDAO(HotelManagementContext dbContext)
        {
            _context = dbContext;
        }

        // Singleton Instance property
        public static CustomersDAO Instance(HotelManagementContext dbContext)
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new CustomersDAO(dbContext);
                }
                return instance;
            }
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
