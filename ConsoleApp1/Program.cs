using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Accounting_DBEntities dbEntities = new Accounting_DBEntities();
            //ICustomerRepository customer = new CustomerRepository(dbEntities);

            //Customer customer1 = new Customer() {

            //    FullName = "رضا محمدی",
            //    CustomerImage ="NoPhoto",
            //    Mobile = "09589856363"
            //};
            //customer.InsertCustomer(customer1);
            //customer.Save();

            //var list = customer.GetAllCustomers();


            //use pattern unit of work

            UnitOfWork db = new UnitOfWork();   
            var list =db.CustomerRepository.GetAllCustomers();
            db.Dispose();


        }
    }
}
