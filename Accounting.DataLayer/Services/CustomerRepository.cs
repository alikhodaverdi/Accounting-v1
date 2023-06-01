using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public Customer GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State=System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }
    }
}
