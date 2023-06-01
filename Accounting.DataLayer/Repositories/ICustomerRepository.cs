using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {

        //single bug is Customer name - > is Customers *****

        //Get All Customer
        List<Customer> GetAllCustomers();

        //Get  Customer By id
        Customer GetCustomerById(int customerId);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
        void Save();
    }
}
